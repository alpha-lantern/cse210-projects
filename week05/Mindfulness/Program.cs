// I added a session summary at the end of the program (when the user types 4 to quit). This summary shows how many rounds of each activity were run and how many time in seconds was spend with each activity.
class Program
{
    static void Main(string[] args)
    {
        string breathingDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        string reflectionDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        string listingDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        BreathingActivity breathe = new BreathingActivity("Breathing Activity", breathingDescription);
        ReflectingActivity reflection = new ReflectingActivity("Reflection Activity", reflectionDescription);
        ListingActivity listing = new ListingActivity("Listing Activity", listingDescription);

        string choice;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    // Run the activity
                    breathe.Run();
                    break;

                case "2":
                    // Run the activity
                    reflection.Run();
                    break;

                case "3":
                    // Run the activity
                    listing.Run();
                    break;

                case "4":
                    // Display session information
                    Console.WriteLine("Well Done!");
                    Console.Write("This session you completed: ");
                    breathe.ShowCountdown(3);
                    Console.WriteLine();

                    if (breathe.GetRounds() > 0)
                    {
                        breathe.DisplaySessionInfo();
                    }

                    if (reflection.GetRounds() > 0)
                    {
                        reflection.DisplaySessionInfo();
                    }

                    if (listing.GetRounds() > 0)
                    {
                        listing.DisplaySessionInfo();
                    }

                    break;
            }
            
        } while(choice != "4"); 
    }
}