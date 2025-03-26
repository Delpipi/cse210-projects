using System;

class Program
{
    static void Main(string[] args)
    {
        string text = "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        string book = "Proverbs";
        int chapter = 3;
        int verse = 5;
        int endVerse = 6;

        string answer = "";
        int numberToHide = 4;
        bool IsCompletelyHidden = false;

        //Create Reference
        Reference reference = new Reference(book, chapter, verse, endVerse);

        //Create Scripture
        Scripture scripture = new Scripture(reference, text);


        do
        {
            //Clear the previous console
            Console.Clear();

            //check if scripture's words are completely hidden
            IsCompletelyHidden = scripture.IsCompletelyHidden();

            //Display scripture text
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            answer = Console.ReadLine();

            if (answer != "quit")
            {
                scripture.HideRandomWords(numberToHide);
            }

        } while (answer != "quit" && !IsCompletelyHidden);
    }
}