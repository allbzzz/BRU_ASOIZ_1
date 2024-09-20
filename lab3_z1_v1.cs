/*
Лабораторная 3, задание 1, вариант 1
Написать программу, которая, реализует диалог с
пользователем:
запрашивает с клавиатуры два
целых числа, и выводит на экран
сумму данных чисел:

*/


using System;

class Program
{
    static void Main() {
        Console.Write("Введите первое целое число: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе целое число: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        int sum = firstNumber + secondNumber;

        Console.WriteLine($"Сумма {firstNumber} и {secondNumber} равна {sum}.");
    }
}