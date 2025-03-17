/*
Лабораторная 5, задание 1, вариант 3
Дан номер телевизионного канала. Вывести на экран наиболее популярные 
программы заданного канала. 
*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер телевизионного канала (1 - 5): ");
        int channelNumber = Convert.ToInt32(Console.ReadLine());

        switch (channelNumber)
        {
            case 1:
                Console.WriteLine("Канал 1: Новости, Спортивные события, Утреннее шоу");
                break;
            case 2:
                Console.WriteLine("Канал 2: Кулинарные программы, Реалити-шоу, Комедийные сериалы");
                break;
            case 3:
                Console.WriteLine("Канал 3: Документальные фильмы, Научные передачи, Образовательные программы");
                break;
            case 4:
                Console.WriteLine("Канал 4: Музыкальные клипы, Концерты, Ток-шоу");
                break;
            case 5:
                Console.WriteLine("Канал 5: Мультфильмы, Семейные фильмы, Дети и семья");
                break;
            default:
                Console.WriteLine("Неверный номер канала. Пожалуйста, введите номер от 1 до 5.");
                break;
        }
    }
}