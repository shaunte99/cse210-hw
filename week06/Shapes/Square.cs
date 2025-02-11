using System;

public class Square : Shape
{
    public double Side { get; set; }

    public Square(string color, double side) : base("Square", color)
    {
        Side = side;
    }

    public override double GetArea()
    {
        return Side * Side;
    }

    public override void Describe()
    {
        base.Describe();
        Console.WriteLine($"I have equal sides of length {Side}. I'm a perfect square!");
    }
}
