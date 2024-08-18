/*
Лабораторная 1, задание 2, вариант 8
Даны три числа. Вывести вначале наименьшее, а затем наибольшее из
данных чисел.
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
        Console.WriteLine($"Наименьшее число: {numbers[0]}, \nНаибольшее число: {numbers[numbers.Length - 1]}");
    }
}