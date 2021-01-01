using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Configuration
{
    public class DatabaseSettings
    {
        public string Host { get; set; }
        public string DbPort { get; set; }
        public string DatabaseName { get; set; }
        public string TrustedConnection { get; set; }
        public string ConnectionString => $"Server={Host},{DbPort};" +
                                          $"Database={DatabaseName};" +
                                          $"Trusted_Connection={TrustedConnection};";
    }
}
