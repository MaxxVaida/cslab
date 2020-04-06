using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1,x2,x3,y1,y2,y3, AB, BC, AC;

            Console.Write("x1=");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2=");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x3=");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1=");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2=");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y3=");
            y3 = Convert.ToInt32(Console.ReadLine());
            AB = Math.Sqrt (Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
            BC = Math.Sqrt (Math.Pow((x3 - x2),2) + Math.Pow((y3 - y2),2));
            AC = Math.Sqrt(Math.Pow((x1 - x3),2) + Math.Pow((y1 - y3),2));
            if (Math.Pow(AB, 2) == Math.Pow(BC, 2) + Math.Pow(AC, 2))
                Console.WriteLine("Трикутник прямокутний");
            else if (Math.Pow(BC, 2) == Math.Pow(AB, 2) + Math.Pow(AC, 2))
                Console.WriteLine("Трикутник прямокутний");
            else if (Math.Pow(AC, 2) == Math.Pow(AB, 2) + Math.Pow(BC, 2))
                Console.WriteLine("Трикутник прямокутний");
            else
                Console.WriteLine("Трикутник не є прямокутним");

        }
    }
}
