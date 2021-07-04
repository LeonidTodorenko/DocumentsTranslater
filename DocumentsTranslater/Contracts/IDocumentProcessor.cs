using DocumentsTranslater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsTranslater.Contracts
{
    public interface IDocumentProcessor
    {
        Task<IResult<bool>> OpenFile(string fileName);
        IResult<bool> SaveFile();
        IDocument Document { get; }
        Task<IResult<IEnumerable<IRegion>>> AnalyzeAsync(RLIParameters parameters);
        Task<IResult<IDictionary<string, string>>> CreateIMPagesAsync();
        IDictionary<string, string> IMPages { get; }
        Task<IResult<TranslateJob>> SendToTranslate(string langFrom, string fileName, string text);
        Task<IResult<TranslateJob>> GetJobStatus(string jobName);
        Task<IResult<Tuple<string,string>>> DownloadResults(string jobName);
        Task<IResult<bool>> CreateResultDoc(Dictionary<string, string> dict);
    }
}
