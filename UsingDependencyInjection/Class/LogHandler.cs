using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingDependencyInjection.Class;
using UsingDependencyInjection.Interface;

namespace UsingDependencyInjection.Class
{
    public class LogHandler
    {
        private ICentralLog _centralLogger;

        public LogHandler(ICentralLog iCentralLog)
        {
            this._centralLogger = iCentralLog;
        }

        public void SaveLog(string msg)
        {
            this._centralLogger.NewLog(msg, 55, "Ruy Almeida");
        }
    }
}
