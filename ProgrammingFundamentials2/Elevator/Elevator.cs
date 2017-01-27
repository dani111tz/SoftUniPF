using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            var numberPeople= int.Parse(Console.ReadLine());
            var capacityPeople= int.Parse(Console.ReadLine());

            double numberCourses =Math.Ceiling(((double)(numberPeople)) / (capacityPeople));
            Console.WriteLine(numberCourses);
        }
    }
}
