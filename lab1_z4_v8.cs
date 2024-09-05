/*
Лабораторная 1, задание 4, вариант 8
Дано целое число N > 0. Найти произведение N! = 1*2*...*N (N-
факториал). Чтобы избежать целочисленного переполнения, вычислять это
произведение с помощью вещественной переменной и вывести его как
вещественное число.
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

        double factorial = 1.0;

        for (int i = 1; i <= N; i++) {
            factorial *= i;
        }

        Console.WriteLine($"Факториал {N}! = {factorial}");
    }
}