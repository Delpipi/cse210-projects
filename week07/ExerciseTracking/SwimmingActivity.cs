public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetPace()
    {
        return Math.Round(60 / GetSpeed(), 2);
    }

    public override double GetSpeed()
    {
        return Math.Round((GetDistance() / GetLength()) * 60, 2);
    }
}