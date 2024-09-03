/*
Лабораторная 1, задание 4, вариант 3
Дано целое число N > 0. Найти произведение 1*2*3...
*/


using System;

class Program
{
    static void Main() {
        Console.Write("Введите целое число N > 0: ");
        int N = Convert.ToInt32(Console.ReadLine());

        if (N <= 0) {
            Console.WriteLine("Число должно быть больше 0.");
            return;
        }

        long product = 1;

        for (int i = 1; i <= N; i++) {
            product *= i;
        }

        Console.WriteLine($"Произведение 1 * 2 * ... * {N} = {product}");
    }
}