using System.Globalization;
using Serilog;

namespace ShpracheTest.Models;

public class DoubleProperty : Property
{
    public DoubleProperty(string materialName, string name, string value) : base(materialName, name)
    {
        using var log = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();
        
        Name = name;
        
        if (Double.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out var result))
        {
            Value = result;
        }
        else
        {
            log.Warning("The type conversion on the property {Name} failed in material {Material}. Input value is: {Value}. Default value used", name, materialName, value);
            Value = 0;
        }
    }

    public double Value { get; set; }
}