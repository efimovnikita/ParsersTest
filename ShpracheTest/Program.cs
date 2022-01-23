using ShpracheTest.Models;
using Serilog;

using var log = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

const string input = @"Lib title
1.3

[БрСр-1_02_03]
filename      = 
density_xhi     = 1.62300000
puasson = 2.34

[Second material]
filename      =
density_xhi     = 3.76200000
puasson = 45.8";

log.Information("Start parsing");
try
{
    var library = Library.Parse(input);
    log.Information("Parsed materials count: {@Count}", library.Materials.Count());
    log.Information("Complete");
}
catch (Exception e)
{
    log.Error(e,"While parsing input error occured");
    log.Warning("Complete with errors");
}