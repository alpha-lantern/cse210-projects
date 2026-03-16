using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()}");
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()}");
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()}");
        Console.WriteLine();
        // Set and Get values
        Console.WriteLine("After setting new values:");
        fraction1.SetTop(5);
        fraction1.SetBottom(2);
        Console.WriteLine($"Fraction 1 Top Number: {fraction1.GetTop()}");
        Console.WriteLine($"Fraction 1 Bottom Number: {fraction1.GetBottom()}");
        fraction2.SetTop(10);
        fraction2.SetBottom(2);
        Console.WriteLine($"Fraction 1 Top Number: {fraction2.GetTop()}");
        Console.WriteLine($"Fraction 1 Bottom Number: {fraction2.GetBottom()}");
        fraction3.SetTop(1);
        fraction3.SetBottom(3);
        Console.WriteLine($"Fraction 1 Top Number: {fraction3.GetTop()}");
        Console.WriteLine($"Fraction 1 Bottom Number: {fraction3.GetBottom()}");
        Console.WriteLine();
        // Display with methods
        Console.WriteLine("Final Fractions:");
        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()}");
        Console.WriteLine($"Fraction 1 Decimal Value: {fraction1.GetDecimalValue()}");
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()}");
        Console.WriteLine($"Fraction 2 Decimal Value: {fraction2.GetDecimalValue()}");
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()}");
        Console.WriteLine($"Fraction 3 Decimal Value: {fraction3.GetDecimalValue()}");
    }
}