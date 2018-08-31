using System;


namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();  //call get app info

            GreetUser(); // Greet user




            while (true)
            {
                // Init correct number
                // int correctNumber = 7;

                // Create a new random object
                Random rand = new Random();

                // Init correct number
                int correctNumber = rand.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10: ");

                // While guess is incorrect
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use actual number.");
                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess var
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again.");
                    }
                }

                

                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!");


                // Ask to play again
                Console.WriteLine("Play again? [Y ot N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        }


        // Get and display app info

        static void GetAppInfo()
        {
            // set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "David Agaybi";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();

        }

        // Greet the user
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game ...", inputName);
        }



        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Write out app info
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();

        }

    }
}
