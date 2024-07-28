/*
лабораторная работа 5
задание 2
В старояпонском календаре принят 60-летний цикл, 
состоящий из пяти 12-летних подциклов. Подциклы обозначаются названиями 
цвета: зеленый, красный, желтый, белый и черный. Внутри каждого подцикла 
годы носят названия животных: крысы, коровы, тигра, зайца, дракона, змеи, 
лошади, овцы, обезьяны, курицы, собаки и свиньи. (1924 год – год зеленой 
крысы – был началом очередного цикла). Написать программу, которая вводит 
номер некоторого года и печатает его название по старояпонскому календарю (с 
использованием оператора switch).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер года: ");
            int year = int.Parse(Console.ReadLine());

            string[] colors = {"зеленый", "красный", "желтый", "белый", "черный"};
            string[] animals = {"крысы", "коровы", "тигра", "зайца", "дракона", "змеи",
                             "лошади", "овцы", "обезьяны", "курицы", "собаки", "свиньи"};

            int colorIndex = (year % 60) / 12;
            int animalIndex = (year % 60) % 12;

            string color = colors[colorIndex];
            string animal = animals[animalIndex];

            Console.WriteLine($"Год {year} в старояпонском календаре: {color} {animal}");
        }
    }
}
            