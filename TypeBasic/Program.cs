using System;

public class UnitConverter
{
    int ratio; // Stores the conversion ratio

    public UnitConverter(int unitRatio)
    {
        this.ratio = unitRatio;
    }

    public int Convert(int unit)
    {
        return unit * ratio;
    }
}

class Program
{
    static void Main()
    {
        UnitConverter converter = new UnitConverter(2);
        Console.WriteLine(converter.Convert(5)); // Output: 10
    }
}
