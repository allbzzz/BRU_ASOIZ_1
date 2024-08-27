/*
Лабораторная 1, задание 4, вариант 6
Дано вещественное число A и целое число N (> 0). Найти сумму
1+A+A^2
+A^3
+ ...+A^N.
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

        double sum = 1.0;
        double currentTerm = 1.0;

        for (int i = 1; i <= N; i++) {
            currentTerm *= A;
            sum += currentTerm;
        }

        Console.WriteLine($"Сумма 1 + A + A^2 + ... + A^{N} = {sum}");
    }
}