/*
лабораторная работа 8
задание 2
Вычислить и вывести на экран в виде таблицы значение функции, 
заданной с помощью ряда Тейлора, на интервале от Хнач до Хкон с шагом dX с 
точностью . Таблицу снабдить заголовком и шапкой. Каждая строка таблицы 
должна содержать значение аргумента, значение функции и количество просуммированных членов ряда.
Для вычисления последующего члена ряда 
использовать рекуррентную формулу.
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

            double x_start, x_end, x_step;
            Console.WriteLine("Введите начало функции: ");
            x_start = double.Parse(Console.ReadLine()); //начало аргумента
            Console.WriteLine("Введите конец функции: ");
            x_end = double.Parse(Console.ReadLine()); //конец аргумента
            Console.WriteLine("Введите шаг функции: ");
            x_step = double.Parse(Console.ReadLine()); //шаг
            double precision = 0.0001; //точность

            Console.WriteLine("Аргумент | Значение функции | Количество просуммированных членов ряда");
            for (double x = x_start; x <= x_end; x += x_step)
            {
                double sum = 0; // сумма ряда
                int n = 0; // количество просуммированных членов ряда
                double term = 1; // текущий член ряда
                while (Math.Abs(term) > precision)
                {
                    sum += term;
                    n++;
                    term *= x / n;
                }
                Console.WriteLine($"{x,8:F3} | {sum,17:F6} | {n,28}");
            }

        }
    }
}           
  