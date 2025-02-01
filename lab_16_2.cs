using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите путь к файлу:");
        string filePath = Console.ReadLine();
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Файл не существует.");
            return;
        }
        try
        {
            int count = CountLines(filePath);
            Console.WriteLine($"Количество строк, которые начинаются и заканчиваются одной буквой: {count}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
        }
    }

    static int CountLines(string filePath)
    {
        int count = 0;
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (!string.IsNullOrEmpty(line) && char.ToLower(line[0]) == char.ToLower(line[line.Length - 1]))
                {
                    count++;
                }
            }
        }
        return count;
    }
}