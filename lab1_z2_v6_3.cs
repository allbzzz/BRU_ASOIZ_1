/*
Лабораторная 1, задание 2, вариант 6
 Даны три числа. Найти наименьшее из них
*/


using System;
using System.Linq;

class Program
{
    static void Main() {
        int[] numbers = new int[3];

        for (int i = 0; i < numbers.Length; i++) {
            Console.Write($"Введите число {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int min = numbers.Min();

        Console.WriteLine($"Наименьшее число: {min}");
    }
}