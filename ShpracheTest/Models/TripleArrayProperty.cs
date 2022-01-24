using System.Globalization;
using Serilog;

namespace ShpracheTest.Models;

public class TripleArrayProperty : Property
{
    public TripleArrayProperty(string materialName, string name, string value) : base(materialName, name)
    {
        using var log = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();
        
        Name = name;

        string[] doubleArrayComponents = value.Split(',');
        if (doubleArrayComponents.Length != 3)
        {
            log.Warning("The type conversion on the property {Name} failed in material {Material}. Input value is: {Value}. Default value used", name, materialName, value);
            return;
        }
        
        bool firstElement = Double.TryParse(doubleArrayComponents[0].Trim(), NumberStyles.Float, CultureInfo.InvariantCulture,
            out double firstResult);
        
        bool secondElement = Double.TryParse(doubleArrayComponents[1].Trim(), NumberStyles.Float, CultureInfo.InvariantCulture,
            out double secondResult);
        
        bool thirdElement = Double.TryParse(doubleArrayComponents[2].Trim(), NumberStyles.Float, CultureInfo.InvariantCulture,
            out double thirdResult);
        
        if (new[]{firstElement,secondElement, thirdElement}.Any(b => b == false))
        {
            log.Warning("The type conversion on the property {Name} failed in material {Material}. Input value is: {Value}. Default value used", name, materialName, value);
            return;
        }

        Value[0] = firstResult;
        Value[1] = secondResult;
        Value[2] = thirdResult;
    }

    public double[] Value { get; set; } = { 0.0, 0.0, 0.0 };
}