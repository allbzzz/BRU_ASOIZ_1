/*
Лабораторная 3, задание 2, вариант 14
Дана площадь круга. Найти длину окружности, ограничивающей этот круг. 
В качестве значения Pi использовать 3.14.
*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите площадь круга: ");
        double area = Convert.ToDouble(Console.ReadLine());

        double Pi = 3.14;

        double radius = Math.Sqrt(area / Pi);

        double circumference = 2 * Pi * radius;

        Console.WriteLine($"Длина окружности, ограничивающей круг: {circumference:F2}");
    }
}