using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square1 = new Square(2,"red");
        Circle circle1 = new Circle(5,"blue");
        Rectangle rectangle1 = new Rectangle(4,7,"green");
        shapes.Add(square1);
        shapes.Add(circle1);
        shapes.Add(rectangle1);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColour();

            double area = shape.GetArea();

            Console.WriteLine($"The shape is {color}, and has an area of {area}.");
        }
    }
}