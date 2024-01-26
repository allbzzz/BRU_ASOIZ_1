/*
1) Вводить последовательность 
чисел до тех пор, пока их сумма не 
достигнет М(М вводится и больше 
0).Ввести, какое количество чисел 
составили искомую сумму (саму 
сумму тоже).
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
        static void Main(string[] args)
        {
            try
            {
                double sum = 0, M;
                Console.WriteLine("Введите значение М: ");
                M = double.Parse(Console.ReadLine());
                int count = 0;

                while (sum < M)
                {
					//проверка на корректность введенных данных внутри цикла
                    try
                    {
                        double num = double.Parse(Console.ReadLine());
                        sum += num;
                        count++;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка: введено некорректное значение. Попробуйте еще раз.");
                    }
                }
                Console.WriteLine("Количество чисел: {0}, сумма: {1:f2}", count, sum);
            }
            catch (Exception e)
            {
                string message = e.Message;
                Console.WriteLine("Ошибка: {0}", message);
            }
            Console.ReadKey();
        }
    }
}