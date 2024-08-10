* Лабораторная работа 13. задание 1, вариант 1
* Разработать метод f(n), который для заданного натурального числа n находит значение . 
 * Вычислить с помощью его значение выражения.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static double FindFuction(double n)
        {
            return (Math.Sqrt(n) + n) / 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindFuction(6) + FindFuction(13) + FindFuction(21));
        }
    }
}


