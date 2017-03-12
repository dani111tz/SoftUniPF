using System;

namespace TrickyStrings
{
   public class TrickyStrings
    {
      public  static void Main()
        {
            string delimiter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string sum = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                string inputString= Console.ReadLine();
                sum = (inputString + delimiter)+ (inputString + delimiter);
            }
            Console.WriteLine(sum);
        }
    }
}
