namespace ShpracheTest.Models;

public class StringProperty : Property
{
    public StringProperty(string materialName, string name, string value) : base(materialName, name)
    {
        Name = name;
        Value = value;
    }

    public string Value { get; set; }
}