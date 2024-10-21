/*
Лабораторная 4, задание 2, вариант 7
Даны три числа. Найти среднее из них (то есть число, расположенное между 
наименьшим и наибольшим).
*/


using System;
using System.Collections.Generic;
using System.Linq;

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

        int average = numbers.OrderBy(n => n).Skip(1).First();

        Console.WriteLine($"Среднее число: {average}");
    }
}