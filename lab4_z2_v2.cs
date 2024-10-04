/*
Лабораторная 4, задание 2, вариант 2
 Даны три целых числа. Найти количество положительных и количество 
отрицательных чисел в исходном наборе.

*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое целое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе целое число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите третье целое число: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        
        int positiveCount = 0;
        int negativeCount = 0;

        if (num1 > 0)
            positiveCount++;
        else if (num1 < 0)
            negativeCount++;

        if (num2 > 0)
            positiveCount++;
        else if (num2 < 0)
            negativeCount++;

        if (num3 > 0)
            positiveCount++;
        else if (num3 < 0)
            negativeCount++;

        Console.WriteLine($"Количество положительных чисел: {positiveCount}");
        Console.WriteLine($"Количество отрицательных чисел: {negativeCount}");
    }
}