/*
Лабораторная 3, задание 2, вариант 12
 Скорость первого автомобиля V1 км/ч, второго — V2 км/ч, расстояние 
между ними S км. Определить расстояние между ними через T часов, если 
автомобили удаляются друг от друга.
*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите скорость первого автомобиля (V1) в км/ч: ");
        double V1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите скорость второго автомобиля (V2) в км/ч: ");
        double V2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите начальное расстояние между автомобилями (S) в км: ");
        double S = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите время (T) в часах: ");
        double T = Convert.ToDouble(Console.ReadLine());

        double distanceAfterT = S + (V1 + V2) * T;

        Console.WriteLine($"Расстояние между автомобилями через {T} часов: {distanceAfterT:F2} км");
    }
}