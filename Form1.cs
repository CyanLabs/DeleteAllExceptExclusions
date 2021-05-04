using System;
using System.Windows.Forms;

namespace DeleteAllExceptList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnBrowseClick(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK) return;
            txtPath.Text = folderBrowserDialog1.SelectedPath;
            btnPreview.Enabled = true;
        }

        private void BtnDryClick(object sender, EventArgs e)
        {
            Form2 frm2 = new(txtPath.Text,txtExclusions.Text);
            frm2.Show();
        }
    }
}
