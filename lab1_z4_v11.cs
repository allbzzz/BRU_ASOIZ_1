/*
Лабораторная 1, задание 4, вариант 11
Дано вещественное число X и целое число N > 0. Найти значение
выражения 1 + X + X2
/(2!) + . . . + XN
/(N!) (N! = 1•2•...•N). Полученное число
является приближенным значением функции exp в точке X.
*/


using System;

class Program
{
    static void Main() {
        Console.Write("Введите вещественное число X: ");
        double X = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите целое число N > 0: ");
        int N = Convert.ToInt32(Console.ReadLine());

        if (N <= 0) {
            Console.WriteLine("Число N должно быть больше 0.");
            return;
        }

        double result = 1.0;
        double factorial = 1.0;

        for (int n = 1; n <= N; n++) {
            factorial *= n;
            result += Math.Pow(X, n) / factorial;
        }

        Console.WriteLine($"Приближенное значение exp({X}) = {result}");
    }
}