using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator.Class
{
    public class Kata
    {
        private Random _random;
        private static int count;

        public Kata() {
            if(this._random == null)
            {
                this._random = new Random(count);
            }            
        }

        public int GenerateRandomNumber()
        {
            return _random.Next(0, 1000);
        }
    }
}
