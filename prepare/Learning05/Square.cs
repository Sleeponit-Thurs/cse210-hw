public class Square : Shape
{
    public Square(double side, string colour) : base (colour)
    {
        _side = side;
    }
    public double _side;
    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }
}