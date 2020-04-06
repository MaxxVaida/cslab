using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int [] vector= new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"vector[{i}]");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Okay, Num2 = ");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            int[] vector2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                vector2[i]=vector[i]*Num2;
            }
            Console.WriteLine("[{0}][{1}]*{2}=[{3}][{4}]",vector[0],vector[1],Num2,vector2[0],vector2[1]);
        }
    }
}
