using Sprache;

namespace ShpracheTest.Models;

public class Library
{
    public Library(IEnumerable<Material> materials, string title, string version)
    {
        Materials = materials;
        Title = title;
        Version = version;
    }

    public string Title { get; init; }

    public string Version { get; init; }

    public IEnumerable<Material> Materials { get; init; }

    public static Library Parse(string text) => MaterialLibraryGrammar.LibraryParser.Parse(text);
}