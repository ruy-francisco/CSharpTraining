using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8};

            printEvenNumbers(numbers);
            Console.ReadLine();
        }

        static void printEvenNumbers(int[] input)
        {
            var listOfEvenNumbers = input.Where(d => d % 2 == 0).Select(d => d);

            Console.WriteLine("The numbers which produce the remainder 0 after divided by 2 are : ");
            foreach(var item in listOfEvenNumbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
