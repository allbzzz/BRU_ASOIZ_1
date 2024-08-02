/*
лабораторная работа 11
Задание 1
Дана целочисленная прямоугольная матрица. Определить количество строк, 
не содержащих ни одного нулевого элемента;
*/


using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[3, 4]; // создаем матрицу размером 3x4
		int count = 0; // счетчик строк без нулей

		// заполняем матрицу числами, вводимыми пользователем
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				Console.Write($"Введите элемент [{i}, {j}]: ");
				matrix[i, j] = int.Parse(Console.ReadLine());
			}
		}

		// проверяем каждую строку на наличие нулей
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			bool hasZero = false;
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				if (matrix[i, j] == 0)
				{
					hasZero = true;
					break;
				}
			}
			if (!hasZero)
			{
				count++;
			}
		}
	Console.WriteLine($"Количество строк без нулей: {count}");
    }
}