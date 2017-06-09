using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerNumbersAndSums.Class;
using System.Diagnostics;

namespace PowerNumbersAndSums
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch ellapsedTime = new Stopwatch();

            ellapsedTime.Start();
            long valueToShow = Numbers.PowerSumDigTerm(12);
            ellapsedTime.Stop();

            Console.WriteLine(valueToShow);
            Console.WriteLine("Ellapsed time: {0}", ellapsedTime.ElapsedMilliseconds);

            Console.ReadKey();
        }
    }
}
