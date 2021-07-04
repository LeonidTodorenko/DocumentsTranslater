using DocumentsTranslater.Contracts;
using DocumentsTranslater.Models;
using DocumentsTranslater.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsTranslater.Services
{
    class BashAnalyzeService : IAnalyzeService
    {
        public BashAnalyzeService(string clientPath, string rootDirectory)
        {
            _clientPath = clientPath;
            _root = rootDirectory;
        }

        public IResult<IEnumerable<IRegion>> Analyze(string text, RLIParameters parameters)
        {
            var tempFile = Path.GetTempFileName();

            try
            {
                //store text to tempfile
                File.WriteAllText(tempFile, text);

                var processInfo = new ProcessStartInfo
                {
                    FileName = _clientPath,
                    UseShellExecute = false,
                    RedirectStandardOutput = true, 
                    CreateNoWindow = true,
                    Arguments = GetArgumentsString(tempFile, parameters)   // string.Format("{0} {1} -multilingual", _root, tempFile)
                };

                using(var process = Process.Start(processInfo))
                {
                    using(var reader = process.StandardOutput)
                    {
                        var result = reader.ReadToEnd();
                        return ParseRegions(result, tempFile);
                    }
                }
            }
            catch(Exception ex)
            {
                return new Result<IEnumerable<IRegion>>(null, ex.Message);
            }
            finally
            {
                if(File.Exists(tempFile))
                    File.Delete(tempFile);
            }

        }

        private string GetArgumentsString(string tempFile, RLIParameters parameters)
        {
            var sb = new StringBuilder();

            sb.Append(_root);
            sb.Append(" ");
            sb.Append(tempFile);

            if (parameters.AmbThreshold.HasValue)
                sb.Append(string.Format(" -ambiguityThreshold {0} ", parameters.AmbThreshold.Value));
            sb.Append(" -best " + parameters.Best);
            if(parameters.BreakRegionOnScriptBoundary)
                sb.Append(" -breakRegionOnScriptBoundary ");
            if(parameters.Depth.HasValue)
                sb.Append(string.Format(" -depth {0}", parameters.Depth.Value));
            if(parameters.InvThreshold.HasValue)
                sb.Append(string.Format(" -invalidityThreshold {0} ", parameters.InvThreshold.Value));
            if (parameters.ShortThreshold.HasValue)
                sb.Append(string.Format(" -shortStringThreshold {0} ", parameters.ShortThreshold.Value));
            if(parameters.ValidChars.HasValue)
                sb.Append(string.Format(" -minValidChars {0} ", parameters.ValidChars.Value));

            sb.Append(" -multilingual"); //this parameter is required for this application

            return sb.ToString();
        }

        private IResult<IEnumerable<IRegion>> ParseRegions(string text, string tempFile)
        {
            //if the first string of the result is not equals this one return an error of parsing
            var lines = text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            if(!lines.Any() || !lines.First().Equals(tempFile))
            {
                return new Result<IEnumerable<IRegion>>(null);
            }

            var regions = new List<Region>();

            var arr = lines.Skip(1).ToArray(); //first string is a parsing file name
            for (var i = 0; i < arr.Length / 2; i++ )
            {
                var line = arr[i * 2] + " " + arr[i * 2 + 1];
                var items = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    regions.Add(new Region
                    {
                        Alphabet = items.Count() == 8 ? items[6] : items[7],
                        EndRegion = int.Parse(items[4]),
                        Language = items.Count() == 8 ? items[5] : items[5],
                        StartRegion = int.Parse(items[2])
                    });
                }
                catch (Exception ex)
                {
                    return new Result<IEnumerable<IRegion>>(null, ex.Message);
                }
            }

            return new Result<IEnumerable<IRegion>>(regions);
        }

        private readonly string _clientPath;
        private readonly string _root;
    }
}
