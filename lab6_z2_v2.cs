using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/* 
 * lab6 z2 v2
 * Вычислить значение конечной суммы: 1/(1 + 1)^2 + 1/4(2 + 1)^2 + ... + 1/n^2(n + 1)^n
*/


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1 / (Math.Pow(i, 2) * Math.Pow(i + 1, i));

            }
            WriteLine($"Значение конечной суммы для n = {n}: {sum}");
        }    
    }
}
