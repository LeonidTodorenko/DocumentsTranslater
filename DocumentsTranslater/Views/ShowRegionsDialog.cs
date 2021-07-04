using DocumentsTranslater.Contracts;
using System;
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
    public partial class ShowRegionsDialog : Form
    {
        public ShowRegionsDialog(IEnumerable<IRegion> regions)
        {
            InitializeComponent();

            if (regions != null)
                FillRegions(regions);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void FillRegions(IEnumerable<IRegion> regions)
        {
            foreach(var region in regions)
            {
                var item = new ListViewItem(region.Language);
                item.SubItems.Add(region.Alphabet);
                item.SubItems.Add((region.EndRegion - region.StartRegion).ToString());
                item.SubItems.Add(region.StartRegion.ToString());
                item.SubItems.Add(region.EndRegion.ToString());
                var text = string.IsNullOrWhiteSpace(region.Text) || region.Text.Length < 1000 ? region.Text : region.Text.Substring(0, 1000) + "...";
                item.SubItems.Add(text);
                lvMain.Items.Add(item);
            }
        }
    }
}
