public abstract class Shape
{
    public Shape(string colour)
    {
        _colour = colour;
    }
    private string _colour;

    public void SetColour(string colour)
    {
        _colour = colour;
    }

    public string GetColour()
    {
        return _colour;
    }

    public abstract double GetArea();


}