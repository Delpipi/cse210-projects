public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "The Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = [
                    "Who are people that you appreciate?",
                    "What are personal strengths of yours?",
                    "Who are people that you have helped this week?",
                    "When have you felt the Holy Ghost this month?",
                    "Who are some of your personal heroes?"
                ];
    }

    public void Run()
    {
        int pauseDuration = 5;

        DisplayPrompt();

        Console.Write("You may begin in: ");
        ShowCountDown(pauseDuration);

        List<string> listFromUser = GetListFromUser();
        _count = listFromUser.Count;

        Console.WriteLine($"You listed {_count} items");
        Console.WriteLine();
    }


    private void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"-----{prompt}-----");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count - 1);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        int duration = GetDuration();

        DateTime startDateTime = DateTime.Now;
        DateTime endDateTime = startDateTime.AddSeconds(duration);

        List<string> listFromUser = new List<string>();
        while (DateTime.Now < endDateTime)
        {
            string response = Console.ReadLine();
            listFromUser.Add(response);
        }
        return listFromUser;
    }

    public int GetCount()
    {
        return _count;
    }

    public void SetCount(int count)
    {
        _count = count;
    }
}