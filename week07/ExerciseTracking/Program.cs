class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        Running run1 = new Running("Running", 30, 4.8);
        Cycling cycling = new Cycling("Cycling", 45, 12);
        Swimming swim = new Swimming("Swimming", 60, 70);

        List<Activity> activities = [run1, cycling, swim];

        Console.WriteLine();
        foreach (Activity act in activities)
        {
            Console.WriteLine(act.GetSummary());
        }
        Console.WriteLine();
    }
}