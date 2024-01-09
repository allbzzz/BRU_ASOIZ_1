/*
Лабораторная работа 3
Задание 1
1
запрашивает с клавиатуры два 
целых числа, и выводит на экран 
сумму данных чисел

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
                int num_first, num_second, sum_num;
                Console.WriteLine("Введите первое число: ");
                num_first = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                num_second = int.Parse(Console.ReadLine());
                sum_num = num_first + num_second;
                Console.WriteLine($"Сумма чисел {num_first} + {num_second} = {sum_num}");
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
