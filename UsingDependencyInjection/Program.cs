using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingDependencyInjection.Class;
using UsingDependencyInjection.Interface;

namespace UsingDependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            LogHandler lH = new LogHandler(new FileLog());

            Console.WriteLine("Type somenthing to be logged");
            string msgToLog = Console.ReadLine();

            lH.SaveLog(msgToLog);
             
            Console.ReadKey();
        }
    }
}
