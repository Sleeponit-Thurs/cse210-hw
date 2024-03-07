public class Circle : Shape
{
    public double _radius;
    public Circle(double radius, string colour) : base (colour)
    {
        _radius = radius;
    }


    public override double GetArea()
    {
        double area = (Math.PI * _radius * _radius);
        return area;
    }


}