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

        int min = numbers[0];
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }

            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"Наименьшее число: {min}");
        Console.WriteLine($"Наибольшее число: {max}");
    }
}