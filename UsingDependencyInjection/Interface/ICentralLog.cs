using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDependencyInjection.Interface
{
    public interface ICentralLog
    {
        void NewLog(string logMsg, int userId, string userName);
    }
}
