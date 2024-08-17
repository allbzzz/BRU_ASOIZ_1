/*
Лабораторная 1, задание 2, вариант 7
Даны три числа. Найти среднее из них (то есть число, расположенное
между наименьшим и наибольшим).
*/


using System;

class Program
{
    static void Main() {
        Console.Write("Введите первое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите третье число: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int max = Math.Max(num1, Math.Max(num2, num3));
        int min = Math.Min(num1, Math.Min(num2, num3));

        int middle = num1 + num2 + num3 - max - min;

        Console.WriteLine($"Среднее число: {middle}");
    }
}