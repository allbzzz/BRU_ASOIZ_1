/*
Лабораторная 3, задание 1, вариант 10
Написать программу, которая, реализует диалог с
пользователем:
запрашивает с клавиатуры имя
человека и его возраст, и выводит на
экран следующее сообщение (текущий
год - 2024).

*/


using System;

class Program
{
    static void Main() {
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();

        Console.Write("Введите ваш возраст: ");
        int age = Convert.ToInt32(Console.ReadLine());

        int birthYear = 2024 - age;

        // Вывод результата
        Console.WriteLine($"Привет, {name}! Вам {age} лет, и вы родились в {birthYear} году.");
    }
}