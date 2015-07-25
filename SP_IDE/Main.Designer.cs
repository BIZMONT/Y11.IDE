namespace Y11
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuildButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RunButton = new System.Windows.Forms.ToolStripMenuItem();
            this.iNFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TextFiles = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Y11Code = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ASMCode = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ErrorList = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SaveFile = new System.Windows.Forms.DataGridView();
            this.TName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TextFiles.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Y11Code)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveFile)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu,
            this.BuildButton,
            this.RunButton,
            this.iNFOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Menu";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Menu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Menu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Menu.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(40, 22);
            this.Menu.Text = "FILE";
            this.Menu.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.newToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.openToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saveToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // BuildButton
            // 
            this.BuildButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BuildButton.Enabled = false;
            this.BuildButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BuildButton.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(51, 22);
            this.BuildButton.Text = "BUILD";
            this.BuildButton.Click += new System.EventHandler(this.Build_Click);
            // 
            // RunButton
            // 
            this.RunButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RunButton.Enabled = false;
            this.RunButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RunButton.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(43, 22);
            this.RunButton.Text = "RUN";
            this.RunButton.Click += new System.EventHandler(this.Run_Click);
            // 
            // iNFOToolStripMenuItem
            // 
            this.iNFOToolStripMenuItem.Name = "iNFOToolStripMenuItem";
            this.iNFOToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.iNFOToolStripMenuItem.Text = "INFO";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.TextFiles, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 387);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // TextFiles
            // 
            this.TextFiles.Controls.Add(this.tabPage1);
            this.TextFiles.Controls.Add(this.tabPage2);
            this.TextFiles.Controls.Add(this.tabPage3);
            this.TextFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextFiles.Location = new System.Drawing.Point(2, 0);
            this.TextFiles.Margin = new System.Windows.Forms.Padding(2, 0, 1, 1);
            this.TextFiles.Name = "TextFiles";
            this.TextFiles.SelectedIndex = 0;
            this.TextFiles.Size = new System.Drawing.Size(467, 269);
            this.TextFiles.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Y11Code);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(459, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Y11";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Y11Code
            // 
            this.Y11Code.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.Y11Code.AutoScrollMinSize = new System.Drawing.Size(251, 14);
            this.Y11Code.BackBrush = null;
            this.Y11Code.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Y11Code.CharHeight = 14;
            this.Y11Code.CharWidth = 8;
            this.Y11Code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Y11Code.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Y11Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Y11Code.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.Y11Code.IndentBackColor = System.Drawing.Color.Transparent;
            this.Y11Code.IsReplaceMode = false;
            this.Y11Code.LineNumberStartValue = ((uint)(0u));
            this.Y11Code.Location = new System.Drawing.Point(3, 3);
            this.Y11Code.Margin = new System.Windows.Forms.Padding(0);
            this.Y11Code.Name = "Y11Code";
            this.Y11Code.Paddings = new System.Windows.Forms.Padding(0);
            this.Y11Code.ReadOnly = true;
            this.Y11Code.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Y11Code.ServiceColors = null;
            this.Y11Code.ShowFoldingLines = true;
            this.Y11Code.Size = new System.Drawing.Size(453, 235);
            this.Y11Code.TabIndex = 0;
            this.Y11Code.Text = "Create or open project first";
            this.Y11Code.Zoom = 100;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ASMCode);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(459, 241);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CIL";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ASMCode
            // 
            this.ASMCode.BackColor = System.Drawing.Color.White;
            this.ASMCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ASMCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ASMCode.Location = new System.Drawing.Point(3, 3);
            this.ASMCode.Margin = new System.Windows.Forms.Padding(0);
            this.ASMCode.Name = "ASMCode";
            this.ASMCode.ReadOnly = true;
            this.ASMCode.Size = new System.Drawing.Size(453, 235);
            this.ASMCode.TabIndex = 0;
            this.ASMCode.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(459, 241);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MASM";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ErrorList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 271);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 114);
            this.panel1.TabIndex = 3;
            // 
            // ErrorList
            // 
            this.ErrorList.BackColor = System.Drawing.SystemColors.Menu;
            this.ErrorList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorList.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorList.Location = new System.Drawing.Point(0, 0);
            this.ErrorList.Name = "ErrorList";
            this.ErrorList.ReadOnly = true;
            this.ErrorList.Size = new System.Drawing.Size(463, 112);
            this.ErrorList.TabIndex = 0;
            this.ErrorList.Text = "";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.SaveFile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(472, 22);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 22, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 246);
            this.panel2.TabIndex = 4;
            // 
            // SaveFile
            // 
            this.SaveFile.AllowUserToAddRows = false;
            this.SaveFile.AllowUserToDeleteRows = false;
            this.SaveFile.AllowUserToResizeColumns = false;
            this.SaveFile.AllowUserToResizeRows = false;
            this.SaveFile.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.SaveFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SaveFile.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SaveFile.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SaveFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SaveFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TName,
            this.Value,
            this.Line,
            this.Column});
            this.SaveFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveFile.EnableHeadersVisualStyles = false;
            this.SaveFile.Location = new System.Drawing.Point(0, 0);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.ReadOnly = true;
            this.SaveFile.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SaveFile.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.SaveFile.RowHeadersVisible = false;
            this.SaveFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SaveFile.Size = new System.Drawing.Size(308, 244);
            this.SaveFile.TabIndex = 0;
            // 
            // TName
            // 
            this.TName.Frozen = true;
            this.TName.HeaderText = "Name";
            this.TName.Name = "TName";
            this.TName.ReadOnly = true;
            this.TName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TName.Width = 80;
            // 
            // Value
            // 
            this.Value.Frozen = true;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Value.Width = 80;
            // 
            // Line
            // 
            this.Line.Frozen = true;
            this.Line.HeaderText = "Line";
            this.Line.Name = "Line";
            this.Line.ReadOnly = true;
            this.Line.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Line.Width = 65;
            // 
            // Column
            // 
            this.Column.Frozen = true;
            this.Column.HeaderText = "Column";
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            this.Column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column.Width = 65;
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "OpenFileDialog";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Y11 Compilator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TextFiles.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Y11Code)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SaveFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TabControl TextFiles;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private FastColoredTextBoxNS.FastColoredTextBox Y11Code;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.ToolStripMenuItem BuildButton;
        private System.Windows.Forms.ToolStripMenuItem RunButton;
        private System.Windows.Forms.RichTextBox ASMCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox ErrorList;
        private System.Windows.Forms.ToolStripMenuItem iNFOToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView SaveFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn TName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        private System.Windows.Forms.TabPage tabPage3;


    }
}

