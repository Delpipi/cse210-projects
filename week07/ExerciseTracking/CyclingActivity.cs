public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return Math.Round(60 / _speed, 2);
    }

    public override double GetDistance()
    {
        return Math.Round((_speed / 60) * GetLength(), 2);
    }

}