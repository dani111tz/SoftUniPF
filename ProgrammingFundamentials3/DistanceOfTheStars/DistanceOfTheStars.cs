using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceOfTheStars
{
    public class DistanceOfTheStars
    {
        public static void Main(string[] args)
        {
            decimal lightYear = 9450000000000;
            decimal earthNearestStar =(decimal )4.22 * lightYear;
            decimal centerOurGalaxy = 26000 * lightYear;
            decimal diameterMilkyWay = 100000 * lightYear;
            decimal distanceEdge= 46500000000 * lightYear;

            Console.WriteLine(earthNearestStar);
            Console.WriteLine(centerOurGalaxy);
            Console.WriteLine(diameterMilkyWay);
            Console.WriteLine(distanceEdge);


        }
    }
}
