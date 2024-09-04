/*
Лабораторная 1, задание 4, вариант 5
Дано вещественное число A и целое число N >0. Найти A в степени N
(числа A перемножаются N раз)
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

        double result = 1.0;

        for (int i = 0; i < N; i++) {
            result *= A;
        }

        Console.WriteLine($"{A} в степени {N} равно {result}");
    }
}