/*
Лабораторная 4, задание 2, вариант 14
На числовой оси расположены три точки: A, B, C. Определить, какая из 
двух последних точек (B или C) расположена ближе к A, и вывести эту точку и 
ее расстояние от точки A.
*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите координату точки A: ");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите координату точки B: ");
        int B = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите координату точки C: ");
        int C = Convert.ToInt32(Console.ReadLine());

        int distanceToB = Math.Abs(A - B);
        int distanceToC = Math.Abs(A - C);

        if (distanceToB < distanceToC)
        {
            Console.WriteLine($"Точка B ближе к A с расстоянием {distanceToB}");
        }
        else if (distanceToC < distanceToB)
        {
            Console.WriteLine($"Точка C ближе к A с расстоянием {distanceToC}");
        }
        else
        {
            Console.WriteLine($"Точки B и C находятся на равном расстоянии {distanceToB} от A");
        }
    }
}