﻿using System;

namespace lab2
{
    class Program
    {
        static double f(double x)
        {
            return Math.Sin(Math.Log(x)) - Math.Cos(Math.Log(x)) + 2 * Math.Log(x);
        }
        static double f1(double x)
        {
            return Math.Cos(Math.Log(x)) / x + Math.Sin(Math.Log(x)) / x + 2 / x;
        }
        static double f2(double x)
        {
            return (-2 *Math.Sin(Math.Log(x))) / Math.Pow(x , 2) - 2 / Math.Pow(x , 2);
        }
        static double Approximation(double a, double b)
        {
            return f(a) * f2(a) > 0 ? a : b;
        }

        static void Input(out double a, out double b, out double eps)
        {
            Console.Write("Введите число a: ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            b = Double.Parse(Console.ReadLine());
            Console.Write("Введите число точность: ");
            eps = Double.Parse(Console.ReadLine());
        }
        static void Decision(double a, double b, double eps)
        {
            double Xn = 0.0, X = 0.0;
            double X0 = Approximation(a, b);
            Xn = X0;
            do
            {
                X = Xn - f(Xn) / f1(X0);
                Xn = X;
            } 
            while (Math.Abs(X - Xn) > eps);
            Console.Write($"Решение уравнения: {X}");
        }

        static void Main(string[] args)
        {
            double a, b, eps;
            Input(out a, out b, out eps);
            Decision(a, b, eps);
        }
    }
}
