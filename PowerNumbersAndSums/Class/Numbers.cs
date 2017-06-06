using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerNumbersAndSums.Class
{
    public static class Numbers
    {
        public static long PowerSumDigTerm(int n)
        {
            int controller = 0;
            long count = 10;
            long resultNumber = 0;

            while(controller < n)
            {
                if(PowerEqualsSumOfDigits(count))
                {
                    resultNumber = count;
                    controller++;
                }

                count++;
            }

            return resultNumber;
        }

        public static bool PowerEqualsSumOfDigits(long input)
        {
            var listOfDigits = input.ToString().Select(c => c).ToArray();
            int sumOfDigits = (int)listOfDigits.Sum(d => Char.GetNumericValue(d));

            int count = 1;
            while(count <= sumOfDigits)
            {
                if(input == Math.Pow(sumOfDigits, count))
                    return true;

                if(input < Math.Pow(sumOfDigits, count))
                    return false;

                count++;
            }

            return false;
        }
    }
}
