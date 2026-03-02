using System;

class Program
{
    static void Main(string[] args)
    {

        // Prepare to generate a random number
        Random randomGenerator = new Random();
        int magicNumber;

        // Initial variables
        string play = "yes"; // Stores the user answer to play again
        int guess; // Stores the user guess

        // Start the game
        do
        {
            Console.WriteLine("Guess My Number!");
            Console.WriteLine(); // Blank line

            // Generate a random number
            magicNumber = randomGenerator.Next(1, 100);
            int guessCounter = 1; // Starts with the first guess of the user

            // Inside the game loop
            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCounter} guesses.");
                    Console.WriteLine(); // Blank line

                    // Ask if the user wants to play again
                    Console.Write("Play Again? (type 'yes' to play again) ");
                    play = Console.ReadLine();
                }

                guessCounter ++; // Count the number of guesses

            } while (guess != magicNumber);
            
        } while (play == "yes");
    }
}