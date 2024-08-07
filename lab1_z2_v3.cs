/*
Лабораторная 1, задание 2, вариант 3
 Даны две переменные вещественного типа: A, B. Перераспределить 
значения данных переменных так, чтобы в A оказалось меньшее из значений, а 
в B — большее. Вывести новые значения переменных A и B.
*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение A: ");
        double A = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение B: ");
        double B = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"До перераспределения: A = {A}, B = {B}");
        
        if (A > B)
        {
            double temp = A;
            A = B;
            B = temp;
        }
        Console.WriteLine($"После перераспределения: A = {A}, B = {B}");
    }
}