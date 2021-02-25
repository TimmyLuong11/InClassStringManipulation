using System;

namespace InClass
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                sum += i;
            }
            Console.WriteLine($"{sum.ToString("N0")}");

        }
    }
}
