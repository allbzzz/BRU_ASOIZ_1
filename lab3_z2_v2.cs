/*
Лабораторная 3, задание 2, вариант 2
Дана длина ребра куба. Найти площадь грани, площадь полной
поверхности и объем этого куба.
*/


using System;

class Program
{
    static void Main() {
        Console.Write("Введите длину ребра куба: ");
        double edgeLength = Convert.ToDouble(Console.ReadLine());

        double faceArea = edgeLength * edgeLength;

        double totalSurfaceArea = 6 * faceArea;

        double volume = edgeLength * edgeLength * edgeLength;

        Console.WriteLine($"Площадь грани куба: {faceArea:F2}");
        Console.WriteLine($"Площадь полной поверхности куба: {totalSurfaceArea:F2}");
        Console.WriteLine($"Объем куба: {volume:F2}");
    }
}