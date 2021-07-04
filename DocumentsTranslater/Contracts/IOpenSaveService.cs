using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsTranslater.Contracts
{
    interface IOpenSaveService
    {
        IResult<bool> OpenFile(string fileName);
        Task<IResult<bool>> ImplementTranslatedData(Dictionary<string, string> dict);
        Task<IResult<bool>> SaveResultDoc();
        IDocument Document { get; }
    }
}
