using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            Console.Write("Hello, a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("ok, n=");
            double n = Convert.ToDouble(Console.ReadLine());
            for (; n > 0; n--)
            {
                s += Math.Log(Math.Pow(a, n));
                n -= 1;
            }
            Console.WriteLine($"Сума = {s}");
        }
    }
}
