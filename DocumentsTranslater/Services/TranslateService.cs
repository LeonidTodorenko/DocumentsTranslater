using DocumentsTranslater.Contracts;
using DocumentsTranslater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DocumentsTranslater.Services
{
    class TranslateService : ITranslateService
    {
        public TranslateService(string gslogin, string gspassword)
        {
            _gsLogin = gslogin;
            _gsPassword = gspassword;

            _languages = new Dictionary<string, string>
            {
                {"Russian", "RUEN"},
                {"French", "FREN"},
                {"Japanese", "JPEN"},
                {"Spanish", "SPEN"}
            };
        }
        public async Task<IResult<TranslateJob>> SendForTranslate(string langFrom, string fileName, string text)
        {
            if(!_isInit)
            {
                var res = await Task.Factory.StartNew<IResult<bool>>(Init);
                if(res.HasError)
                    return new Result<TranslateJob>(null, res.Error);
            }

            try
            {
                var client = new GlobalSight.AmbassadorService();
                var uniqueJobName = client.getUniqueJobName(_token, _jobName);
                var langCode = _languages[langFrom];
                var filePath = string.Format("files/{0}", fileName);
                var profileId =  _profiles[langCode];
                client.uploadFile(_token, uniqueJobName, filePath, profileId, text);
                client.createJob(_token, uniqueJobName, "Test Job From Application", filePath, profileId, string.Empty);
                return new Result<TranslateJob>(new TranslateJob { Name = uniqueJobName });
            }
            catch(Exception ex)
            {
                return new Result<TranslateJob>(null, ex.Message);
            }
        }

        public async Task<IResult<IEnumerable<string>>> GetFinishedJobNames()
        {
            try 
            {
                if(!_isInit)
                {
                    var resInit = await Task.Factory.StartNew<IResult<bool>>(Init);
                    if (resInit.HasError)
                        return new Result<IEnumerable<string>>(null, resInit.Error);
                }

                var client = new GlobalSight.AmbassadorService();
                var res = client.getAllProjectsByUser(_token);

                return new Result<IEnumerable<string>>(new List<string>());
            }
            catch (Exception ex)
            {
                return new Result<IEnumerable<string>>(null, ex.Message);
            }            
        }

        public async Task<IResult<TranslateJob>> GetJobStatus(string jobName)
        {
            if (!_isInit)
            {
                var res = await Task.Factory.StartNew<IResult<bool>>(Init);
                if (res.HasError)
                    return new Result<TranslateJob>(null, res.Error);
            }

            try
            {
                var client = new GlobalSight.AmbassadorService();
                var res = client.getJobStatus(_token, jobName);
                var xml = XElement.Parse(res);

                return new Result<TranslateJob>(new TranslateJob { Name = xml.Element("name").Value, Id = xml.Element("id").Value, Status = xml.Element("status").Value });
            }
            catch (Exception ex)
            {
                return new Result<TranslateJob>(null, ex.Message);
            }
        }


        public IResult<IEnumerable<string>> DownloadResults(string jobName)
        {
            try
            {
                var client = new GlobalSight.AmbassadorService();
                var res = client.getJobExportFiles(_token, jobName);
                var xml = XElement.Parse(res);
                var root = xml.Element("root").Value;
                var paths = xml.Elements("paths").Select(x => root + "/" + x.Value);

                return new Result<IEnumerable<string>>(paths);
            }
            catch (Exception ex)
            {
                return new Result<IEnumerable<string>>(null, ex.Message);
            }
        }

        private IResult<string> GetToken()
        {
            try 
            {
                var client = new GlobalSight.AmbassadorService();
                _token = client.login(_gsLogin, _gsPassword);
                return new Result<string>(_token);
            }
            catch (Exception ex)
            {
                return new Result<string>(string.Empty, ex.Message);
            }
        }

        private IResult<bool> Init()
        {
            var token = GetToken();
            if(token.HasError)
                return new Result<bool>(false, token.Error);
            _token = token.Value;

            var profiles = GetProfiles();


            return new Result<bool>(true);
        }

        private IResult<bool> GetProfiles()
        {
            try 
            {
                var client = new GlobalSight.AmbassadorService();
                var profiles = client.getFileProfileInformation(_token);
                var xml = XElement.Parse(profiles);
                var fileProfiles = xml.Elements();
                _profiles = fileProfiles.ToDictionary(i => i.Element("name").Value, i => i.Element("id").Value);
                _isInit = true;
                return new Result<bool>(true);
            }
            catch (Exception ex)
            {
                return new Result<bool>(false, ex.Message);
            }
        }

        private string _gsLogin;
        private string _gsPassword;
        private string _token;
        private bool _isInit;
        private IDictionary<string,string> _profiles;
        private string _jobName = "TestJobApi";
        private readonly Dictionary<string, string> _languages;
    }
}


//Locales - getSourceLocales

/*
 
 <?xml version="1.0" encoding="UTF-8" ?>
<fileProfileInformation>
<fileProfile>	<id>183</id>
	<name>FREN</name>
	<description>N/A</description>
</fileProfile><fileProfile>	<id>5</id>
	<name>HTML</name>
	<description>N/A</description>
</fileProfile><fileProfile>	<id>185</id>
	<name>JPEN</name>
	<description>N/A</description>
</fileProfile><fileProfile>	<id>184</id>
	<name>RUEN</name>
	<description>N/A</description>
</fileProfile><fileProfile>	<id>16</id>
	<name>TXT</name>
	<description>N/A</description>
</fileProfile><fileProfile>	<id>6</id>
	<name>XML</name>
	<description>N/A</description>
</fileProfile></fileProfileInformation>
 
 
 */