using System;
using System.Collections.Generic;

public static class ShapeFactory
{
    private static readonly Random random = new Random();

    public static Shape CreateRandomShape()
    {
        List<string> colors = new List<string> { "Red", "Blue", "Green", "Yellow", "Purple" };
        int shapeType = random.Next(3);
        string color = colors[random.Next(colors.Count)];

        switch (shapeType)
        {
            case 0:
                return new Square(color, random.Next(1, 10));
            case 1:
                return new Rectangle(color, random.Next(1, 10), random.Next(1, 10));
            default:
                return new Circle(color, random.Next(1, 10));
        }
    }
}
