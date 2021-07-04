namespace DocumentsTranslater
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.gbDocument = new System.Windows.Forms.GroupBox();
            this.lblCharsCount = new System.Windows.Forms.Label();
            this.lblWordsCount = new System.Windows.Forms.Label();
            this.lblTextBlocksCount = new System.Windows.Forms.Label();
            this.lblCharsCountCaption = new System.Windows.Forms.Label();
            this.lblWordsCountCaption = new System.Windows.Forms.Label();
            this.lblTextBlocksCountCaption = new System.Windows.Forms.Label();
            this.lblDocument = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tbOpenFile = new System.Windows.Forms.TextBox();
            this.gbRLI = new System.Windows.Forms.GroupBox();
            this.gbParameters = new System.Windows.Forms.GroupBox();
            this.btnResetToDefaulParameters = new System.Windows.Forms.Button();
            this.nudShortThreshold = new System.Windows.Forms.NumericUpDown();
            this.nudValidChars = new System.Windows.Forms.NumericUpDown();
            this.nudDepth = new System.Windows.Forms.NumericUpDown();
            this.chbBreakRegionOnScriptBoundary = new System.Windows.Forms.CheckBox();
            this.lblBoundaries = new System.Windows.Forms.Label();
            this.nudBest = new System.Windows.Forms.NumericUpDown();
            this.lblInvThresholdCount = new System.Windows.Forms.Label();
            this.chbShortThreshold = new System.Windows.Forms.CheckBox();
            this.lblHintWeightCount = new System.Windows.Forms.Label();
            this.chbValidChars = new System.Windows.Forms.CheckBox();
            this.lblAmbThresholdValue = new System.Windows.Forms.Label();
            this.chbDepthEnabled = new System.Windows.Forms.CheckBox();
            this.chbInvThreshold = new System.Windows.Forms.CheckBox();
            this.chbHintWeight = new System.Windows.Forms.CheckBox();
            this.chbAmbTresholdEnabled = new System.Windows.Forms.CheckBox();
            this.tbInvThreshold = new System.Windows.Forms.TrackBar();
            this.lblShortStringThreshold = new System.Windows.Forms.Label();
            this.tbHintWeight = new System.Windows.Forms.TrackBar();
            this.lblValidChars = new System.Windows.Forms.Label();
            this.tbAmbThreshold = new System.Windows.Forms.TrackBar();
            this.lblDepthCaption = new System.Windows.Forms.Label();
            this.lblInvThreshold = new System.Windows.Forms.Label();
            this.lblHintWeight = new System.Windows.Forms.Label();
            this.lblBest = new System.Windows.Forms.Label();
            this.lblAmbTresholdCaption = new System.Windows.Forms.Label();
            this.btnShowRegions = new System.Windows.Forms.Button();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.lblRegionsCount = new System.Windows.Forms.Label();
            this.lblLanguagesCount = new System.Windows.Forms.Label();
            this.lblRegionsCountCaption = new System.Windows.Forms.Label();
            this.lblLanguagesCountCaption = new System.Windows.Forms.Label();
            this.lblAnalyzeStatus = new System.Windows.Forms.Label();
            this.lblAnalyzeStatusCaption = new System.Windows.Forms.Label();
            this.gbTranslate = new System.Windows.Forms.GroupBox();
            this.btnShowIMPage = new System.Windows.Forms.Button();
            this.cbIMPageSend = new System.Windows.Forms.ComboBox();
            this.cbIMPages = new System.Windows.Forms.ComboBox();
            this.lblShowIMPageCaption = new System.Windows.Forms.Label();
            this.btnCreateIntermediateDocs = new System.Windows.Forms.Button();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.lblPagesCount = new System.Windows.Forms.Label();
            this.lblIMPagesCountCaption = new System.Windows.Forms.Label();
            this.lblTranslateStatus = new System.Windows.Forms.Label();
            this.lblTranslateStatusCaption = new System.Windows.Forms.Label();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.tbJobName = new System.Windows.Forms.TextBox();
            this.btnCreateResultDoc = new System.Windows.Forms.Button();
            this.cbResultPages = new System.Windows.Forms.ComboBox();
            this.btnShowResultPage = new System.Windows.Forms.Button();
            this.btnGetJobStatus = new System.Windows.Forms.Button();
            this.btnDownloadResults = new System.Windows.Forms.Button();
            this.lblJobStatusCaption = new System.Windows.Forms.Label();
            this.lblJobStatus = new System.Windows.Forms.Label();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.ofdDocument = new System.Windows.Forms.OpenFileDialog();
            this.sfdDocument = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.gbDocument.SuspendLayout();
            this.gbRLI.SuspendLayout();
            this.gbParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShortThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValidChars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHintWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAmbThreshold)).BeginInit();
            this.gbTranslate.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.gbLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.tlpMain);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.gbLog);
            this.scMain.Size = new System.Drawing.Size(624, 598);
            this.scMain.SplitterDistance = 454;
            this.scMain.TabIndex = 0;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.gbDocument, 0, 0);
            this.tlpMain.Controls.Add(this.gbRLI, 1, 0);
            this.tlpMain.Controls.Add(this.gbTranslate, 0, 1);
            this.tlpMain.Controls.Add(this.gbResult, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.Size = new System.Drawing.Size(624, 454);
            this.tlpMain.TabIndex = 0;
            // 
            // gbDocument
            // 
            this.gbDocument.Controls.Add(this.lblCharsCount);
            this.gbDocument.Controls.Add(this.lblWordsCount);
            this.gbDocument.Controls.Add(this.lblTextBlocksCount);
            this.gbDocument.Controls.Add(this.lblCharsCountCaption);
            this.gbDocument.Controls.Add(this.lblWordsCountCaption);
            this.gbDocument.Controls.Add(this.lblTextBlocksCountCaption);
            this.gbDocument.Controls.Add(this.lblDocument);
            this.gbDocument.Controls.Add(this.btnOpen);
            this.gbDocument.Controls.Add(this.tbOpenFile);
            this.gbDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDocument.Location = new System.Drawing.Point(3, 3);
            this.gbDocument.Name = "gbDocument";
            this.gbDocument.Size = new System.Drawing.Size(306, 130);
            this.gbDocument.TabIndex = 0;
            this.gbDocument.TabStop = false;
            this.gbDocument.Text = "Document Properties";
            // 
            // lblCharsCount
            // 
            this.lblCharsCount.AutoSize = true;
            this.lblCharsCount.Location = new System.Drawing.Point(138, 65);
            this.lblCharsCount.Name = "lblCharsCount";
            this.lblCharsCount.Size = new System.Drawing.Size(13, 13);
            this.lblCharsCount.TabIndex = 4;
            this.lblCharsCount.Text = "0";
            // 
            // lblWordsCount
            // 
            this.lblWordsCount.AutoSize = true;
            this.lblWordsCount.Location = new System.Drawing.Point(138, 87);
            this.lblWordsCount.Name = "lblWordsCount";
            this.lblWordsCount.Size = new System.Drawing.Size(13, 13);
            this.lblWordsCount.TabIndex = 4;
            this.lblWordsCount.Text = "0";
            // 
            // lblTextBlocksCount
            // 
            this.lblTextBlocksCount.AutoSize = true;
            this.lblTextBlocksCount.Location = new System.Drawing.Point(138, 110);
            this.lblTextBlocksCount.Name = "lblTextBlocksCount";
            this.lblTextBlocksCount.Size = new System.Drawing.Size(13, 13);
            this.lblTextBlocksCount.TabIndex = 4;
            this.lblTextBlocksCount.Text = "0";
            // 
            // lblCharsCountCaption
            // 
            this.lblCharsCountCaption.AutoSize = true;
            this.lblCharsCountCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCharsCountCaption.Location = new System.Drawing.Point(9, 65);
            this.lblCharsCountCaption.Name = "lblCharsCountCaption";
            this.lblCharsCountCaption.Size = new System.Drawing.Size(76, 13);
            this.lblCharsCountCaption.TabIndex = 3;
            this.lblCharsCountCaption.Text = "Chars Count";
            // 
            // lblWordsCountCaption
            // 
            this.lblWordsCountCaption.AutoSize = true;
            this.lblWordsCountCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWordsCountCaption.Location = new System.Drawing.Point(9, 87);
            this.lblWordsCountCaption.Name = "lblWordsCountCaption";
            this.lblWordsCountCaption.Size = new System.Drawing.Size(80, 13);
            this.lblWordsCountCaption.TabIndex = 3;
            this.lblWordsCountCaption.Text = "Words Count";
            // 
            // lblTextBlocksCountCaption
            // 
            this.lblTextBlocksCountCaption.AutoSize = true;
            this.lblTextBlocksCountCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextBlocksCountCaption.Location = new System.Drawing.Point(9, 110);
            this.lblTextBlocksCountCaption.Name = "lblTextBlocksCountCaption";
            this.lblTextBlocksCountCaption.Size = new System.Drawing.Size(111, 13);
            this.lblTextBlocksCountCaption.TabIndex = 3;
            this.lblTextBlocksCountCaption.Text = "Text Blocks Count";
            // 
            // lblDocument
            // 
            this.lblDocument.AutoSize = true;
            this.lblDocument.Location = new System.Drawing.Point(9, 21);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(56, 13);
            this.lblDocument.TabIndex = 2;
            this.lblDocument.Text = "Document";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(275, 37);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(25, 20);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tbOpenFile
            // 
            this.tbOpenFile.Location = new System.Drawing.Point(9, 37);
            this.tbOpenFile.Name = "tbOpenFile";
            this.tbOpenFile.ReadOnly = true;
            this.tbOpenFile.Size = new System.Drawing.Size(260, 20);
            this.tbOpenFile.TabIndex = 0;
            // 
            // gbRLI
            // 
            this.gbRLI.Controls.Add(this.gbParameters);
            this.gbRLI.Controls.Add(this.btnShowRegions);
            this.gbRLI.Controls.Add(this.btnAnalyse);
            this.gbRLI.Controls.Add(this.lblRegionsCount);
            this.gbRLI.Controls.Add(this.lblLanguagesCount);
            this.gbRLI.Controls.Add(this.lblRegionsCountCaption);
            this.gbRLI.Controls.Add(this.lblLanguagesCountCaption);
            this.gbRLI.Controls.Add(this.lblAnalyzeStatus);
            this.gbRLI.Controls.Add(this.lblAnalyzeStatusCaption);
            this.gbRLI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRLI.Location = new System.Drawing.Point(315, 3);
            this.gbRLI.Name = "gbRLI";
            this.tlpMain.SetRowSpan(this.gbRLI, 3);
            this.gbRLI.Size = new System.Drawing.Size(306, 448);
            this.gbRLI.TabIndex = 1;
            this.gbRLI.TabStop = false;
            this.gbRLI.Text = "Language Regions";
            // 
            // gbParameters
            // 
            this.gbParameters.Controls.Add(this.btnResetToDefaulParameters);
            this.gbParameters.Controls.Add(this.nudShortThreshold);
            this.gbParameters.Controls.Add(this.nudValidChars);
            this.gbParameters.Controls.Add(this.nudDepth);
            this.gbParameters.Controls.Add(this.chbBreakRegionOnScriptBoundary);
            this.gbParameters.Controls.Add(this.lblBoundaries);
            this.gbParameters.Controls.Add(this.nudBest);
            this.gbParameters.Controls.Add(this.lblInvThresholdCount);
            this.gbParameters.Controls.Add(this.chbShortThreshold);
            this.gbParameters.Controls.Add(this.lblHintWeightCount);
            this.gbParameters.Controls.Add(this.chbValidChars);
            this.gbParameters.Controls.Add(this.lblAmbThresholdValue);
            this.gbParameters.Controls.Add(this.chbDepthEnabled);
            this.gbParameters.Controls.Add(this.chbInvThreshold);
            this.gbParameters.Controls.Add(this.chbHintWeight);
            this.gbParameters.Controls.Add(this.chbAmbTresholdEnabled);
            this.gbParameters.Controls.Add(this.tbInvThreshold);
            this.gbParameters.Controls.Add(this.lblShortStringThreshold);
            this.gbParameters.Controls.Add(this.tbHintWeight);
            this.gbParameters.Controls.Add(this.lblValidChars);
            this.gbParameters.Controls.Add(this.tbAmbThreshold);
            this.gbParameters.Controls.Add(this.lblDepthCaption);
            this.gbParameters.Controls.Add(this.lblInvThreshold);
            this.gbParameters.Controls.Add(this.lblHintWeight);
            this.gbParameters.Controls.Add(this.lblBest);
            this.gbParameters.Controls.Add(this.lblAmbTresholdCaption);
            this.gbParameters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbParameters.Location = new System.Drawing.Point(3, 136);
            this.gbParameters.Name = "gbParameters";
            this.gbParameters.Size = new System.Drawing.Size(300, 309);
            this.gbParameters.TabIndex = 6;
            this.gbParameters.TabStop = false;
            this.gbParameters.Text = "Parameters";
            // 
            // btnResetToDefaulParameters
            // 
            this.btnResetToDefaulParameters.Location = new System.Drawing.Point(94, 280);
            this.btnResetToDefaulParameters.Name = "btnResetToDefaulParameters";
            this.btnResetToDefaulParameters.Size = new System.Drawing.Size(113, 23);
            this.btnResetToDefaulParameters.TabIndex = 7;
            this.btnResetToDefaulParameters.Text = "Default Parameters";
            this.btnResetToDefaulParameters.UseVisualStyleBackColor = true;
            this.btnResetToDefaulParameters.Click += new System.EventHandler(this.btnResetToDefaulParameters_Click);
            // 
            // nudShortThreshold
            // 
            this.nudShortThreshold.Enabled = false;
            this.nudShortThreshold.Location = new System.Drawing.Point(137, 191);
            this.nudShortThreshold.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudShortThreshold.Name = "nudShortThreshold";
            this.nudShortThreshold.Size = new System.Drawing.Size(157, 20);
            this.nudShortThreshold.TabIndex = 9;
            // 
            // nudValidChars
            // 
            this.nudValidChars.Enabled = false;
            this.nudValidChars.Location = new System.Drawing.Point(137, 158);
            this.nudValidChars.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudValidChars.Name = "nudValidChars";
            this.nudValidChars.Size = new System.Drawing.Size(157, 20);
            this.nudValidChars.TabIndex = 9;
            // 
            // nudDepth
            // 
            this.nudDepth.Enabled = false;
            this.nudDepth.Location = new System.Drawing.Point(137, 127);
            this.nudDepth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDepth.Name = "nudDepth";
            this.nudDepth.Size = new System.Drawing.Size(157, 20);
            this.nudDepth.TabIndex = 9;
            // 
            // chbBreakRegionOnScriptBoundary
            // 
            this.chbBreakRegionOnScriptBoundary.AutoSize = true;
            this.chbBreakRegionOnScriptBoundary.Checked = true;
            this.chbBreakRegionOnScriptBoundary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbBreakRegionOnScriptBoundary.Location = new System.Drawing.Point(116, 255);
            this.chbBreakRegionOnScriptBoundary.Name = "chbBreakRegionOnScriptBoundary";
            this.chbBreakRegionOnScriptBoundary.Size = new System.Drawing.Size(165, 17);
            this.chbBreakRegionOnScriptBoundary.TabIndex = 8;
            this.chbBreakRegionOnScriptBoundary.Text = "Combine the same languages";
            this.chbBreakRegionOnScriptBoundary.UseVisualStyleBackColor = true;
            // 
            // lblBoundaries
            // 
            this.lblBoundaries.AutoSize = true;
            this.lblBoundaries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBoundaries.Location = new System.Drawing.Point(6, 257);
            this.lblBoundaries.Name = "lblBoundaries";
            this.lblBoundaries.Size = new System.Drawing.Size(70, 13);
            this.lblBoundaries.TabIndex = 3;
            this.lblBoundaries.Text = "Boundaries";
            // 
            // nudBest
            // 
            this.nudBest.Location = new System.Drawing.Point(137, 224);
            this.nudBest.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBest.Name = "nudBest";
            this.nudBest.Size = new System.Drawing.Size(157, 20);
            this.nudBest.TabIndex = 7;
            this.nudBest.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblInvThresholdCount
            // 
            this.lblInvThresholdCount.AutoSize = true;
            this.lblInvThresholdCount.Location = new System.Drawing.Point(272, 95);
            this.lblInvThresholdCount.Name = "lblInvThresholdCount";
            this.lblInvThresholdCount.Size = new System.Drawing.Size(13, 13);
            this.lblInvThresholdCount.TabIndex = 6;
            this.lblInvThresholdCount.Text = "0";
            this.lblInvThresholdCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblInvThresholdCount.Visible = false;
            // 
            // chbShortThreshold
            // 
            this.chbShortThreshold.AutoSize = true;
            this.chbShortThreshold.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbShortThreshold.Location = new System.Drawing.Point(116, 193);
            this.chbShortThreshold.Name = "chbShortThreshold";
            this.chbShortThreshold.Size = new System.Drawing.Size(15, 14);
            this.chbShortThreshold.TabIndex = 5;
            this.chbShortThreshold.UseVisualStyleBackColor = true;
            this.chbShortThreshold.CheckedChanged += new System.EventHandler(this.chbShortThreshold_CheckedChanged);
            // 
            // lblHintWeightCount
            // 
            this.lblHintWeightCount.AutoSize = true;
            this.lblHintWeightCount.Location = new System.Drawing.Point(272, 59);
            this.lblHintWeightCount.Name = "lblHintWeightCount";
            this.lblHintWeightCount.Size = new System.Drawing.Size(13, 13);
            this.lblHintWeightCount.TabIndex = 6;
            this.lblHintWeightCount.Text = "1";
            this.lblHintWeightCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblHintWeightCount.Visible = false;
            // 
            // chbValidChars
            // 
            this.chbValidChars.AutoSize = true;
            this.chbValidChars.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbValidChars.Location = new System.Drawing.Point(116, 160);
            this.chbValidChars.Name = "chbValidChars";
            this.chbValidChars.Size = new System.Drawing.Size(15, 14);
            this.chbValidChars.TabIndex = 5;
            this.chbValidChars.UseVisualStyleBackColor = true;
            this.chbValidChars.CheckedChanged += new System.EventHandler(this.chbValidChars_CheckedChanged);
            // 
            // lblAmbThresholdValue
            // 
            this.lblAmbThresholdValue.AutoSize = true;
            this.lblAmbThresholdValue.Location = new System.Drawing.Point(272, 23);
            this.lblAmbThresholdValue.Name = "lblAmbThresholdValue";
            this.lblAmbThresholdValue.Size = new System.Drawing.Size(13, 13);
            this.lblAmbThresholdValue.TabIndex = 6;
            this.lblAmbThresholdValue.Text = "0";
            this.lblAmbThresholdValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblAmbThresholdValue.Visible = false;
            // 
            // chbDepthEnabled
            // 
            this.chbDepthEnabled.AutoSize = true;
            this.chbDepthEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbDepthEnabled.Location = new System.Drawing.Point(116, 129);
            this.chbDepthEnabled.Name = "chbDepthEnabled";
            this.chbDepthEnabled.Size = new System.Drawing.Size(15, 14);
            this.chbDepthEnabled.TabIndex = 5;
            this.chbDepthEnabled.UseVisualStyleBackColor = true;
            this.chbDepthEnabled.CheckedChanged += new System.EventHandler(this.chbDepthEnabled_CheckedChanged);
            // 
            // chbInvThreshold
            // 
            this.chbInvThreshold.AutoSize = true;
            this.chbInvThreshold.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbInvThreshold.Location = new System.Drawing.Point(116, 95);
            this.chbInvThreshold.Name = "chbInvThreshold";
            this.chbInvThreshold.Size = new System.Drawing.Size(15, 14);
            this.chbInvThreshold.TabIndex = 5;
            this.chbInvThreshold.UseVisualStyleBackColor = true;
            this.chbInvThreshold.CheckedChanged += new System.EventHandler(this.chbInvThreshold_CheckedChanged);
            // 
            // chbHintWeight
            // 
            this.chbHintWeight.AutoSize = true;
            this.chbHintWeight.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbHintWeight.Location = new System.Drawing.Point(116, 58);
            this.chbHintWeight.Name = "chbHintWeight";
            this.chbHintWeight.Size = new System.Drawing.Size(15, 14);
            this.chbHintWeight.TabIndex = 5;
            this.chbHintWeight.UseVisualStyleBackColor = true;
            this.chbHintWeight.CheckedChanged += new System.EventHandler(this.chbHintWeight_CheckedChanged);
            // 
            // chbAmbTresholdEnabled
            // 
            this.chbAmbTresholdEnabled.AutoSize = true;
            this.chbAmbTresholdEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbAmbTresholdEnabled.Location = new System.Drawing.Point(116, 22);
            this.chbAmbTresholdEnabled.Name = "chbAmbTresholdEnabled";
            this.chbAmbTresholdEnabled.Size = new System.Drawing.Size(15, 14);
            this.chbAmbTresholdEnabled.TabIndex = 5;
            this.chbAmbTresholdEnabled.UseVisualStyleBackColor = true;
            this.chbAmbTresholdEnabled.CheckedChanged += new System.EventHandler(this.chbAmbTresholdEnabled_CheckedChanged);
            // 
            // tbInvThreshold
            // 
            this.tbInvThreshold.AutoSize = false;
            this.tbInvThreshold.Enabled = false;
            this.tbInvThreshold.Location = new System.Drawing.Point(137, 91);
            this.tbInvThreshold.Maximum = 100;
            this.tbInvThreshold.Name = "tbInvThreshold";
            this.tbInvThreshold.Size = new System.Drawing.Size(129, 30);
            this.tbInvThreshold.TabIndex = 4;
            this.tbInvThreshold.ValueChanged += new System.EventHandler(this.tbInvThreshold_ValueChanged);
            // 
            // lblShortStringThreshold
            // 
            this.lblShortStringThreshold.AutoSize = true;
            this.lblShortStringThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShortStringThreshold.Location = new System.Drawing.Point(6, 193);
            this.lblShortStringThreshold.Name = "lblShortStringThreshold";
            this.lblShortStringThreshold.Size = new System.Drawing.Size(97, 13);
            this.lblShortStringThreshold.TabIndex = 3;
            this.lblShortStringThreshold.Text = "Short Threshold";
            // 
            // tbHintWeight
            // 
            this.tbHintWeight.AutoSize = false;
            this.tbHintWeight.Enabled = false;
            this.tbHintWeight.Location = new System.Drawing.Point(137, 55);
            this.tbHintWeight.Maximum = 99;
            this.tbHintWeight.Minimum = 1;
            this.tbHintWeight.Name = "tbHintWeight";
            this.tbHintWeight.Size = new System.Drawing.Size(129, 30);
            this.tbHintWeight.TabIndex = 4;
            this.tbHintWeight.Value = 1;
            this.tbHintWeight.ValueChanged += new System.EventHandler(this.tbHintWeight_ValueChanged);
            // 
            // lblValidChars
            // 
            this.lblValidChars.AutoSize = true;
            this.lblValidChars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblValidChars.Location = new System.Drawing.Point(6, 160);
            this.lblValidChars.Name = "lblValidChars";
            this.lblValidChars.Size = new System.Drawing.Size(71, 13);
            this.lblValidChars.TabIndex = 3;
            this.lblValidChars.Text = "Valid Chars";
            // 
            // tbAmbThreshold
            // 
            this.tbAmbThreshold.AutoSize = false;
            this.tbAmbThreshold.Enabled = false;
            this.tbAmbThreshold.Location = new System.Drawing.Point(137, 19);
            this.tbAmbThreshold.Maximum = 100;
            this.tbAmbThreshold.Name = "tbAmbThreshold";
            this.tbAmbThreshold.Size = new System.Drawing.Size(129, 30);
            this.tbAmbThreshold.TabIndex = 4;
            this.tbAmbThreshold.ValueChanged += new System.EventHandler(this.tbAmbThreshold_ValueChanged);
            // 
            // lblDepthCaption
            // 
            this.lblDepthCaption.AutoSize = true;
            this.lblDepthCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDepthCaption.Location = new System.Drawing.Point(6, 129);
            this.lblDepthCaption.Name = "lblDepthCaption";
            this.lblDepthCaption.Size = new System.Drawing.Size(41, 13);
            this.lblDepthCaption.TabIndex = 3;
            this.lblDepthCaption.Text = "Depth";
            // 
            // lblInvThreshold
            // 
            this.lblInvThreshold.AutoSize = true;
            this.lblInvThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInvThreshold.Location = new System.Drawing.Point(6, 95);
            this.lblInvThreshold.Name = "lblInvThreshold";
            this.lblInvThreshold.Size = new System.Drawing.Size(89, 13);
            this.lblInvThreshold.TabIndex = 3;
            this.lblInvThreshold.Text = "Inv. Threshold";
            // 
            // lblHintWeight
            // 
            this.lblHintWeight.AutoSize = true;
            this.lblHintWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHintWeight.Location = new System.Drawing.Point(6, 59);
            this.lblHintWeight.Name = "lblHintWeight";
            this.lblHintWeight.Size = new System.Drawing.Size(74, 13);
            this.lblHintWeight.TabIndex = 3;
            this.lblHintWeight.Text = "Hint Weight";
            // 
            // lblBest
            // 
            this.lblBest.AutoSize = true;
            this.lblBest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBest.Location = new System.Drawing.Point(6, 226);
            this.lblBest.Name = "lblBest";
            this.lblBest.Size = new System.Drawing.Size(32, 13);
            this.lblBest.TabIndex = 3;
            this.lblBest.Text = "Best";
            // 
            // lblAmbTresholdCaption
            // 
            this.lblAmbTresholdCaption.AutoSize = true;
            this.lblAmbTresholdCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAmbTresholdCaption.Location = new System.Drawing.Point(6, 23);
            this.lblAmbTresholdCaption.Name = "lblAmbTresholdCaption";
            this.lblAmbTresholdCaption.Size = new System.Drawing.Size(95, 13);
            this.lblAmbTresholdCaption.TabIndex = 3;
            this.lblAmbTresholdCaption.Text = "Amb. Threshold";
            // 
            // btnShowRegions
            // 
            this.btnShowRegions.Enabled = false;
            this.btnShowRegions.Location = new System.Drawing.Point(119, 34);
            this.btnShowRegions.Name = "btnShowRegions";
            this.btnShowRegions.Size = new System.Drawing.Size(104, 23);
            this.btnShowRegions.TabIndex = 5;
            this.btnShowRegions.Text = "Show Regions";
            this.btnShowRegions.UseVisualStyleBackColor = true;
            this.btnShowRegions.Click += new System.EventHandler(this.btnShowRegions_Click);
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.Enabled = false;
            this.btnAnalyse.Location = new System.Drawing.Point(9, 34);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(104, 23);
            this.btnAnalyse.TabIndex = 5;
            this.btnAnalyse.Text = "Analyze";
            this.btnAnalyse.UseVisualStyleBackColor = true;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
            // 
            // lblRegionsCount
            // 
            this.lblRegionsCount.AutoSize = true;
            this.lblRegionsCount.Location = new System.Drawing.Point(135, 110);
            this.lblRegionsCount.Name = "lblRegionsCount";
            this.lblRegionsCount.Size = new System.Drawing.Size(13, 13);
            this.lblRegionsCount.TabIndex = 4;
            this.lblRegionsCount.Text = "0";
            // 
            // lblLanguagesCount
            // 
            this.lblLanguagesCount.AutoSize = true;
            this.lblLanguagesCount.Location = new System.Drawing.Point(135, 87);
            this.lblLanguagesCount.Name = "lblLanguagesCount";
            this.lblLanguagesCount.Size = new System.Drawing.Size(13, 13);
            this.lblLanguagesCount.TabIndex = 4;
            this.lblLanguagesCount.Text = "0";
            // 
            // lblRegionsCountCaption
            // 
            this.lblRegionsCountCaption.AutoSize = true;
            this.lblRegionsCountCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRegionsCountCaption.Location = new System.Drawing.Point(6, 110);
            this.lblRegionsCountCaption.Name = "lblRegionsCountCaption";
            this.lblRegionsCountCaption.Size = new System.Drawing.Size(90, 13);
            this.lblRegionsCountCaption.TabIndex = 3;
            this.lblRegionsCountCaption.Text = "Regions Count";
            // 
            // lblLanguagesCountCaption
            // 
            this.lblLanguagesCountCaption.AutoSize = true;
            this.lblLanguagesCountCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLanguagesCountCaption.Location = new System.Drawing.Point(6, 87);
            this.lblLanguagesCountCaption.Name = "lblLanguagesCountCaption";
            this.lblLanguagesCountCaption.Size = new System.Drawing.Size(106, 13);
            this.lblLanguagesCountCaption.TabIndex = 3;
            this.lblLanguagesCountCaption.Text = "Languages Count";
            // 
            // lblAnalyzeStatus
            // 
            this.lblAnalyzeStatus.AutoSize = true;
            this.lblAnalyzeStatus.Location = new System.Drawing.Point(135, 65);
            this.lblAnalyzeStatus.Name = "lblAnalyzeStatus";
            this.lblAnalyzeStatus.Size = new System.Drawing.Size(70, 13);
            this.lblAnalyzeStatus.TabIndex = 4;
            this.lblAnalyzeStatus.Text = "Not Analyzed";
            // 
            // lblAnalyzeStatusCaption
            // 
            this.lblAnalyzeStatusCaption.AutoSize = true;
            this.lblAnalyzeStatusCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnalyzeStatusCaption.Location = new System.Drawing.Point(6, 65);
            this.lblAnalyzeStatusCaption.Name = "lblAnalyzeStatusCaption";
            this.lblAnalyzeStatusCaption.Size = new System.Drawing.Size(43, 13);
            this.lblAnalyzeStatusCaption.TabIndex = 3;
            this.lblAnalyzeStatusCaption.Text = "Status";
            // 
            // gbTranslate
            // 
            this.gbTranslate.Controls.Add(this.btnShowIMPage);
            this.gbTranslate.Controls.Add(this.cbIMPageSend);
            this.gbTranslate.Controls.Add(this.cbIMPages);
            this.gbTranslate.Controls.Add(this.lblShowIMPageCaption);
            this.gbTranslate.Controls.Add(this.btnCreateIntermediateDocs);
            this.gbTranslate.Controls.Add(this.btnTranslate);
            this.gbTranslate.Controls.Add(this.lblPagesCount);
            this.gbTranslate.Controls.Add(this.lblIMPagesCountCaption);
            this.gbTranslate.Controls.Add(this.lblTranslateStatus);
            this.gbTranslate.Controls.Add(this.lblTranslateStatusCaption);
            this.gbTranslate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTranslate.Location = new System.Drawing.Point(3, 139);
            this.gbTranslate.Name = "gbTranslate";
            this.gbTranslate.Size = new System.Drawing.Size(306, 175);
            this.gbTranslate.TabIndex = 2;
            this.gbTranslate.TabStop = false;
            this.gbTranslate.Text = "Translating";
            // 
            // btnShowIMPage
            // 
            this.btnShowIMPage.Enabled = false;
            this.btnShowIMPage.Location = new System.Drawing.Point(232, 108);
            this.btnShowIMPage.Name = "btnShowIMPage";
            this.btnShowIMPage.Size = new System.Drawing.Size(68, 23);
            this.btnShowIMPage.TabIndex = 8;
            this.btnShowIMPage.Text = "Show";
            this.btnShowIMPage.UseVisualStyleBackColor = true;
            this.btnShowIMPage.Click += new System.EventHandler(this.btnShowIMPage_Click);
            // 
            // cbIMPageSend
            // 
            this.cbIMPageSend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIMPageSend.FormattingEnabled = true;
            this.cbIMPageSend.Location = new System.Drawing.Point(141, 137);
            this.cbIMPageSend.Name = "cbIMPageSend";
            this.cbIMPageSend.Size = new System.Drawing.Size(85, 21);
            this.cbIMPageSend.TabIndex = 7;
            // 
            // cbIMPages
            // 
            this.cbIMPages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIMPages.FormattingEnabled = true;
            this.cbIMPages.Location = new System.Drawing.Point(141, 109);
            this.cbIMPages.Name = "cbIMPages";
            this.cbIMPages.Size = new System.Drawing.Size(85, 21);
            this.cbIMPages.TabIndex = 7;
            // 
            // lblShowIMPageCaption
            // 
            this.lblShowIMPageCaption.AutoSize = true;
            this.lblShowIMPageCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShowIMPageCaption.Location = new System.Drawing.Point(9, 113);
            this.lblShowIMPageCaption.Name = "lblShowIMPageCaption";
            this.lblShowIMPageCaption.Size = new System.Drawing.Size(85, 13);
            this.lblShowIMPageCaption.TabIndex = 6;
            this.lblShowIMPageCaption.Text = "ShowIM Page";
            // 
            // btnCreateIntermediateDocs
            // 
            this.btnCreateIntermediateDocs.Enabled = false;
            this.btnCreateIntermediateDocs.Location = new System.Drawing.Point(9, 30);
            this.btnCreateIntermediateDocs.Name = "btnCreateIntermediateDocs";
            this.btnCreateIntermediateDocs.Size = new System.Drawing.Size(103, 23);
            this.btnCreateIntermediateDocs.TabIndex = 5;
            this.btnCreateIntermediateDocs.Text = "Create IM pages";
            this.btnCreateIntermediateDocs.UseVisualStyleBackColor = true;
            this.btnCreateIntermediateDocs.Click += new System.EventHandler(this.btnCreateIntermediateDocs_Click);
            // 
            // btnTranslate
            // 
            this.btnTranslate.Enabled = false;
            this.btnTranslate.Location = new System.Drawing.Point(232, 137);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(68, 23);
            this.btnTranslate.TabIndex = 5;
            this.btnTranslate.Text = "Send";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // lblPagesCount
            // 
            this.lblPagesCount.AutoSize = true;
            this.lblPagesCount.Location = new System.Drawing.Point(138, 88);
            this.lblPagesCount.Name = "lblPagesCount";
            this.lblPagesCount.Size = new System.Drawing.Size(13, 13);
            this.lblPagesCount.TabIndex = 4;
            this.lblPagesCount.Text = "0";
            // 
            // lblIMPagesCountCaption
            // 
            this.lblIMPagesCountCaption.AutoSize = true;
            this.lblIMPagesCountCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIMPagesCountCaption.Location = new System.Drawing.Point(9, 88);
            this.lblIMPagesCountCaption.Name = "lblIMPagesCountCaption";
            this.lblIMPagesCountCaption.Size = new System.Drawing.Size(79, 13);
            this.lblIMPagesCountCaption.TabIndex = 3;
            this.lblIMPagesCountCaption.Text = "Pages Count";
            // 
            // lblTranslateStatus
            // 
            this.lblTranslateStatus.AutoSize = true;
            this.lblTranslateStatus.Location = new System.Drawing.Point(138, 66);
            this.lblTranslateStatus.Name = "lblTranslateStatus";
            this.lblTranslateStatus.Size = new System.Drawing.Size(64, 13);
            this.lblTranslateStatus.TabIndex = 4;
            this.lblTranslateStatus.Text = "No IM Page";
            // 
            // lblTranslateStatusCaption
            // 
            this.lblTranslateStatusCaption.AutoSize = true;
            this.lblTranslateStatusCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTranslateStatusCaption.Location = new System.Drawing.Point(9, 66);
            this.lblTranslateStatusCaption.Name = "lblTranslateStatusCaption";
            this.lblTranslateStatusCaption.Size = new System.Drawing.Size(43, 13);
            this.lblTranslateStatusCaption.TabIndex = 3;
            this.lblTranslateStatusCaption.Text = "Status";
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.tbJobName);
            this.gbResult.Controls.Add(this.btnCreateResultDoc);
            this.gbResult.Controls.Add(this.cbResultPages);
            this.gbResult.Controls.Add(this.btnShowResultPage);
            this.gbResult.Controls.Add(this.btnGetJobStatus);
            this.gbResult.Controls.Add(this.btnDownloadResults);
            this.gbResult.Controls.Add(this.lblJobStatusCaption);
            this.gbResult.Controls.Add(this.lblJobStatus);
            this.gbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbResult.Location = new System.Drawing.Point(3, 320);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(306, 131);
            this.gbResult.TabIndex = 3;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result";
            // 
            // tbJobName
            // 
            this.tbJobName.Location = new System.Drawing.Point(141, 17);
            this.tbJobName.Name = "tbJobName";
            this.tbJobName.Size = new System.Drawing.Size(159, 20);
            this.tbJobName.TabIndex = 8;
            // 
            // btnCreateResultDoc
            // 
            this.btnCreateResultDoc.Enabled = false;
            this.btnCreateResultDoc.Location = new System.Drawing.Point(196, 99);
            this.btnCreateResultDoc.Name = "btnCreateResultDoc";
            this.btnCreateResultDoc.Size = new System.Drawing.Size(104, 23);
            this.btnCreateResultDoc.TabIndex = 5;
            this.btnCreateResultDoc.Text = "Create Result Doc";
            this.btnCreateResultDoc.UseVisualStyleBackColor = true;
            this.btnCreateResultDoc.Click += new System.EventHandler(this.btnCreateResultDoc_Click);
            // 
            // cbResultPages
            // 
            this.cbResultPages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResultPages.FormattingEnabled = true;
            this.cbResultPages.Location = new System.Drawing.Point(9, 101);
            this.cbResultPages.Name = "cbResultPages";
            this.cbResultPages.Size = new System.Drawing.Size(103, 21);
            this.cbResultPages.TabIndex = 7;
            // 
            // btnShowResultPage
            // 
            this.btnShowResultPage.Location = new System.Drawing.Point(141, 99);
            this.btnShowResultPage.Name = "btnShowResultPage";
            this.btnShowResultPage.Size = new System.Drawing.Size(44, 23);
            this.btnShowResultPage.TabIndex = 5;
            this.btnShowResultPage.Text = "Show";
            this.btnShowResultPage.UseVisualStyleBackColor = true;
            this.btnShowResultPage.Click += new System.EventHandler(this.btnShowResultPage_Click);
            // 
            // btnGetJobStatus
            // 
            this.btnGetJobStatus.Location = new System.Drawing.Point(9, 17);
            this.btnGetJobStatus.Name = "btnGetJobStatus";
            this.btnGetJobStatus.Size = new System.Drawing.Size(103, 23);
            this.btnGetJobStatus.TabIndex = 5;
            this.btnGetJobStatus.Text = "Get Job Status";
            this.btnGetJobStatus.UseVisualStyleBackColor = true;
            this.btnGetJobStatus.Click += new System.EventHandler(this.btnGetJobStatus_Click);
            // 
            // btnDownloadResults
            // 
            this.btnDownloadResults.Location = new System.Drawing.Point(9, 72);
            this.btnDownloadResults.Name = "btnDownloadResults";
            this.btnDownloadResults.Size = new System.Drawing.Size(103, 23);
            this.btnDownloadResults.TabIndex = 5;
            this.btnDownloadResults.Text = "Download Result";
            this.btnDownloadResults.UseVisualStyleBackColor = true;
            this.btnDownloadResults.Click += new System.EventHandler(this.btnDownloadResults_Click);
            // 
            // lblJobStatusCaption
            // 
            this.lblJobStatusCaption.AutoSize = true;
            this.lblJobStatusCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblJobStatusCaption.Location = new System.Drawing.Point(138, 48);
            this.lblJobStatusCaption.Name = "lblJobStatusCaption";
            this.lblJobStatusCaption.Size = new System.Drawing.Size(43, 13);
            this.lblJobStatusCaption.TabIndex = 3;
            this.lblJobStatusCaption.Text = "Status";
            // 
            // lblJobStatus
            // 
            this.lblJobStatus.AutoSize = true;
            this.lblJobStatus.Location = new System.Drawing.Point(213, 48);
            this.lblJobStatus.Name = "lblJobStatus";
            this.lblJobStatus.Size = new System.Drawing.Size(84, 13);
            this.lblJobStatus.TabIndex = 4;
            this.lblJobStatus.Text = "NOT CHECKED";
            // 
            // gbLog
            // 
            this.gbLog.Controls.Add(this.rtbLog);
            this.gbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLog.Location = new System.Drawing.Point(0, 0);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(624, 140);
            this.gbLog.TabIndex = 0;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "Log";
            // 
            // rtbLog
            // 
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Location = new System.Drawing.Point(3, 16);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(618, 121);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // ofdDocument
            // 
            this.ofdDocument.Filter = "Word files(*.docx)|*.docx";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 598);
            this.Controls.Add(this.scMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documents Translator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.gbDocument.ResumeLayout(false);
            this.gbDocument.PerformLayout();
            this.gbRLI.ResumeLayout(false);
            this.gbRLI.PerformLayout();
            this.gbParameters.ResumeLayout(false);
            this.gbParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShortThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValidChars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHintWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAmbThreshold)).EndInit();
            this.gbTranslate.ResumeLayout(false);
            this.gbTranslate.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.gbLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox gbDocument;
        private System.Windows.Forms.Label lblCharsCount;
        private System.Windows.Forms.Label lblWordsCount;
        private System.Windows.Forms.Label lblTextBlocksCount;
        private System.Windows.Forms.Label lblCharsCountCaption;
        private System.Windows.Forms.Label lblWordsCountCaption;
        private System.Windows.Forms.Label lblTextBlocksCountCaption;
        private System.Windows.Forms.Label lblDocument;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox tbOpenFile;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.OpenFileDialog ofdDocument;
        private System.Windows.Forms.GroupBox gbRLI;
        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.Label lblRegionsCount;
        private System.Windows.Forms.Label lblLanguagesCount;
        private System.Windows.Forms.Label lblRegionsCountCaption;
        private System.Windows.Forms.Label lblLanguagesCountCaption;
        private System.Windows.Forms.Label lblAnalyzeStatus;
        private System.Windows.Forms.Label lblAnalyzeStatusCaption;
        private System.Windows.Forms.GroupBox gbTranslate;
        private System.Windows.Forms.Button btnCreateIntermediateDocs;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Label lblTranslateStatus;
        private System.Windows.Forms.Label lblTranslateStatusCaption;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Button btnCreateResultDoc;
        private System.Windows.Forms.SaveFileDialog sfdDocument;
        private System.Windows.Forms.Button btnShowRegions;
        private System.Windows.Forms.GroupBox gbParameters;
        private System.Windows.Forms.TrackBar tbAmbThreshold;
        private System.Windows.Forms.Label lblAmbTresholdCaption;
        private System.Windows.Forms.Label lblAmbThresholdValue;
        private System.Windows.Forms.CheckBox chbAmbTresholdEnabled;
        private System.Windows.Forms.NumericUpDown nudShortThreshold;
        private System.Windows.Forms.NumericUpDown nudValidChars;
        private System.Windows.Forms.NumericUpDown nudDepth;
        private System.Windows.Forms.CheckBox chbBreakRegionOnScriptBoundary;
        private System.Windows.Forms.Label lblBoundaries;
        private System.Windows.Forms.NumericUpDown nudBest;
        private System.Windows.Forms.Label lblInvThresholdCount;
        private System.Windows.Forms.CheckBox chbShortThreshold;
        private System.Windows.Forms.Label lblHintWeightCount;
        private System.Windows.Forms.CheckBox chbValidChars;
        private System.Windows.Forms.CheckBox chbDepthEnabled;
        private System.Windows.Forms.CheckBox chbInvThreshold;
        private System.Windows.Forms.CheckBox chbHintWeight;
        private System.Windows.Forms.TrackBar tbInvThreshold;
        private System.Windows.Forms.Label lblShortStringThreshold;
        private System.Windows.Forms.TrackBar tbHintWeight;
        private System.Windows.Forms.Label lblValidChars;
        private System.Windows.Forms.Label lblDepthCaption;
        private System.Windows.Forms.Label lblInvThreshold;
        private System.Windows.Forms.Label lblHintWeight;
        private System.Windows.Forms.Label lblBest;
        private System.Windows.Forms.Button btnResetToDefaulParameters;
        private System.Windows.Forms.Button btnShowIMPage;
        private System.Windows.Forms.ComboBox cbIMPages;
        private System.Windows.Forms.Label lblShowIMPageCaption;
        private System.Windows.Forms.Label lblPagesCount;
        private System.Windows.Forms.Label lblIMPagesCountCaption;
        private System.Windows.Forms.ComboBox cbIMPageSend;
        private System.Windows.Forms.Button btnDownloadResults;
        private System.Windows.Forms.ComboBox cbResultPages;
        private System.Windows.Forms.Button btnShowResultPage;
        private System.Windows.Forms.Label lblJobStatusCaption;
        private System.Windows.Forms.Label lblJobStatus;
        private System.Windows.Forms.Button btnGetJobStatus;
        private System.Windows.Forms.TextBox tbJobName;
    }
}

