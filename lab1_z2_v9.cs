/*
Лабораторная 1, задание 2, вариант 9
Даны три числа. Найти сумму двух наибольших из них
*/

using System;

class Program
{
    static void Main() {
        int[] numbers = new int[3];
        for (int i = 0; i < numbers.Length; i++) {
            Console.Write($"Введите число {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(numbers);
        int sumOfTwoLargest = numbers[numbers.Length - 1] + numbers[numbers.Length - 2];

        Console.WriteLine($"Сумма двух наибольших чисел: {sumOfTwoLargest}");
    }
}