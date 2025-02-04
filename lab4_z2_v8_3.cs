/*
Лабораторная 4, задание 2, вариант 8
Даны три числа. Вывести вначале меньшее, а затем большее из данных 
чисел.
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

        Console.WriteLine($"Наименьшее число: {numbers[0]}");
        Console.WriteLine($"Наибольшее число: {numbers[2]}");
    }
}