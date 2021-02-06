

using System;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.Write("Enter an Integer value between 1 and 100 to execute an iterative statement: ");
            /*
               Use the try catch block to validate user input.
               If the user provides bad input, the catch block
               will handle the error and a message will be displayed.
            */
            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();

                int value_of_input = int.Parse(input);
                /* 
                   This conditional IF/ELSE IF/ELSE statement is used to test the values of user input.
                   Depending on the value of the user input between 1 and 100, a 
                   iterative statement will execute. 
                */
                // If the value of user input is between 1 and 100, execute a For Loop
                if ((value_of_input > 0) && (value_of_input <= 100))
                {
                    Console.WriteLine("Executing a For Loop!");

                    // Here is the For Loop
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("You have entered " + value_of_input.ToString());
                        Console.WriteLine("This is the current integer value in the loop:" + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program ...");
                    // Pause the program and await the user to press a key to end the program
                    Console.ReadKey(true);
                }

                // If the user does not enter a value between 1 and 100, display a message
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 100 and try again ...");
                    Console.WriteLine("Press any key to exit the program and try again ...");
                    Console.ReadKey(true);
                }
            } // End of try
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            } // End of catch
        }
    }
}
