using System;
using System.IO;


/* Creativity and Exceeding Requirements:
    - Program fetch scripture from file "scripture.txt" */

class Program
{
    static void Main(string[] args)
    {
        string filePath = "scripture.txt";
        Random random = new Random();


        //Reading all lines into any array
        string[] lines = File.ReadAllLines(filePath);

        //Random fetch scripture from file
        int index = random.Next(lines.Length);
        string line = lines[index];

        //Example of line: "Proverbs 5:4 But her end is bitter as ...."
        var parts = line.Split(' ', 3); // Split into Book, Chapter, Verse and Text
        string book = parts[0];
        string chapterVerse = parts[1];
        string text = parts[2];

        //Get chapter and verse part
        var chapterVerseParts = chapterVerse.Split(":");
        int chapter = int.Parse(chapterVerseParts[0]);
        int verse = int.Parse(chapterVerseParts[1]);

        /* string text = "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
      string book = "Proverbs";
      int chapter = 3;
      int verse = 5;
      int endVerse = 6; 

        //Create Reference
        Reference reference = new Reference(book, chapter, verse, endVerse);
        */

        //Create Reference
        Reference reference = new Reference(book, chapter, verse);

        //Create Scripture
        Scripture scripture = new Scripture(reference, text);

        bool IsCompletelyHidden;
        string answer;
        int numberToHide = 4;

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