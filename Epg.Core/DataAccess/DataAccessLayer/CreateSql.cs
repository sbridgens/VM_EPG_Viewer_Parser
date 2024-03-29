﻿using Epg.Core.Abstract;
using Microsoft.Extensions.Configuration;
using System;

namespace Epg.Core.DataAccess.Concrete.DataAccessLayer
{
    /// <summary>
    /// This class use for create MsSql, PgSQL, OleDB, ODBCDB object based on provider.
    /// Created By : Rekansh Patel
    /// Created On : 07/09/2019
    /// </summary>
    public class CreateSql
    {
        #region Constructor
        public IConfiguration Configuration { get; private set; }

        /// <summary>
        /// Get configurations in constructor.
        /// </summary>
        /// <param name="configuration"></param>
        public CreateSql(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        #endregion

        #region Private Variable
        private string _connectionStringKey;
        private static string _staticConnectionStringKey;
        #endregion

        #region Properties
        public string ConnectionStringKey
        {
            get { return _connectionStringKey; }
            set { _connectionStringKey = value; }
        }
        public static string CommonConnectionStringKey
        {
            get { return _staticConnectionStringKey; }
            set { _staticConnectionStringKey = value; }
        }
        private string ProviderName => 
            Configuration.GetSection("ConnectionStrings:Default:ProviderName").Value.ToLower();

        private string ConnectionString => 
            Configuration.GetSection("ConnectionStrings:Default:ConnectionString").Value.ToLower();
        
        private string IPAddress
        {
            get;
            set;
        }
        public string Schema
        {
            get;
            set;
        }

        #endregion

        #region Public Methods
        public ISql CreateSqlInstance()
        {
            IPAddress = string.Empty;
            if (ProviderName.Contains("system.data.sqlclient"))
                return new MsSQL(ConnectionString, Schema);
            //else if (ProviderName.ToLower().Contains("oracle.dataaccess.client") || ProviderName.ToLower().Contains("microsoft.ace.oledb"))
            //    return new OleSql(ConnectionString, Schema);
            //else if (ProviderName.ToLower().Contains("npgsql"))
            //    return new PostgreSql(ConnectionString, Schema);
           
            return new MsSQL(ConnectionString, Schema);
        }

        public ISql CreateSqlInstance(string connectionStringKey, string schema = "")
        {
            IPAddress = string.Empty;
            ConnectionStringKey = connectionStringKey;
            Schema = schema;
            return CreateSqlInstance();
        }

        #endregion
    }
}
