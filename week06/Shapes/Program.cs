using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("red", 4.9);
        Console.WriteLine(square1.GetArea());

        Rectangle rectangle1 = new Rectangle("green", 2.5, 4.5);
        Console.WriteLine(rectangle1.GetArea());

        Circle circle1 = new Circle("blue", 8.1);
        Console.WriteLine(circle1.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();
            Console.WriteLine($"The area of the {color} {shape} is {area}");
        }
    }
}