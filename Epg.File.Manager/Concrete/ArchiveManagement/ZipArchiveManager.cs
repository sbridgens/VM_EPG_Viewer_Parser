using System;
using System.IO;
using System.Text;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using Epg.File.Manager.Abstract;
using ICSharpCode.SharpZipLib.GZip;
using ICSharpCode.SharpZipLib.Tar;

namespace Epg.File.Manager.Concrete.ArchiveManagement
{
    public class ZipArchiveManager : IZipArchiveInterface
    {
        public string FullEpgPackagePath { get; set; }
        public string OutputDirectoryPath { get; set; }
        public string OutputEpgFile { get; set; }
        public string EpgArchiveDirectory { get; set; }
        public bool OperationsSuccessful { get; set; }
        public bool CanArchive { get; set; }

        private readonly byte[] streamBuffer = new byte[4096];

        public ZipArchiveManager()
        {
            OperationsSuccessful = false;
        }

        public void CleanExtractionDirectory()
        {
            var dirInfo = new DirectoryInfo(OutputDirectoryPath);

            foreach (var finfo in dirInfo.GetFiles())
            {
                if(CanArchive)
                {
                    var archiveFile = Path.Combine(EpgArchiveDirectory, finfo.Name);
                    if (System.IO.File.Exists(archiveFile))
                    {
                        System.IO.File.Move(archiveFile, Path.Combine(EpgArchiveDirectory, $"[Duplicate_{DateTime.Now:ddMyyyTHH-mm-ss}]_{finfo.Name}"));
                    }
                    finfo.MoveTo(archiveFile);
                }
                else
                {
                    finfo.Delete();
                }
            }
        }

        public void ExtractZipFile()
        {
            try
            {
                using(var inputFileStream = System.IO.File.OpenRead(FullEpgPackagePath))
                using (var epgZip = new ZipFile(inputFileStream))
                {
                    foreach (ZipEntry entry in epgZip)
                    {
                        if(!entry.IsFile)
                            continue;

                        OutputEpgFile = Path.Combine(OutputDirectoryPath, entry.Name);
                        using (var zipStream = epgZip.GetInputStream(entry))
                        using (var outputFileStream = System.IO.File.Create(OutputEpgFile))
                        {
                            StreamUtils.Copy(zipStream, outputFileStream, streamBuffer);
                        }
                    }
                    epgZip.Close();
                    inputFileStream.Close();
                    OperationsSuccessful = System.IO.File.Exists(OutputEpgFile);
                }

            }
            catch (Exception ezfException)
            {
                Console.WriteLine(ezfException);
                throw;
            }
        }

        public void ExtractGzipFile()
        {
            try
            {
                using (var inputFileStream = System.IO.File.OpenRead(FullEpgPackagePath))
                using (var gzipStream = new GZipInputStream(inputFileStream))
                {
                    OutputEpgFile = Path.Combine(OutputDirectoryPath, Path.GetFileNameWithoutExtension(FullEpgPackagePath));

                    using (var outputFileStream = System.IO.File.Create(OutputEpgFile))
                    {
                        OutputEpgFile = outputFileStream.Name;
                        StreamUtils.Copy(gzipStream, outputFileStream, streamBuffer);
                    }
                    gzipStream.Close();
                    inputFileStream.Close();
                    OperationsSuccessful = System.IO.File.Exists(OutputEpgFile);
                }
            }
            catch (Exception egzfException)
            {
                Console.WriteLine(egzfException);
                throw;
            }
        }

        private void ProcessTarInputStream(TarInputStream tarStream)
        {
            var entry = tarStream.GetNextEntry();
            OutputEpgFile = Path.Combine(OutputDirectoryPath, entry.Name);
            var outStream = new FileStream(OutputEpgFile, FileMode.CreateNew);
            while (entry != null)
            {
                Console.WriteLine($"Extracting: {entry.Name} to {OutputEpgFile}");
                tarStream.CopyEntryContents(outStream);
                entry = tarStream.GetNextEntry();
            }
            outStream.Close();
        }

        public void ExtractTarFile()
        {
            try
            {
                using (var inputStream = System.IO.File.OpenRead(FullEpgPackagePath))
                using (var tarStream = new TarInputStream(inputStream, Encoding.UTF8))
                {
                    ProcessTarInputStream(tarStream);
                    OperationsSuccessful = System.IO.File.Exists(OutputEpgFile);
                    tarStream.Close();
                    inputStream.Close();
                }
            }
            catch (Exception etfException)
            {
                Console.WriteLine(etfException);
                throw;
            }
        }

        public void ExtractTarGzFile()
        {
            try
            {
                using (var inputStream = System.IO.File.OpenRead(FullEpgPackagePath))
                using (var gzStream = new GZipInputStream(inputStream))
                using (var tarStream = new TarInputStream(gzStream, Encoding.UTF8))
                {

                    ProcessTarInputStream(tarStream);
                    OperationsSuccessful = System.IO.File.Exists(OutputEpgFile);
                    tarStream.Close();
                    gzStream.Close();
                    inputStream.Close();
                }
            }
            catch (Exception etgfException)
            {
                Console.WriteLine(etgfException);
                throw;
            }
        }
    }
}
