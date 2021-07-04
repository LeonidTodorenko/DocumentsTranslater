using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsTranslater.Contracts
{
    public interface IDocument
    {
        DocumentType Type {get;}
        string FileName { get; }
        string TranslatedFileName { get; }
        string OriginalPlainText { get; }
        IEnumerable<IRegion> Regions { get; set; }
        int CharsCount { get; }
        int WordsCount { get; }
        int TextBlocksCount { get; }
        IResult<string> GetHtmlView(string language);
        IDictionary<string, string> IMPages { get; set; }
        IResult<bool> ImplementTranslateData(Dictionary<string, string> dict);
        IResult<bool> Simplify();
    }
}
