using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RemovingFinalZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NoBoringZeros(1450));
            Console.ReadKey();
        }

        public static int NoBoringZeros(int n)
        {
            Regex regexObj = new Regex(@"0*$");
            string aux = regexObj.Replace(n.ToString(), "");
            return Int32.Parse(aux);
        }
    }
}
