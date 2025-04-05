using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeAppGun1.SOLID
{
    public class Logger
    {
        public ILog iLog;

        //Constructor Injection
        public Logger(ILog iLog)
        {
            this.iLog = iLog;
        }

        public string LogKaydet(string message)
        {
           return iLog.log(message);
        }
    }
}
