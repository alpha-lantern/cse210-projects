public class GoalManager()
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    private List<string> _motivationalPhrases = [
        "Small steps lead to big results.",
        "Don't stop until you're proud.",
        "Make today count.",
        "Focus on progress, not perfection.",
        "Success starts with self-discipline."];

    public void Start()
    {
        Console.Clear();
        Console.Write("Loading... ");
        string userChoice = "";
        while(userChoice != "6")
        {
            ShowSpinner(2);
            Console.Clear();
            Console.WriteLine(); // Blank line
            DisplayPlayerInfo();
            Console.WriteLine(); // Blank line
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    CreateGoal();
                break;

                case "2":
                    ListGoalDetails();
                    Console.Write("- Press Enter to continue - ");
                    Console.ReadLine();
                break;

                case "3":
                    SaveGoals();
                break;

                case "4":
                    LoadGoals();
                break;

                case "5":
                    ListGoalNames();
                    RecordEvent();
                    Console.Write("- Press Enter to continue - ");
                    Console.ReadLine();
                break;

                case "6":
                    DisplayByeMessage();
                break;

                default:
                    Console.WriteLine("Invalid option. Please select one from the menu.");
                break;
            }
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    private void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        int n = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"  {n}. {goal.GetName()}");
            n ++;
        }
    }

    private void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        int n = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{n}. {goal.GetDetailString()}");
            n ++;
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalChoice = Console.ReadLine();
        // if (goalChoice != "1" || goalChoice != "2" || goalChoice != "3")
        // {
        //     Console.WriteLine("Invalid option.");
        //     return;
        // }

        // Questions applicable for every goal
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of point associated with this goal? ");
        string points = Console.ReadLine();

        // Proceed according to the goal type
        switch (goalChoice)
        {
            case "1":
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
            break;

            case "2":
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
            break;

            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine()
                );
                Console.Write("What is the bonus for accomplishing that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(checklistGoal);
            break;

            default:
                Console.WriteLine("Invalid option. Please select one from the goals listed.");
            break;
        }
    }

    private void RecordEvent()
    {
        // Ask for a goal
        Console.Write("Which goal did you accomplish? ");
        string userAnswer = Console.ReadLine();
        int goalIndex = int.Parse(userAnswer);
        
        if (goalIndex > _goals.Count)
        {
            Console.WriteLine("Invalid option.");
            return;
        }

        // Get the correct goal
        Goal goal = _goals[goalIndex - 1];

        // Add points
        if (!goal.IsComplete() || goal is EternalGoal)
        {
            goal.RecordEvent();
            int pointsObtained = int.Parse(goal.GetPoints());
            _score += pointsObtained;

            // Display messages
            Console.WriteLine($"Congratulations! You have earned {pointsObtained} points!");
            Console.WriteLine($"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("You've already completed this goal.");
        }
    }

    private void SaveGoals()
    {
        string filename = GetFilenameFromUser();

        using (StreamWriter goalFile = new StreamWriter(filename))
        {
            goalFile.WriteLine(_score);
            // Iterate over each Goal object
            foreach (Goal goal in _goals)
            {
                goalFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    private void LoadGoals()
    {
        string filename = GetFilenameFromUser();

        int typeIndex = 0;
        int infoIndex = 1;
        // GOAL INFO
        int nameIndex = 0;
        int descIndex = 1;
        int pointsIndex = 2;
        // Simple goal only
        int isCompleteIndex = 3;
        // Checklist goal only
        int bonusIndex = 3;
        int targetIndex = 4;
        int amountCompleted = 5;

        string[] goals = File.ReadAllLines(filename);

        _score = int.Parse(goals[0]);

        for (int i = 1; i < goals.Length; i++)
        {
            string goalString = goals[i];
            // Split in type and Info
            string[] goalLog = goalString.Split("::");
            string goalType = goalLog[typeIndex];
            string[] goalInfo = goalLog[infoIndex].Split("~");

            if (goalType == "EternalGoal") // Eternal Goal
            {
                EternalGoal eternalGoal = new EternalGoal(goalInfo[nameIndex], goalInfo[descIndex], goalInfo[pointsIndex]);
                _goals.Add(eternalGoal);
            }
            else if (goalType == "SimpleGoal") // Simple Goal
            {
                SimpleGoal simpleGoal = new SimpleGoal(goalInfo[nameIndex], goalInfo[descIndex], goalInfo[pointsIndex], goalInfo[isCompleteIndex]);
                _goals.Add(simpleGoal);
            }
            else
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(goalInfo[nameIndex], goalInfo[descIndex], goalInfo[pointsIndex], goalInfo[targetIndex], goalInfo[bonusIndex], goalInfo[amountCompleted]);
                _goals.Add(checklistGoal);
            }
        }
    }

    private string GetFilenameFromUser()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        return filename;
    }

    private void DisplayByeMessage()
    {
        int randIndex = GetRandomNumber(_motivationalPhrases.Count);
        string phrase = _motivationalPhrases[randIndex];
        Console.WriteLine(); // Blank line
        Console.WriteLine($"  -- \"{phrase}\" --");
        Console.WriteLine(); // Blank line
        Console.WriteLine("See you later!");
    }

    // UTILITY
    protected int GetRandomNumber(int max)
    {
        Random randomGenerator = new Random();
        int randomNum = randomGenerator.Next(max);
        return randomNum;
    }
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
}