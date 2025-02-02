using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "powers_of_3.bin";
            int n = 10; // Количество степеней числа 3

            // Создание и запись
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                for (int i = 0; i < n; i++)
                {
                    int power = (int)Math.Pow(3, i);
                    writer.Write(power);
                }
            }

            // Вывод 
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                int recordNumber = 1;
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    int number = reader.ReadInt32();
                    if (recordNumber % 2 == 0)
                    {
                        Console.WriteLine(number);
                    }
                    recordNumber++;
                }
            }

            Console.ReadLine();
        }
    }
}