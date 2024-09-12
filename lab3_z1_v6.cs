/*
Лабораторная 3, задание 1, вариант 6
Написать программу, которая, реализует диалог с
пользователем:
запрашивает с клавиатуры три
вещественных числа, и выводит на экран
следующее сообщение (вещественные
числа выводятся с точностью до 2
знаков после запятой).
*/


using System;

class Program
{
    static void Main() {
        Console.Write("Введите первое вещественное число: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе вещественное число: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите третье вещественное число: ");
        double thirdNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Вы ввели следующие числа: {firstNumber:F2}, {secondNumber:F2}, {thirdNumber:F2}.");
    }
}