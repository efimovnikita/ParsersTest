using ShpracheTest.Models;
using Serilog;

using var log = new LoggerConfiguration()
    .WriteTo.Console()
    .MinimumLevel.Debug()
    .CreateLogger();

const string input = @"T-Flex Material Library Unicode
Version1370

[Алюминий чистый]
guid	= E61A919C-D234-422D-9AD4-902921CF39BF
guidDOCS	= 00000000-0000-0000-0000-000000000000
coating	= FALSE
description	= Чистые металлы
ambientColor	= 166,166,166
diffuseColor	= 215,218,223
specularColor	= 154,154,154
emissiveColor	= 7,7,7
blendColor	= 146,147,147
shininess	= 0.420000
transparency	= 0.000000
reflection	= 0.300000
index_refraction	= 1.000000
filename	= 
wrapT	= REPEAT
wrapS	= REPEAT
density	= 2.70000000000000e-06
folder	= Чистые металлы
bump	= 
bump_type	= NORMAL
structure	= ISOTROPIC
elasticity	= 0.000000
expansion	= 0.000021
puasson	= 0.000000
thermal_cond	= 0.218000
shear_modulus_xy	= 0.000000
stressT	= 0.000000
stressC	= 0.000000
temprature_cond	= 2700.000000
specific_heat	= 900.000000
yield_strength	= 0.000000
exportinfo	= 
model	= MODULATE
specification_left	= 
specification_top	= 
specification_bottom	= 
specification_right	= 
translate	= 0e+00, 0.000000e+00
rotate	= 0e+00
center	= 0e+00, 0.000000e+00
scale	= 1e+00, 1.000000e+00
coordFunc	= DEFAULT
directionS	= 0e+00, 1.000000e+00, 0.000000e+00
directionT	= 0e+00, 1.000000e+00, 0.000000e+00
patscale	= 25.400000
pattern	= DEFAULT
Fatigue Law	=Empty Fatigue

[Бериллий чистый]
guid	= B37F140D-18EC-4B0F-BCE1-82B7C0873CE6
guidDOCS	= 00000000-0000-0000-0000-000000000000
coating	= FALSE
description	= Чистые металлы
ambientColor	= 98,96,90
diffuseColor	= 196,196,198
specularColor	= 196,196,198
emissiveColor	= 2,2,2
blendColor	= 146,147,147
shininess	= 0.420000
transparency	= 0.000000
reflection	= 0.300000
index_refraction	= 1.000000
filename	= 
wrapT	= REPEAT
wrapS	= REPEAT
density	= 1.85000000000000e-06
folder	= Чистые металлы
bump	= 
bump_type	= NORMAL
structure	= ISOTROPIC
elasticity	= 0.000000
expansion	= 0.000012
puasson	= 0.000000
thermal_cond	= 0.184000
shear_modulus_xy	= 0.000000
stressT	= 0.000000
stressC	= 0.000000
temprature_cond	= 1850.000000
specific_heat	= 1884.000000
yield_strength	= 0.000000
exportinfo	= 
model	= MODULATE
specification_left	= 
specification_top	= 
specification_bottom	= 
specification_right	= 
translate	= 0e+00, 0.000000e+00
rotate	= 0e+00
center	= 0e+00, 0.000000e+00
scale	= 1e+00, 1.000000e+00
coordFunc	= DEFAULT
directionS	= 0e+00, 1.000000e+00, 0.000000e+00
directionT	= 0e+00, 1.000000e+00, 0.000000e+00
patscale	= 25.400000
pattern	= DEFAULT
Fatigue Law	=Empty Fatigue";

log.Information("Start parsing");
try
{
    var library = Library.Parse(input);
    log.Information("Parsed materials count: {@Count}", library.Materials.Count());

    foreach (var material in library.Materials)
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