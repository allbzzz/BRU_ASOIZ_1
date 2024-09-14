/*
Лабораторная 3, задание 1, вариант 5
Написать программу, которая, реализует диалог с
пользователем:
запрашивает с клавиатуры два
вещественных числа, и выводит на
экран результат деления первого
числа на второе (вещественные числа
выводятся с точностью до 3 знаков
после запятой).
*/


using System;

class Program
{
    static void Main() {
        Console.Write("Введите первое вещественное число: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе вещественное число: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        if (secondNumber != 0) {
            double result = firstNumber / secondNumber;

            Console.WriteLine($"Результат деления {firstNumber:F3} на {secondNumber:F3} равен {result:F3}.");
        } else
        {
            Console.WriteLine("Ошибка: Деление на ноль невозможно.");
        }
    }
}