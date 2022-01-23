using System.Globalization;

namespace ShpracheTest.Models;

public class DoubleProperty : Property
{
    public DoubleProperty(string name, string value) : base(name)
    {
        Name = name;
        Value = Double.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out var result) ? result : 0;
    }

    public double Value { get; set; }
}