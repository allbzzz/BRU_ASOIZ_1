/*
Лабораторная 1, задание 2, вариант 12
Даны три целых числа, одно из которых отлично от двух других,
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

        switch (num1) {
            case var _ when num1 == num2:
                Console.WriteLine("Номер отличного числа: 3");
                break;
            case var _ when num1 == num3:
                Console.WriteLine("Номер отличного числа: 2");
                break;
            default:
                Console.WriteLine("Номер отличного числа: 1");
                break;
        }
    }
}