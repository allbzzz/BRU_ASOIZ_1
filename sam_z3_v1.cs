/*
самостоятельная работа
Задание 3
1
Для задач 1 -10 вычислить и вывести на экран в виде таблицы значения функции F на интервале
от Xнач  до  Хкон с шагом  dX. Значения a, b, c, Хнач, Хкон, dX
(действительные числа) ввести с клавиатуры.


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
                double a, b, c, x_start, x_end, x_step, x, F;
                Console.WriteLine("Введите коэффициенты a, b, c:");
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                c = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите Xнач, Хкон и шаг dX: ");
                x_start = double.Parse(Console.ReadLine());
                x_end = double.Parse(Console.ReadLine());
                x_step = double.Parse(Console.ReadLine());

                for (x = x_start; x <= x_end; x += x_step)
                {
                    if (x < 0 && b != 0)
                        F = a * Math.Pow(x, 2) + b;
                    else if (x > 0 && b == 0)
                        F = x - a / x - c;
                    else
                        F = x / c;
                    Console.WriteLine($"x = {0,3:f2} F(x)= {1,6:f4}", x, F);
                }
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
