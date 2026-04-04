public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
    
    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life.");
    }

    public ListingActivity(string name, string description) : base(name, description) 
    {}

    public void Run()
    {
        // This will also set the duration of the activity
        DisplayStartingMessage();

        GetRandomPrompt();
        SetAndDisplayCount(GetListFromUser());

        DisplayFinalMessage();
        // Add one to the counter of how many rounds of the activity were done
        AddOneRound();
        // Add to the total time spent in an activity
        AddToTimeSpent();
    }

    private void GetRandomPrompt()
    {
        int randomNum = GetRandomNumber(_prompts.Count);
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {_prompts[randomNum]}---");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine(); // Jump to a new line
    }

    private List<string> GetListFromUser()
    {
        DateTime finalTime = DateTime.Now.AddSeconds(GetDuration());
        List<string> userList = new List<string>();
        string answer;
        
        while (DateTime.Now < finalTime)
        {
            Console.Write("> ");
            answer = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(answer))
            {
                userList.Add(answer);
            }
        }

        return userList;
    }

    private void SetAndDisplayCount(List<string> userList)
    {
        _count = userList.Count;
        Console.WriteLine($"You listed {_count} items!");
    }
}