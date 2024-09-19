* Лабораторная работа 13. задание 1, вариант 2
* Разработать метод f(n, x), который для заданного натурального числа n и 
* вещественного х находит значение выражения . Вычислить с помощью данного метода значение выражения .*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static double FindFuction(double x, int n)
        {
            return (Math.Pow(x, n)) / n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter value x: ");
            double x = double.Parse(Console.ReadLine());
            double func = FindFuction(x, 2) + FindFuction(x, 4) + FindFuction(x, 6);
            Console.WriteLine($"Result: {func:f5}");
            Console.ReadKey();
        }
    }
}


