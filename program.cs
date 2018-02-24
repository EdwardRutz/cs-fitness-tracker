using System;

namespace Treehouse.FitnessFrog
{
    class Program
    {
        static void Main()
        {

            int runningTotal = 0;
            bool keepGoing = true;

            //To stop the loop, just set keepGoing to false when the stop condition is met

            while (keepGoing)
            {
                // Prompt the user for minutes exercised
                Console.Write("How many minutes did you exercise or type \"quit\" to exit: ");
                string entry = Console.ReadLine();

                if (entry == "quit")
                {
                    keepGoing = false;
                }
                else
                {
                    int minutes = int.Parse(entry);

                    // Add minutes exercised to total
                    runningTotal = runningTotal + minutes;

                    // Display total minutes exercised to the screen
                    Console.WriteLine("You entered " + runningTotal + " minutes");
                }
                // repeat until the user quits
            }
        }
    }  
} 