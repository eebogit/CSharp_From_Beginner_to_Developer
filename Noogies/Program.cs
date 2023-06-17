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
                }
                Console.WriteLine("Want to run again?");
                strYesNoAnswer = Console.ReadLine().ToLower();
                    while(!strYesNoAnswer.Equals("y") && !strYesNoAnswer.Equals("n")){
                    Console.WriteLine("Not a valid choice, type \"y\" or \"n\" \n Please try again.");
                    strYesNoAnswer = Console.ReadLine().ToLower();
                }
            }
            while(strYesNoAnswer.Equals("y"));
            // If the user answers no.
            return;
        }
    }
}
