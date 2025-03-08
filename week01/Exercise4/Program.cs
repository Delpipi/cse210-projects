using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "";
        int sum = 0;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (answer != "0")
        {
            Console.Write("Enter number: ");
            answer = Console.ReadLine();
            if (answer != "0")
            {
                numbers.Add(int.Parse(answer));
            }
        }

        int smallest = numbers.First<int>();
        int largest = numbers.Last<int>();

        numbers.ForEach(number => sum += number);

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }

            if (number > 0 && number < smallest)
            {
                smallest = number;
            }
        }

        float avg = ((float)sum) / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest number is: {smallest}");
    }
}