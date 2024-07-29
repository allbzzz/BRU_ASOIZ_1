/*
лабораторная работа 8
задание 1
41 42 43 … 50
51 52 53 … 60
61 62 63 … 70
…
71 72 73 … 80
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
            int start = 1;
            int end = 100;
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}   