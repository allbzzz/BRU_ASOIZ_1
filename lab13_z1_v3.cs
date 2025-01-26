* Лабораторная работа 13, задание 1, вариант 3
* Разработать метод  f(x), который нечетное число заменяет на 0, а четное число уменьшает в 2 раза.
* Продемонстрировать работу данного метода на примере. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static double FindFuction(double n)
        {
            if(n % 2 == 0)
            {
                return n / 2;
            }
            return n = 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter value n: ");
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine($"Result: {FindFuction(number)}");
            Console.ReadKey();
        }
    }
}


