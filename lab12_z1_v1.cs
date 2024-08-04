/*
лабораторная работа 12
Задание 1
Для заданной строки символов проверить, является ли она симметричной или 
нет. (Симметричной считается строка, которая одинаково читается слева 
направо и справа налево).
*/


using System;

class Program
{
    static void Main()
    { 
		string input = Console.ReadLine(); // ввод строки с клавиатуры
		string reversed = new string(input.Reverse().ToArray()); // переворачиваем строку

		if (input == reversed)
		{
			Console.WriteLine("Строка симметрична");
		}
		else
		{
			Console.WriteLine("Строка несимметрична");
		} 
    }  
}


