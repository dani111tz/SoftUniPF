using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    public class ExchangeVariableValues
    {
        public static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine()); 
            int b = int.Parse(Console.ReadLine()); 
            int ta = b;
            int tb = a;
            a = ta;
            b = tb;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
