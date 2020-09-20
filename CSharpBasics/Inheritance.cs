using System;

public abstract class Shape
{
    public abstract double GetArea();

    public abstract double GetCircumference();

    public virtual void Display()
    {
        Console.WriteLine($"Displaying result for");
    }

}

public class Square : Shape
{
    public Square(double side)
    {
        Side = side;
    }
    public double Side { get; set; }
    public override double GetArea() => Side * Side;

    public override double GetCircumference() => 4 * Side;

    public override void Display()
    {
        Console.WriteLine($"Area : {GetArea()}");
        Console.WriteLine($"Circimference : {GetCircumference()}");
    }
}

public class Rectangle : Shape
{
    public double Length { get; set; }

    public double Breadth { get; set; }

    public Rectangle(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }

    public override double GetArea() => Length * Breadth;

    public override double GetCircumference() => 2 * (Length + Breadth);
}

public class Circle : Shape
{
    public double Radius { get; set; }


    public override double GetArea() => Math.PI * (Radius * Radius);

    public override double GetCircumference() => 2 * Math.PI * Radius;
}