/*
Лабораторная 1, задание 4, вариант 15
Дано целое число N > 1 и две вещественные точки на числовой оси: A,
B (A < B). Отрезок [A, B] разбит на N равных отрезков. Вывести H - длину
отрезка, а также значения функции F(X) = 1 - sin(X) в точках, разбивающих
отрезок [A,B]: F(A), F(A+H), F(A+2H), ..., F(B).

*/


using System;

class Program
{
    static void Main() {
        Console.Write("Введите целое число N > 1: ");
        int N = Convert.ToInt32(Console.ReadLine());

        if (N <= 1) {
            Console.WriteLine("Число N должно быть больше 1.");
            return;
        }

        Console.Write("Введите значение A (A < B): ");
        double A = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите значение B (B > A): ");
        double B = Convert.ToDouble(Console.ReadLine());

        if (A >= B) {
            Console.WriteLine("Значение A должно быть меньше B.");
            return;
        }

        double H = (B - A) / N;

        Console.WriteLine($"Длина отрезка H = {H}");

        // Вычисление и вывод значений функции F(X) = 1 - sin(X)
        for (int i = 0; i <= N; i++) {
            double x = A + i * H; // Точка разбивки
            double F = 1 - Math.Sin(x); // Значение функции в точке x
            Console.WriteLine($"F({x}) = {F}");
        }
    }
}