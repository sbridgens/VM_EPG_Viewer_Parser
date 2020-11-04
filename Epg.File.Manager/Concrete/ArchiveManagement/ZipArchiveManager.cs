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
    public class ZipArchiveManager : IZipArchiveInterface, IDisposable
    {
        public string FullEpgPackagePath { get; set; }
        public string OutputDirectoryPath { get; set; }
        public string OutputEpgFile { get; set; }
        public string EpgArchiveDirectory { get; set; }
        public bool OperationsSuccessful { get; set; }
        public bool CanArchive { get; set; }

        private readonly byte[] streamBuffer = new byte[4096];
        private Stream InputFileStream { get; set; }
        private Stream OutputFileStream { get; set; }

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
                        System.IO.File.Move(archiveFile, Path.Combine(EpgArchiveDirectory, $"[Duplicate_{DateTime.Now.ToString("ddMyyyTHH-mm-ss")}]_{finfo.Name}"));
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
                using(InputFileStream = System.IO.File.OpenRead(FullEpgPackagePath))
                using (var epgZip = new ZipFile(InputFileStream))
                {
                    foreach (ZipEntry entry in epgZip)
                    {
                        if(!entry.IsFile)
                            continue;

                        OutputEpgFile = Path.Combine(OutputDirectoryPath, entry.Name);
                        using (var zipStream = epgZip.GetInputStream(entry))
                        using (OutputFileStream = System.IO.File.Create(OutputEpgFile))
                        {
                            StreamUtils.Copy(zipStream, OutputFileStream, streamBuffer);
                        }
                    }
                    epgZip.Close();
                    InputFileStream.Close();
                    OperationsSuccessful = true;
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
                using (InputFileStream = new FileStream(FullEpgPackagePath, FileMode.Open, FileAccess.Read))
                using (var gzipStream = new GZipInputStream(InputFileStream))
                {
                    OutputEpgFile = Path.Combine(OutputDirectoryPath,
                        Path.GetFileNameWithoutExtension(FullEpgPackagePath));

                    using (OutputFileStream = System.IO.File.Create(OutputEpgFile))
                    {
                        StreamUtils.Copy(gzipStream, OutputFileStream, streamBuffer);
                    }
                    gzipStream.Close();
                    InputFileStream.Close();
                    OperationsSuccessful = true;
                }
            }
            catch (Exception egzfException)
            {
                Console.WriteLine(egzfException);
                throw;
            }
        }

        public void ExtractTarFile()
        {
            try
            {
                using (InputFileStream = System.IO.File.OpenRead(FullEpgPackagePath))
                {
                    var tarBall = TarArchive.CreateInputTarArchive(InputFileStream, Encoding.UTF8);
                    tarBall.ExtractContents(OutputDirectoryPath);
                    tarBall.Close();
                    InputFileStream.Close();
                    OperationsSuccessful = true;
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
                using (InputFileStream = System.IO.File.OpenRead(FullEpgPackagePath))
                using (var gzipStream = new GZipInputStream(InputFileStream))
                {
                    var tarBall = TarArchive.CreateInputTarArchive(gzipStream, Encoding.UTF8);
                    tarBall.ExtractContents(OutputDirectoryPath);
                    tarBall.Close();
                    gzipStream.Close();
                    InputFileStream.Close();
                    OperationsSuccessful = true;
                }
            }
            catch (Exception etgfException)
            {
                Console.WriteLine(etgfException);
                throw;
            }
        }


        #region IDisposable

        // Flag: Has Dispose already been called?
        private bool disposed;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                InputFileStream?.Dispose();
                OutputFileStream?.Dispose();
            }


            disposed = true;
        }

        ~ZipArchiveManager()
        {
            Dispose(false);
        }

        #endregion
    }
}
