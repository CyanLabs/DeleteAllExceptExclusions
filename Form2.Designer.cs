
namespace DeleteAllExceptList
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lstToDelete = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.lstToKeep = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.lblToDelete = new System.Windows.Forms.Label();
            this.lblToKeep = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(503, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 29);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
            // 
            // lstToDelete
            // 
            this.lstToDelete.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.columnHeader1, this.columnHeader2, this.columnHeader3, this.columnHeader7});
            this.lstToDelete.FullRowSelect = true;
            this.lstToDelete.GridLines = true;
            this.lstToDelete.HideSelection = false;
            this.lstToDelete.Location = new System.Drawing.Point(11, 42);
            this.lstToDelete.Name = "lstToDelete";
            this.lstToDelete.Size = new System.Drawing.Size(563, 124);
            this.lstToDelete.TabIndex = 2;
            this.lstToDelete.UseCompatibleStateImageBehavior = false;
            this.lstToDelete.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Filename";
            this.columnHeader1.Width = 350;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Created On";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "FullPath";
            this.columnHeader7.Width = 0;
            // 
            // lstToKeep
            // 
            this.lstToKeep.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.columnHeader4, this.columnHeader5, this.columnHeader6, this.columnHeader8});
            this.lstToKeep.FullRowSelect = true;
            this.lstToKeep.GridLines = true;
            this.lstToKeep.HideSelection = false;
            this.lstToKeep.Location = new System.Drawing.Point(11, 201);
            this.lstToKeep.Name = "lstToKeep";
            this.lstToKeep.Size = new System.Drawing.Size(563, 124);
            this.lstToKeep.TabIndex = 3;
            this.lstToKeep.UseCompatibleStateImageBehavior = false;
            this.lstToKeep.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Filename";
            this.columnHeader4.Width = 350;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Size";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Created On";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "FullPath";
            this.columnHeader8.Width = 0;
            // 
            // lblToDelete
            // 
            this.lblToDelete.AutoSize = true;
            this.lblToDelete.Location = new System.Drawing.Point(11, 26);
            this.lblToDelete.Name = "lblToDelete";
            this.lblToDelete.Size = new System.Drawing.Size(179, 13);
            this.lblToDelete.TabIndex = 4;
            this.lblToDelete.Text = "The following files will be DELETED:";
            // 
            // lblToKeep
            // 
            this.lblToKeep.AutoSize = true;
            this.lblToKeep.Location = new System.Drawing.Point(11, 185);
            this.lblToKeep.Name = "lblToKeep";
            this.lblToKeep.Size = new System.Drawing.Size(205, 13);
            this.lblToKeep.TabIndex = 5;
            this.lblToKeep.Text = "The following files will NOT be DELETED:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "# of files to be deleted: \r\n";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(124, 8);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(21, 13);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "##";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 365);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblToKeep);
            this.Controls.Add(this.lblToDelete);
            this.Controls.Add(this.lstToKeep);
            this.Controls.Add(this.lstToDelete);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Delete All Files Except Exclusions!";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListView lstToDelete;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lstToKeep;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lblToDelete;
        private System.Windows.Forms.Label lblToKeep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}

