using System;

class Program
{
    static void Main(string[] args)
    {
        //Default constructor
        Fraction fraction1 = new Fraction();
        fraction1.SetTop(1);
        fraction1.SeBottom(1);
        string StrResult1 = fraction1.GetFractionString();
        double DoubleResult1 = fraction1.GetDeciamalValue();
        Console.WriteLine(StrResult1);
        Console.WriteLine(DoubleResult1);

        Fraction fraction2 = new Fraction(5);
        string StrResult2 = fraction2.GetFractionString();
        double DoubleResult2 = fraction2.GetDeciamalValue();
        Console.WriteLine(StrResult2);
        Console.WriteLine(DoubleResult2);

        Fraction fraction3 = new Fraction(3, 4);
        string StrResult3 = fraction3.GetFractionString();
        double DoubleResult3 = fraction3.GetDeciamalValue();
        Console.WriteLine(StrResult3);
        Console.WriteLine(DoubleResult3);


        Fraction fraction4 = new Fraction(1, 3);
        string StrResult4 = fraction4.GetFractionString();
        double DoubleResult4 = fraction4.GetDeciamalValue();
        Console.WriteLine(StrResult4);
        Console.WriteLine(DoubleResult4);

    }
}