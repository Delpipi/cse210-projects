using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter grade percentage(%) ");
        string input = Console.ReadLine();
        int percent = int.Parse(input);

        string letter = "";
        string sign = "";

        if (percent >= 90)
        {
            letter = "A";
            int lastDigit = percent % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else if (percent < 90 && percent >= 80)
        {
            letter = "B";
            int lastDigit = percent % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else if (percent < 80 && percent >= 70)
        {
            letter = "C";
            int lastDigit = percent % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else if (percent < 70 && percent >= 60)
        {
            letter = "D";
            int lastDigit = percent % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else
        {
            letter = "F";
            int lastDigit = percent % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }

        if (percent >= 70)
        {
            Console.WriteLine($"Congratulation you passed with {letter}{sign} grade");
        }
        else
        {
            Console.WriteLine($"Sorry, You did not pass the class with {letter}{sign} grade");
        }
    }
}