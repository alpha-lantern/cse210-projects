using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess My Number!");
        Console.WriteLine();

        // Generate a random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess;
        // Game loop
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
            }
            
        } while (guess != magicNumber);

    }
}