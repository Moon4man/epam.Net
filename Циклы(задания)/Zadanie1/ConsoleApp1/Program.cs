using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Pow(double a, int pow)
            {
                double result = 1;
                for (int i = 1; i <= pow; i++)
                {
                    result *= a;
                }
                return result;
            }
            double SqrtN(double n, double A, double esp = 0.00001)
            {
                var x0 = A / n;
                var x1 = (1 / n) * ((n - 1) * x0 + A / Pow(x0, (int)n - 1));

                while (Math.Abs(x1 - x0) > esp)
                {
                    x0 = x1;
                    x1 = (1 / n) * ((n - 1) * x0 + A / Pow(x0, (int)n - 1));
                }
                return x1;
            }
            Console.WriteLine(SqrtN(3, 8));
            Console.ReadKey();
        }
    }
}
