using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsTranslater.Models
{
    public class RLIParameters
    {
        public int? AmbThreshold { get; set; }
        public int? HintWeight { get; set; }
        public int? InvThreshold { get; set; }
        public int? Depth { get; set; }
        public int? ValidChars { get; set; }
        public int? ShortThreshold { get; set; }
        public int Best { get; set; }
        public bool BreakRegionOnScriptBoundary { get; set; }
    }
}
