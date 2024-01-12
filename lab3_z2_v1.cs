/*
Лабораторная работа 3
Задание 2
1
Ввести с клавиатуры длины катетов a и b прямоугольного треугольника. 
Найти его периметр и площадь.

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
                int a, b;
                double p, s;
                Console.WriteLine("Введите длину первого катета: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите длину второго катета: ");
                b = int.Parse(Console.ReadLine());
                double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                p = a + b + c;
                s = (a * b) / 2.0;
                Console.WriteLine($"Периметр треугольника с катетами {a} и {b} = {p:f2}\nПлощадь треугольника с катетами {a} и {b} = {s:f2}");
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
