using System;
using System.Xml.Serialization;
// Added a config menu were the user can change the number of words to hide each time or load a scripture from a file.
// There's an example file in the folder called "scripture.txt".
class Program
{
    static void Main(string[] args)
    {
        // Initialize the classes
        Reference reference = new Reference("2 Nephi", 31, 20);
        string text = "Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life.";
        Scripture scripture = new Scripture(reference, text);

        // Number of words to hide
        int numberToHide = 5;

        // Clear the console before displaying the title
        Console.Clear();
        Console.WriteLine("-----------------SCRIPTURE MEMORIZER-----------------");
        Console.WriteLine("Press enter to see a scripture and start memorizing!");
        Console.WriteLine("Type 'config' to enter the configuration menu.");
        Console.Write("> ");
        string choice = Console.ReadLine().ToLower();

        if (choice == "config")
        {
            while (choice != "4")
            {
                // Clear the console before displaying the menu
                Console.Clear();
                Console.WriteLine("Configuration");
                Console.WriteLine("1. Define number of words to hide.");
                Console.WriteLine("2. Load scripture from file.");
                Console.WriteLine("3. Show scripture file example.");
                Console.WriteLine("4. Leave.");
                Console.Write("What would you like to do? (1-4) ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("How many words do you want to hide each time?");
                        numberToHide =  int.Parse(Console.ReadLine());
                        Console.WriteLine("Changes applied.");
                        Thread.Sleep(1000);
                        break;

                    case "2":
                        Console.WriteLine("What is the filename? (Ex.: 'scripture.txt')");
                        string filename = Console.ReadLine();
                        scripture.LoadFromFile(filename);
                        Thread.Sleep(500);
                        Console.WriteLine("Scripture loaded.");
                        Thread.Sleep(1000);
                        break;

                    case "3":
                        Console.WriteLine("A file scripture should look like this:");
                        Console.WriteLine();
                        Console.WriteLine("John 3:16");
                        Console.WriteLine("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
                        Console.WriteLine("----------------- OR -----------------");
                        Console.WriteLine("John 14:14-15");
                        Console.WriteLine("If ye shall ask any thing in my name, I will do it.");
                        Console.WriteLine("If ye love me, keep my commandments.");
                        Console.WriteLine();
                        Console.WriteLine("Press enter to go back.");
                        Console.ReadLine();
                        break;

                    case "4":
                        Console.WriteLine("The program will start now.");
                        Thread.Sleep(1000);
                        break;
                }
            }
        }
        
        // Clear the console before displaying the scripture
        Console.Clear();

        // Display the scripture
        Console.WriteLine(scripture.GetDisplayText());
        
        // Display instructions and wait for the user input
        Console.WriteLine(); // Blank Line
        Console.WriteLine("Press enter to continue or type 'quit' to finish.");
        choice = Console.ReadLine().ToLower();

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
            choice = Console.ReadLine().ToLower();
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        }
        
    }
}