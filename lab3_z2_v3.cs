/*
Лабораторная 3, задание 2, вариант 3
Найти длину окружности и площадь круга заданного радиуса R.
*/


using System;

class Program
{
    static void Main() {
        Console.Write("Введите радиус круга R: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double circumference = 2 * Math.PI * radius;

        double area = Math.PI * radius * radius;

        Console.WriteLine($"Длина окружности: {circumference:F2}");
        Console.WriteLine($"Площадь круга: {area:F2}");
    }
}