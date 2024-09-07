/*
Лабораторная 1, задание 4, вариант 13
Дано вещественное число X (|X|<1) и целое число N > 0. Найти
значение выражения X - X3
/3 + X5
/5 - . . . + (-1)N
•X2N+1/(2•N+1). Полученное
число является приближенным значением функции arctg в точке X.
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

        for (int n = 0; n <= N; n++) {
            double term = Math.Pow(X, 2 * n + 1) / (2 * n + 1); // Текущий член ряда
            if (n % 2 == 0) // Четные n дают положительный знак
            {
                result += term;
            } else // Нечетные n дают отрицательный знак
            {
                result -= term;
            }
        }

        Console.WriteLine($"Приближенное значение arctg({X}) = {result}");
    }
}