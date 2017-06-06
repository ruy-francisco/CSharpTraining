using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingDependencyInjection.Interface;
using System.IO;

namespace UsingDependencyInjection.Class
{
    public class FileLog: ICentralLog
    {
        public void NewLog(string logMsg, int userId, string userName)
        {
            try
            {
                string msgToLog = "Usuário de código " + userId + " e nome " + userName + " executou " + logMsg;

                using(StreamWriter sw = new StreamWriter("loggerFile.txt", true))
                {
                    sw.WriteLine(msgToLog);
                }
            }
            catch(Exception e)
            {
                throw e;
            }            
        }   
    }
}
