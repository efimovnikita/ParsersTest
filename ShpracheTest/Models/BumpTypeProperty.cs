using Serilog;

namespace ShpracheTest.Models;

public class BumpTypeProperty : Property
{
    public BumpTypeProperty(string materialName, string name, string value) : base(materialName, name)
    {
        using var log = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();
        
        Name = name;

        switch (value)
        {
            case "PARALLAX":
                Value = BumpType.Parallax;
                break;
            case "NORMAL":
                Value = BumpType.Normal;
                break;
            case "NONE":
                Value = BumpType.None;
                break;
            default:
                log.Warning("The type conversion on the property {Name} failed in material {Material}. Input value is: {Value}. Default value used", name, materialName, value);
                Value = BumpType.Normal;
                break;
        }
    }

    public BumpType Value { get; set; }
}