using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseCharCase
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string inputData = "oPaeIdoa";
            Console.WriteLine(inputData.ToAlternatingCase());
            Console.ReadKey();
        }

        public static string ToAlternatingCase(this string s)
        {
            var charsOfString = s.ToCharArray();
            charsOfString = charsOfString.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)).ToArray();
            return new String(charsOfString);
        }
    }
}
