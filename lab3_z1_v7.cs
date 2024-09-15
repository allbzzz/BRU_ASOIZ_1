/*
Лабораторная 3, задание 1, вариант 7
Написать программу, которая, реализует диалог с
пользователем:
запрашивает с клавиатуры номинал
купюры и количество купюр, и
выводит экран сообщение.

*/


using System;

class Program
{
    static void Main() {
        Console.Write("Введите номинал купюры: ");
        double denomination = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите количество купюр: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        double totalAmount = denomination * quantity;

        Console.WriteLine($"Общая сумма: {totalAmount:F2} (номинал: {denomination:F2}, количество: {quantity})");
    }
}