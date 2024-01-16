/*
лабораторная работа 5
Задание 1
Дан пол человека: м – мужчина, ж – женщина. Вывести на экран возможные 
мужские и женские имена в зависимости от введенного пола с 
использованием оператора switch.
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

            string gender = Console.ReadLine();
            switch(gender)
            {
                case "м":
                    Console.WriteLine("Алексей, Андрей, Артемий, Виктор, Никита, Даниил, Денис, Егор, Игорь, Лев, Леонид, Павел, Петр, Роман");
                    break;
                case "ж":
                    Console.WriteLine("София, Анна, Мария, Ева, Виктория, Варвара, Полина, Алиса, Василиса, Александра, Елизавета, Ксения");
                    break;
                default:
                    Console.WriteLine("Неккоректный ввод пола");
                    break;
            }
			Console.Read();
        }
    }
}
            