using Serilog;

namespace ShpracheTest.Models;

public class BoolProperty : Property
{
    public BoolProperty(string materialName, string name, string value) : base(materialName, name)
    {
        using var log = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();
        
        Name = name;
        
        if (Boolean.TryParse(value, out var result))
        {
            Value = result;
        }
        else
        {
            log.Warning("The type conversion on the property {Name} failed in material {Material}. Input value is: {Value}. Default value used", name, materialName, value);
            Value = false;
        }
    }

    public bool Value { get; set; }
}