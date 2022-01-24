namespace ShpracheTest.Models;

public class Material
{
    public Material(string name,
        GuidProperty guid,
        GuidProperty guidDocs,
        BoolProperty coating,
        StringProperty description,
        ColorProperty ambientColor,
        ColorProperty diffuseColor,
        ColorProperty specularColor,
        ColorProperty emissiveColor,
        ColorProperty blendColor,
        DoubleProperty shininess,
        DoubleProperty transparency,
        DoubleProperty reflection,
        DoubleProperty indexRefraction,
        StringProperty filename,
        StringProperty wrapT,
        StringProperty wrapS,
        DoubleProperty density,
        StringProperty folder,
        StringProperty bump,
        BumpTypeProperty bumpType,
        StringProperty structure,
        DoubleProperty elasticity,
        DoubleProperty expansion,
        DoubleProperty puasson,
        DoubleProperty thermalCond,
        DoubleProperty shearModulusXy,
        DoubleProperty stressT,
        DoubleProperty stressC,
        DoubleProperty temperatureCond,
        DoubleProperty specificHeat,
        DoubleProperty yieldStrength,
        StringProperty exportInfo,
        StringProperty model,
        StringProperty specificationLeft,
        StringProperty specificationTop,
        StringProperty specificationBottom,
        StringProperty specificationRight,
        DoubleArrayProperty translate,
        DoubleProperty rotate,
        DoubleArrayProperty center,
        DoubleArrayProperty scale,
        StringProperty coordFunc,
        TripleArrayProperty directionS,
        TripleArrayProperty directionT,
        DoubleProperty patScale,
        StringProperty pattern,
        StringProperty fatigueLaw
    )
    {
        Name = name;
        Guid = guid;
        GuidDocs = guidDocs;
        Coating = coating;
        Description = description;
        AmbientColor = ambientColor;
        DiffuseColor = diffuseColor;
        SpecularColor = specularColor;
        EmissiveColor = emissiveColor;
        BlendColor = blendColor;
        Shininess = shininess;
        Transparency = transparency;
        Reflection = reflection;
        IndexRefraction = indexRefraction;
        Filename = filename;
        WrapT = wrapT;
        WrapS = wrapS;
        Density = density;
        Folder = folder;
        Bump = bump;
        BumpType = bumpType;
        Structure = structure;
        Elasticity = elasticity;
        Expansion = expansion;
        Puasson = puasson;
        ThermalCond = thermalCond;
        ShearModulusXy = shearModulusXy;
        StressT = stressT;
        StressC = stressC;
        TemperatureCond = temperatureCond;
        SpecificHeat = specificHeat;
        YieldStrength = yieldStrength;
        ExportInfo = exportInfo;
        Model = model;
        SpecificationLeft = specificationLeft;
        SpecificationTop = specificationTop;
        SpecificationBottom = specificationBottom;
        SpecificationRight = specificationRight;
        Translate = translate;
        Rotate = rotate;
        Center = center;
        Scale = scale;
        CoordFunc = coordFunc;
        DirectionS = directionS;
        DirectionT = directionT;
        PatScale = patScale;
        Pattern = pattern;
        FatigueLaw = fatigueLaw;
    }

    public string Name { get; set; }
    public GuidProperty Guid { get; set; }
    public GuidProperty GuidDocs { get; set; }
    public BoolProperty Coating { get; set; }
    public StringProperty Description { get; set; }
    public ColorProperty AmbientColor { get; set; }
    public ColorProperty DiffuseColor { get; set; }
    public ColorProperty SpecularColor { get; set; }
    public ColorProperty EmissiveColor { get; set; }
    public ColorProperty BlendColor { get; set; }
    public DoubleProperty Shininess { get; set; }
    public DoubleProperty Transparency { get; set; }
    public DoubleProperty Reflection { get; set; }
    public DoubleProperty IndexRefraction { get; set; }
    public StringProperty Filename { get; set; }
    public StringProperty WrapT { get; set; }
    public StringProperty WrapS { get; set; }
    public DoubleProperty Density { get; set; }
    public StringProperty Folder { get; set; }
    public StringProperty Bump { get; set; }
    public BumpTypeProperty BumpType { get; set; }
    public StringProperty Structure { get; set; }
    public DoubleProperty Elasticity { get; set; }
    public DoubleProperty Expansion { get; set; }
    public DoubleProperty Puasson { get; set; }
    public DoubleProperty ThermalCond { get; set; }
    public DoubleProperty ShearModulusXy { get; set; }
    public DoubleProperty StressT { get; set; }
    public DoubleProperty StressC { get; set; }
    public DoubleProperty TemperatureCond { get; set; }
    public DoubleProperty SpecificHeat { get; set; }
    public DoubleProperty YieldStrength { get; set; }
    public StringProperty ExportInfo { get; set; }
    public StringProperty Model { get; set; }
    public StringProperty SpecificationLeft { get; set; }
    public StringProperty SpecificationTop { get; set; }
    public StringProperty SpecificationBottom { get; set; }

    public StringProperty SpecificationRight { get; set; }
    public DoubleArrayProperty Translate { get; set; }
    public DoubleProperty Rotate { get; set; }
    public DoubleArrayProperty Center { get; set; }
    public DoubleArrayProperty Scale { get; set; }
    public StringProperty CoordFunc { get; set; }
    public TripleArrayProperty DirectionS { get; set; }
    public TripleArrayProperty DirectionT { get; set; }
    public DoubleProperty PatScale { get; set; }
    public StringProperty Pattern { get; set; }
    public StringProperty FatigueLaw { get; set; }
}