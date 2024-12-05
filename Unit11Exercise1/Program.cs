using System;
using System.Drawing;

public class Program
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle();
        circle.Radius = 10;
        Console.WriteLine(circle.Area());
        Console.WriteLine(circle);
        circle.Color = "yellow";
        Console.WriteLine(circle);

        Cylinder cylinder = new Cylinder();
        cylinder.Radius = 10;
        cylinder.Height = 10;
        Console.WriteLine(cylinder.Volume());
        Console.WriteLine(cylinder);
        cylinder.Color = "blue";
        Console.WriteLine(cylinder);
    }
}

public class Circle
{
    private int radius;
    private string color = "";

    public int Radius { get { return radius; } set { radius = value; } }
    public string Color { get { return color; } set { color = value; } }

    public double Area()
    {
        return Math.Pow(radius, 2) * Math.PI;
    }

    public override string ToString()
    {
        if (color.Equals(""))
        {
            return "This circle has a radius of " + radius + " and no color";
        }

        return "This circle has a radius of " + radius + " and the color of " + color;
    }
}

public class Cylinder : Circle
{
    private int height;

    public int Height { get { return height; } set { height = value; } }

    public override string ToString()
    {
        if (Color.Equals(""))
        {
            return "This cylinder has a radius of " + Radius + ", a height of " + height + " and no color";
        }

        return "This cylinder has a radius of " + Radius + ", a height of " + height + " and the color of " + Color;
    }

    public double Volume()
    {
        return Area() * height;
    }
}