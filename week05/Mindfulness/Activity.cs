public class Activity
{
    private string _name;
    private string _description;
    private int _duration = 30; // Default time

    private int _rounds = 0;
    private int _timeSpent = 0;

    protected Activity()
    {}

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // MESSAGES
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;
        
        Console.Clear(); // Clear console

        // Loading animation
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine(); // Blank Line
    }

    public void DisplayFinalMessage()
    {
        Console.WriteLine("Good Job!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(6);
    }

    // GRAPHICS / ANIMATIONS
    public void ShowSpinner(int seconds)
    // Shows a spinner for loading animation
    {
        // Time to complete the activity
        DateTime finalTime = DateTime.Now.AddSeconds(seconds);
        int sleepTime = 200;
        // Spinner chars
        char[] spinner = ['-', '\\', '|', '/'];
        // Number for iteration
        int i = 0;
        while (DateTime.Now < finalTime)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
            i++;
        }
        Console.Write(" \b"); // Clear line and move cursor back
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i != 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.Write(" \b");
    }

    // UTILITY
    protected int GetRandomNumber(int max)
    {
        Random randomGenerator = new Random();
        int randomNum = randomGenerator.Next(max);
        return randomNum;
    }

    public void DisplaySessionInfo()
    {
        Console.WriteLine($"{_rounds} round(s) of {_name}.");
        Console.WriteLine($"Time spent: {_timeSpent} seconds.");
        ShowSpinner(2);
    }

    // GETTERS AND SETTERS
    protected void SetDescription(string description)
    {
        _description = description;
    }
    protected void SetName(string name)
    {
        _name = name;
    }

    protected int GetDuration()
    {
        return _duration;
    }

    protected void AddOneRound()
    {
        _rounds ++;
    }

    public int GetRounds()
    {
        return _rounds;
    }

    protected void AddToTimeSpent()
    {
        _timeSpent += _duration;
    }
}