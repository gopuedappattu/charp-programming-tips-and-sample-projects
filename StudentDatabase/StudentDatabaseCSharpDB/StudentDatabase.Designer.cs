namespace StudentDatabaseCSharpDB
{
    partial class StudentDatabase
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllSudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewStudentList = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentInfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(489, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentInfoToolStripMenuItem
            // 
            this.studentInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAStudentToolStripMenuItem,
            this.deleteAStudentToolStripMenuItem,
            this.showAllSudentsToolStripMenuItem});
            this.studentInfoToolStripMenuItem.Name = "studentInfoToolStripMenuItem";
            this.studentInfoToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.studentInfoToolStripMenuItem.Text = "Student Info";
            // 
            // addAStudentToolStripMenuItem
            // 
            this.addAStudentToolStripMenuItem.Name = "addAStudentToolStripMenuItem";
            this.addAStudentToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.addAStudentToolStripMenuItem.Text = "Add a Student";
            this.addAStudentToolStripMenuItem.Click += new System.EventHandler(this.addAStudentToolStripMenuItem_Click);
            // 
            // deleteAStudentToolStripMenuItem
            // 
            this.deleteAStudentToolStripMenuItem.Name = "deleteAStudentToolStripMenuItem";
            this.deleteAStudentToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.deleteAStudentToolStripMenuItem.Text = "Delete a Student";
            this.deleteAStudentToolStripMenuItem.Click += new System.EventHandler(this.deleteAStudentToolStripMenuItem_Click);
            // 
            // showAllSudentsToolStripMenuItem
            // 
            this.showAllSudentsToolStripMenuItem.Name = "showAllSudentsToolStripMenuItem";
            this.showAllSudentsToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.showAllSudentsToolStripMenuItem.Text = "Show all sudents";
            this.showAllSudentsToolStripMenuItem.Click += new System.EventHandler(this.showAllSudentsToolStripMenuItem_Click);
            // 
            // dataGridViewStudentList
            // 
            this.dataGridViewStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentList.Location = new System.Drawing.Point(12, 79);
            this.dataGridViewStudentList.Name = "dataGridViewStudentList";
            this.dataGridViewStudentList.RowTemplate.Height = 24;
            this.dataGridViewStudentList.Size = new System.Drawing.Size(448, 164);
            this.dataGridViewStudentList.TabIndex = 1;
            // 
            // StudentDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 351);
            this.Controls.Add(this.dataGridViewStudentList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentDatabase";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StudentDatabase_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllSudentsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewStudentList;
    }
}

