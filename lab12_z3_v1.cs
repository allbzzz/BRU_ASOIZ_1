/*
лабораторная работа 12
Задание 3
Дана строка, в которой содержится осмысленное текстовое 
сообщение. Слова сообщения разделяются пробелами и знаками препинания.
Вывести только те слова сообщения, которые содержат не более чем n 
букв.
*/


using System;

class Program
{
    static void Main()
    { 
		string message = Console.ReadLine();
		int n = int.Parse(Console.ReadLine());
		string[] words = message.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
		foreach (string word in words)
		{
			if (word.Length <= n)
			{
				Console.WriteLine(word);
			}
		}
    }  
}


