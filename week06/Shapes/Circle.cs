using System;

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(string color, double radius) : base("Circle", color)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override void Describe()
    {
        base.Describe();
        Console.WriteLine($"I have a radius of {Radius}. I'm round and perfect for rolling!");
    }
}
