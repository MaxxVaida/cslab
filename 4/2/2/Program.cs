using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, n;
            Console.Write("Hello, x=");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ok, n=");
            n = Convert.ToDouble(Console.ReadLine());
            if (x <= n)
                x = Math.Log(x) - n;
            else
                x = Math.Sin(x*n);
            Console.WriteLine($"x={x}");
        
        }
    }
}
