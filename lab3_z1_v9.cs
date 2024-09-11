/*
Лабораторная 3, задание 1, вариант 9
Написать программу, которая, реализует диалог с
пользователем:
запрашивает с клавиатуры сумму
вклада и процент по вкладу, и выводит
на экран следующее сообщение (вклад
без капитализации - все начисления в
конце года).

*/


using System;

class Program
{
    static void Main() {
        Console.Write("Введите сумму вклада: ");
        double depositAmount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите процент по вкладу (в %): ");
        double interestRate = Convert.ToDouble(Console.ReadLine());

        double interestAmount = depositAmount * (interestRate / 100);
        double totalAmount = depositAmount + interestAmount;

        Console.WriteLine($"Итоговая сумма вклада без капитализации: {totalAmount:F2} (начальный вклад: {depositAmount:F2}, начисленные проценты: {interestAmount:F2})");
    }
}