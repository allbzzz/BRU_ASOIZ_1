/*
Лабораторная 4, задание 2, вариант 7
Даны три числа. Найти среднее из них (то есть число, расположенное между 
наименьшим и наибольшим).
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

        int average = numbers[1];

        Console.WriteLine($"Среднее число: {average}");
    }
}