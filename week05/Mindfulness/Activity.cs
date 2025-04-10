public class Activity
{
    protected string _name;
    protected string _description;
    private int _duration;

    public Activity() { }

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine(_name);
        Console.WriteLine();
        Console.WriteLine(_description);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done !!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");

        DateTime startDateTime = DateTime.Now;
        DateTime endDateTime = startDateTime.AddSeconds(seconds);

        int i = seconds;
        while (DateTime.Now < endDateTime)
        {
            Console.Write(animationStrings[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        DateTime startDateTime = DateTime.Now;
        DateTime endDateTime = startDateTime.AddSeconds(seconds);

        int i = seconds;
        while (DateTime.Now < endDateTime)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i--;
        }
        Console.WriteLine();
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }
}