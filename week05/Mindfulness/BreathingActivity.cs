public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly.");
    }
    public BreathingActivity(string name, string description) : base(name, description)
    {}

    public void Run()
    {
        // This will also set the duration of the activity
        DisplayStartingMessage();

        RunBreathingLoop(GetDuration());

        DisplayFinalMessage();
        // Add one to the counter of how many rounds of the activity were done
        AddOneRound();
        // Add to the total time spent in an activity
        AddToTimeSpent();
    }

    private void RunBreathingLoop(int seconds)
    {
        DateTime finalTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < finalTime)
        {
            Console.Write("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine(); // Blank Line
            
            Console.Write("Now breathe out...");
            ShowCountdown(6);
            Console.WriteLine(); // Blank Line
            
            Console.WriteLine(); // Blank Line
        }
    }
}