using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "powers_of_3.txt";
            int n = 10; // Количество степеней числа 3

            // Создание и запись
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                for (int i = 0; i < n; i++)
                {
                    int power = (int)Math.Pow(3, i);
                    writer.WriteLine(power);
                }
            }

            // Вывод 
            using (StreamReader reader = new StreamReader(fileName))
            {
                int lineNumber = 1;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (lineNumber % 2 == 0)
                    {
                        Console.WriteLine(line);
                    }
                    lineNumber++;
                }
            }

            Console.ReadLine();
        }
    }
}