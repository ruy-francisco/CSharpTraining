using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomNumberGenerator.Class;

namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata kata1 = new Kata();
            Kata kata2 = new Kata();

            Console.WriteLine(kata1.GenerateRandomNumber());
            Console.WriteLine(kata2.GenerateRandomNumber());
            Console.ReadKey();
        }

    }
}
