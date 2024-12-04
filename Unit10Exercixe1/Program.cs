using System;

public class Unit10
{
    public static void Main(string[] args)
    {
        Fan fan1 = new Fan();
        fan1.Speed = Fan.SLOW;
        fan1.Radius = 10;
        fan1.Color = "yellow";
        fan1.On = true;
        Console.WriteLine(fan1.ToString());

        Fan fan2 = new Fan();
        fan2.Speed = Fan.MEDIUM;
        fan2.Radius = 5;
        fan2.Color = "blue";
        fan2.On = false;
        Console.WriteLine(fan2.ToString());
    }
}


public class Fan
{
    public const int SLOW = 1, MEDIUM = 2, FAST = 3;
    private int speed = SLOW;
    private bool on = false;
    private double radius = 5.0;
    private string color = "blue";

   

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public bool On
    {
        get { return on; }
        set { on = value; }
    }

    public double Radius
    {
        get { return  radius; }
        set { radius = value; }
    }

    public string Color
    {
        get { return color; }
        set {  color = value; }
    }

    public override string ToString()
    {
        if (on)
        {
            return "Speed = " + speed + ", color = " + color + ", radius = " + radius + ", fan is on.";
        }

        return "Color = " + color + ", radius = " + radius + ", fan is off.";
    }
}