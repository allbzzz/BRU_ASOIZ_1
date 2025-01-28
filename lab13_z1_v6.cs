* Лабораторная работа 13, задание 1, вариант 6
* Разработать метод   f(x), который в трехзначном числе меняет местами первую цифру с последней, 
* а остальные числа оставляет без изменения. Продемонстрировать работу данного метода на примере. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static int SwapFuction(int n)
        {
            if(n >= 100 && n <= 999)
            {
                string num = n.ToString();
                char first_num = num[0];
                char second_num = num[1];
                char third_num = num[2];
                num = third_num.ToString() + second_num.ToString() + first_num.ToString();
                return int.Parse(num);
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



/*other solution
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static int SwapFunction(int n)
        {
            if (n >= 100 && n <= 999)
            {
                int hundreds = n / 100;
                int tens = (n / 10) % 10;
                int ones = n % 10;
                return ones * 100 + tens * 10 + hundreds;
            }
            return n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Number after swapping digits: {SwapFunction(n)}");
            Console.ReadKey();
        }
    }
}
*/