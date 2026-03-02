using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lets determine your grade!");

        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());

        // Grades verification
        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        // Determine the sign (+ or -)
        string sign = "";
        int lastDigit = grade % 10;
        // There's no A+ neither F+
        if (lastDigit >= 7 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        // There's no F-
        else if (lastDigit < 3 && letter != "F")
        {
            sign = "-";
        }

        // Print letter
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Determine if the user passed the course
        if (grade >= 70)
        {
            Console.WriteLine("Congrats! You've passed the course.");
        }
        else
        {
            Console.WriteLine("Sadly, you didn't pass. Keep studying and you'll succeed!");
        }
    }
}