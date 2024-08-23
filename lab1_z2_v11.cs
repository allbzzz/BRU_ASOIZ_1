/*
Лабораторная 1, задание 2, вариант 11
Даны три переменные вещественного типа: A, B, C. Если их
значения упорядочены по возрастанию или убыванию, то удвоить их; в
противном случае заменить значение каждой переменной на противоположное.
Вывести новые значения переменных A, B, C.
*/


using System;

class Program
{
    static void Main() {
        Console.Write("Введите значение A: ");
        double A = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение B: ");
        double B = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение C: ");
        double C = Convert.ToDouble(Console.ReadLine());

        if ((A < B && B < C) || (A > B && B > C)) {
            A *= 2
            B *= 2
            C *= 2
        } else
        {
            A = -A;
            B = -B;
            C = -C;
        }

        Console.WriteLine($"Новые значения: A = {A}, B = {B}, C = {C}");
    }
}