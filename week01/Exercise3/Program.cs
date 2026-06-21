using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // Version 1
        /* 
        Console.Write("What is the magic number? ");
        string userInput1 = Console.ReadLine();
        int magicNum = int.Parse(userInput1);

         Console.Write("What is your guess? ");
         string userInput2 = Console.ReadLine();
         int guessNum = int.Parse(userInput2);

         if (guessNum > magicNum)
         {
             Console.WriteLine("Lower");
         }
         else if (guessNum < magicNum)
         {
             Console.WriteLine("Higher");
         }
         else
         {
             Console.WriteLine("You guessed it!");
         } */

        // Version 2
        Random randomGenerator = new Random();
        string response = "yes";
        while (response.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
        {
            int magicNum = randomGenerator.Next(1, 101);
            int guesses = 0;
            int guessNum;

            do
            {
                guesses += 1;

                Console.Write("What is your guess? ");
                string userInput2 = Console.ReadLine();
                guessNum = int.Parse(userInput2);

                if (guessNum > magicNum)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNum < magicNum)
                {
                    Console.WriteLine("Higher");
                }

            } while (guessNum != magicNum);

            Console.WriteLine($"You guessed it at {guesses} guesses!");

            Console.Write("Do you want to play again (Yes/No)? ");
            response = Console.ReadLine();
        }

    }
}