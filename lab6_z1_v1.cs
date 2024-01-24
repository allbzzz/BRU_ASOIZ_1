/*
Лабораторная работа 6
Задание 1
1
Построить таблицу значений для функции 
f (x) x sin(x)
на отрезке [0, /2] с 
числом разбиений отрезка m=10.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double start = 0, end = Math.PI / 2;
                int m = 10;
                double step = (end - start) / m;
                for (int i = 0; i <= m; i++)
                {
                    double x = start + i * step;
                    double fx = x - Math.Sin(x);
                    Console.WriteLine($"{x:f3} = {fx:f3}");
                } 
            }
            catch(Exception e)
            {
                string message = e.Message;
                Console.WriteLine("Ошибка: {0}", message);
            }
            Console.ReadKey();
        }
    }
}