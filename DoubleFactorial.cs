using System;

namespace DoubleFactorial
{
    class Program
    {
        static double DF(double n) => n % 2 == 0 ? Math.Pow(2, n / 2) * F(n / 2) : F(n) / (Math.Pow(2, (n - 1) / 2) * F((n - 1) / 2));

        static double F(double n) => n == 1 ? 1 : n * F(n - 1);

        static void Main(string[] args)
        {
            Console.WriteLine();
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(DF(num));
            Console.ReadKey();
        }
    }
