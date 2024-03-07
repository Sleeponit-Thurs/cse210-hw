public class Rectangle : Shape
{
    public Rectangle(double length, double width, string colour) : base (colour)
    {
        _length = length;
        _width = width;

    }
    public override double GetArea()
    {
        double area = _length * _width;
        return area;
    }
    public double _length;
    public double _width;

}