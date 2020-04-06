using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double res;
            double dobut = 1;
            Console.Write("Кількість чисел:");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] b = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Елемент [{i+1}] = ");
                b[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                dobut *= b[i];
            }
            res = Math.Pow(dobut,(1/n)) ;
            Console.WriteLine($"Середнє геометричне ={res}");
        }
    }
}
