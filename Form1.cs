using System;
using System.IO;
using System.Linq;
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
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) path.Text = folderBrowserDialog1.SelectedPath;
            btnDelete.Enabled = false;
        }

        private void BtnDryClick(object sender, EventArgs e)
        {
            DirectoryInfo d = new(path.Text);
            int count = d.GetFiles().Select(fi => fi.FullName.Replace(path.Text + "\\", "")).Count(filename => !exclusions.Text.Contains(filename));
            MessageBox.Show(count + @" files will be deleted!",@"Dry Run Results");
            btnDelete.Enabled = true;
        }

        private void BtnDeleteClick(object sender, EventArgs e)
        {
            DirectoryInfo d = new(path.Text);
            foreach (FileInfo fi in d.GetFiles())
                if (!exclusions.Text.Contains(fi.FullName)) File.Delete(fi.FullName);
        }
    }
}
