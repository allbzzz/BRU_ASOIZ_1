/*
Лабораторная 4, задание 2, вариант 8
Даны три числа. Вывести вначале меньшее, а затем большее из данных 
чисел.
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

        int min = Math.Min(Math.Min(num1, num2), num3);
        int max = Math.Max(Math.Max(num1, num2), num3);

        Console.WriteLine($"Наименьшее число: {min}");
        Console.WriteLine($"Наибольшее число: {max}");
    }
}