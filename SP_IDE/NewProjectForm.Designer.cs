namespace Y11
{
    partial class NewProjectForm
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
            this.PName = new System.Windows.Forms.TextBox();
            this.ProjectPath = new System.Windows.Forms.TextBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.BrowsePath = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // PName
            // 
            this.PName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PName.Location = new System.Drawing.Point(74, 12);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(300, 23);
            this.PName.TabIndex = 0;
            // 
            // ProjectPath
            // 
            this.ProjectPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProjectPath.Location = new System.Drawing.Point(74, 41);
            this.ProjectPath.Name = "ProjectPath";
            this.ProjectPath.Size = new System.Drawing.Size(300, 23);
            this.ProjectPath.TabIndex = 1;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lable1.Location = new System.Drawing.Point(12, 16);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(42, 15);
            this.lable1.TabIndex = 2;
            this.lable1.Text = "Name:";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lable2.Location = new System.Drawing.Point(12, 44);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(56, 15);
            this.lable2.TabIndex = 3;
            this.lable2.Text = "Location:";
            // 
            // BrowsePath
            // 
            this.BrowsePath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrowsePath.Location = new System.Drawing.Point(380, 40);
            this.BrowsePath.Name = "BrowsePath";
            this.BrowsePath.Size = new System.Drawing.Size(75, 25);
            this.BrowsePath.TabIndex = 4;
            this.BrowsePath.Text = "Browse...";
            this.BrowsePath.UseVisualStyleBackColor = true;
            this.BrowsePath.Click += new System.EventHandler(this.BrowsePath_Click);
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OK.Location = new System.Drawing.Point(299, 71);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 6;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(380, 71);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // NewProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 106);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.BrowsePath);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.ProjectPath);
            this.Controls.Add(this.PName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewProjectForm";
            this.Text = "New Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PName;
        private System.Windows.Forms.TextBox ProjectPath;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Button BrowsePath;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
    }
}