using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsTranslater
{
    /// <summary>
    /// Document supported types
    /// </summary>
    public enum DocumentType
    {
        /// <summary>
        /// Plain text (txt etc.)
        /// </summary>
        PlainText,
        /// <summary>
        /// Word file (docx)
        /// </summary>
        DocX
    }

    public enum Languages
    {
        [Description("English")]
        English,
        [Description("Russian")]
        Russian,
        [Description("French")]
        French,
        [Description("Spain")]
        Spain,
        [Description("Japan")]
        Japan,
        [Description("Chinese")]
        Chinese
    }
}
