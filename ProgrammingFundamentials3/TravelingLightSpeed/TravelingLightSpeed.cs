using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelingLightSpeed
{
   public class TravelingLightSpeed
    {
       public static void Main(string[] args)

        {
            decimal lightYear= decimal.Parse(Console.ReadLine());

            decimal lightYearToKM = 9450000000000;
            decimal lightSpeed = 300000;
            //s=v*t ;t=s/v

            decimal seconds = lightYearToKM / lightSpeed*lightYear;
            decimal minutes = seconds /60;
            seconds %= 60;
            decimal hours = minutes/ 60;
            minutes %= 60;
            decimal days = hours / 24;
            hours %= 24;
            decimal weeks = days / 7;
            days %= 7;


            Console.WriteLine("{0} weeks",(int) weeks );
            Console.WriteLine("{0} days", (int)days);
            Console.WriteLine("{0} hours",(int) hours);
            Console.WriteLine("{0} minutes",(int) minutes);
            Console.WriteLine("{0} seconds",(int) seconds);
           




                
        }
    }
}
