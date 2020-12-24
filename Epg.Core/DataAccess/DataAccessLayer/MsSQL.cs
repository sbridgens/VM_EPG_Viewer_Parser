using Epg.Core.Abstract;
using Epg.Core.DataAccess.DataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Epg.Core.DataAccess.Concrete.DataAccessLayer
{
    public class MsSQL : abstractCommonSQL
    {
        #region Private Variable
        SqlConnection sqlConn;
        SqlCommand sqlCmd;
        #endregion

        #region Constructor
        public MsSQL()
        {
        }

        public MsSQL(string connectionString)
        {
            ConnectionString = connectionString;
            Schema = "dbo.";
        }

        public MsSQL(string connectionString, string schema)
        {
            ConnectionString = connectionString;
            Schema = schema == string.Empty ? "dbo." : schema;
        }
        #endregion

        #region Connection Methods
        protected override void OpenConnection()
        {
            try
            {
                if (sqlConn == null || sqlConn.State != ConnectionState.Open)
                {
                    sqlConn = new SqlConnection();
                    sqlConn.ConnectionString = ConnectionString;
                    sqlConn.Open();
                }
            }
            catch (Exception ex)
            {
                sqlConn.Close();
                throw ex;
            }
        }

        protected override void CloseConnection()
        {
            try
            {
                if (sqlConn != null && sqlConn.State != ConnectionState.Closed)
                {
                    sqlConn.Close();
                }
            }
            finally
            {
                sqlConn.Dispose();
                sqlConn = null;
            }
        }

        protected override void SetCommanProperties(string commandText, CommandType commandType)
        {
            sqlCmd.CommandText = Schema + commandText;
            sqlCmd.CommandType = commandType;
            sqlCmd.CommandTimeout = CommandTimeout;
            foreach (DALParameter dalParameter in DALParameters)
            {
                SqlParameter sqlParameter = new SqlParameter("@" + dalParameter.ParameterName, dalParameter.ParameterValue);
                sqlParameter.DbType = dalParameter.DBType;
                sqlParameter.Direction = dalParameter.Direction;
                sqlCmd.Parameters.Add(sqlParameter);
            }
            DALParameters.Clear();
        }
        #endregion

        #region Single Trasaction Methods
        public override void ExecuteNonQuery(string commandText, CommandType commandType)
        {
            try
            {
                sqlCmd = new SqlCommand();
                SetCommanProperties(commandText, commandType);
                OpenConnection();
                sqlCmd.Connection = sqlConn;
                sqlCmd.ExecuteNonQuery();
            }
            finally
            {
                sqlCmd.Dispose();
                CloseConnection();
            }
        }

        public override object ExecuteScalar(string commandText, CommandType commandType)
        {
            object objReturn = null;
            try
            {
                sqlCmd = new SqlCommand();
                SetCommanProperties(commandText, commandType);
                OpenConnection();
                sqlCmd.Connection = sqlConn;
                objReturn = sqlCmd.ExecuteScalar();
            }
            finally
            {
                sqlCmd.Dispose();
                CloseConnection();
            }
            return objReturn;
        }

        #endregion
    }
}
