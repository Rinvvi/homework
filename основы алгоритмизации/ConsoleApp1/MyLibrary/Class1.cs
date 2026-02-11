using System;

namespace MyLibrary
{
    /// <summary>
    /// Библиотека базовых арифметических операций.
    /// </summary>
    public static class BasicMath
    {
        /// <summary>
        /// Сложение двух чисел.
        /// </summary>
        public static double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Вычитание двух чисел.
        /// </summary>
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Умножение двух чисел.
        /// </summary>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Деление двух чисел.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Возникает при попытке деления на ноль.
        /// </exception>
        public static double Divide(double a, double b)
        {
            if (b == 0)
                throw new ArgumentException("Деление на ноль невозможно.");

            return a / b;
        }

        /// <summary>
        /// Безопасное деление без исключений.
        /// </summary>
        public static bool TryDivide(double a, double b, out double result)
        {
            if (b == 0)
            {
                result = 0;
                return false;
            }

            result = a / b;
            return true;
        }
    }
}
