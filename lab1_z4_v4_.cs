/*
Лабораторная 1, задание 4, вариант 4
Дано целое число N > 0. Найти значение выражения 1.1 - 1.2 + 1.3 - ...
(N слагаемых, знаки чередуются)
*/


using System;

class Program
{
    static void Main() {
        Console.Write("Введите целое число N > 0: ");
        int N = Convert.ToInt32(Console.ReadLine());

        if (N <= 0) {
            Console.WriteLine("Число должно быть больше 0.");
            return;
        }

        double result = 0.0;

        for (int i = 1; i <= N; i++) {
            if (i % 2 == 0) {
                result -= i * 0.1;
            } else
            {
                result += i * 0.1;
            }
        }

        Console.WriteLine($"Результат выражения: {result}");
    }
}