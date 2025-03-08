using System;

class Program
{
    static void Main(string[] args)
    {

        string play = "yes";

        do
        {
            //Console.Write("What is the magic number ? ");
            //string input = Console.ReadLine();
            //int magicNumber = int.Parse(input);

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            int guess = -1;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string answer = Console.ReadLine();
                guess = int.Parse(answer);

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.Write("Do you want to play again (no/yes) ");
            play = Console.ReadLine();

        } while (play == "yes");

        Console.Write("GOOD BYE, see you soon");
    }
}