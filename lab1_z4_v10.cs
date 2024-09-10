/*
Лабораторная 1, задание 4, вариант 10
Дано целое число N > 0. Найти сумму 1 + 1/(1!) + 1/(2!) + 1/(3!) + ... +
1/(N!) (выражение N! — N–факториал — обозначает произведение всех целых
чисел от 1 до N). Полученное число является приближенным значением
константы e.
*/


using System;

class Program
{
    static void Main() {
        Console.Write("Введите целое число N > 0: ");
        int N = Convert.ToInt32(Console.ReadLine());

        if (N <= 0) {
            Console.WriteLine("Число N должно быть больше 0.");
            return;
        }

        double sum = 1.0;

        double factorial = 1.0;

        for (int i = 1; i <= N; i++) {
            factorial *= i;
            sum += 1.0 / factorial;
        }

        Console.WriteLine($"Сумма 1 + 1/(1!) + 1/(2!) + ... + 1/({N}!) = {sum}");
    }
}