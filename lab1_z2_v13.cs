/*
Лабораторная 1, задание 2, вариант 13
Даны четыре целых числа, одно из которых отлично от трех других,
равных между собой. Определить порядковый номер числа, отличного от
остальных.

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

        Console.Write("Введите четвертое число: ");
        int num4 = Convert.ToInt32(Console.ReadLine());

        if (num1 == num2 && num1 == num3) {
            Console.WriteLine("Номер отличного числа: 4");
        } else if (num1 == num2 && num1 == num4) {
            Console.WriteLine("Номер отличного числа: 3");
        } else if (num1 == num3 && num1 == num4) {
            Console.WriteLine("Номер отличного числа: 2");
        } else
        {
            Console.WriteLine("Номер отличного числа: 1");
        }
    }
}