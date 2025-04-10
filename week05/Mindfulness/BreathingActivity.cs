public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "The Breathing Activity";
        _description = "his activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    }

    public void Run()
    {
        int pauseDuration = 5;
        int duration = GetDuration();

        DateTime startDateTime = DateTime.Now;
        DateTime endDateTime = startDateTime.AddSeconds(duration);

        Console.WriteLine();
        while (DateTime.Now < endDateTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(pauseDuration);
            Console.Write("Now Breathe out...");
            ShowCountDown(pauseDuration);
        }
        Console.WriteLine();
    }
}