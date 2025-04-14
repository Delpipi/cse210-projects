public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return Math.Round((_distance / GetLength()) * 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round(60 / GetSpeed(), 2);
    }

}