using System;

class Program
{
    static void Main(string[] args)
    {
        double a, b, h;
        Console.WriteLine("Введите значение a:");
        while (!double.TryParse(Console.ReadLine(), out a)) // начало интервала
        {
            Console.WriteLine("Некорректное значение. Введите число:");
        }

        Console.WriteLine("Введите значение b:");
        while (!double.TryParse(Console.ReadLine(), out b)) // конец интервала
        {
            Console.WriteLine("Некорректное значение. Введите число:");
        }

        Console.WriteLine("Введите значение h:");
        while (!double.TryParse(Console.ReadLine(), out h) || h <= 0) // шаг
        {
            Console.WriteLine("Некорректное значение. Введите положительное число:");
        }

        PrintTable(a, b, h);
    }

    static void PrintTable(double a, double b, double h)
    {
        Console.WriteLine("x\t|\ty");
        Console.WriteLine("---------------------");

        double x = a;

        while (x <= b + h / 2) // добавляем погрешность h/2 для учета последнего значения
        {
            double y = CalculateFunction(x);
            Console.WriteLine($"{x}\t|\t{y}");

            x += h;
        }
    }

    static double CalculateFunction(double x)
    {
        if (x - 1 < 1)
        {
            return 1;
        }
        else if (x - 1 == 1)
        {
            return 0;
        }
        else
        {
            return -1;
        }
    }
}