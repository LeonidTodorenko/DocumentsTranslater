using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsTranslater.Contracts
{
    public interface IRegion
    {
        int StartRegion { get; set; }
        int EndRegion { get; set; }
        string Text { get; set; }
        string Language { get; set; }
        string Alphabet { get; set; }
    }
}
