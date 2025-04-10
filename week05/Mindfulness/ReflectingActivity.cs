public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<int> _usedPromptIndices;
    private List<int> _usedQuestionIndices;

    public ReflectingActivity()
    {
        _name = "The Reflecting Activity";
        _description = "his activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        ];
        _questions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];
        _usedPromptIndices = new List<int>();
        _usedQuestionIndices = new List<int>();
    }


    public void Run()
    {
        int pauseDuration = 5;
        int duration = GetDuration();

        DateTime startDateTime = DateTime.Now;
        DateTime endDateTime = startDateTime.AddSeconds(duration);

        DisplayPrompt();

        Console.Write("You may begin in: ");
        ShowCountDown(pauseDuration);

        while (DateTime.Now < endDateTime)
        {
            DisplayQuestions();
            Console.WriteLine();
        }
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt\n");
        Console.WriteLine($"-----{prompt}-----\n");
        Console.WriteLine("When you have something in mind, press enter to continue.\n");
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
    }

    public void DisplayQuestions()
    {
        int pauseDuration = 5;
        string question = GetRandomQuestion();
        Console.Write($"{question} ");
        ShowSpinner(pauseDuration);
    }

    public string GetRandomPrompt()
    {
        int index;
        Random random = new Random();

        if (_usedPromptIndices.Count == _prompts.Count)
        {
            _usedPromptIndices.Clear();
        }

        do
        {
            index = random.Next(0, _prompts.Count);
        } while (_usedPromptIndices.Contains(index));

        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        int index;
        Random random = new Random();

        if (_usedQuestionIndices.Count == _questions.Count)
        {
            _usedQuestionIndices.Clear();
        }

        do
        {
            index = random.Next(0, _questions.Count);
        } while (_usedQuestionIndices.Contains(index));

        return _questions[index];
    }

}