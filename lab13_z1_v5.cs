* Лабораторная работа 13, задание 1, вариант 5
* Разработать метод   f(x),  который в двузначном числе меняет цифры местами, 
* а остальные числа оставляет без изменения. 
* Продемонстрировать работу данного метода на примере. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static double SwapFuction(int n)
        {
            if(n >= 10 && n <= 99)
            {
                int tens = n / 10;
                int ones = n % 10;
                return ones * 10 + tens;
            }
            return n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter value n: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Number after replacing digits: {SwapFuction(number)}");
            Console.ReadKey();
        }
    }
}

