/*
Лабораторная 1, задание 2, вариант 14
На числовой оси расположены три точки:
Определить, какая из двух последних точек (B или C) расположена ближе к A, и вывести эту
точку и ее расстояние от точки A.
*/


using System;

class Program
{
    static void Main() {
        Console.Write("Введите координату точки A: ");
        double A = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координату точки B: ");
        double B = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координату точки C: ");
        double C = Convert.ToDouble(Console.ReadLine());

        double distanceAB = Math.Abs(A - B);
        double distanceAC = Math.Abs(A - C);

        if (distanceAB < distanceAC) {
            Console.WriteLine($"Точка B ближе к A на расстояние {distanceAB}");
        } else if (distanceAC < distanceAB) {
            Console.WriteLine($"Точка C ближе к A на расстояние {distanceAC}");
        } else
        {
            Console.WriteLine($"Точки B и C расположены на одинаковом расстоянии от A: {distanceAB}");
        }
    }
}