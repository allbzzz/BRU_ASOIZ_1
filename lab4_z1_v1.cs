/*
Лабораторная работа 4
Задание 
1
Написать программу для вычисления значения функции



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
                double x, y;
                Console.WriteLine("Введите значение x: ");
                x = double.Parse(Console.ReadLine());
                if (x <= 0)
                    y = Math.Sin(x);
                else if (0 < x && x <= Math.PI / 4)
                    y = Math.Tan(x);
                else if (Math.PI / 4 <= x && x <= 32)
                    y = Math.Log(2, x);
                else
                    y = 1 / x;
                Console.WriteLine($"Значение y = {y:f3}");   
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