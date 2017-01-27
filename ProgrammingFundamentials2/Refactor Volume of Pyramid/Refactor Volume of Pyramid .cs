using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_Volume_of_Pyramid
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double length = 0;
            double width = 0;
            double height = 0;
            double volume = 0;

            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());
            volume = (length * width * height) /3.0;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);

        }
    }
}
