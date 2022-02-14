using System;

namespace Factorial
{
    class Program
    {
        static ulong F(ulong n) => n == 1 ? 1 : n * F(n - 1);

        static void Main(string[] args)
        {
            ulong f = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine(F(f));
            Console.ReadKey();
        }
    }
}
