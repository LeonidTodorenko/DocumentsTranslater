using DocumentsTranslater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsTranslater.Contracts
{
    public interface ITranslateService
    {
        Task<IResult<TranslateJob>> SendForTranslate(string langFrom, string fileName, string text);
        Task<IResult<TranslateJob>> GetJobStatus(string jobName);
        IResult<IEnumerable<string>> DownloadResults(string jobName);
    }
}