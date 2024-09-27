/*
Лабораторная 3, задание 2, вариант 4
Найти площадь кольца, внутренний радиус которого равен R1, а внешний 
радиус равен R2 (R1 < R2). В качестве значения Pi использовать 3.14.
*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите внутренний радиус R1: ");
        double R1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите внешний радиус R2: ");
        double R2 = Convert.ToDouble(Console.ReadLine());

        if (R1 >= R2)
        {
            Console.WriteLine("Ошибка: внутренний радиус должен быть меньше внешнего радиуса.");
            return;
        }

        const double Pi = 3.14;

        double area = Pi * (R2 * R2 - R1 * R1);

        Console.WriteLine($"Площадь кольца: {area:F2}");
    }
}