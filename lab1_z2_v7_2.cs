/*
Лабораторная 1, задание 2, вариант 7
Даны три числа. Найти среднее из них (то есть число, расположенное
между наименьшим и наибольшим).
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

        var sortedNumbers = numbers.OrderBy(n => n).ToArray();

        int middle = sortedNumbers[1];

        Console.WriteLine($"Среднее число: {middle}");
    }
}