using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult();
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!.");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        return int.Parse(input);
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult()
    {
        string fullName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int square = SquareNumber(favoriteNumber);

        Console.WriteLine($"{fullName}, the square of your number is {square}");
    }
}