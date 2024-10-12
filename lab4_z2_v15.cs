/*
Лабораторная 4, задание 2, вариант 15
Даны целочисленные координаты точки на плоскости. Если точка совпадает 
с началом координат, то вывести 0. Если точка не совпадает с началом 
координат, но лежит на оси OX или OY, то вывести соответственно 1 или 2. 
Если точка не лежит на координатных осях, то вывести 3.
*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите координату X: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите координату Y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x == 0 && y == 0)
        {
            Console.WriteLine(0);т
        }
        else if (y == 0)
        {
            Console.WriteLine(1);
        }
        else if (x == 0)
        {
            Console.WriteLine(2);
        }
        else
        {
            Console.WriteLine(3);
        }
    }
}