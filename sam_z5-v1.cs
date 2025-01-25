/*
самостоятельная работа
Задание 5
1
В одномерном массиве, состоящем из n целых элементов, вычислить:
1) номер минимального элемента массива;
2) сумму модулей элементов массива, расположенных после первого отрицательного элемента.

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
            Random random = new Random();
            Console.WriteLine("Введите размер массива:");
            string user_input = Console.ReadLine();
            int size;
            if (int.TryParse(user_input, out size))
            {
                int[] numbers = new int[size];

                for(int i = 0; i < size; i++)
                {
                    numbers[i] = random.Next(-100, 101);
                }
                foreach(int num in numbers)
                {
                    Console.WriteLine(num);
                }

                int minIndex = 0;
                for(int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] < numbers[minIndex])
                    {
                        minIndex = i;
                    }                   
                }
                Console.WriteLine($"Номер минимального элемента: {minIndex}");

                int sum = 0;
                bool foundNegative = false;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (foundNegative)
                    {
                        sum += Math.Abs(numbers[i]);
                    }
                    else if (numbers[i] < 0)
                    {
                        foundNegative = true;
                    }
                }
                Console.WriteLine("Сумма модулей элементов после первого отрицательного: " + sum);
            }
            else
            {
                Console.WriteLine("Введено не число, пожалуйста, попробуйте еще раз.");
            }           

            Console.ReadKey();
        }
    }
}
