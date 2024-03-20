using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        fraction1.GetFractionString();
        fraction1.ReturnDecimalValue();
        Fraction fraction2 = new Fraction(7,4);
        fraction2.GetFractionString();
        Console.WriteLine(fraction2.ReturnDecimalValue());
    }
}