using System;

namespace Tomato_Time
{
    class Program
    {
        static void Main(string[] args)
        {
           // Declaring variables, including a few preset time spans (1500 = 25 min, 600 = 10 min and 3600 = 1h in seconds).
           // For now, default time settings are commented out as they haven't been implemented yet.
            // int intTimeDefaultSet = 1500;
            // int intPreSet1 = 600;
            // int intPreset2 = 3600;
            int intTimeSet = 0;
          // Declare user's name for a more personalized touch.
            string strName = "User";

            // Ask user to state their name.
            Console.Write("What is your name? \n");
            strName = Console.ReadLine();
            Console.WriteLine($"Hello, {strName}, it is nice to meet you.\n How many seconds would you like to focus for?");
            intTimeSet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You want to focus for {intTimeSet} seconds, right?");
            while (strFocusAcknowledge = "Yes" && intTimeSet != 0)
            {
                Console.Write($"There are {intTimeSet} seconds remaining.")
                intTimeSet--;
                Threads
            }
            
           // Request  
        }
    }
}
