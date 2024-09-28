/*
Лабораторная 3, задание 2, вариант 10
Дано целое четырехзначное число. Используя операции деления / и
нахождения остатка от деления %, найти сумму и произведение его цифр
*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое четырехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 1000 || number > 9999)
        {
            Console.WriteLine("Ошибка: число должно быть четырехзначным.");
            return;
        }

        int sum = 0;
        int product = 1;

        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            product *= digit;
            number /= 10;
        }

        Console.WriteLine($"Сумма цифр: {sum}");
        Console.WriteLine($"Произведение цифр: {product}");
    }
}