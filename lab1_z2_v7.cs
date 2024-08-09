/*
Лабораторная 1, задание 2, вариант 7
Даны три числа. Найти среднее из них (то есть число, расположенное
между наименьшим и наибольшим).
*/


using System;

class Program
{
    static void Main() {
        Console.Write("Введите первое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите третье число: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int middle;

        if ((num1 > num2 && num1 < num3) || (num1 < num2 && num1 > num3)) {
            middle = num1;
        } else if ((num2 > num1 && num2 < num3) || (num2 < num1 && num2 > num3)) {
            middle = num2;
        } else
        {
            middle = num3;
        }

        Console.WriteLine($"Среднее число: {middle}");
    }
}