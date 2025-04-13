public class ChecklistGoal : Goal
{

    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int bonus, int target) : base(shortName, description, points)
    {
        _bonus = bonus;
        _target = target;
        _amountCompleted = 0;
    }

    public ChecklistGoal(string shortName, string description, int points, int bonus, int target, int amountCompleted) : base(shortName, description, points)
    {
        _bonus = bonus;
        _target = target;
        _amountCompleted = amountCompleted;
    }

    public override string GetDetailsString()
    {
        string stauts = "[ ]";
        if (IsComplete())
        {
            stauts = "[X]";
        }
        return $"{stauts} {GetShortName()} ({GetDescription()}) -- Currently completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_amountCompleted}";
    }

    public override bool IsComplete()
    {
        if (_target == _amountCompleted)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void RecordEvent()
    {
        int points = GetPoints();
        _amountCompleted++;
        if (IsComplete())
        {
            points = GetPoints() + _bonus;
        }
        Console.WriteLine($"Congratulations!, You have earned {points} points!");
    }
}