/*
самостоятельная работа 2
Задание 2
1




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
                Console.WriteLine("Введите число x: ");
                x = double.Parse(Console.ReadLine());
                if (x < 1.35)
                    y = Math.Sin(x + 2);
                else if (2 <= x && x <= 4)
                    y = x + 3.5 * Math.Tan(x);
                else
                    y = Math.Sqrt(Math.Abs(2.56 * x - 0.35));
                Console.WriteLine($"Значение числа y = {y:f4}");
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
