using System;

namespace Noogies
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int d;
            int e;

            Console.WriteLine("Pick a Number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a Second Number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a Larger Third Number:");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=================");
            c = a + b;
            e = d - c;

            while (c <= d)
            {
                Console.WriteLine($"Number {c} is {e} less than {d}. \n");
                c++;
                e--;
            }
        }
    }
}
