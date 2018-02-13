using System;

namespace SoftwareInc
{
    class Program
    {
        static void Main()
        {

            int runningTotal = 0;

            // Prompt the user for minutes exercised
            Console.Write("How many minutes did you exercise?  ");

            string entry = Console.ReadLine();

            int minutes = int.Parse(entry);   // Change string to integer
            runningTotal = runningTotal + minutes;

            // Add minutes exercised to total


            // Display total minutes exercised to the screen
                Console.WriteLine("You entered " + runningTotal + " minutes");

            // repeat until the user quits

        }
    }  
} 