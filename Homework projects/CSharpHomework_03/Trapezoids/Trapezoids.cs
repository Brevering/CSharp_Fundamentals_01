﻿using System;

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = (h * ((a + b) / 2.0d));
            Console.WriteLine("{0:0.0000000}",area);
        }
    }
}