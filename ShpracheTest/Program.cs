// ReSharper disable All

using System.Text;
using Sprache;

var input = @"Lib title
1.3

[БрСр-1_02_03]
filename      = 
density_xhi     = 1.62300000
puasson = 2.34

[Second material]
filename      = 
density_xhi     = 3.76200000
puasson = 3.14";

Parser<string> nameParser =
    from name in Parse.CharExcept(']').Many().Text().Contained(Parse.Char('['), Parse.Char(']'))
    select name;

Parser<Property> propertyParser =
    from name in Parse.CharExcept(new []{ '=', ' ', '\t', '\n' }).Many().Text().Token()
    from equalChar in Parse.Char('=')
    from value in Parse.AnyChar.Until(Parse.LineEnd).Text().Select(text => text.Trim())
        .Or(Parse.AnyChar.Until(Parse.LineTerminator).Text().Select(text => text.Trim()))
    select new Property(name, value);

Parser<Material> materialParser =
    from name in nameParser
    from props in propertyParser.Many()
    from end in Parse.LineEnd.Text().Optional()
    select new Material(props, name);

Parser<Library> libraryParser =
    from title in Parse.AnyChar.Until(Parse.LineEnd).Text()
    from version in Parse.AnyChar.Until(Parse.LineEnd).Text()
    from space in Parse.LineEnd.Many()
    from materials in materialParser.Many()
    select new Library(materials, title, version);

var library = libraryParser.Parse(input);
Console.WriteLine(library);

public class Library
{
    public Library(IEnumerable<Material> materials, string title, string version)
    {
        Materials = materials;
        Title = title;
        Version = version;
    }

    public string Title { get; set; }

    public string Version { get; set; }

    public IEnumerable<Material> Materials { get; set; }
}
public class Material
{
    public Material(IEnumerable<Property> properties, string name)
    {
        Properties = properties;
        Name = name;
    }

    public string Name { get; set; }
    public IEnumerable<Property> Properties { get; set; }
}
public class Property
{
    public Property(string name, string value)
    {
        Name = name;
        Value = value;
    }

    private string Name { get; set; }
    private string Value { get; set; }

    public override string ToString()
    {
        return $"{nameof(Name)}: \"{Name}\", {nameof(Value)}: \"{Value}\"";
    }
}

public class Properties
{
    public Properties(IEnumerable<Property> propertyList)
    {
        PropertyList = propertyList;
    }

    private IEnumerable<Property> PropertyList { get; set; }

    private string Print()
    {
        var sb = new StringBuilder();
        if (PropertyList.Count() == 0)
        {
            sb.AppendLine("Empty");
            return sb.ToString();
        }
        sb.AppendLine();
        foreach (var property in PropertyList)
        {
            sb.AppendLine($"{property.ToString()}");
        }

        return sb.ToString();
    }

    public override string ToString()
    {
        return $"{nameof(PropertyList)}: {Print()}";
    }
}