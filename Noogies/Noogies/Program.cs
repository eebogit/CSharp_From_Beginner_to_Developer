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
            int f = 2;
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
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write($"Number {c} is {e} less than {d}. \n");
                    c++;
                    e--;
                    if (c % f == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("This number is odd.\n");
                        Thread.Sleep(250);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This number is even.");
                        Thread.Sleep(250);
                    }
                    
                                        
                }
                Console.ForegroundColor = ConsoleColor.Gray;
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
