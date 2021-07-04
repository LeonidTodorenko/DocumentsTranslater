using DocumentsTranslater.Contracts;
using DocumentsTranslater.Models;
using DocumentsTranslater.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentsTranslater
{
    public partial class MainForm : Form
    {
        #region Constructors

        public MainForm(IDocumentProcessor processor)
        {
            InitializeComponent();

            _processor = processor;
        }

        #endregion Constructors

        #region Events Handlers

        private void MainForm_Load(object sender, EventArgs e)
        {
            if(!DesignMode)
            {

            }
        }

        private async void btnOpen_Click(object sender, EventArgs e)
        {
            if(ofdDocument.ShowDialog() == DialogResult.OK)
            {
                tbOpenFile.Text = ofdDocument.FileName;
                var res = await _processor.OpenFile(ofdDocument.FileName);

                if(res.Value)
                {
                    AddLogMessage(string.Format("File \"{0}\" is successfuly opened.", ofdDocument.FileName), false);

                    lblCharsCount.Text = _processor.Document.CharsCount.ToString();
                    lblWordsCount.Text = _processor.Document.WordsCount.ToString();
                    lblTextBlocksCount.Text = _processor.Document.TextBlocksCount.ToString();

                    btnAnalyse.Enabled = true;
                }
                else
                {
                    AddLogMessage(string.Format("File open error: {0}", res.Error), true);
                }
            }
        }

        private async void btnAnalyse_Click(object sender, EventArgs e)
        {
            var parameters = new RLIParameters
            {
                AmbThreshold = chbAmbTresholdEnabled.Checked ? tbAmbThreshold.Value : (int?)null,
                Best = Convert.ToInt32(nudBest.Value),
                BreakRegionOnScriptBoundary = chbBreakRegionOnScriptBoundary.Checked,
                Depth = chbDepthEnabled.Checked ? Convert.ToInt32(nudDepth.Value) : (int?)null,
                HintWeight = chbHintWeight.Checked ? tbHintWeight.Value : (int?)null,
                InvThreshold = chbInvThreshold.Checked ? tbInvThreshold.Value : (int?)null,
                ShortThreshold = chbShortThreshold.Checked ? Convert.ToInt32(nudShortThreshold.Value) : (int?)null,
                ValidChars = chbValidChars.Checked ? Convert.ToInt32(nudValidChars.Value) : (int?)null
            };

            lblAnalyzeStatus.Text = "Analyzing";
            var res = await _processor.AnalyzeAsync(parameters);

            if(res.HasError)
            {
                lblAnalyzeStatus.Text = "Analyze error";
                AddLogMessage(string.Format("Analyze file error: {0}", res.Error), true);
                return;
            }
            if(res == null)
            {
                lblAnalyzeStatus.Text = "Analyze error";
                AddLogMessage(string.Format("Analyze file error: Input files doesn't have any regions."), true);
                return;
            }

            AddLogMessage(string.Format("File \"{0}\" is successfuly analyzed.", ofdDocument.FileName), false);
            lblAnalyzeStatus.Text = "Analyzed";
            lblLanguagesCount.Text = res.Value.Select(r => r.Language).Distinct().Count().ToString();
            lblRegionsCount.Text = res.Value.Count().ToString();
            btnCreateIntermediateDocs.Enabled = true;
            btnShowRegions.Enabled = true;
        }

        private void btnShowRegions_Click(object sender, EventArgs e)
        {
            using(var dlg = new ShowRegionsDialog(_processor.Document.Regions))
            {
                dlg.ShowDialog();
            }
        }

        private async void btnCreateIntermediateDocs_Click(object sender, EventArgs e)
        {
            lblTranslateStatus.Text = "Creating pages";
            //it need to create a page for each language
            var res = await _processor.CreateIMPagesAsync();

            if(res.HasError)
            {
                lblTranslateStatus.Text = "Error";
            }
            else
            {
                lblTranslateStatus.Text = "Pages have created";

                DataTable dt = new DataTable();
                dt.Columns.Add("Key", typeof(string));
                dt.Columns.Add("Value", typeof(string));

                DataTable dtSend = new DataTable();
                dtSend.Columns.Add("Key", typeof(string));
                dtSend.Columns.Add("Value", typeof(string));

                foreach (var i in res.Value)
                {
                    dt.Rows.Add(i.Key, i.Value);

                    if(i.Key == "French" || i.Key == "Japanese" || i.Key == "Russian")
                        dtSend.Rows.Add(i.Key, i.Value);
                }

                cbIMPages.DisplayMember = "Key";
                cbIMPages.ValueMember = "Value";
                cbIMPages.DataSource = dt;

                cbIMPageSend.DisplayMember = "Key";
                cbIMPageSend.ValueMember = "Value";
                cbIMPageSend.DataSource = dtSend;

                btnShowIMPage.Enabled = true;
                btnTranslate.Enabled = true;
            }
        }

        private void chbAmbTresholdEnabled_CheckedChanged(object sender, EventArgs e)
        {
            lblAmbThresholdValue.Visible =
                tbAmbThreshold.Enabled =
                    chbAmbTresholdEnabled.Checked;
        }

        private void tbAmbThreshold_ValueChanged(object sender, EventArgs e)
        {
            lblAmbThresholdValue.Text = tbAmbThreshold.Value.ToString();
        }

        private void chbHintWeight_CheckedChanged(object sender, EventArgs e)
        {
            lblHintWeightCount.Visible =
                tbHintWeight.Enabled =
                    chbHintWeight.Checked;
        }

        private void tbHintWeight_ValueChanged(object sender, EventArgs e)
        {
            lblHintWeightCount.Text = tbHintWeight.Value.ToString();
        }

        private void chbInvThreshold_CheckedChanged(object sender, EventArgs e)
        {
            lblInvThresholdCount.Visible =
                tbInvThreshold.Enabled =
                    chbInvThreshold.Checked;
        }

        private void tbInvThreshold_ValueChanged(object sender, EventArgs e)
        {
            lblInvThresholdCount.Text = tbInvThreshold.Value.ToString();
        }

        private void chbDepthEnabled_CheckedChanged(object sender, EventArgs e)
        {
            nudDepth.Enabled = chbDepthEnabled.Checked;
        }

        private void chbValidChars_CheckedChanged(object sender, EventArgs e)
        {
            nudValidChars.Enabled = chbValidChars.Checked;
        }

        private void chbShortThreshold_CheckedChanged(object sender, EventArgs e)
        {
            nudShortThreshold.Enabled = chbShortThreshold.Checked;
        }

        private void btnShowIMPage_Click(object sender, EventArgs e)
        {
            using(var dlg = new ViewIMPageDialog(cbIMPages.Text, cbIMPages.SelectedValue.ToString()))
            {
                dlg.ShowDialog();
            }
        }

        private void btnResetToDefaulParameters_Click(object sender, EventArgs e)
        {
            chbAmbTresholdEnabled.Checked =
                chbHintWeight.Checked =
                chbInvThreshold.Checked =
                chbDepthEnabled.Checked =
                chbValidChars.Checked =
                chbShortThreshold.Checked
                     = false;

            nudBest.Value = 5;
            chbBreakRegionOnScriptBoundary.Checked = true;
        }

        private async void btnTranslate_Click(object sender, EventArgs e)
        {
            var lang = cbIMPageSend.Text;
            var text = cbIMPageSend.SelectedValue.ToString();
            var fileName = string.Format("{0}-{1}{2}",  Path.GetFileNameWithoutExtension(tbOpenFile.Text.Trim()), lang.Substring(0, 2).ToUpper(), ".html");
            var res = await _processor.SendToTranslate(lang, fileName, text);
            if (res.HasError)
            {
                AddLogMessage(res.Error, true);
            }
            else
            {
                AddLogMessage("The text was successfuly sent.", false);
                tbJobName.Text = res.Value.Name;
            }
        }

        private async void btnGetJobStatus_Click(object sender, EventArgs e)
        {
            btnGetJobStatus.Enabled = false;

            var res = await _processor.GetJobStatus(tbJobName.Text);
            if (res.HasError)
                AddLogMessage(res.Error, true);
            else
                btnDownloadResults.Enabled = true;


            lblJobStatus.Text = res.Value.Status;
            btnGetJobStatus.Enabled = true;
        }

        private async void btnDownloadResults_Click(object sender, EventArgs e)
        {
            btnDownloadResults.Enabled = false;

            var res = await _processor.DownloadResults(tbJobName.Text);
            if (res.HasError)
            {
                AddLogMessage(res.Error, true);
                return;
            }

            DataTable dt = cbResultPages.DataSource as DataTable;
            if(dt == null)
            {
                dt = new DataTable();
                dt.Columns.Add("Key", typeof(string));
                dt.Columns.Add("Value", typeof(string));
            }
                            
            dt.Rows.Add(res.Value.Item1, res.Value.Item2);

            cbResultPages.DisplayMember = "Key";
            cbResultPages.ValueMember = "Value";
            cbResultPages.DataSource = dt;

            btnDownloadResults.Enabled = true;
            if (!res.HasError)
                btnCreateResultDoc.Enabled = true;
        }

        private void btnShowResultPage_Click(object sender, EventArgs e)
        {
            using(var dlg = new ViewIMPageDialog(cbResultPages.Text, cbResultPages.SelectedValue.ToString()))
            {
                dlg.ShowDialog();
            }
        }

        private async void btnCreateResultDoc_Click(object sender, EventArgs e)
        {
            //create result document by results of translate
            var dt = cbResultPages.DataSource as DataTable;
            var dict = dt.Select().ToDictionary(r => r[0].ToString(), r => r[1].ToString());

            IResult<bool> resSave = await _processor.CreateResultDoc(dict);
            if (resSave.HasError)
            {
                AddLogMessage(resSave.Error, true);
            }
            else
            {
                AddLogMessage("The result was successfuly saved.", false);
            }

        }

        #endregion Events Handlers

        #region Private Methods

        private void AddLogMessage(string text, bool isError)
        {
            rtbLog.SelectionColor = isError ? Color.Red : Color.Green;
            rtbLog.AppendText(rtbLog.TextLength > 0 ? Environment.NewLine + text : text);
        }

        #endregion Private Methods

        #region Private Members

        private readonly IDocumentProcessor _processor;

        #endregion Private Members
    }
}