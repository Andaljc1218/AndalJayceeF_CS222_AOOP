using System;

public class InterestCalculator
{
    public static void Main()
    {
        Console.Write("Enter principal amount: ");
        double principal = double.Parse(Console.ReadLine());

        Console.Write("Enter rate of interest: ");
        double rate = double.Parse(Console.ReadLine());

        Console.Write("Enter time in years: ");
        int year = int.Parse(Console.ReadLine());

        double interest = (principal * rate * year) / 100;

        Console.Write($"Simple Interest: {interest:F2}");
    }
}