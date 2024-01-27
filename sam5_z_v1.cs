/*
самостоятельная работа 5
Задание 1
В одномерном массиве, состоящем из n целых элементов, вычислить:
1) номер минимального элемента массива;
2) сумму модулей элементов массива, расположенных после первого отрицательного элемента.
*/


using System;

class Program
{
    static void Main()
    {
        int[] array = new int[10]; // создаем массив размером 10
		Random random = new Random(); // создаем объект для генерации случайных чисел

		// заполняем массив случайными числами
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = random.Next(-10, 11); // генерируем число от -10 до 10
		}

		// находим номер минимального элемента массива
		int minIndex = 0;
		for (int i = 1; i < array.Length; i++)
		{
			if (array[i] < array[minIndex])
			{
				minIndex = i;
			}
		}
		Console.WriteLine($"Номер минимального элемента массива: {minIndex}");

		// находим сумму модулей элементов массива, расположенных после первого отрицательного элемента
		int sum = 0;
		bool foundNegative = false;
		for (int i = 0; i < array.Length; i++)
		{
			if (foundNegative)
			{
				sum += Math.Abs(array[i]);
			}
			if (array[i] < 0)
			{
				foundNegative = true;
			}
		}
		Console.WriteLine($"Сумма модулей элементов массива, расположенных после первого отрицательного элемента: {sum}");
    }
}