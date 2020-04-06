using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.Write("Введіть число: ");
            string num = Convert.ToString(Console.ReadLine());
            foreach (var i in num)
            {
                if (i == '0')
                    count += 1;
            }
            Console.WriteLine($"Кількість нулів - {count}");
        }
    }
}
