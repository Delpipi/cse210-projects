using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int num = -1;
        int smallest = 1000;

        while (num != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            num = int.Parse(userInput);
            if (num != 0)
            {
                numbers.Add(num);
            }

        }

        numbers.Sort();

        foreach (int number in numbers)
        {
            if (number > 0 && smallest > number)
            {
                smallest = number;
            }
        }

        int sum = numbers.Sum();
        double avg = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}