using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Initialize
        List<int> numbers = new List<int>();
        int userNum = 1;

        while (userNum != 0)
        {
            Console.Write("Enter number: ");
            userNum = int.Parse(Console.ReadLine());

            if (userNum != 0)
            {
                numbers.Add(userNum);
            }
        }

        Console.WriteLine($"Your list: {numbers}");

        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        // Using a loop for sum and average
        // int sum2 = 0;
        // foreach (int num in numbers)
        // {
        //     sum2 += num;
        // }
        // double avg = (double)sum2 / numbers.Count;
        // // Display results
        // Console.WriteLine($"The sum is: {sum2}");
        // Console.WriteLine($"The average is: {avg}");

        int largest = numbers.Max();
        Console.WriteLine($"The largest number is: {largest}");
    }
}