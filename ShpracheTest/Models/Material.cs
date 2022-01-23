namespace ShpracheTest.Models;

public class Material
{
    public Material(string name, StringProperty filename, DoubleProperty densityXhi, DoubleProperty puasson)
    {
        Name = name;
        Filename = filename;
        DensityXhi = densityXhi;
        Puasson = puasson;
    }

    public string Name { get; set; }
    public StringProperty Filename { get; init; }
    public DoubleProperty DensityXhi { get; init; }
    public DoubleProperty Puasson { get; init; }
}