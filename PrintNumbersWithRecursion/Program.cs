using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PrintNumbersWithRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //printNaturalNumbers(1, 10);
            //printDescNaturaNumbers(10, 10);
            //Console.WriteLine(sumFirstNaturalNumbers(10));
            showDigits(1234);
            Console.Read();
        }

        static int printNaturalNumbers(int count, int number)
         {
            if(number < 1)
                return count;            

            Console.Write(count + ", ");
            number--;
            count++;

            return printNaturalNumbers(count, number);
        }

        static int printDescNaturaNumbers(int number, int count)
        {
            if(number < 1)
                return count;

            Console.Write(count + " ");

            number--;
            count--;

            return printDescNaturaNumbers(number, count);
        }

        static int sumFirstNaturalNumbers(int input)
        {
            if(input < 1)
                return input;

            return input + sumFirstNaturalNumbers(input - 1);
        }

        static int showDigits(int input)
        {
            var allNumbers = input.ToString().ToArray();

            if(allNumbers.Length == 1)
                return allNumbers[0];

            string newNumber = String.Join("", allNumbers.ToString().Substring(1, allNumbers.Length - 2));

            return 1;
        }
    }
}
