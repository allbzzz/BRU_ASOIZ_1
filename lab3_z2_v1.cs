/*
Лабораторная 3, задание 2, вариант 1
Найти периметр и площадь равнобедренной трапеции с основаниями a и b
(a > b) и углом alpha при большем основании (угол дан в радианах).

*/


using System;

class Program
{
    static void Main() {
        Console.Write("Введите длину первого катета a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите длину второго катета b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double c = Math.Sqrt(a * a + b * b);

        double perimeter = a + b + c;

        double area = (a * b) / 2;

        Console.WriteLine($"Периметр треугольника: {perimeter:F2}");
        Console.WriteLine($"Площадь треугольника: {area:F2}");
    }
}