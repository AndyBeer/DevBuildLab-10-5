using System;

namespace Lab2NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            //0.0 get user's name, to refer to them throughout the code
            //1.0 get integer input between 1 and 100
                //1.1 add validation to guarantee a user enters a valid input
            //2.0 take integer that user submitted and:
                //2.1 if odd, print the number and display "Odd."
                //2.2 if even and between 2-25 incl, print "Even and less than 25."
                //2.3 if even and between 26 - 60 incl, print "Even."
                //2.4 if even and > 60 excl, print the number and "Even."
                //2.5 if odd and > 60 excl, print the number and "Odd." (REDUNDANT to 2.1)
            //3.0 ask if the user wants to continue (while loop?)

            //0.0
            Console.WriteLine("Hello!  Welcome to Number Analyzer.\nPlease enter your name.");
            string userName = Console.ReadLine();

            Console.WriteLine($"Welcome {userName}!  Let's get started.");
            Console.WriteLine();
            

            //3.0
            bool retry = true;
            int userInput;
 
            while (retry)
            {
                //1.0
                Console.WriteLine("Please enter an integer from 1 to 100 (inclusive).");
                userInput = int.Parse(Console.ReadLine());

                //1.1
                if (userInput > 0 
                    && userInput <= 100
                    && userInput % 1 == 0)
                {
                    Console.WriteLine($"Thanks {userName}.");
                }
                else
                {
                    Console.WriteLine($"Thanks {userName}, but that isn't an integer from 1-100.  Please try again.\nPlease enter an integer from 1 to 100 (inclusive).");
                    userInput = int.Parse(Console.ReadLine());
                }
                //if even
                if (userInput % 2 == 0)

                {
                    //2.2
                    if (userInput >= 2 
                        && userInput <= 25)
                    {
                        Console.WriteLine("Even and less than 25.");
                    }
                    //2.3
                    else if (userInput >= 26 
                        && userInput <= 60)
                    {
                        Console.WriteLine("Even.");
                    }
                    //2.4
                    else if (userInput > 60)
                    {
                        Console.WriteLine($"{userInput}\nEven.");
                    }
                }
                //if odd
                else
                {
                    //2.5
                    if (userInput > 60)
                    {
                        Console.WriteLine($"{userInput}\nOdd.");
                    }
                    //2.1
                    else
                    {
                        Console.WriteLine($"{userInput}\nOdd.");
                    }
                }
                Console.WriteLine($"Would you like to try this again, {userName}?\nY/N");
                string goOn = Console.ReadLine().ToLower();

                if (goOn == "y")
                {
                    Console.WriteLine($"Great {userName}!  Let's try it again.");

                }
                else if (goOn == "n")

                {
                    Console.WriteLine($"Thanks for playing {userName}!");
                    retry = false;
                }
                else
                {
                    Console.WriteLine($"Sorry {userName}, I didn't understand that.\nWould you like to retry?\nY/N");
                }
            }
        }
    }
}
