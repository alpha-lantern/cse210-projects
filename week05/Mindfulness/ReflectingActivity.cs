public class ReflectingActivity : Activity
{
    private List<string> _prompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
    private List<string> _questions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];

    public ReflectingActivity() : base()
    {
        SetName("Reflection Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience.");
    }

    public ReflectingActivity(string name, string description) : base(name, description) 
    {}

    public void Run()
    {
        // This will also set the duration of the activity
        DisplayStartingMessage();
        
        DisplayPrompt();
        DisplayQuestions();

        DisplayFinalMessage();
        // Add one to the counter of how many rounds of the activity were done
        AddOneRound();
        // Add to the total time spent in an activity
        AddToTimeSpent();
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {GetRandomPrompt()}---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    private void DisplayQuestions()
    {
        // Explanation
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.Clear();

        DateTime finalTime = DateTime.Now.AddSeconds(GetDuration());
        
        while (DateTime.Now < finalTime)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(10);
            Console.WriteLine();
        }
    }

    private string GetRandomPrompt()
    {
        int randomIndex = GetRandomNumber(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        return randomPrompt;
    }
    
    private string GetRandomQuestion()
    {
        int randomIndex = GetRandomNumber(_questions.Count);
        string randomQuestion = _questions[randomIndex];
        return randomQuestion;
    }
}