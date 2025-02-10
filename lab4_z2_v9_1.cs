/*
Лабораторная 4, задание 2, вариант 9
Даны три числа. Найти сумму двух наибольших из них.
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
        
        int sum_numbers = numbers[1] + numbers[2];

        Console.WriteLine($"Сумма двух наибольших чисел: {sum_numbers}");
    }
}