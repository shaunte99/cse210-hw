using System;

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(string color, double width, double height) : base("Rectangle", color)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }

    public override void Describe()
    {
        base.Describe();
        Console.WriteLine($"My width is {Width}, and my height is {Height}. I'm a versatile shape!");
    }
}
