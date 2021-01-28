using Epg.Core.Abstract;
using Epg.Core.DataAccess.Concrete.DataAccessLayer;
using Epg.DataAccess.Abstract;
using Epg.Entities.Concrete;
using Epg.Serialization.Concrete;
using Microsoft.Extensions.Configuration;
using System.Data;
using Epg.Core.DataAccess.DataAccessLayer;
using System;

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
            sql.CommandTimeout = 3600;
            sql.AddParameter("EpgFilenameGZ", tVADBMainEntities.ScheduleFileHistory.EpgFilenameGZ);
            sql.AddParameter("EpgFilenameExtracted", tVADBMainEntities.ScheduleFileHistory.EpgFilenameExtracted);
            sql.AddParameter("EpgOriginalFileSize", tVADBMainEntities.ScheduleFileHistory.EpgOriginalFileSize);
            sql.AddParameter("EpgExtractedFileSize", tVADBMainEntities.ScheduleFileHistory.EpgExtractedFileSize);
            sql.AddParameter("EpgDateTimeRetrieved", DbType.DateTime, ParameterDirection.Input, tVADBMainEntities.ScheduleFileHistory.EpgDateTimeRetrieved);
            sql.AddParameter("EpgDateTimeParsed", DbType.DateTime, ParameterDirection.Input, tVADBMainEntities.ScheduleFileHistory.EpgDateTimeParsed);
            sql.AddParameter("EpgDateTimeArchived", DbType.DateTime, ParameterDirection.Input, tVADBMainEntities.ScheduleFileHistory.EpgDateTimeArchived);
            sql.AddParameter("EpgArchiveLocation", tVADBMainEntities.ScheduleFileHistory.EpgArchiveLocation);
            sql.AddParameter("GroupInformationData", tVADBMainEntities.Groups.ToXML());
            sql.AddParameter("ProgramInformationData", tVADBMainEntities.Programs.ToXML());
            sql.AddParameter("ProgramScheduleData", tVADBMainEntities.ProgramSchedules.ToXML());
            sql.AddParameter("ServiceInformationData", tVADBMainEntities.Services.ToXML());
            sql.AddParameter("CurrentDateTime", DbType.DateTime, ParameterDirection.Input, DateTime.UtcNow);
            sql.ExecuteNonQuery("EPG_History_InsertUpdate", CommandType.StoredProcedure);
        }


    }
}
