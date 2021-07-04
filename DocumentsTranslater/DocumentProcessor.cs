using DocumentsTranslater.Contracts;
using DocumentsTranslater.Models;
using DocumentsTranslater.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsTranslater
{
    class DocumentProcessor : IDocumentProcessor
    {
        public DocumentProcessor(IAnalyzeService analyzer, ITranslateService translator)
        {
            _analyzer = analyzer;
            _translator = translator;
        }

        public Task<IResult<bool>> OpenFile(string fileName)
        {
            return Task.Factory.StartNew<IResult<bool>>(() =>
                {
                    var info = new FileInfo(fileName);

                    if(!info.Exists)
                    {
                        return new Result<bool>(false, "File doesn't exists.");
                    }

                    switch(info.Extension)
                    {
                        case(".docx"):
                            _service = new WordService();
                            var res =  _service.OpenFile(fileName);
                            if(!res.HasError)
                            {
                                Document = _service.Document;
                            }
                            return res;
                        default:
                            return new Result<bool>(false, "Unsupported file type.");

                    }

                    //it needs to create a file 
                });
        }

        public Task<IResult<IEnumerable<IRegion>>> AnalyzeAsync(RLIParameters parameters)
        {
            return Task.Factory.StartNew<IResult<IEnumerable<IRegion>>>(() =>
            {
                var res = _analyzer.Analyze(Document.OriginalPlainText, parameters);
                if (res.Value == null)
                    return res;

                Document.Regions = res.Value;
                //fill Text field in regions
                foreach(var region in Document.Regions)
                {
                    region.Text = Document.OriginalPlainText.Substring(region.StartRegion, region.EndRegion - region.StartRegion);
                }

                return new Result<IEnumerable<IRegion>>(res.Value);
            });
        }

        public Task<IResult<IDictionary<string, string>>> CreateIMPagesAsync()
        {
            return Task.Factory.StartNew<IResult<IDictionary<string, string>>>(CreateIMPages);            
        }

        public async Task<IResult<TranslateJob>> SendToTranslate(string langFrom, string fileName, string text)
        {
            var res = await _translator.SendForTranslate(langFrom, fileName, text);
            return res;
        }
        public async Task<IResult<TranslateJob>> GetJobStatus(string jobName)
        {
            var res = await _translator.GetJobStatus(jobName);
            return res;
        }

        public async Task<IResult<Tuple<string, string>>> DownloadResults(string jobName)
        {
            var paths = await Task.Factory.StartNew<IResult<IEnumerable<string>>>(() => _translator.DownloadResults(jobName));
            if(paths.HasError)
                return new Result<Tuple<string, string>>(null, paths.Error);

            var list = new List<KeyValuePair<string, string>>();
            try
            {
                using(var client = new WebClient())
                {
                    foreach(var path in paths.Value)
                    {
                        var str = await client.DownloadStringTaskAsync(path);
                        str = UTF8ToWin1251(str);
                        list.Add(new KeyValuePair<string, string>(path.Substring(path.LastIndexOf(".") - 2, 2), str));
                    }
                }
                return new Result<Tuple<string, string>>(new Tuple<string,string>(list.First().Key, list.First().Value));
            }
            catch(Exception ex)
            {
                return new Result<Tuple<string, string>>(null, ex.Message);
            }
        }

        private IResult<IDictionary<string, string>> CreateIMPages()
        {
            var dict = new Dictionary<string, string>();
            var languages = Document.Regions.Select(r => r.Language).Distinct();

            foreach(var lang in languages)
            {
                var page = Document.GetHtmlView(lang);
                if (page.HasError)
                    return new Result<IDictionary<string, string>>(null, page.Error);
                dict.Add(lang, page.Value);
            }

            IMPages = dict;
            return new Result<IDictionary<string, string>>(dict);
        }

        public async Task<IResult<bool>> CreateResultDoc(Dictionary<string, string> dict)
        {
            var res = await _service.ImplementTranslatedData(dict);

            if(res.HasError)
            {
                return res;
            }
            else
            {
                var saveRes = await _service.SaveResultDoc();
                return saveRes;
            }
        }

        public IResult<bool> SaveFile()
        {
            throw new NotImplementedException();
        }

        private string UTF8ToWin1251(string source)
        {
            if (string.IsNullOrWhiteSpace(source))
                return source;

            Encoding utf8 = Encoding.GetEncoding("utf-8");
            Encoding win1251 = Encoding.GetEncoding("windows-1251");

            byte[] win1251Bytes = utf8.GetBytes(source);
            byte[] utf8Bytes = Encoding.Convert(utf8, win1251, win1251Bytes);
            source = utf8.GetString(utf8Bytes);
            return source;
        }

        public IDocument Document { get; private set; }

        public IDictionary<string, string> IMPages { get; private set; }

        private IOpenSaveService _service;
        private IAnalyzeService _analyzer;
        private ITranslateService _translator;
    }
}
