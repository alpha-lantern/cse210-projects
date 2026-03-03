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
            string input = Console.ReadLine();
            userNum = int.Parse(input);

            if (userNum != 0)
            {
                numbers.Add(userNum);
            }
        }

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
        // float avg = (float)sum2 / numbers.Count;
        // // Display results
        // Console.WriteLine($"The sum is: {sum2}");
        // Console.WriteLine($"The average is: {avg}");

        // Find largest using a loop
        // int largest = numbers[0];
        // foreach (int number in numbers)
        // {
        //     if (number > largest)
        //     {
        //         largest = number;
        //     }
        // }
        int largest = numbers.Max();
        Console.WriteLine($"The largest number is: {largest}");

        // Find smallest positive number
        int smallest = largest;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallest)
            {
                smallest = number;
            }
        }
        // Decide what to display
        if (smallest != largest)
        {
            Console.WriteLine($"The smallest positive number is: {smallest}");   
        }
        else
        {
            Console.WriteLine($"There are no positive numbers.");
        }
        
        // Display sorted list
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}