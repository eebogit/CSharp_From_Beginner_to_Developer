using System;

namespace Noogies
{
    using System;
    using System.Threading;
    class Program
    {
        static void Main(string[] args)
        {
          
            
            int a;
            int b;
            int c;
            int d;
            int e;
            string strYesNoAnswer = "";

            do
            {
                Console.WriteLine("Pick a Number:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a Second Number:");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a Larger Third Number:");
                d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("====================");
                c = a + b;
                e = d - c;

                while (c <= d)
                {
                    Console.WriteLine($"Number {c} is {e} less than {d}. \n");
                    c++;
                    e--;
                    Thread.Sleep(500);
                }
                Console.WriteLine("Want to run again?");
                strYesNoAnswer = Console.ReadLine().ToLower();
                    while(!strYesNoAnswer.Equals("y") && !strYesNoAnswer.Equals("n")) {
                    Console.WriteLine("Not a valid choice, type \"y\" or \"n\". \nPlease try again.");
                    strYesNoAnswer = Console.ReadLine().ToLower();
                }
            }
            while(strYesNoAnswer.Equals("y"));
            // If the user answers no.
            return;
        }
    }
}
