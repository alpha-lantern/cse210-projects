using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their first name and store it
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Ask the user for their last name and store it
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine(); // Blank line

        // Print full name
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}