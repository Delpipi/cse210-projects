public class Circle : Shape
{
    private double _radius = 4;
    public override double GetArea()
    {
        return 3.14 * _radius * _radius;
    }
}