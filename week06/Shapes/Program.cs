using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("🎨 Welcome to the Fun Shapes Show! 🎉");

        List<Shape> shapes = new List<Shape>();

        for (int i = 0; i < 5; i++)
        {
            Shape shape = ShapeFactory.CreateRandomShape();
            shapes.Add(shape);
        }

        foreach (var shape in shapes)
        {
            shape.Describe();
            Console.WriteLine($"Area: {shape.GetArea():F2}");
            Console.WriteLine("------------------------------");
        }

        Console.WriteLine("🎈 Thanks for exploring fun shapes with us! 🎈");
    }
}
