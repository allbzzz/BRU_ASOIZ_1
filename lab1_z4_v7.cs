/*
Лабораторная 1, задание 4, вариант 7
. Дано вещественное число A и целое число N > 0. Найти значение
выражения 1-A+A^2-A^3
+ ... + (-1)N^A^N
.
*/

using System;

class Program
{
    static void Main() {
        Console.Write("Введите вещественное число A: ");
        double A = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите целое число N > 0: ");
        int N = Convert.ToInt32(Console.ReadLine());

        if (N <= 0) {
            Console.WriteLine("Число N должно быть больше 0.");
            return;
        }

        double result = 0.0;

        for (int i = 0; i <= N; i++) {
            double currentTerm = Math.Pow(A, i);
            if (i % 2 == 0) {
                result += currentTerm;
            } else
            {
                result -= currentTerm;
            }
        }

        Console.WriteLine($"Результат выражения 1 - A + A^2 - A^3 + ... + (-1)^{N} * A^{N} = {result}");
    }
}