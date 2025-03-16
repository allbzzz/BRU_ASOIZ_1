/*
Лабораторная 5, задание 1, вариант 2
Дан признак транспортного средства: a – автомобиль, в – велосипед, м -
мотоцикл, с – самолет, п – поезд. Вывести на экран максимальную скорость 
транспортного средства в зависимости от введенного признака
*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите признак транспортного средства (a - автомобиль, b - велосипед, m - мотоцикл, c - самолет, p - поезд): ");
        char vehicleType = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (vehicleType)
        {
            case 'a':
                Console.WriteLine("Максимальная скорость автомобиля: 200 км/ч");
                break;
            case 'b':
                Console.WriteLine("Максимальная скорость велосипеда: 30 км/ч");
                break;
            case 'm':
                Console.WriteLine("Максимальная скорость мотоцикла: 180 км/ч");
                break;
            case 'c':
                Console.WriteLine("Максимальная скорость самолета: 900 км/ч");
                break;
            case 'p':
                Console.WriteLine("Максимальная скорость поезда: 300 км/ч");
                break;
            default:
                Console.WriteLine("Некорректный признак транспортного средства.");
                break;
        }
    }
}