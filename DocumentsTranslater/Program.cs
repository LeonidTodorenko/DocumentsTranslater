using DocumentsTranslater.Contracts;
using DocumentsTranslater.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentsTranslater
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Path to bash RLI client.
            var bashClientPath = ConfigurationManager.AppSettings["bashClientPath"];
            // Loaction for the root directory
            var root = ConfigurationManager.AppSettings["rootDirectory"];
            //Login/password for GlobalSight
            var gslogin = ConfigurationManager.AppSettings["globalSightLogin"];
            var gspassword = ConfigurationManager.AppSettings["globalSightPassword"];

            ITranslateService translator = new TranslateService(gslogin, gspassword);
            IAnalyzeService analyzer = new BashAnalyzeService(bashClientPath, root);
            IDocumentProcessor processor = new DocumentProcessor(analyzer, translator);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(processor));
        }
    }
}
