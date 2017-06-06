using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightForWeight.Class
{
    public static class WeightSort
    {
        public static string orderWeight(string strng)
        {
            if(strng.Equals(""))
                return strng;

            return strng.orderByWeight();
        }

        private static string orderByWeight(this string input)
        {
            List<string> inputAsList = input.Split(' ').ToList();
            List<KeyValuePair<int, string>> weightAndDigits = new List<KeyValuePair<int, string>>();
            
            foreach(var item in inputAsList)
            {
                weightAndDigits.Add(new KeyValuePair<int, string>((int)item.Sum(d => Char.GetNumericValue(d)), item));
            }

            var auxGroups = weightAndDigits.OrderBy(i => i.Key).GroupBy(i => i.Key);

            string strToReturn = "";

            foreach(var group in auxGroups)
            {
                strToReturn += string.Join(" ", group.OrderBy(e => e.Value).Select(e => e.Value.ToString()).ToArray()) + " ";
            }

            return strToReturn.TrimEnd();
        }
    }
}
