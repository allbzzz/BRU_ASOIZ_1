/*
Самостоятельная работа 1
Задание 1
Даны  x, y, z. Вычислить a, b:





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
                double x, y, z, a, b;
                Console.WriteLine("Введите x: ");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите y: ");
                y = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите z: ");
                z = double.Parse(Console.ReadLine());
                a = (1 + Math.Sin(z - 2)) / (Math.Pow(y, 3) / 3 + Math.Cos(Math.Pow(x, 2)));
                b = (1 + Math.Sin(Math.Pow(x + y, 2))) / (2 + Math.Abs(x - 2 * y / (1 + Math.Pow(x, 2) * Math.Pow(y, 2))));
                Console.WriteLine($"Значение a = {a:f5}\nЗначение b = {b:f5}");
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
