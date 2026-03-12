using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        string choice;

        // Create a Journal object to store the entries.
        Journal currentJournal = new();

        // Display the menu options
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? (1-5) ");
            // Read user input
            choice = Console.ReadLine();

            // Check input and respond to the option selected
            if (choice == "1")
            {
                // WRITE A NEW ENTRY
                // Generate a new Entry instance
                Entry newEntry = new();

                // Get Current Date
                DateTime currentTime = DateTime.Now;
                string dateText = currentTime.ToShortDateString();
                newEntry._date = dateText;

                // Get Random Prompt
                PromptGenerator promptGen = new();
                string prompt = promptGen.GetRandomPrompt();
                newEntry._promptText = prompt;

                // Prompt the user and store the answer as an entry
                Console.WriteLine($"{prompt}");
                Console.Write("> ");
                string userEntry = Console.ReadLine();
                newEntry._entryText = userEntry;

                // Store the entry in the Journal
                currentJournal._entries.Add(newEntry);
            }
            else if (choice == "2")
            {
                // Display the entries in the current journal
                currentJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                // Load a journal file
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                currentJournal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                // Save the current journal to a file
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                currentJournal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                // Quit
                Console.WriteLine("Good bye!");
            }
            else
            {
                // Invalid choice
                Console.WriteLine("Invalid Choice.");
                Console.WriteLine();
            }

        } while (choice != "5");
    }
}