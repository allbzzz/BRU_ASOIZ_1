/*
Лабораторная 4, задание 2, вариант 4
Даны две переменные целого типа: A и B. Если их значения не равны, то
присвоить каждой переменной сумму этих значений, а если равны, то
присвоить переменным нулевые значения. Вывести новые значения
переменных A и B.
*/


using System;

class Program
{
    static void Main() {
        Console.Write("Введите значение A: ");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение B: ");
        int B = Convert.ToInt32(Console.ReadLine());

        if (A != B) {
            int sum = A + B;
            A = sum;
            B = sum;
        } else
        {
            A = 0;
            B = 0;
        }

        Console.WriteLine($"Новое значение A: {A}");
        Console.WriteLine($"Новое значение B: {B}");
    }
}