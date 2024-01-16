/*
Лабораторная работа 4
Задание 2
1
Даны три целых числа. Найти количество положительных чисел в исходном наборе.
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
                double sum = 0, num;
                int x = 1, n;
                Console.WriteLine("Введите число: ");
                num = double.Parse(Console.ReadLine());
                for (n = 1; n <= num; n++)
                {
                    sum += Math.Sin(n * x + 1) / n;
                }
                Console.WriteLine($"Результат: {sum:f3}");
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