using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentsTranslater.Contracts;

namespace DocumentsTranslater.Models
{
    class Paragraph
    {
        public Paragraph()
        {
            TextBlocks = new List<TextBlock>();
        }

        public string Name { get; set; }
        public IList<TextBlock> TextBlocks { get; set; }
    }

    class TextBlock
    {
        public string Name { get; set; }
        public string Text { get; set; }
    }

    class TextHyperLink : TextBlock
    {
        public string Url { get; set; }
    }
}
