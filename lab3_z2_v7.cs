/*
Лабораторная 3, задание 2, вариант 7
Найти расстояние между двумя точками с заданными координатами (x1,
y1) и (x2, y2).
*/

using System;

class Program
{
    static void Main() {
        Console.Write("Введите координаты первой точки (x1, y1): ");
        string[] point1 = Console.ReadLine().Split(',');
        double x1 = Convert.ToDouble(point1[0]);
        double y1 = Convert.ToDouble(point1[1]);

        Console.Write("Введите координаты второй точки (x2, y2): ");
        string[] point2 = Console.ReadLine().Split(',');
        double x2 = Convert.ToDouble(point2[0]);
        double y2 = Convert.ToDouble(point2[1]);

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine($"Расстояние между точками: {distance:F2}");
    }
}