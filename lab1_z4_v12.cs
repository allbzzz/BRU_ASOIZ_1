/*
Лабораторная 1, задание 4, вариант 12
Дано вещественное число X (|X|<1) и целое число N > 0. Найти
значение выражения X - X2
/2 + X3
/3 - . . . + (-1)N-1
•XN
/N. Полученное число
является приближенным значением функции ln в точке 1+X.
*/


using System;

class Program
{
    static void Main() {
        Console.Write("Введите вещественное число X (|X| < 1): ");
        double X = Convert.ToDouble(Console.ReadLine());

        if (Math.Abs(X) >= 1) {
            Console.WriteLine("Число X должно удовлетворять условию |X| < 1.");
            return;
        }

        Console.Write("Введите целое число N > 0: ");
        int N = Convert.ToInt32(Console.ReadLine());

        if (N <= 0) {
            Console.WriteLine("Число N должно быть больше 0.");
            return;
        }

        double result = 0.0;

        for (int n = 1; n <= N; n++) {
            double term = Math.Pow(X, n) / n; // Текущий член ряда
            if (n % 2 == 0) // Четные n дают отрицательный знак
            {
                result -= term;
            } else // Нечетные n дают положительный знак
            {
                result += term;
            }
        }

        Console.WriteLine($"Приближенное значение ln(1 + {X}) = {result}");
    }
}