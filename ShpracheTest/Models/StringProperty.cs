namespace ShpracheTest.Models;

public class StringProperty : Property
{
    public StringProperty(string name, string value) : base(name)
    {
        Name = name;
        Value = value;
    }

    public string Value { get; set; }
}