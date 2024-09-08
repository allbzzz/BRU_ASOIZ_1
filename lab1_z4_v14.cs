/*
Лабораторная 1, задание 4, вариант 14
Дано целое число N (> 1) и две вещественные точки на числовой оси:
A, B (A < B). Отрезок [A, B] разбит на N равных отрезков. Вывести H - длину
каждого отрезка, а также набор точек A, A+H, A+2H, A+3H, ..., B, образующий
разбиение отрезка [A,B].

*/


using System;

class Program
{
    static void Main() {
        Console.Write("Введите целое число N (> 1): ");
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

        Console.WriteLine($"Длина каждого отрезка H = {H}");

        Console.WriteLine("Точки разбиения:");
        for (int i = 0; i <= N; i++) {
            double point = A + i * H;
            Console.WriteLine(point);
        }
    }
}