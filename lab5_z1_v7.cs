/*
Лабораторная 5, задание 1, вариант 7
Написать алгоритм, позволяющий получить словесное наименование 
школьных оценок.
*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите оценку (1-5): ");
        int grade = Convert.ToInt32(Console.ReadLine());

        string gradeName = grade switch
        {
            1 => "Неудовлетворительно",
            2 => "Неудовлетворительно",
            3 => "Удовлетворительно",
            4 => "Хорошо",
            5 => "Отлично",
            _ => "Некорректное значение. Пожалуйста, введите число от 1 до 5."
        };

        Console.WriteLine(gradeName);
    }
}