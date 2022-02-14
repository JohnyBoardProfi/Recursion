using System;

namespace Fibonacci
{
    class Program
    {
        static ulong Fibonacci(ulong n) => n == 1 || n == 2 ? 1 : Fibonacci(n - 1) + Fibonacci(n - 2);

        static void Main(string[] args)
        {
            Console.WriteLine("Please, write your sequence number!");
            ulong num = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine(Fibonacci(num));
            Console.ReadKey();
        }
    }
}
