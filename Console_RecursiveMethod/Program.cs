using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_RecursiveMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to calculate it's factorial:");
            double n=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("factorial of {0} is {1}",n, Fact(n));
            Console.ReadKey();
        }

        public static double Fact(double x)
        {
            if (x == 1)
                return 1;
            else
                return x * Fact(x - 1);            
        }
    }
}
