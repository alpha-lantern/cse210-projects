public class PromptGenerator
{
    public string _sourceFile = "prompts.txt";
    public List<string> _prompts = new List<string>();

    // Constructor
    public PromptGenerator()
    {
        GetPromptsFromFile(_sourceFile);
    }

    // Get Random prompt form available prompts
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int random = randomGenerator.Next(_prompts.Count);

        string prompt = _prompts[random];
        
        return prompt;
    }

    // Get Prompts from a prompt file
    public void GetPromptsFromFile(string file)
    {
        if (File.Exists(file))
        {     
            string[] prompts = File.ReadAllLines(file);
            _prompts.AddRange(prompts);
        }
        else
        {
            // If there's no Prompts file, then a new one is created and saved to the current directory
            List<string> defaultPrompts = ["Who was the most interesting person I interacted with today?", "What was the best part of my day?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What did I do today to move forward with my goals?"];
            SavePromptsFile(defaultPrompts);

            // I found help with paths in an answer on StackOverflow. Reference source:
            // https://es.stackoverflow.com/questions/617039/despliegue-de-carpetas-proyecto-c
            string path = Path.Combine(Directory.GetCurrentDirectory(), file);

            // Debugging
            Console.WriteLine("New prompts file created at:");
            Console.WriteLine(path);
            _prompts.AddRange(defaultPrompts);
        }
    }

    // Add personalized prompts
    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }

    // Save or update the prompts file
    public void SavePromptsFile(List<string> promptsList)
    {
        using (StreamWriter promptsFile = new StreamWriter(_sourceFile))
        {
            foreach (string prompt in promptsList)
            {
                promptsFile.WriteLine(prompt);
            }
        }
    }

    // Display all prompts
    public void DisplayAll()
    {
        Console.WriteLine("Prompts:");
        foreach (string prompt in _prompts)
        {
            Console.WriteLine($"- {prompt}");
        }
    }
}