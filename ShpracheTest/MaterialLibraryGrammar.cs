using ShpracheTest.Models;
using Sprache;

namespace ShpracheTest;

internal static class MaterialLibraryGrammar
{
    private static readonly Parser<string> MaterialNameParser =
        from name in Parse.CharExcept(']').Many().Text().Contained(Parse.Char('['), Parse.Char(']'))
        select name;

    private static readonly Parser<(string name, string value)> PropertyParser =
        from name in Parse.CharExcept(new []{ '=', ' ', '\t', '\n' }).Many().Text().Token()
        from equalChar in Parse.Char('=')
        from value in Parse.AnyChar.Until(Parse.LineEnd).Text().Select(text => text.Trim())
            .Or(Parse.AnyChar.Until(Parse.LineTerminator).Text().Select(text => text.Trim()))
        select (name, value);

    private static readonly Parser<Material> MaterialParser =
        from name in MaterialNameParser
        from filename in PropertyParser.Select(property => new StringProperty(name, property.name, property.value))
        from densityXhi in PropertyParser.Select(property => new DoubleProperty(name, property.name, property.value))
        from puasson in PropertyParser.Select(property => new DoubleProperty(name, property.name, property.value))
        from end in Parse.LineEnd.Text().Optional()
        select new Material(name, filename, densityXhi, puasson);

    public static readonly Parser<Library> LibraryParser =
        from title in Parse.AnyChar.Until(Parse.LineEnd).Text()
        from version in Parse.AnyChar.Until(Parse.LineEnd).Text()
        from space in Parse.LineEnd.Many()
        from materials in MaterialParser.Many()
        select new Library(materials, title, version);
}