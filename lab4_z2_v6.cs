/*
Лабораторная 4, задание 2, вариант 6
Даны три числа. Найти наименьшее из них.
*/



using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите третье число: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int min = num1;

        if (num2 < min)
        {
            min = num2;
        }
        if (num3 < min)
        {
            min = num3;
        }

        Console.WriteLine($"Наименьшее число: {min}");
    }
}