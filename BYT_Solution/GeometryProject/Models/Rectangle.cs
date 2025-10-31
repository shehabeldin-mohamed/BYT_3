namespace BYT_Solution.Models;

public class Rectangle(double length, double width) : IShape
{
    private readonly double length = length;
    private readonly double width = width;
    
    public double CalculateArea()
    {
        return length * width;
    }

    public double CalculateVolume()
    {
        //no volume for 2d shapes
        return 0;
    }
}