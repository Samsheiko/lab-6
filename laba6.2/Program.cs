using System;

public class Point
{
    public double x;
    public double y;

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double CalculateDistance()
    {
        return Math.Sqrt(x * x + y * y);
    }
}