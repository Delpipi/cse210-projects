public class Fraction
{

    //Member variables
    private int _top;
    private int _bottom;

    //Constructors
    public Fraction() { }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //Getters and Setters
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SeBottom(int bottom)
    {
        _bottom = bottom;
    }

    //Methods
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDeciamalValue()
    {
        return ((double)_top) / _bottom;
    }
}
