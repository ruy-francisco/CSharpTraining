using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingPeopleInTheBus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int[]> peopleList = new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 10 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 10 } };
            int remainingPeople = Number(peopleList);

            Console.ReadKey();
        }

        public static int Number(List<int[]> peopleListInOut)
        {
            return peopleListInOut.Sum(arr => arr[0] - arr[1]);
        }
    }
}
