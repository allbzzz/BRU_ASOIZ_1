/*
Лабораторная работа 1
Задание 4
1
Дано целое число N (> 0). Найти сумму 1 + 1/2 + 1/3 + ... + 1/N

*/


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
                int number, count = 2, sum_numbers = 0, i;
                Console.WriteLine("Введите число: ");
                number = int.Parse(Console.ReadLine());
                for (i = 0; i < number; i++)
                {
                    if (number > 0)
                        sum_numbers += 1.0 / count + 1.0 / (count + 1) + 1.0 / (count + number);
                    count += 2;
                }
                Console.WriteLine($"Сумма = {sum_numbers}");
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
