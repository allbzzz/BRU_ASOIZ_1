/*
Лабораторная 1, задание 2, вариант 5
Даны две переменные целого типа: A и B. Если их значения не равны, 
то присвоить каждой переменной большее из этих значений, а если равны, то 
присвоить переменным нулевые значения. Вывести новые значения 
переменных A и B
*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение A: ");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение B: ");
        int B = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"До обработки: A = {A}, B = {B}");

        if (A != B)
        {
            int max = A > B ? A : B;
            A = max;
            B = max;
        }
        else
        {
            A = 0;
            B = 0;
        }

        Console.WriteLine($"После обработки: A = {A}, B = {B}");
    }
}