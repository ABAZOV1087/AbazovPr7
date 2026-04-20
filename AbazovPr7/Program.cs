using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbazovPr7
{
    class Program
    {
        /// <summary>
        /// Точка входа в программу для расчета чисел Фибоначчи.
        /// </summary>
        static void Main(string[] args)
        {
            int result = Fibonacci(5);
            Console.WriteLine(result);
        }

        /// <summary>
        /// Вычисляет n-ное число последовательности Фибоначчи.
        /// </summary>
        /// <param name="n">Порядковый номер числа.</param>
        /// <returns>Число Фибоначчи.</returns>
        static int Fibonacci(int n)
        {
            int n1 = 0;
            int n2 = 1;
            int sum;

            for (int i = 2; i <= n; i++)
            {
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
            }

            return n == 0 ? n1 : n2;
        }
    }
}