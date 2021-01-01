using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Configuration
{
    public class ProxySettings
    {
        public string UseProxy { get; set; }
        public string ProxyType { get; set; }
        public string ProxyHost { get; set; }
        public string ProxyPort { get; set; }
        public string ProxyUsername { get; set; }
        public string ProxyPassword { get; set; }
    }
}
