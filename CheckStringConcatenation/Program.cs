using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckStringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            StringMerger.isMerge("Bananas from Bahamas", "Bahas", "Bananas from am");

            Console.ReadKey();
        }
    }

    public class StringMerger
    {
        public static bool isMerge(string s, string part1, string part2)
        {
            string orderedBothPartStr = new String(string.Concat(part1, part2).OrderBy(c => c).ToArray());

            if(!orderedBothPartStr.Equals(new String(s.OrderBy(c => c).ToArray())))
                return false;

            for(int i = 0; i < part1.Length - 1; i++)
            {
                string copyOfs = s.Substring(s.IndexOf(part1[i]));

                if(copyOfs.IndexOf(part1[i + 1]) == -1)
                    return false;
            }

            for(int i = 0; i < part2.Length - 1; i++)
            {
                string copyOfs = s.Substring(s.IndexOf(part2[i]));

                if(copyOfs.IndexOf(part2[i + 1]) == -1)
                    return false;
            }

            return true;
        }
    }
}
