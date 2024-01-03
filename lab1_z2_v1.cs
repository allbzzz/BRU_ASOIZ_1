/*
Лабораторная работа 1
Задание 2
1. Даны три целых числа. Найти количество положительных чисел в 
исходном наборе.
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
                double x, y, z;
                int positive_num = 0;
                Console.WriteLine("Введите x: ");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите y: ");
                y = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите z: ");
                z = double.Parse(Console.ReadLine());
                if (x > 0)
                    positive_num++;
                if (y > 0)
                    positive_num++;
                if (z > 0)
                    positive_num++;
                Console.WriteLine($"Количество положительных чисел в наборе = {positive_num}");
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