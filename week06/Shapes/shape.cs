using System;

public abstract class Shape
{
    public string Name { get; set; }
    public string Color { get; set; }

    public Shape(string name, string color)
    {
        Name = name;
        Color = color;
    }

    public abstract double GetArea();

    public virtual void Describe()
    {
        Console.WriteLine($"I am a {Color} {Name}!");
    }
}
