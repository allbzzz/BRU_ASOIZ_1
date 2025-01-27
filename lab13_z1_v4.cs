* Лабораторная работа 13, задание 1, вариант 4
* 4Разработать метод  f(x),  который число, кратное 5, уменьшает в 5 раз, 
* а остальные числа увеличивает на 1. Продемонстрировать работу данного метода на примере. */


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
            if(n % 5 == 0)
            {
                return n / 5;
            }
            return n += 1;
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

