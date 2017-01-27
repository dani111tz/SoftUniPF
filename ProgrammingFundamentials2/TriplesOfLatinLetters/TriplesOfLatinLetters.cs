using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesOfLatinLetters
{
   public class TriplesOfLatinLetters
    {
        public static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());

            for (int firstDigit = 0; firstDigit< n; firstDigit++)
            {
                for (int secondDigit = 0; secondDigit < n; secondDigit++)
                {
                    for (int thirdDigit = 0; thirdDigit < n; thirdDigit++)
                    {

                        var firstLetter =(char) (firstDigit + 'a');
                        var secondLetter = (char)(secondDigit + 'a');
                        var thirdletter = (char)(thirdDigit + 'a');
                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdletter}");

                    }
                }
            }
        }
    }
}
