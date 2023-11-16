using System;

public class Fraction
{
    private int top;
    private int bottom;

    public Fraction()
    {

        top = 1;
        bottom = 1;
    }

    public Fraction(int topFraction)
    {
        top = topFraction;
        bottom = 1;
    }

    public Fraction(int topFraction, int bottomFraction)
    {
        top = topFraction;
        bottom = bottomFraction;
    }

    public string GetFractionString()
    {

        string text = $"{top}/{bottom}";
        return text;
    }

    public double GetDecimalValue()
    {

        return (double)top / (double)bottom;
    }
}