using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double s;
            int a;
            Console.Write("a=");
            a = Convert.ToInt32(Console.ReadLine());
            int b;
            Console.Write("b=");
            b = Convert.ToInt32(Console.ReadLine());
            int c;
            Console.Write("c=");
            c = Convert.ToInt32(Console.ReadLine());
            int p = (a + b + c) / 2;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Sabc = {0}", s);

        }
    }
}
