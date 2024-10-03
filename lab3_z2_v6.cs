/*
Лабораторная 3, задание 2, вариант 6
Дана длина окружности. Найти площадь круга, ограниченного этой 
окружностью. В качестве значения Pi использовать 3.14.
*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите длину окружности: ");
        double circumference = Convert.ToDouble(Console.ReadLine());

        const double Pi = 3.14;

        double radius = circumference / (2 * Pi);

        double area = Pi * radius * radius;

        Console.WriteLine($"Площадь круга: {area:F2}");
    }
}