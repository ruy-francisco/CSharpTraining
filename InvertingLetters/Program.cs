using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertingLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder letters = new StringBuilder();

            for(int i = 0; i < 3; i++)
            {
                Console.Write("Insert a letter: ");
                letters.Append(Console.ReadLine());
            }

            Console.WriteLine(String.Join("", letters.ToString().ToArray().Reverse()));
            Console.ReadLine();
        }
    }
}
