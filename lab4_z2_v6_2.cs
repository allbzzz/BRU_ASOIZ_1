/*
Лабораторная 4, задание 2, вариант 6
Даны три числа. Найти наименьшее из них.
*/


using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[3];

        Console.Write("Введите первое число: ");
        numbers[0] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        numbers[1] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите третье число: ");
        numbers[2] = Convert.ToInt32(Console.ReadLine());

        int min = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        Console.WriteLine($"Наименьшее число: {min}");
    }
}