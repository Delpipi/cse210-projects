public class Rectangle : Shape
{
    private double _length = 6;
    private double _width = 8;

    public override double GetArea()
    {
        return _length * _width;
    }
}