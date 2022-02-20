using System;

class GCD
{
    int GCD (int a, int b) => a == 0 ? Math.Abs(b) : GCD(b % a, a);
    
    static void Main() 
    {
        int a = Convert.ToInt32(Console.ReadLine()), b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(GCD(a, b));
    }
}
