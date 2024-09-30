/*
Лабораторная 3, задание 2, вариант 9
Найти действительные корни квадратного уравнения A·x^2
+ B·x + C = 0, 
заданного своими коэффициентами A, B, C (коэффициент A не равен 0), если 
известно, что уравнение имеет ровно два корня.
*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите коэффициент A (не равен 0): ");
        double A = Convert.ToDouble(Console.ReadLine());

        if (A == 0)
        {
            Console.WriteLine("Коэффициент A не может быть равен 0.");
            return;
        }

        Console.Write("Введите коэффициент B: ");
        double B = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент C: ");
        double C = Convert.ToDouble(Console.ReadLine());

        double D = B * B - 4 * A * C;

        if (D > 0)
        {
            double x1 = (-B + Math.Sqrt(D)) / (2 * A);
            double x2 = (-B - Math.Sqrt(D)) / (2 * A);
            Console.WriteLine($"Корни уравнения: x1 = {x1:F2}, x2 = {x2:F2}");
        }
        else
        {
            Console.WriteLine("Уравнение не имеет двух действительных корней.");
        }
    }
}