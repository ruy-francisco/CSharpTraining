using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PowerNumbersAndSums.Class
{
    public static class Numbers
    {
        public static long PowerSumDigTerm(int n)
        {
            int count = 0;
            long currentNumber = 80;

            while(count < n)
            {
                currentNumber++;

                if(PowerEqualsSumOfDigits(currentNumber))
                    count++;                
            }

            return currentNumber;
        }

        public static bool PowerEqualsSumOfDigits(long input)
        {
            var listOfDigits = input.ToString().Select(c => c).ToArray();
            int sumOfDigits = (int)listOfDigits.Sum(d => Char.GetNumericValue(d));
            bool returnVal = false;

            Parallel.For(1, (int)input, (int powNumber, ParallelLoopState pls) =>
            {
                if(input == Math.Pow(sumOfDigits, powNumber))
                {
                    returnVal = true;
                    pls.Break();
                }                

                if(input < Math.Pow(sumOfDigits, powNumber))
                    pls.Break();
            });

            return returnVal;
        }
    }
}
