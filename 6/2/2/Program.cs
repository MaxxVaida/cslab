using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] B = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int k = 0; k < n; k++)
                    {
                        B[i] += 1 / k;
                    };
                }

            }
        }
    }
}
