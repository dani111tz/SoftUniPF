using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
   public class Greeting
    {
        public static void Main(string[] args)
        {
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            int age= int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {firstname} {lastname}. You are {age} years old. ");
        }
    }
}
