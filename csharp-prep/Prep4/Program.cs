using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int userInput = -1;

        int total = 0;

        int currentSmallestNumber = 100000;

        while (userInput != 0)
        {
            Console.Write("Enter number: ");
            numbers.Add(userInput = int.Parse(Console.ReadLine()));
        }

        numbers.RemoveAt(numbers.Count - 1);

        foreach (int number in numbers)
        {
            total += number;

            if (number > 0 && number < currentSmallestNumber)
            {
                currentSmallestNumber = number;
            }
        }

        Console.WriteLine($"The sum is: {total}");
        
        // compute average
        float avg = (float)numbers.Average();
        Console.WriteLine($"The average is: {avg}");

        Console.WriteLine($"The largest number is: {numbers.Max()}");

        Console.WriteLine($"The smallest positive number is: {currentSmallestNumber}");

        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}