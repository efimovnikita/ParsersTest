namespace ShpracheTest.Models;

public class Property
{
    protected Property(string name)
    {
        Name = name;
    }

    protected string Name { get; set; }
}