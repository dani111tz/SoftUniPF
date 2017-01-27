using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
   public class Transport
    {
       public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var capacity = (8 + 4 + 12);
            var courses = Math.Ceiling((double) n / capacity);
            Console.WriteLine(courses);
        }
    }
}
