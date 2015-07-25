using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Y11
{
    public partial class NewProjectForm : Form
    {
        public string FolderPath;
        public string ProjectName;
        public NewProjectForm()
        {
            InitializeComponent();
        }

        private void BrowsePath_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = FolderBrowser.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                FolderPath = FolderBrowser.SelectedPath;
            }
            ProjectPath.Text = FolderPath;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            ProjectName = PName.Text.ToLower();
            StringBuilder path = new StringBuilder();

            path.AppendFormat(@"{0}\{1}\", FolderPath, ProjectName);
            FolderPath = path.ToString();
            string[] lines = { FolderPath, ProjectName };
            Directory.CreateDirectory(FolderPath);
            path.AppendFormat("{0}.prj", ProjectName);
            System.IO.File.WriteAllLines(path.ToString(), lines);
            var Y11File = File.Create(FolderPath + ProjectName + ".y11");
            Y11File.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string RetPath()
        {
            return FolderPath;
        }

        public string RetName()
        {
            return ProjectName;
        }
    }
}
