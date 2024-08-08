/*
 лабораторная №14, задание 1, вариант 1
Дана последовательность целых чисел.
Задачи из данного пункта решить двумя способами, используя одномерный массив, а затем двумерный. 
Размерность массива вводится с клавиатуры.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void ChangeArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= -1;
            }
        }

        static void ChangeArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] *= -1;
                }
            }
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }

        static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Выберите размерность массива: 1 - одномерный, 2 - двумерный");
            int size = int.Parse(Console.ReadLine());
            switch(size)
            {
                case 1:
                    Console.WriteLine("Введите количество столбцов:");
                    int row = int.Parse(Console.ReadLine());
                    int[] array = new int[row];
                    for (int i = 0; i < row; i++)
                    {
                        array[i] = rand.Next(-100, 100);
                    }
                    Console.WriteLine();
                    PrintArray(array);
                    ChangeArray(array);
                    Console.WriteLine("Массив после измерения: ");
                    PrintArray(array);
                    break;
                case 2:
                    Console.WriteLine("Введите количество столбцов: ");
                    int rows = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите количество строк: ");
                    int columns = int.Parse(Console.ReadLine());
                    int[,] arrays = new int[rows, columns];
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            arrays[i, j] = rand.Next(-100, 100);
                        }
                    }
                    Console.WriteLine();
                    PrintArray(arrays);
                    ChangeArray(arrays);
                    Console.WriteLine("Массив после измерения: ");
                    PrintArray(arrays);
                    break;
                default:
                    Console.WriteLine("выберите только 1 или 2!");
                    break;
            }

        }
        
    }
}
