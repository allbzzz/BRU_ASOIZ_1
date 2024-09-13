/*
Лабораторная 3, задание 1, вариант 4
Написать программу, которая, реализует диалог с
пользователем:
запрашивает с клавиатуры два
вещественных числа, и выводит на
экран произведение данных чисел
(вещественные числа выводятся с
точностью до 1 знака после запятой).

*/


using System;

class Program
{
    static void Main() {
        Console.Write("Введите первое вещественное число: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе вещественное число: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        double product = firstNumber * secondNumber;

        Console.WriteLine($"Произведение {firstNumber:F1} и {secondNumber:F1} равно {product:F1}.");
    }
}