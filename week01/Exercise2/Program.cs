using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage (%)? ");
        string userInput = Console.ReadLine();
        int lastDigit = int.Parse(userInput[^1].ToString());
        int gradePercentage = int.Parse(userInput);

        string letter = "unknow";
        string sign = "-";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (lastDigit >= 7)
        {
            sign = "+";
        }

        Console.WriteLine($"Your grade is {letter}{sign}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("You pass !");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}