using ShpracheTest.Models;

const string input = @"Lib title
1.3

[БрСр-1_02_03]
filename      = 
density_xhi     = 1.62300000
puasson = 2.34

[Second material]
filename      =
density_xhi     = 3.76200000
puasson = 3.14";

var library = Library.Parse(input);
Console.WriteLine(library);