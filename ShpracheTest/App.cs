using System.CommandLine;
using System.Text;
using Serilog;
using Serilog.Core;
using ShpracheTest.Models;

namespace ShpracheTest
{
    internal class App
    {
        private Logger? _log;

        public int Run(string[] args)
        {
            Option<FileInfo> inputFileOption = new("--input", "Path to the library file in .mtr format");

            var rootCommand = new RootCommand
            {
                inputFileOption
            };

            rootCommand.Description = "Library converter tool";

            _log = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

            rootCommand.SetHandler((FileInfo? fileInfo) =>
            {
                bool validationStatus = Validate(fileInfo);
                if (validationStatus)
                {
                    Handler(fileInfo);
                }
            }, inputFileOption);

            return rootCommand.Invoke(args);
        }

        private bool Validate(FileSystemInfo? fileInfo)
        {
            if (fileInfo == null)
            {
                _log?.Error("Library file path not specified");
                return false;
            }

            if (fileInfo.Exists)
            {
                return true;
            }

            _log?.Error("The file was not found");
            return false;
        }

        private void Handler(FileSystemInfo? fileInfo)
        {
            string text = File.ReadAllText(fileInfo!.FullName, Encoding.Unicode);

            _log?.Information("Start reading material library");
            try
            {
                var library = Library.Parse(text);
                _log?.Information("The number of materials that have been read from the library file: {@Count}",
                    library.Materials.Count());
                _log?.Information("Completed");
            }
            catch (Exception e)
            {
                _log?.Error(e, "There were errors while parsing the file");
                _log?.Warning("Completed with errors");
            }
        }
    }
}