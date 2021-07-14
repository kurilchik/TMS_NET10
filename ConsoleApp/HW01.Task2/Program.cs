using System;
using System.Collections.Generic;

namespace HW01.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> x = new();
            for (double i = 0; i <= 1; i += 0.1)
            {
                x.Add(Math.Sqrt(Math.Asin(i)) - 2);
            }
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
            foreach (var item in x)
            {                
                Console.WriteLine(Math.Round(Math.Sin(Math.Pow(item + 2, 2)), 2));
            }
        }
    }
}
