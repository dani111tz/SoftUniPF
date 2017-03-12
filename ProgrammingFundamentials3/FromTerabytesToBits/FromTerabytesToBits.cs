using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromTerabytesToBits
{
   public class FromTerabytesToBits
    {
        public static void Main(string[] args)
        {
            decimal teraBit= decimal.Parse(Console.ReadLine());
            decimal teraBitToBit = teraBit *1024 * 1024 * 1024 * 1024* 8;
            Console.WriteLine("{0:f0}", teraBitToBit);
        }
    }
}
