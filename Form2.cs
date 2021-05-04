using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace DeleteAllExceptList
{
    public partial class Form2 : Form
    {
        public Form2(string path, string exclusions)
        {
            InitializeComponent();
            DirectoryInfo d = new(path);
            int count = 0;
            foreach (FileInfo fi in d.GetFiles())
            {
                string filename = fi.FullName.Replace(path + "\\", "");
                ListViewItem lvi = new(filename);
                lvi.SubItems.Add(fi.Length.ToString());
                lvi.SubItems.Add(fi.CreationTime.ToString(CultureInfo.InvariantCulture));
                lvi.SubItems.Add(fi.FullName);
                if (exclusions.Contains(filename))
                    lstToKeep.Items.Add(lvi);
                else
                {
                    lstToDelete.Items.Add(lvi);
                    count++;
                }
            }
            lblCount.Text = count.ToString();
        }

        private void BtnDeleteClick(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure you want to delete " + lblCount.Text + @" files!", @"WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) !=
                DialogResult.Yes) return;
            foreach (ListViewItem item in lstToDelete.Items)
                File.Delete(item.SubItems[3].Text);
        }

    }
}
