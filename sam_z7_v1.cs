/*
самостоятельная работа 7
Задание 1
Определить метод MeanA(X,Y,Z), вычисляющий среднее арифметическое из трех чисел по формуле (X+Y+Z)/3. 
С помощью этого метода найти среднее арифметическое для троек (A,B,C), (A,B,D), (A,C,D), 
если даны действительные числа А, В, С, D.
*/


using System;

class Program
{
    static double MeanA(double X, double Y, double Z)
    {
        return (X + Y + Z) / 3.0; // вычисление среднего арифметического
    }

    static void Main(string[] args)
    {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());
        double D = double.Parse(Console.ReadLine());

        // вычисление среднего арифметического для троек (A,B,C), (A,B,D), (A,C,D)
        double mean1 = MeanA(A, B, C);
        double mean2 = MeanA(A, B, D);
        double mean3 = MeanA(A, C, D);

        Console.WriteLine("Среднее арифметическое для троек (A,B,C), (A,B,D), (A,C,D):");
        Console.WriteLine(mean1);
        Console.WriteLine(mean2);
        Console.WriteLine(mean3);
    }
}