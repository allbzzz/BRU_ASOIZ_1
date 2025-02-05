/*
Лабораторная 4, задание 2, вариант 9
Даны три числа. Найти сумму двух наибольших из них.
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

        int largest = Math.Max(num1, Math.Max(num2, num3));
        int secondLargest;

        if (largest == num1)
        {
            secondLargest = Math.Max(num2, num3);
        }
        else if (largest == num2)
        {
            secondLargest = Math.Max(num1, num3);
        }
        else
        {
            secondLargest = Math.Max(num1, num2);
        }

        int sumOfTwoLargest = largest + secondLargest;

        Console.WriteLine($"Сумма двух наибольших чисел: {sumOfTwoLargest}");
    }
}