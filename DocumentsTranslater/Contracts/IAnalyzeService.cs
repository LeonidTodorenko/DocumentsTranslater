using DocumentsTranslater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsTranslater.Contracts
{
    public interface IAnalyzeService
    {
        IResult<IEnumerable<IRegion>> Analyze(string text, RLIParameters parameters);
    }
}
