/*
лабораторная работа 12
Задание 2
Дан символ C. Вывести его код (то есть номер в кодовой таблице).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ латинского алфавита");
            char ch = char.Parse(Console.ReadLine());
            int code = Convert.ToInt32(ch);
            Console.WriteLine($"Код символа {ch} равен {code}");
        }
    }
}