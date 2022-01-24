using ShpracheTest.Models;
using Sprache;

namespace ShpracheTest;

internal static class MaterialLibraryGrammar
{
    private static readonly Parser<string> MaterialNameParser =
        from name in Parse.CharExcept(']').Many().Text().Contained(Parse.Char('['), Parse.Char(']'))
        select name;

    private static readonly Parser<(string name, string value)> PropertyParser =
        from name in Parse.CharExcept(new []{ '=', '\t', '\n' }).Many().Text().Token()
        from equalChar in Parse.Char('=')
        from value in Parse.AnyChar.Until(Parse.LineEnd).Text().Select(text => text.Trim())
            .Or(Parse.AnyChar.Until(Parse.LineTerminator).Text().Select(text => text.Trim()))
        select (name, value);

    private static readonly Parser<Material> MaterialParser =
        from name in MaterialNameParser
        from guid in PropertyParser.Select(property => new GuidProperty(name, property.name, property.value))
        from guidDocs in PropertyParser.Select(property => new GuidProperty(name, property.name, property.value))
        from coating in PropertyParser.Select(property => new BoolProperty(name, property.name, property.value))
        from description in PropertyParser.Select(property => new StringProperty(name, property.name, property.value))
        from ambientColor in PropertyParser.Select(property => new ColorProperty(name, property.name, property.value))
        from diffuseColor in PropertyParser.Select(property => new ColorProperty(name, property.name, property.value))
        from specularColor in PropertyParser.Select(property => new ColorProperty(name, property.name, property.value))
        from emissiveColor in PropertyParser.Select(property => new ColorProperty(name, property.name, property.value))
        from blendColor in PropertyParser.Select(property => new ColorProperty(name, property.name, property.value))
        from shininess in PropertyParser.Select(property => new DoubleProperty(name, property.name, property.value))
        from transparency in PropertyParser.Select(property => new DoubleProperty(name, property.name, property.value))
        from reflection in PropertyParser.Select(property => new DoubleProperty(name, property.name, property.value))
        from indexRefraction in PropertyParser.Select(property => new DoubleProperty(name, property.name, property.value))
        from filename in PropertyParser.Select(property => new StringProperty(name, property.name, property.value))
        from wrapT in PropertyParser.Select(property => new StringProperty(name, property.name, property.value))
        from wrapS in PropertyParser.Select(property => new StringProperty(name, property.name, property.value))
        from density in PropertyParser.Select(property => new DoubleProperty(name, property.name, property.value))
        from folder in PropertyParser.Select(property => new StringProperty(name, property.name, property.value))
        from bump in PropertyParser.Select(property => new StringProperty(name, property.name, property.value))
        from bumpType in PropertyParser.Select(property => new BumpTypeProperty(name, property.name, property.value))
        from structure in PropertyParser.Select(property => new StringProperty(name, property.name, property.value))
        from elasticity in PropertyParser.Select(property => new DoubleProperty(name, property.name, property.value))
        from expansion in PropertyParser.Select(property => new DoubleProperty(name, property.name, property.value))
        from puasson in PropertyParser.Select(property => new DoubleProperty(name, property.name, property.value))
        from thermalCond in PropertyParser.Select(property => new DoubleProperty(name, property.name, property.value))
        from shearModulusXy in PropertyParser.Select(property => new DoubleProperty(name, property.name, property.value))
        from stressT in PropertyParser.Select(property => new DoubleProperty(name, property.name, property.value))
        from stressC in PropertyParser.Select(property => new DoubleProperty(name, property.name, property.value))
        from temperatureCond in PropertyParser.Select(property => new DoubleProperty(name, property.name, property.value))
        from specificHeat in PropertyParser.Select(property => new DoubleProperty(name, property.name, property.value))
        from yieldStrength in PropertyParser.Select(property => new DoubleProperty(name, property.name, property.value))
        from exportInfo in PropertyParser.Select(property => new StringProperty(name, property.name, property.value))
        from model in PropertyParser.Select(property => new StringProperty(name, property.name, property.value))
        from specificationLeft in PropertyParser.Select(property => new StringProperty(name, property.name, property.value))
        from specificationTop in PropertyParser.Select(property => new StringProperty(name, property.name, property.value))
        from specificationBottom in PropertyParser.Select(property => new StringProperty(name, property.name, property.value))
        from specificationRight in PropertyParser.Select(property => new StringProperty(name, property.name, property.value))
        from translate in PropertyParser.Select(property => new DoubleArrayProperty(name, property.name, property.value))
        from rotate in PropertyParser.Select(property => new DoubleProperty(name, property.name, property.value))
        from center in PropertyParser.Select(property => new DoubleArrayProperty(name, property.name, property.value))
        from scale in PropertyParser.Select(property => new DoubleArrayProperty(name, property.name, property.value))
        from coordFunc in PropertyParser.Select(property => new StringProperty(name, property.name, property.value))
        from directionS in PropertyParser.Select(property => new TripleArrayProperty(name, property.name, property.value))
        from directionT in PropertyParser.Select(property => new TripleArrayProperty(name, property.name, property.value))
        from patScale in PropertyParser.Select(property => new DoubleProperty(name, property.name, property.value))
        from pattern in PropertyParser.Select(property => new StringProperty(name, property.name, property.value))
        from fatigueLaw in PropertyParser.Select(property => new StringProperty(name, property.name, property.value))
        from end in Parse.LineEnd.Text().Optional()
        select new Material(name,
            guid,
            guidDocs,
            coating,
            description,
            ambientColor,
            diffuseColor,
            specularColor,
            emissiveColor,
            blendColor,
            shininess,
            transparency,
            reflection,
            indexRefraction,
            filename,
            wrapT,
            wrapS,
            density,
            folder,
            bump,
            bumpType,
            structure,
            elasticity,
            expansion,
            puasson,
            thermalCond,
            shearModulusXy,
            stressT,
            stressC,
            temperatureCond,
            specificHeat,
            yieldStrength,
            exportInfo,
            model,
            specificationLeft,
            specificationTop,
            specificationBottom,
            specificationRight,
            translate,
            rotate,
            center,
            scale,
            coordFunc,
            directionS,
            directionT,
            patScale,
            pattern,
            fatigueLaw
        );

    public static readonly Parser<Library> LibraryParser =
        from title in Parse.AnyChar.Until(Parse.LineEnd).Text()
        from version in Parse.AnyChar.Until(Parse.LineEnd).Text()
        from space in Parse.LineEnd.Many()
        from materials in MaterialParser.Many()
        select new Library(materials, title, version);
}