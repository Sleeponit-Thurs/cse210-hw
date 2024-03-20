public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }
    public void GetFractionString()
    {
        Console.WriteLine($"{_top}/{_bottom}");
    }

    public double ReturnDecimalValue()
    {
        return (double)_top / (double)_bottom;
        
    }

}