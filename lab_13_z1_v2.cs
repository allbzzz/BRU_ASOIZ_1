using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static double Calculate(double x, int n)
        {
            return Math.Pow(x, n) / n;
        }
        static void Main(string[] args)
        {
            double x = 2;
            double result = Calculate(x, 2) + Calculate(x, 4) + Calculate(x, 6);
            Console.WriteLine(result);
        }
    }
}
