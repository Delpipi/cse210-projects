using System;

/* Exceeding Requirements:
 - Make sure no random prompts/questions are selected until they have all been used at least once in that session.  */

class Program
{
    static void Main(string[] args)
    {


        int menu = 0;

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from menu: ");
            string answer = Console.ReadLine();
            menu = int.Parse(answer);

            if (menu != 4)
            {
                Console.Write("How long, in seconds, would you like for your session? ");
                string duration = Console.ReadLine();

                if (menu == 1)
                {
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.SetDuration(int.Parse(duration));
                    breathingActivity.DisplayStartingMessage();

                    Console.WriteLine("Get Ready...");
                    breathingActivity.ShowSpinner(5);

                    breathingActivity.Run();

                    breathingActivity.DisplayEndingMessage();
                    breathingActivity.ShowSpinner(5);
                }
                else if (menu == 2)
                {
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.SetDuration(int.Parse(duration));
                    reflectingActivity.DisplayStartingMessage();

                    Console.WriteLine("Get Ready...");
                    reflectingActivity.ShowSpinner(5);

                    reflectingActivity.Run();

                    reflectingActivity.DisplayEndingMessage();
                    reflectingActivity.ShowSpinner(5);
                }

                else if (menu == 3)
                {
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.SetDuration(int.Parse(duration));
                    listingActivity.DisplayStartingMessage();

                    Console.WriteLine("Get Ready...");
                    listingActivity.ShowSpinner(5);

                    listingActivity.Run();

                    listingActivity.DisplayEndingMessage();
                    listingActivity.ShowSpinner(5);
                }

                Console.Clear();
            }
            else
            {
                Console.WriteLine("Bye, see you soon");
            }



        } while (menu != 4);

    }
}