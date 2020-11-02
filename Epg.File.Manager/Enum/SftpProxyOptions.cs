using System;
using System.Collections.Generic;
using System.Text;

namespace Epg.File.Manager.Enum
{ 
    public enum ProxyMethod
    {
        None = 0,
        SOCKS4 = 1,
        SOCKS5 = 2,
        HTTP = 3,
        TELNET_SCP = 4,
        LOCAL_SCP = 5
    }
}
