using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a Cº degree: ");

            double degrees = 0.0;

            try
            {
                Double.TryParse(Console.ReadLine(), out degrees);
                if(degrees.GetType() != typeof(double))
                {
                    throw new Exception("Please, insert a number");
                }

                Console.WriteLine("Fº: " + convertToFahrenheit(degrees));
                Console.WriteLine("Kº: " + convertToKelvin(degrees));
                Console.ReadLine();
            }
            catch(Exception)
            {

                throw;
            }            
        }

        public static double convertToKelvin(double input)
        {
            return input + 273.15;
        }

        public static double convertToFahrenheit(double input)
        {
            return (input * 1.8 + 32);
        }
    }
}
