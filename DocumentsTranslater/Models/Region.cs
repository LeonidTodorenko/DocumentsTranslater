using DocumentsTranslater.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsTranslater.Models
{
    class Region : IRegion
    {
        public int StartRegion { get; set; }

        public int EndRegion { get; set; }

        public string Text { get; set; }


        public string Language { get; set; }

        public string Alphabet { get; set; }
    }
}
