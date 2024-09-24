/*
Лабораторная 3, задание 2, вариант 5
Дана сторона равностороннего треугольника. Найти площадь этого 
треугольника и радиусы вписанной и описанной окружностей.
*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите длину стороны равностороннего треугольника: ");
        double a = Convert.ToDouble(Console.ReadLine());

        double area = (Math.Sqrt(3) / 4) * a * a;

        double rIn = a / (2 * Math.Sqrt(3));

        double rOut = a / Math.Sqrt(3);

        Console.WriteLine($"Площадь равностороннего треугольника: {area:F2}");
        Console.WriteLine($"Радиус вписанной окружности: {rIn:F2}");
        Console.WriteLine($"Радиус описанной окружности: {rOut:F2}");
    }
}