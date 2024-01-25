using System;

namespace CSharpRampUp
{
    class Program
    {
        static void Main(string[] args)
        {   // Part 1&2 - Program options
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Convert Units");
            Console.WriteLine("2. Perform Mathematical Operations");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ConvertUnits();
                    break;

                case "2":
                    PerformMathematicalOperations();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                    break;
            }
        }
            // Part 1 - Convert Units
        static void ConvertUnits()
        {
            // Pounds to kilograms 
            Console.Write("Enter weight in pounds: ");
            double pounds = double.Parse(Console.ReadLine());
            double kilograms = pounds * 0.453592;
            Console.WriteLine($"{pounds} pounds is equal to {kilograms:F2} kilograms");

            // Miles to kilometers 
            Console.Write("Enter distance in miles: ");
            double miles = double.Parse(Console.ReadLine());
            double kilometers = miles * 1.60934;
            Console.WriteLine($"{miles} miles is equal to {kilometers:F2} kilometers");

            // Fahrenheit to Celsius 
            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit}°F is equal to {celsius:F2}°C");

            // Student ages and average
            double[] studentAges = new double[10];
            double totalAge = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter age of student {i + 1}: ");
                studentAges[i] = double.Parse(Console.ReadLine());
                totalAge += studentAges[i];
            }

            double averageAge = totalAge / 10;
            
            Console.WriteLine("Student ages: ");
            foreach (double age in studentAges)    // enumerates the elements of a collection and executes its body for each element of the collection.
            {
                Console.WriteLine(age);
            }

            Console.WriteLine($"Average age of the students: {averageAge:F2}");

            // Fantasy story
            string hero = "Karlach";
            string weapon = "The Balduran's Giantslayer";
            string questItem = "Infernal Engine";
            string villain = "Sarevok";
            string skill = "Berserker";

            Console.WriteLine($"A realm packed with dungeons and dragons that wander the heavens and sky, {hero} wielded the legendary {weapon}. Her quest: to remove the {questItem} out of her heart. From the toughest enemies on Baldur's Gate. The {villain}. With her {skill} skill, Karlach will find many companions along her journey and eventually get rid of her Infernal Engine from the forces of evil...");
        }
            // Part 2 - Mathematical Operations
        static void PerformMathematicalOperations()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Print Number Pattern");
            Console.WriteLine("2. Calculate Sum and Formula");
            Console.WriteLine("3. Print Reversed Number Pattern");

            string choice = Console.ReadLine();

                // Part 2 - Program options
            // selection statement
            switch (choice)
            {
                case "1":
                    NumberPatternPrinter.PrintPattern();
                    break;

                case "2":
                    SumAndFormulaCalculator.CalculateSumAndFormula();
                    break;

                case "3":
                    ReversedNumberPatternPrinter.PrintReversedPattern();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                    break;
            }
        }
    }
 
  
}
    // Part 2 - Print Number Pattern
class NumberPatternPrinter
{
    public static void PrintPattern()
    {
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int n) && n > 0)
        {
            PrintNumberPattern(n);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }

    static void PrintNumberPattern(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
    // Part 2 - Calculate Sum and Formula
class SumAndFormulaCalculator
{
    public static void CalculateSumAndFormula()
    {
        Console.WriteLine("Enter a number :");
        string input = Console.ReadLine();
                                        // Returns True if both statements are true.
        if (int.TryParse(input, out int n) && n > 0)
        {
            string formula = GenerateFormula(n);
            int sum = CalculateSum(n);

            Console.WriteLine($"Formula: {formula}");
            Console.WriteLine($"Sum of numbers from 1 to {n} using the formula is: {sum}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }

    static int CalculateSum(int n)
    {
        
        return n * (n + 1) / 2;
    }

    static string GenerateFormula(int n)
    {
        
        return $"Sum = {n} * ({n} + 1) / 2";
    }
}
    // Part 2 - Print Reversed Number Pattern
class ReversedNumberPatternPrinter
{
    public static void PrintReversedPattern()
    {
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int n) && n > 0)
        {
            PrintReversedNumberPattern(n);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }

    static void PrintReversedNumberPattern(int n)
    {
        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
