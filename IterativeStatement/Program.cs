/*
 Author: Bethy Gomez
 Date: 9/10/2019
 Description: Deliverable 2 - Iterative Statement (For Loop)
 */

using System;

namespace IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for input
            Console.WriteLine("Enter a value between 1 and 100.");

            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);

                if ((value_of_input >= 1) && (value_of_input <= 100))
                    // Will execute For Loop only if input is an integer between 1 and 100
                {
                    // This is the code for the For Loop
                    for (int i = 1; i <= value_of_input; i++) // The Loop will begin on 1 and increase each time
                    {
                        Console.WriteLine("You have entered " + value_of_input.ToString() + 
                            ". This is the current integer value in the loop: " + i.ToString());
                    }
                    Console.WriteLine(); // To put a space between the output and exit instructions
                    // Pause the program and ask the user to press a key to exit the program
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);
                }
                else
                {
                    // Will show an error if the number is not between 1 and 100
                    Console.WriteLine("Please enter a value between 1 and 100");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to exit and try again...");
                    Console.ReadKey(true);
                }
            } // end of try section
            catch
            {
                // Will show an error if the user does not enter an integer value
                Console.WriteLine("Please enter an integer value between 1 and 100...");
                Console.WriteLine();
                Console.WriteLine("Press any key to exit and try again...");
                Console.ReadKey(true);
            } // end of catch block
        }
    }
}
