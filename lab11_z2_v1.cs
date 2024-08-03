/*
лабораторная работа 11
Задание 2
Исходные данные должны включать и положительные числа, и 
отрицательные числа, и нули. Массив заполнить случайными числами.
Дана целочисленная прямоугольная матрица. Определить:
количество строк, не содержащих ни одного нулевого элемента;
максимальное из чисел, встречающихся в заданной матрице более одного 
раза.
*/


using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[5, 4]; // создаем матрицу размером 5x4
		Random random = new Random(); // создаем объект для генерации случайных чисел

		// заполняем матрицу случайными числами
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				matrix[i, j] = random.Next(-10, 11); // генерируем число от -10 до 10
			}
		}

		// определяем количество строк без нулей
		int count = 0;
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

		// определяем максимальное число, встречающееся более одного раза
		Dictionary<int, int> numbersCount = new Dictionary<int, int>(); // словарь для хранения количества вхождений каждого числа
		int maxNumber = int.MinValue; // максимальное число, встречающееся более одного раза
		foreach (int number in matrix)
		{
			if (!numbersCount.ContainsKey(number))
			{
				numbersCount[number] = 1;
			}
			else
			{
				numbersCount[number]++;
				if (numbersCount[number] > 1 && number > maxNumber)
				{
					maxNumber = number;
				}
			}
		}
		if (maxNumber != int.MinValue)
		{
			Console.WriteLine($"Максимальное число, встречающееся более одного раза: {maxNumber}");
		}
		else
		{
			Console.WriteLine("В матрице нет чисел, встречающихся более одного раза");
		}
    }
}