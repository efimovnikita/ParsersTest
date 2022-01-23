using System.Text;
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

    private string PrintMaterialsInfo()
    {
        var sb = new StringBuilder();
        foreach (var material in Materials)
        {
            sb.AppendLine(material.Name);
            sb.AppendLine($"{nameof(material.Filename)}: {material.Filename.Value}");
            sb.AppendLine($"{nameof(material.DensityXhi)}: {material.DensityXhi.Value}");
            sb.AppendLine($"{nameof(material.Puasson)}: {material.Puasson.Value}");
            sb.AppendLine();
        }

        return sb.ToString();
    }
    public override string ToString()
    {
        return $"{nameof(Title)}: {Title}, {nameof(Version)}: {Version}, {nameof(Materials)}:\n\n{PrintMaterialsInfo()}";
    }
}