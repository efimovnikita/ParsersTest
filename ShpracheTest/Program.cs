using System.Text;
using ShpracheTest.Models;
using Serilog;

using var log = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

string metals = File.ReadAllText("/home/maskedball/Downloads/materials.zip_pass_123/materials/metals.mtr", Encoding.Unicode);
string nonMetals = File.ReadAllText("/home/maskedball/Downloads/materials.zip_pass_123/materials/non_metals.mtr", Encoding.Unicode);

log.Information("Start parsing");
try
{
    var metalsLib = Library.Parse(metals);
    var nonMetalsLib = Library.Parse(nonMetals);

    log.Information("Parsed materials count in metals lib: {@Count}", metalsLib.Materials.Count());
    log.Information("Parsed materials count in non metals lib: {@Count}", nonMetalsLib.Materials.Count());

    foreach (var material in metalsLib.Materials)
    { 
        log.Debug("{PropName} {@Info}", nameof(material.Name), material.Name);
        log.Debug("{PropName} {@Info}", nameof(material.Guid), material.Guid);
        log.Debug("{PropName} {@Info}", nameof(material.GuidDocs), material.GuidDocs);
        log.Debug("{PropName} {@Info}", nameof(material.Coating), material.Coating);
        log.Debug("{PropName} {@Info}", nameof(material.Description), material.Description);
        log.Debug("{PropName} {@Info}", nameof(material.AmbientColor), material.AmbientColor);
        log.Debug("{PropName} {@Info}", nameof(material.DiffuseColor), material.DiffuseColor);
        log.Debug("{PropName} {@Info}", nameof(material.SpecularColor), material.SpecularColor);
        log.Debug("{PropName} {@Info}", nameof(material.EmissiveColor), material.EmissiveColor);
        log.Debug("{PropName} {@Info}", nameof(material.BlendColor), material.BlendColor);
        log.Debug("{PropName} {@Info}", nameof(material.Shininess), material.Shininess);
        log.Debug("{PropName} {@Info}", nameof(material.Transparency), material.Transparency);
        log.Debug("{PropName} {@Info}", nameof(material.Reflection), material.Reflection);
        log.Debug("{PropName} {@Info}", nameof(material.IndexRefraction), material.IndexRefraction);
        log.Debug("{PropName} {@Info}", nameof(material.Filename), material.Filename);
        log.Debug("{PropName} {@Info}", nameof(material.WrapT), material.WrapT);
        log.Debug("{PropName} {@Info}", nameof(material.WrapS), material.WrapS);
        log.Debug("{PropName} {@Info}", nameof(material.Density), material.Density);
        log.Debug("{PropName} {@Info}", nameof(material.Folder), material.Folder);
        log.Debug("{PropName} {@Info}", nameof(material.Bump), material.Bump);
        log.Debug("{PropName} {@Info}", nameof(material.BumpType), material.BumpType);
        log.Debug("{PropName} {@Info}", nameof(material.Structure), material.Structure);
        log.Debug("{PropName} {@Info}", nameof(material.Elasticity), material.Elasticity);
        log.Debug("{PropName} {@Info}", nameof(material.Expansion), material.Expansion);
        log.Debug("{PropName} {@Info}", nameof(material.Puasson), material.Puasson);
        log.Debug("{PropName} {@Info}", nameof(material.ThermalCond), material.ThermalCond);
        log.Debug("{PropName} {@Info}", nameof(material.ShearModulusXy), material.ShearModulusXy);
        log.Debug("{PropName} {@Info}", nameof(material.StressT), material.StressT);
        log.Debug("{PropName} {@Info}", nameof(material.StressC), material.StressC);
        log.Debug("{PropName} {@Info}", nameof(material.TemperatureCond), material.TemperatureCond);
        log.Debug("{PropName} {@Info}", nameof(material.SpecificHeat), material.SpecificHeat);
        log.Debug("{PropName} {@Info}", nameof(material.YieldStrength), material.YieldStrength);
        log.Debug("{PropName} {@Info}", nameof(material.ExportInfo), material.ExportInfo);
        log.Debug("{PropName} {@Info}", nameof(material.Model), material.Model);
        log.Debug("{PropName} {@Info}", nameof(material.SpecificationLeft), material.SpecificationLeft);
        log.Debug("{PropName} {@Info}", nameof(material.SpecificationTop), material.SpecificationTop);
        log.Debug("{PropName} {@Info}", nameof(material.SpecificationBottom), material.SpecificationBottom);
        log.Debug("{PropName} {@Info}", nameof(material.SpecificationRight), material.SpecificationRight);
        log.Debug("{PropName} {@Info}", nameof(material.Translate), material.Translate);
        log.Debug("{PropName} {@Info}", nameof(material.Rotate), material.Rotate);
        log.Debug("{PropName} {@Info}", nameof(material.Center), material.Center);
        log.Debug("{PropName} {@Info}", nameof(material.Scale), material.Scale);
        log.Debug("{PropName} {@Info}", nameof(material.CoordFunc), material.CoordFunc);
        log.Debug("{PropName} {@Info}", nameof(material.DirectionS), material.DirectionS);
        log.Debug("{PropName} {@Info}", nameof(material.DirectionT), material.DirectionT);
        log.Debug("{PropName} {@Info}", nameof(material.PatScale), material.PatScale);
        log.Debug("{PropName} {@Info}", nameof(material.Pattern), material.Pattern);
        log.Debug("{PropName} {@Info}", nameof(material.FatigueLaw), material.FatigueLaw);
    }

    log.Information("Complete");
}
catch (Exception e)
{
    log.Error(e,"While parsing input error occured");
    log.Warning("Complete with errors");
}