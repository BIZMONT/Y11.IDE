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
using System.Diagnostics;

namespace Y11
{
    public partial class Main : Form
    {
        private string WorkPath;
        private string WorkName;


        public Main()
        {
            InitializeComponent();
        }

        private void Start()
        {
            RunButton.Enabled = true;
            BuildButton.Enabled = true;
            Y11Code.ReadOnly = false;
            Y11Code.BackColor = Color.White;
        }

        private void BuildTable(List<Token> T)
        {
            int i = 0;
            foreach (Token t in T)
            {
                SaveFile.Rows.Add(t.Name.ToString(), t.Value.ToString(), (t.Line - 1).ToString(), t.Column.ToString());
                i++;
            }
        }

        private void BuildProject()
        {
            SaveFile.Rows.Clear();
            ErrorList.Clear();
            ErrorList.Text += "--------------------Build started: Project: " + WorkName + "\n";
            File.WriteAllText(WorkPath + WorkName + ".y11", Y11Code.Text);

            Compilator compilator = new Compilator(WorkPath, WorkName);
            compilator.Compile();
            if (compilator.GetErrors().Length > 0)
            {
                ErrorList.Text += "--------------------Build stoped with errors!\n";
                ErrorList.Text += compilator.GetErrors();
                return;
            }
            else
            {
                BuildTable(compilator.GetTokensList());

                File.WriteAllText(WorkPath + WorkName + ".il", compilator.GetCode());
                ASMCode.Text = compilator.GetCode();

                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.FileName = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\ilasm.exe";
                p.StartInfo.Arguments = this.WorkPath + this.WorkName + ".il";
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                ErrorList.Text += "--------------------Build successful!\n";
            }
        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            Y11Code.Clear();
            ErrorList.Clear();
            NewProjectForm New = new NewProjectForm();
            New.ShowDialog();
            if (New.DialogResult == DialogResult.OK)
            {
                WorkName = New.RetName();
                WorkPath = New.RetPath();
                Y11Code.Text = @"#PROGRAM " + WorkName + @";
START

STOP";
                New.Close();
                Start();
            } 
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "Y11 files (*.prj)|*.prj";
            Y11Code.Clear();
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                WorkPath = File.ReadLines(OpenFileDialog.FileName).Skip(0).First();
                WorkName = File.ReadLines(OpenFileDialog.FileName).Skip(1).First();
                ErrorList.Clear();
                try
                {
                    Y11Code.Text += File.ReadAllText(WorkPath + WorkName + ".y11");
                }
                catch (Exception ex)
                {
                    ErrorList.Text += "Error: Could not open file!\n";
                }
                Start();
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            File.WriteAllText(WorkPath + WorkName + ".y11", Y11Code.Text);
        }

        private void Build_Click(object sender, EventArgs e)
        {
            BuildProject();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(WorkPath + WorkName + ".exe");
            }
            catch(Win32Exception ex)
            {
                ErrorList.Text += "Error: Can`t find executable file!\n";
            }
        }
    }
}
