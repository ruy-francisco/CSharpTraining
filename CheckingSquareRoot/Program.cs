using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingSquareRoot
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static int[] SquareOrSquareRoot(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(Math.Sqrt(array[i]) % 1 == 0)
                    array[i] = Math.Sqrt[array[i]];
                else
                    array[i] = array[i] * array[i];
            }

            return array;
        }

    }
}
