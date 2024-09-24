/*
Лабораторная 3, задание 2, вариант 15
Найти периметр и площадь равнобедренной трапеции с основаниями a и b
(a > b) и углом alpha при большем основании (угол дан в радианах).

*/


using System;

class Program
{
    static void Main() {
        Console.Write("Введите большее основание a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите меньшее основание b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите угол alpha в радианах: ");
        double alpha = Convert.ToDouble(Console.ReadLine());

        double h = (a - b) * Math.Tan(alpha / 2);

        double c = Math.Sqrt(h * h + Math.Pow((a - b) / 2, 2));

        double perimeter = a + b + 2 * c;

        double area = ((a + b) * h) / 2;

        Console.WriteLine($"Периметр трапеции: {perimeter:F2}");
        Console.WriteLine($"Площадь трапеции: {area:F2}");
    }
}