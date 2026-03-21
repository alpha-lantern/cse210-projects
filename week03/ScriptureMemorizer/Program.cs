using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the classes
        Reference reference = new Reference("2 Nephi", 31, 20);
        string text = "Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life.";
        // Number of words to hide
        int numberToHide = 5;

        Scripture scripture = new Scripture(reference, text);

        // Clear the console before displaying the scripture
        Console.Clear();
        
        // Program to display the scripture
        Console.WriteLine(scripture.GetDisplayText());
        
        // Display instructions and wait for the user input
        Console.WriteLine(); // Blank Line
        Console.WriteLine("Press enter to continue or type 'quit' to finish.");
        Console.WriteLine("Type 'config' to enter the options.");
        string choice = Console.ReadLine().ToLower();

        if (choice == "config")
        {
            Console.WriteLine("How many words do you want to hide each time?");
            numberToHide =  int.Parse(Console.ReadLine());
        }

        // Program Loop
        while (choice != "quit")
        {
            // Clear the console before displaying the scripture
            Console.Clear();
            
            // Program to display the scripture
            scripture.HideRandomWords(numberToHide);

            // Display instructions and wait for the user input
            Console.WriteLine(); // Blank Line
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            choice = Console.ReadLine();
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        }
        
    }
}