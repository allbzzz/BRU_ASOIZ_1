/*
лабораторная работа 10
Задание 1
В одномерном массиве, состоящем из n целых элементов, 
вычислить: 1) минимальный по модулю элемент массива;
2) сумму модулей элементов массива, расположенных после первого 
элемента, равного нулю. Преобразовать массив таким образом, чтобы в первой 
его половине располагались элементы, стоявшие в четных позициях, а во 
второй половине — элементы, стоявшие в нечетных позициях.
*/


using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int n = 10;
        int[] array = new int[n];

        // Заполнение массива случайными значениями
        for (int i = 0; i < n; i++)
        {
            array[i] = random.Next(-50, 51); // Генерация случайного целого числа от -50 до 50
        }

        // Вывод массива до преобразования
        Console.WriteLine("Массив до преобразования:");
        PrintArray(array);

        // Поиск минимального по модулю элемента
        int minAbsValue = Math.Abs(array[0]);
        for (int i = 1; i < array.Length; i++)
        {
            if (Math.Abs(array[i]) < minAbsValue)
            {
                minAbsValue = Math.Abs(array[i]);
            }
        }
        Console.WriteLine("Минимальный по модулю элемент массива: " + minAbsValue);

        // Вычисление суммы модулей элементов после первого элемента, равного нулю
        int sumAfterZero = 0;
        bool foundZero = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (foundZero)
            {
                sumAfterZero += Math.Abs(array[i]);
            }
            if (array[i] == 0)
            {
                foundZero = true;
            }
        }
        Console.WriteLine("Сумма модулей элементов после первого нуля: " + sumAfterZero);

        // Преобразование массива
        int[] transformedArray = new int[n];
        int index = 0;
        for (int i = 0; i < n; i += 2)
        {
            transformedArray[index] = array[i];
            index++;
        }
        for (int i = 1; i < n; i += 2)
        {
            transformedArray[index] = array[i];
            index++;
        }

        // Вывод преобразованного массива
        Console.WriteLine("Массив после преобразования:");
        PrintArray(transformedArray);
    }

    static void PrintArray(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}