using System.Reflection.Metadata.Ecma335;

public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double area = 3.1415926535897932384626433832795 * (_radius * _radius);
        return area;
    }
}