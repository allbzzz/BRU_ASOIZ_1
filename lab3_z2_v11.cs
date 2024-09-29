/*
Лабораторная 3, задание 2, вариант 11
Скорость лодки в стоячей воде V км/ч, скорость течения реки U км/ч (U < 
V). Время движения лодки по озеру T1 ч, а по реке (против течения) — T2 ч. 
Определить путь S, пройденный лодкой.
*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите скорость лодки в стоячей воде (V) в км/ч: ");
        double V = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите скорость течения реки (U) в км/ч (U < V): ");
        double U = Convert.ToDouble(Console.ReadLine());

        if (U >= V)
        {
            Console.WriteLine("Ошибка: скорость течения реки должна быть меньше скорости лодки в стоячей воде.");
            return;
        }

        Console.Write("Введите время движения лодки по озеру (T1) в часах: ");
        double T1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите время движения лодки по реке (T2) в часах: ");
        double T2 = Convert.ToDouble(Console.ReadLine());

        double distanceOnLake = V * T1;
        double distanceAgainstCurrent = (V - U) * T2;

        double totalDistance = distanceOnLake + distanceAgainstCurrent;

        Console.WriteLine($"Общий путь, пройденный лодкой: {totalDistance:F2} км");
    }
}