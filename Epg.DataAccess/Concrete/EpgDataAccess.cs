using Epg.Core.Abstract;
using Epg.Core.DataAccess.Concrete.DataAccessLayer;
using Epg.DataAccess.Abstract;
using Epg.Entities.Concrete;
using Epg.Serialization.Concrete;
using Microsoft.Extensions.Configuration;
using System.Data;
using Epg.Core.DataAccess.DataAccessLayer;

namespace Epg.DataAccess.Concrete
{
    public class EpgDataAccess: abstractCommonDataAccess
    {
        ISql sql;
        public EpgDataAccess(IConfiguration config)
        {
            CreateSql createSql = new CreateSql(config);
            sql = createSql.CreateSqlInstance("Default");
        }

        public void InsertUpdate(TVADBMainEntities tVADBMainEntities)
        {
            sql.AddParameter("EpgFilenameGZ", tVADBMainEntities.ScheduleFileHistory.EpgFilenameGZ);
            sql.AddParameter("EpgFilenameExtracted", tVADBMainEntities.ScheduleFileHistory.EpgFilenameExtracted);
            sql.AddParameter("EpgOriginalFileSize", tVADBMainEntities.ScheduleFileHistory.EpgOriginalFileSize);
            sql.AddParameter("EpgExtractedFileSize", tVADBMainEntities.ScheduleFileHistory.EpgExtractedFileSize);
            sql.AddParameter("EpgDateTimeRetrieved", tVADBMainEntities.ScheduleFileHistory.EpgDateTimeRetrieved);
            sql.AddParameter("EpgDateTimeParsed", tVADBMainEntities.ScheduleFileHistory.EpgDateTimeParsed);
            sql.AddParameter("EpgDateTimeArchived", tVADBMainEntities.ScheduleFileHistory.EpgDateTimeArchived);
            sql.AddParameter("EpgArchiveLocation", tVADBMainEntities.ScheduleFileHistory.EpgArchiveLocation);
            sql.AddParameter("GroupInformationData", tVADBMainEntities.Groups.ToXML());
            sql.AddParameter("ProgramInformationData", tVADBMainEntities.Programs.ToXML());
            sql.AddParameter("ProgramScheduleData", tVADBMainEntities.ProgramSchedules.ToXML());
            sql.AddParameter("ServiceInformationData", tVADBMainEntities.Services.ToXML());
            sql.ExecuteNonQuery("EPG_InsertUpdate", CommandType.StoredProcedure);
        }


    }
}
