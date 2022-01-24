using System.Drawing;
using System.Globalization;
using Serilog;

namespace ShpracheTest.Models;

public class ColorProperty : Property
{
    public ColorProperty(string materialName, string name, string value) : base(materialName, name)
    {
        using var log = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();
        
        Name = name;

        string[] colorComponents = value.Split(',');
        if (colorComponents.Length != 3)
        {
            log.Warning("The type conversion on the property {Name} failed in material {Material}. Input value is: {Value}. Default value used", name, materialName, value);
            Value = Color.White;
            return;
        }

        bool redTryParse = Int32.TryParse(colorComponents[0], NumberStyles.Integer, CultureInfo.InvariantCulture,
            out int redParseResult);
        
        bool greenTryParse = Int32.TryParse(colorComponents[1], NumberStyles.Integer, CultureInfo.InvariantCulture,
            out int greenParseResult);
        
        bool blueTryParse = Int32.TryParse(colorComponents[2], NumberStyles.Integer, CultureInfo.InvariantCulture,
            out int blueParseResult);

        if (new[]{redTryParse,greenTryParse,blueTryParse}.Any(b => b == false))
        {
            log.Warning("The type conversion on the property {Name} failed in material {Material}. Input value is: {Value}. Default value used", name, materialName, value);
            Value = Color.White;
            return;
        }

        Value = Color.FromArgb(redParseResult, greenParseResult, blueParseResult);
    }

    public Color Value { get; set; }
}