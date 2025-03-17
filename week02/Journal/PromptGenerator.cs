public class PromptGenerator
{
    //Member variables
    Random randomGenerator = new Random();
    public List<string> _prompts = new List<string>();

    //Constructor
    public PromptGenerator() { }

    //Methods
    public void createPromptList()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
    }

    public string GetRandomPrompt()
    {
        int index = randomGenerator.Next(0, _prompts.Count - 1);
        return _prompts[index];
    }
}