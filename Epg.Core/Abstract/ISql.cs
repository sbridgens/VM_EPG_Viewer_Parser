using System.Collections.Generic;
using System.Data;

namespace Epg.Core.Abstract
{
    public interface ISql
    {
        int CommandTimeout { get; set; }
        string Schema { get; set; }

        void ExecuteNonQuery(string commandText, CommandType commandType);
        object ExecuteScalar(string commandText, CommandType commandType);

        void AddParameter(string parameterName, object parameterValue);
        void AddParameter(string parameterName, DbType dbType, ParameterDirection direction, object parameterValue);
        void ClearParameter();
        Dictionary<string, object> GetParameters();
    }
}
