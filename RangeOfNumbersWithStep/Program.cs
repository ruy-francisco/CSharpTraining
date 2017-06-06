using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeOfNumbersWithStep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GenerateRange(1, 10, 4));

            Console.ReadKey();
        }

        public static int[] GenerateRange(int min, int max, int step)
        {
            List<int> listToReturn = new List<int>();
            listToReturn.Add(min);

            while((listToReturn.Last() + step) < max)
            {
                listToReturn.Add(listToReturn.Last() + step);
            }

            return listToReturn.ToArray();
        }
    }
}
