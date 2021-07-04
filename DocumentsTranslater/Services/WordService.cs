using DocumentFormat.OpenXml.Packaging;
using DocumentsTranslater.Contracts;
using DocumentsTranslater.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DocumentsTranslater.Services
{
    class WordService : IOpenSaveService
    {
        public IDocument Document { get; private set; }

        public IResult<bool> OpenFile(string fileName)
        {
            try
            {
                //first it needs create a copy of the file
                //the next actions will be with that file
                var fi = new FileInfo(fileName);
                var newFi = fi.CopyTo(string.Format("{0}/{1}{2}", fi.DirectoryName, fi.Name.Replace(fi.Extension, string.Empty), ".!docx"), true);

                using (var doc = WordprocessingDocument.Open(newFi.FullName, true))
                {
                    Document = new WordDocument(fileName, newFi.FullName, doc.MainDocumentPart.Document);
                    Document.Simplify();
                    return new Result<bool>(true);
                }
            }
            catch (Exception ex)
            {
                return new Result<bool>(false, ex.Message);
            }
        }

        public Task<IResult<bool>> ImplementTranslatedData(Dictionary<string, string> dict)
        {
            return Task.Factory.StartNew<IResult<bool>>(() =>
                {
                    using (var doc = WordprocessingDocument.Open(Document.TranslatedFileName, true))
                    {
                        Document = new WordDocument(Document.TranslatedFileName, Document.TranslatedFileName, doc.MainDocumentPart.Document);
                        var res = Document.ImplementTranslateData(dict);
                        return res;
                    }
                });
        }

        public Task<IResult<bool>> SaveResultDoc()
        {
            return Task.Factory.StartNew<IResult<bool>>(() =>
                {
                    try
                    {
                        var fi = new FileInfo(Document.TranslatedFileName);
                        var newName = fi.FullName.Replace(fi.Extension, string.Empty);
                        newName += "_translated.docx";
                        fi.MoveTo(newName);
                        return new Result<bool>(true);
                    }
                    catch(Exception ex)
                    {
                        return new Result<bool>(false, ex.Message);
                    }
                });
        }
    }
}
