﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentsTranslater.Views
{
    public partial class ViewIMPageDialog : Form
    {
        public ViewIMPageDialog(string language, string text)
        {
            InitializeComponent();

            Text += language;
            tbSource.Text = text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
