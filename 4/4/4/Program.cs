using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            Console.Write("Hello, a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ok, b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ok, c=");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ok, d=");
            d = Convert.ToDouble(Console.ReadLine());
            if (1<=a && a<=2 && c<a && a<d)
                Console.WriteLine("A належить проміжку");
            else
                Console.WriteLine("А не належить проміжку");
            if (1 <= b && b <= 2 && c < b && b < d)
                Console.WriteLine("B належить проміжку");
            else
                Console.WriteLine("B не належить проміжку");
            if (1 <= c && c <= 2 && c < c && c < d)
                Console.WriteLine("C належить проміжку");
            else
                Console.WriteLine("C не належить проміжку");
            if (1 <= d && d <= 2 && c < d && d < d)
                Console.WriteLine("D належить проміжку");
            else
                Console.WriteLine("D не належить проміжку");


        }
    }
}
