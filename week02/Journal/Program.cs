using System;

/* for Exceed requirement: I implemented save and load Entry from Json for
that change member variable using _underscoreCamelCase by use properties
with TitleCase
 */
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int menu = -1;
        do
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load From Text File");
            Console.WriteLine("4. Save To Text File");
            Console.WriteLine("5. Load From Json File");
            Console.WriteLine("6. Save To Json File");
            Console.WriteLine("7. Quit");
            Console.WriteLine("What would you like to do ? ");
            menu = int.Parse(Console.ReadLine());

            Entry entry = new Entry();
            if (menu == 1)
            {
                writeOperation(entry);
                journal.AddEntry(entry);
            }
            else if (menu == 2)
            {
                journal.DisplayAll();
            }
            else if (menu == 3)
            {
                Console.WriteLine("What is the filename ? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (menu == 4)
            {
                Console.WriteLine("What is the filename ? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (menu == 5)
            {
                journal.LoadFromJsonFile();
            }
            else if (menu == 6)
            {
                journal.SaveToJsonFile();
            }
            else if (menu == 5)
            {
                Console.WriteLine("Good bye. Have a nice day.");
            }
            else
            {
                Console.WriteLine("Enter a valid menu choice");
            }

        } while (menu != 7);

        static void writeOperation(Entry entry)
        {
            //Create PromptGenerator instance
            PromptGenerator promptGenerator = new PromptGenerator();
            promptGenerator.createPromptList();
            string promptText = promptGenerator.GetRandomPrompt();
            //Display prompt to user
            Console.WriteLine($"{promptText}.");
            string entryText = Console.ReadLine();

            entry.PromptText = promptText;
            entry.EntryText = entryText;
            entry.Date = DateTime.Now.ToString("dd/MM/yyyy");
        }

    }
}