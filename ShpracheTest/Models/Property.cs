namespace ShpracheTest.Models;

public class Property
{
    protected Property(string materialName, string name)
    {
        Name = name;
        MaterialName = materialName;
    }

    protected string Name { get; set; }
    public string MaterialName { get; set; }
}