using System;

namespace Power // a^b without using Math.Pow
{
    class Program
    {
        static double Power(int a, int b) => Math.Exp(b * Math.Log(a));
        
        static void Main(string[] args)
        {
            Console.WriteLine();
            int a = Convert.ToInt32(Console.ReadLine()), b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Power(a, b));
            Console.ReadKey();
        }
    }
}
