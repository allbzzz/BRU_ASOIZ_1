/*
лабораторная работа 9
Задание 1
 В одномерном массиве, состоящем из n вещественных элементов, 
вычислить: 1) сумму отрицательных элементов массива;
2) произведение элементов массива, расположенных между 
максимальным и минимальным элементами. Упорядочить элементы массива по 
возрастанию.
*/


using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int n = 10;
        double[] array = new double[n];

        // Заполнение массива случайными значениями
        for (int i = 0; i < n; i++)
        {
            array[i] = random.NextDouble() * 100 - 50; // Генерация случайного вещественного числа от -50 до 50
        }

        // Вывод массива до сортировки
        Console.WriteLine("Массив до сортировки:");
        PrintArray(array);

        // Сумма отрицательных элементов
        double sumOfNegatives = 0;
        foreach (var number in array)
        {
            if (number < 0)
            {
                sumOfNegatives += number;
            }
        }
        Console.WriteLine("Сумма отрицательных элементов: " + sumOfNegatives);

        // Поиск максимального и минимального элементов
        double max = array[0];
        double min = array[0];
        int maxIndex = 0;
        int minIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
            else if (array[i] < min)
            {
                min = array[i];
                minIndex = i;
            }
        }

        // Поиск произведения элементов между максимальным и минимальным
        double product = 1;
        int start, end;
        if (maxIndex < minIndex)
        {
            start = maxIndex + 1;
            end = minIndex;
        }
        else
        {
            start = minIndex + 1;
            end = maxIndex;
        }
        for (int i = start; i < end; i++)
        {
            product *= array[i];
        }
        Console.WriteLine("Произведение элементов между максимальным и минимальным: " + product);

        // Сортировка массива по возрастанию
        Array.Sort(array);

        // Вывод массива после сортировки
        Console.WriteLine("Массив после сортировки:");
        PrintArray(array);
    }

    static void PrintArray(double[] array)
    {
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}


