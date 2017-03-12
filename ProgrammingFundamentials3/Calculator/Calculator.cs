using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            char operatori = char.Parse(Console.ReadLine());

            double b = double.Parse(Console.ReadLine());
            double result = 0;


            switch (operatori)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b; 
                    break;
                case '*':
                    result = a * b; 
                    break;
                case '/':
                    result = a / b;
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
                    


            }
            Console.WriteLine($"{a} {operatori} {b} = {result}");

        }
    }
}

