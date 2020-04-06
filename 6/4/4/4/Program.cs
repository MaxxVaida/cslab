using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, n =");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"B[{i}] = ");
                b[i] = Convert.ToInt32(Console.ReadLine());
            }
            int temp;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (b[i] < b[j])
                    {
                        temp = b[i];
                        b[i] = b[j];
                        b[j] = temp;
                    }
                }
            }
            Console.WriteLine("Вивід відсортованого масиву:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(b[i]);
            }
            Console.ReadLine();
        }
    }
}
