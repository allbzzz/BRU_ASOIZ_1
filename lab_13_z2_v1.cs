/*
* Лабораторная работа № 13, задание 2, вариант 1
* Постройте таблицу значений функции y =  f (x) для х  [a, b]  с шагом h. 
* Для решения задачи использовать вспомогательный метод.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static double Func(double x)
        {
            double y = 0;
            if (x - 1 < 1) { y = 1; }
            if (x - 1 == 1) { y = 0; }
            if ( x - 1 > 1) { y = -1; }
            return y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value start - a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value end - b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value step h: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine();
            for (double x = a; x < b; x += h)
            {
                double y = Func(x);
                Console.WriteLine($"{x}\t\t{y}");
            }
            Console.ReadKey();
        }
    }
}