using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingPredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 1, 2, 3, 4, 5 };
            All(test, v => v > 9);
        }

        public static bool All(int[] arr, Func<int, bool> fun)
        {
            if(arr == null || arr.Length == 0) return true;

            return arr.Where(fun).ToArray().Length == arr.Length;
        }
    }
}
