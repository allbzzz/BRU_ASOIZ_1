/*
Лабораторная 5, задание 1, вариант 9
Написать алгоритм нахождения числа дней в месяце, если даны: Номер 
месяца n - целое число а, равное 1 для високосного года и равное 0 в противном 
случае.

*/



using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер месяца (1-12): ");
        int monthNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите 1, если год високосный, или 0, если нет: ");
        int isLeapYear = Convert.ToInt32(Console.ReadLine());

        int daysInMonth = monthNumber switch
        {
            1 => 31,  // Январь
            2 => isLeapYear == 1 ? 29 : 28,  // Февраль
            3 => 31,  // Март
            4 => 30,  // Апрель
            5 => 31,  // Май
            6 => 30,  // Июнь
            7 => 31,  // Июль
            8 => 31,  // Август
            9 => 30,  // Сентябрь
            10 => 31, // Октябрь
            11 => 30, // Ноябрь
            12 => 31, // Декабрь
            _ => -1    // Некорректное значение
        };

        if (daysInMonth == -1)
        {
            Console.WriteLine("Некорректное значение месяца. Пожалуйста, введите число от 1 до 12.");
        }
        else
        {
            Console.WriteLine($"Количество дней в месяце {monthNumber}: {daysInMonth}");
        }
    }
}