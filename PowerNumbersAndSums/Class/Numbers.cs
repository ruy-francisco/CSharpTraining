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
            return PowerEqualsSumOfDigits(80, 0, n);
        }

        public static long PowerEqualsSumOfDigits(long starterNumber, int count, long input)
        {
            if(count == input)
                return starterNumber - 1;

            var listOfDigits = starterNumber.ToString().Select(c => c).ToArray();
            int sumOfDigits = 0;
            bool isValidNumber = false;

            while(true)
            {
                listOfDigits = starterNumber.ToString().Select(c => c).ToArray();
                sumOfDigits = (int)listOfDigits.Sum(d => Char.GetNumericValue(d));

                if(sumOfDigits > 1 && (starterNumber % sumOfDigits == 0))
                {
                    Parallel.For(1, int.MaxValue, (int curPow, ParallelLoopState pls) =>
                    {
                        if(starterNumber == Math.Pow(sumOfDigits, curPow))
                        {
                            isValidNumber = true;
                            pls.Break();
                        }   

                        if(starterNumber < Math.Pow(sumOfDigits, curPow))
                            pls.Break();
                    });

                    if(isValidNumber)
                        return PowerEqualsSumOfDigits(++starterNumber, ++count, input);
                }                

                starterNumber++;
            }
        }
    }
}
