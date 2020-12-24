using Epg.Core.DataAccess.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace Epg.Core.Abstract
{
    public abstract class abstractCommonSQL : ISql
    {
        #region Private Variable
        private string _connectionString;
        protected List<DALParameter> DALParameters = new List<DALParameter>();
        #endregion

        #region Public Properties
        /// <summary>
        /// Get & Set Connection String
        /// </summary>
        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        private int _CommandTimeout = 300;
        public int CommandTimeout
        {
            get
            {
                return _CommandTimeout;
            }
            set
            {
                _CommandTimeout = value;
            }
        }
        public string Schema { get; set; }
        #endregion

        #region Abstract Methods
        protected abstract void OpenConnection();
        protected abstract void CloseConnection();
        protected abstract void SetCommanProperties(string commandText, CommandType commandType);

        public abstract void ExecuteNonQuery(string commandText, CommandType commandType);
        public abstract object ExecuteScalar(string commandText, CommandType commandType);

        #endregion

        #region Public Methods
        public void AddParameter(string parameterName, object parameterValue)
        {
            if (parameterValue == null)
                parameterValue = DBNull.Value;
            DALParameters.Add(new DALParameter(parameterName, parameterValue));
        }
        public void AddParameter(string parameterName, DbType dbType, ParameterDirection direction, object parameterValue)
        {
            if (parameterValue == null)
                parameterValue = DBNull.Value;
            DALParameters.Add(new DALParameter(parameterName, dbType, direction, parameterValue));
        }
        public void ClearParameter()
        {
            DALParameters.Clear();
        }

        public Dictionary<string, object> GetParameters()
        {
            Dictionary<string, object> _dict = new Dictionary<string, object>();
            DALParameters.ForEach(d => _dict.Add(d.ParameterName, d.ParameterValue));
            return _dict;
        }

        #endregion
    }
}
