using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatOrInteger
{
   public class Program
    {
      public  static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            if(!(a % a==1))
            {
                Console.WriteLine(Math.Round(a));
            }
            else Console.WriteLine(a);

        }
    }
}
