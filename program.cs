using System;

namespace Treehouse.FitnessFrog
{
    class Program
    {
        static void Main()
        {

            double runningTotal = 0.0;

            //To stop the loop, just set keepGoing to false when the stop condition is met

            while (true)
            {
                // Prompt the user for minutes exercised
                Console.Write("How many minutes did you exercise or type \"quit\" to exit: ");
                var entry = Console.ReadLine();

                if (entry.ToLower() == "quit")  //toLower() makes entry all lower case
                {
                    break;
                }
                
                //Use try-catch to handle exceptions
                try
                {
                    //make sure everything that uses the variable minutes is within curly braces

                    var minutes = double.Parse(entry);

                    if (minutes <= 0)
                    {
                        Console.WriteLine(minutes + " is not an acceptable value");
                        continue;  //continue tells the loop to start from the beginning
                    }
                    else if (minutes <= 10)
                    {
                        Console.WriteLine("Your off to a good start!");
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Way to go, you are smoke'n!");
                    }
                    else if (minutes <= 60)
                    {
                        Console.WriteLine("You're a Ninja Warrior in Training!");
                    }
                    else
                    {
                        Console.WriteLine("You are rock'n the house!");
                    }

                    // Add minutes exercised to total
                    runningTotal = runningTotal + minutes;      //runningTotal = runningTotal + minutes;
                }
                    catch(FormatException)
                    {
                        Console.WriteLine("That is not valid input.");
                        continue;
                    }                  
                    // Display total minutes exercised to the screen
                    Console.WriteLine("You entered " + runningTotal + " minutes");
                    
                // repeat until the user quits
            }
        }
    }  
} 