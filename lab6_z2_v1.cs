/*
Вычислить значение конечной суммы:

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
                double sum = 0, num;
                int x = 1, n;
                Console.WriteLine("Введите число: ");
                num = double.Parse(Console.ReadLine());
                for (n = 1; n <= num; n++)
                {
                    if (n != 0)
					{
						sum += Math.Sin(n * x + 1) / n;
					}
                }
                Console.WriteLine($"Значение конечной суммы = {sum:f5}");
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