using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hexadecimal_Format
{
   public class Program
    {
       public static void Main(string[] args)
        {
            string toConvert = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(toConvert, 16));
        }
    }
}
