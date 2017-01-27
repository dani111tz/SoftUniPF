using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_Special_Numbers
{
   public class Program
    {
     public   static void Main(string[] args)
        {
            int maxnumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentNumber = 0;
             bool result = false;
            for (int i = 1; i <= maxnumber; i++)
            {
                currentNumber = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                result = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{currentNumber} -> {result}");
                sum = 0;
                i = currentNumber;
            }


        }
    }
}
