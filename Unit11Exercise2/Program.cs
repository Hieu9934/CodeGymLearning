using System;

public class Program
{
    public static void Main(string[] args)
    {
        Point2D point1 = new Point2D();
        point1.SetXY(1, 2);
        Console.WriteLine(point1);
        float[] array1 = point1.GetXY();
        foreach (float f in array1)
        {
            Console.WriteLine(f);
        }

        Point3D point2 = new Point3D();
        point2.SetXY(3, 4);
        Console.WriteLine(point2);
        float[] array2 = point2.GetXY();
        foreach (float f in array2)
        {
            Console.WriteLine(f);
        }
        point2.SetXYZ(5, 6, 7);
        Console.WriteLine(point2);
        float[] array3 = point2.GetXYZ();
        foreach (float f in array3)
        {
            Console.WriteLine(f);
        }
    }
}

public class Point2D {
    private float x, y;

    public float X { get { return x; } set { x = value; } }
    public float Y { get { return y; } set { y = value; } }
    public void SetXY(float x, float y)
    {
        this.x = x;
        this.y = y;
    }
    public float[] GetXY()
    {
        return new float[] { this.x, this.y };
    }

    public override string ToString()
    {
        return "(" + x + ", " + y + ")";
    }
}

public class Point3D : Point2D {
    private float z;
    public float Z { get { return z; } set { z = value; } }
    public void SetXYZ(float x, float y, float z) {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public float[] GetXYZ()
    {
        return new float[]{ this.X, this.Y, this.Z };
    }
    public override string ToString()
    {
        return "(" + this.X + ", " + this.Y + ", " + z + ")";
    }
}