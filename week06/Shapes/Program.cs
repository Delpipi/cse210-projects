using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square();
        double areaSquare = square.GetArea();
        Console.WriteLine($"The area of the sqaure is : {areaSquare}");
        Console.WriteLine();

        Rectangle rectangle = new Rectangle();
        double areaRectangle = rectangle.GetArea();
        Console.WriteLine($"The area of the rectangle is : {areaRectangle}");
        Console.WriteLine();

        Circle circle = new Circle();
        double areaCirle = circle.GetArea();
        Console.WriteLine($"The area of the circle is : {areaCirle}");
        Console.WriteLine();
    }
}