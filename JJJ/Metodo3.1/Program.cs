﻿using System;

namespace Metodo3._1
{
    class Program
    {
        public double LineValueForY(double m, double x, double b)
        {
            double resultY;

            resultY = m * x + b;

            return resultY;

        }
        static void Main(string[] args)
        {
            double m, x, b, Yvalue;
            Console.WriteLine("Please enter the value of m:");
            m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the value of x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the value of b:");
            b = Convert.ToDouble(Console.ReadLine());

            Program n = new Program();
            Yvalue = n.LineValueForY(m, x, b);

            Console.WriteLine($"the Y value of the line is: {Yvalue}");

            Console.ReadKey();
        } 
    }
}
