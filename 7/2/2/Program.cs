using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Матриця A
            Console.Write("Кількість рядків A = ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кількість стовпців A = ");
            int columns = Convert.ToInt32(Console.ReadLine());
            double[,] a = new double[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"a[{i}][{j}] = ");
                    a[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            //// Матриця B
            Console.WriteLine("Введіть матрицю B");
            double[,] b = new double[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"b[{i}][{j}] = ");
                    b[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            //// Розвязок
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (a[i, j] == 0)
                        a[i, j] = b[i, j];
                }
            }
            Console.WriteLine("Відповідь:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"a[{i}][{j}]={a[i, j]}");
                }
            }
            Console.ReadLine();
        }
    }
}
