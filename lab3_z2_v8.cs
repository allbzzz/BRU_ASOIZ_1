/*
Лабораторная 3, задание 2, вариант 8
Ввести с клавиатуры координаты трех вершин треугольника (x1, y1), (x2, 
y2), (x3, y3). Найти его периметр и площадь.

*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите координаты первой вершины (x1, y1): ");
        string[] vertex1 = Console.ReadLine().Split(',');
        double x1 = Convert.ToDouble(vertex1[0]);
        double y1 = Convert.ToDouble(vertex1[1]);

        Console.Write("Введите координаты второй вершины (x2, y2): ");
        string[] vertex2 = Console.ReadLine().Split(',');
        double x2 = Convert.ToDouble(vertex2[0]);
        double y2 = Convert.ToDouble(vertex2[1]);

        Console.Write("Введите координаты третьей вершины (x3, y3): ");
        string[] vertex3 = Console.ReadLine().Split(',');
        double x3 = Convert.ToDouble(vertex3[0]);
        double y3 = Convert.ToDouble(vertex3[1]);

        double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); // Сторона между (x1, y1) и (x2, y2)
        double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)); // Сторона между (x2, y2) и (x3, y3)
        double c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2)); // Сторона между (x1, y1) и (x3, y3)

        double perimeter = a + b + c;

        // Вычисление площади по формуле Герона
        double semiPerimeter = perimeter / 2;
        double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));

        Console.WriteLine($"Периметр треугольника: {perimeter:F2}");
        Console.WriteLine($"Площадь треугольника: {area:F2}");
    }
}