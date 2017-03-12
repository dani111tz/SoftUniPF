using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_String
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string sum = string.Empty;
            for (int i = 0; i < n; i++)
            {
                int number= int.Parse(Console.ReadLine());
                char character = (char)number;
                sum +=character;
            }
            Console.WriteLine(sum);
        }
    }
}
