using System;
using MyLibrary;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 5;

            Console.WriteLine("Базовые математические операции:\n");

            Console.WriteLine($"Сложение: {a} + {b} = {BasicMath.Add(a, b)}");
            Console.WriteLine($"Вычитание: {a} - {b} = {BasicMath.Subtract(a, b)}");
            Console.WriteLine($"Умножение: {a} * {b} = {BasicMath.Multiply(a, b)}");

            try
            {
                Console.WriteLine($"Деление: {a} / {b} = {BasicMath.Divide(a, b)}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            // Пример безопасного деления
            if (BasicMath.TryDivide(a, 0, out double result))
            {
                Console.WriteLine($"Результат деления: {result}");
            }
            else
            {
                Console.WriteLine("Безопасное деление: деление на ноль невозможно.");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
