using DocumentFormat.OpenXml.Packaging;
using DocumentsTranslater.Contracts;
using DocumentsTranslater.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace DocumentsTranslater.Models
{
    class WordDocument : IDocument
    {
        public WordDocument(string fileName, string newFileName, DocumentFormat.OpenXml.Wordprocessing.Document doc)
        {
            var textBlocks = doc.MainDocumentPart.Document.Body.ChildElements.Where(p => !string.IsNullOrWhiteSpace(p.InnerText));
            FileName = fileName;
            TranslatedFileName = newFileName;
            var strings = GetPlainText(textBlocks);
            OriginalPlainText = strings.Any() ? strings.Aggregate((a, b) => a + b) : string.Empty;
            CharsCount = OriginalPlainText.Count();
            WordsCount = GetWordsCount(OriginalPlainText);
            TextBlocksCount = textBlocks.Count();
            _doc = doc;
        }

        public DocumentType Type
        {
            get { return DocumentType.DocX; }
        }

        public string FileName { get; private set; }
        public string TranslatedFileName { get; private set; }
        public string OriginalPlainText { get; private set; }
        public string TranslatedPlainText { get; private set; }

        public IEnumerable<IRegion> Regions { get; set; }
        public IDictionary<string, string> IMPages { get; set; }
        public int CharsCount { get; private set; }
        public int WordsCount { get; private set; }
        public int TextBlocksCount { get; private set; }

        public IResult<string> GetHtmlView(string language)
        {
            var sb = new StringBuilder();
            var regions = Regions.Where(r => r.Language == language);

            sb.AppendLine("<!DOCTYPE html>");
            sb.AppendLine("<html>");
            sb.AppendLine("<head>");
            sb.AppendLine("<title></title>");
            sb.AppendLine("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\">");
            sb.AppendLine("</head>");

            foreach (var item in _doc.MainDocumentPart.Document.Body.ChildElements)
            {
                if (item is DocumentFormat.OpenXml.Wordprocessing.Paragraph)
                {
                    var p = item as DocumentFormat.OpenXml.Wordprocessing.Paragraph;
                    var txts = GetPlainText((new[] { p }).ToList());
                    if(!txts.Any())
                        continue;
                    Regex rgx = new Regex("\\W");
                    var txt = txts.Select(t => rgx.Replace(t, "")).Aggregate((a, b) => a + b);
                    if(regions.Any(r => rgx.Replace(r.Text, "").Contains(txt)))
                    {
                        sb.AppendLine(string.Format("<p id=\"{0}\">", item.GetAttributes().Single(a => a.LocalName == IdName).Value));
                        foreach(var sub in item.ChildElements)
                        {
                            if (sub is Run)
                            {
                                if(sub.PreviousSibling() is Run)
                                {
                                    var text = sub.Elements().Any(e => e.LocalName == "t") ? sub.InnerText : string.Empty;
                                    if(!string.IsNullOrWhiteSpace(text))
                                        sb.Append(string.Format("<b id=\"{0}\">{1}</b>", sub.GetAttributes().Single(a => a.LocalName == IdName).Value, text));
                                }
                                else
                                    sb.Append(string.Format("<span id=\"{0}\">{1}</span>", sub.GetAttributes().Single(a => a.LocalName == IdName).Value, sub.InnerText));
                            }
                            if(sub is Hyperlink)
                                sb.AppendLine(string.Format("<a id=\"{0}\" href=\"#\">{1}</a>", sub.GetAttributes().Single(a => a.LocalName == IdName).Value, sub.InnerText));
                        }
                        sb.AppendLine("</p>");
                    }

                }
                if(item is Table)
                {
                    sb.AppendLine("<table>");
                    foreach(var tr in item.ChildElements.Where(i => i is TableRow))
                    {
                        sb.AppendLine("<tr>");
                        var ths = tr.ChildElements.Where(i => i is TableHeader);
                        if(ths.Any())
                        {
                            foreach(var th in ths)
                            {
                                sb.AppendLine("<th>");
                                    sb.AppendLine(string.Format("<span>{0}</span>", th.InnerText));
                                sb.AppendLine("</th>");
                            }
                        }
                        var tds = tr.ChildElements.Where(i => i is TableCell);
                        if(tds.Any())
                        {
                            foreach(var td in tds)
                            {
                                sb.AppendLine("<td>");
                                    sb.AppendLine(string.Format("<span>{0}</span>", td.InnerText));
                                sb.AppendLine("</td>");
                            }
                        }
                        sb.AppendLine("</tr>");
                    }
                    sb.AppendLine("</table>");
                }
            }

            sb.AppendLine("</html>"); 
            return new Result<string>(sb.ToString());
        }

        public IResult<bool> Simplify()
        {
            //Remove all BookMarkStarts and BookMarkends
            foreach (var par in _doc.Body.ChildElements.Where(p => !string.IsNullOrWhiteSpace(p.InnerText) && p.HasChildren))
            {
                var starts = par.Elements<BookmarkStart>();
                var ends = par.Elements<BookmarkEnd>();
                if(starts.Any() && ends.Any())
                {
                    starts.ToList().ForEach(b => par.RemoveChild(b));
                    ends.ToList().ForEach(b => par.RemoveChild(b));
                }

                if (!par.GetAttributes().Any(a => a.LocalName == IdName))
                {
                    var attr = new OpenXmlAttribute();
                    attr.LocalName = IdName;
                    attr.Value = Helpers.Counter.GetCurrentValue().ToString();
                    par.SetAttribute(attr);
                }
            }

            //we need to remove runs with similar formatting
            foreach(var par in _doc.Body.ChildElements.Where(p => !string.IsNullOrWhiteSpace(p.InnerText) && p.HasChildren))
            {
                var runs = par.ChildElements;
                //skip the first element and all are not runs and hyperlinks
                for(var i = 1; i < runs.Count(); i++)
                {
                    if (!runs[i].GetAttributes().Any(a => a.LocalName == IdName))
                    {
                        var attr = new OpenXmlAttribute();
                        attr.LocalName = "transId";
                        attr.Value = Helpers.Counter.GetCurrentValue().ToString();
                        runs[i].SetAttribute(attr);
                    }

                    if (runs[i] is Run && runs[i - 1] is Run && runs[i].Elements().Any(f => f.LocalName == "t") && runs[i-1].Elements().Any(f => f.LocalName == "t"))
                    {
                        if (!runs[i].InnerText.Trim().Any() || !runs[i-1].InnerText.Trim().Any() || SameFormatting(runs[i - 1], runs[i]))
                        {
                            if (runs[i - 1].InnerText != "")
                            {
                                var text = runs[i].Elements<Text>().SingleOrDefault();
                                if (text != null)
                                    runs[i].Elements<Text>().Single().Text = runs[i - 1].InnerText + runs[i].InnerText;
                                else
                                    runs[i].AppendChild<Text>(new Text(runs[i - 1].InnerText));
                            }
                            runs[i - 1].Remove();
                            i--;
                        }
                    }
                }
            }

            _doc.Save();

            return new Result<bool>(true);
        }

        public IResult<bool> ImplementTranslateData(Dictionary<string, string> dict)
        {
            var htmlList = dict.Select(i =>
                {
                    var doc = new HtmlDocument();
                    doc.LoadHtml(i.Value);
                    return doc;
                });


            //
            foreach (var par in _doc.Body.ChildElements)
            {
                if(par.HasChildren && par.GetAttributes().Any(a => a.LocalName == IdName))
                {
                    RecursiveSwapTranslatedData(par.ChildElements.ToList(), htmlList);
                }
            }

            _doc.Save();

            return new Result<bool>(true);
        }

        //recursive
        private void RecursiveSwapTranslatedData(IEnumerable<OpenXmlElement> items, IEnumerable<HtmlDocument> translated)
        {
            foreach(var item in items)
            {
                if (item is Run && item.GetAttributes().Any(a => a.LocalName == IdName) && !string.IsNullOrWhiteSpace(item.InnerText) && !item.Elements().Any(f => f.LocalName == "instrText"))
                {
                    var id = item.GetAttributes().Single(a => a.LocalName == IdName).Value;
                    var tranItem = translated.FirstOrDefault(i => i.GetElementbyId(id) != null);
                    if(tranItem != null)
                    {
                        item.Elements<Text>().Single().Text = tranItem.GetElementbyId(id).InnerText;
                    }
                }
                else if(item is Hyperlink)
                {
                    var id = item.GetAttributes().Single(a => a.LocalName == IdName).Value;
                    var tranItem = translated.FirstOrDefault(i => i.GetElementbyId(id) != null);
                    if(tranItem != null)
                    {
                        item.Elements<Run>().First().Elements<Text>().Single().Text = tranItem.GetElementbyId(id).InnerText;
                    }
                }
                else if(item.HasChildren && item.InnerText.Length > 0)
                    RecursiveSwapTranslatedData(item.ChildElements.ToList(), translated);
            }
        }

        private bool SameFormatting(OpenXmlElement firstElement, OpenXmlElement secondElement)
        {
            var first = firstElement.Elements<RunProperties>().SingleOrDefault();
            var second = secondElement.Elements<RunProperties>().SingleOrDefault();

            if (first == null && second == null)
                return true;

            if (first == null || second == null)
                return false;

            try
            {
                if (!SameValue(first.Bold, second.Bold))
                    return false;
                if (!SameValue(first.Color, second.Color))
                    return false;
                if (!SameValue(first.FontSize, second.FontSize))
                    return false;
                if (!SameValue(first.Highlight, second.Highlight))
                    return false;
                if (!SameValue(first.Italic, second.Italic))
                    return false;
                if (!SameValue(first.Kern, second.Kern))
                    return false;
                if (!SameValue(first.RightToLeftText, second.RightToLeftText))
                    return false;
                if (!SameFontValue(first.RunFonts, second.RunFonts))
                    return false; 
                if (!SameValue(first.RunStyle, second.RunStyle))
                    return false; 
                if (!SameValue(first.Shadow, second.Shadow))
                    return false;
                if (!SameValue(first.Strike, second.Strike))
                    return false;
                if (!SameValue(first.Underline, second.Underline))
                    return false;
                if (!SameValue(first.VerticalTextAlignment, second.VerticalTextAlignment))
                    return false;
            }
            catch(Exception ex)
            {
                throw new Exception(string.Format("Simplify document error({0})", ex));
            }


            return true;
        }

        private bool SameValue(dynamic first, dynamic second)
        {
            try
            {
                if (first == null && second != null || first != null && second == null)
                    return false;

                if (first == null && second == null)
                    return true;

                if (first.Val == null && second.Val != null || first.Val != null && second.Val == null)
                    return false;

                if (first.Val == null && second.Val == null)
                    return true;

                var res = Equals(first.Val.Value, second.Val.Value);
                return res;
            }
            catch
            {
                return false;
            }
        }

        private bool SameFontValue(RunFonts first, RunFonts second)
        {
            if (first == null || second == null)
                return true;

            var res = Equals(first.Ascii.Value, second.Ascii.Value);
            return res;
        }

        private int GetWordsCount(string text)
        {
            var punctuation = text.Where(Char.IsPunctuation).Distinct().ToArray();
            var count = text.Split().Select(x => x.Trim(punctuation)).Count();
            return count;
        }

        private IEnumerable<string> GetPlainText(IEnumerable<OpenXmlElement> textBlocks)
        {
            var res = new List<string>();

            foreach(var item in textBlocks)
            {
                if (item is DocumentFormat.OpenXml.Wordprocessing.Paragraph)
                {
                    foreach (var child in item.ChildElements.Where(i => i is Run && !i.Elements().Any(f => f.LocalName == "instrText") || i is Hyperlink))
                    {
                        res.Add(child.InnerText);
                    }
                }
                else if (item is DocumentFormat.OpenXml.Wordprocessing.Table)
                {
                    var table = item as DocumentFormat.OpenXml.Wordprocessing.Table;
                    var pars = table.Elements<DocumentFormat.OpenXml.Wordprocessing.Paragraph>();

                    pars.ToList().ForEach(p => res.AddRange(GetPlainText(p)));
                }
            }

            return res;
        }

        private DocumentFormat.OpenXml.Wordprocessing.Document _doc;

        private const string IdName = "transId";
    }
}
