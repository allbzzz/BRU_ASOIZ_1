/*
Лабораторная 4, задание 2, вариант 6
Даны три числа. Найти наименьшее из них.
*/



using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        Console.Write("Введите первое число: ");
        numbers.Add(Convert.ToInt32(Console.ReadLine()));

        Console.Write("Введите второе число: ");
        numbers.Add(Convert.ToInt32(Console.ReadLine()));

        Console.Write("Введите третье число: ");
        numbers.Add(Convert.ToInt32(Console.ReadLine()));

        numbers.Sort();

        int min = numbers[0];

        Console.WriteLine($"Наименьшее число: {min}");
    }
}
