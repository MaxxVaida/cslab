using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            Console.Write("Кількість рядків = ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кількість стовпців = ");
            int columns = Convert.ToInt32(Console.ReadLine());
            double[,] a = new double[rows, columns];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i}][{j}] = ");
                    a[i, j] = Convert.ToDouble(Console.ReadLine());
                    if (a[i, j] > 0 && i % 2 == 0 && j % 2 == 1)
                        sum += a[i, j];
                }
            }
            Console.WriteLine($"Сума = {sum}");
            Console.ReadLine();
        }
    }
}
