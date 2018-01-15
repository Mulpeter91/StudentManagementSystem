namespace Mulpeter_10346867_AP_Assignment
{
    partial class HomeForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInNewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHomeAdd = new System.Windows.Forms.Button();
            this.btnHomeEdit = new System.Windows.Forms.Button();
            this.btnHomeDelete = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnHomeRefresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.newStudentToolStripMenuItem,
            this.viewHistoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1159, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // newStudentToolStripMenuItem
            // 
            this.newStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem1,
            this.editStudentToolStripMenuItem,
            this.deleteStudentToolStripMenuItem,
            this.viewDatabaseToolStripMenuItem});
            this.newStudentToolStripMenuItem.Name = "newStudentToolStripMenuItem";
            this.newStudentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.newStudentToolStripMenuItem.Text = "Student";
            // 
            // addNewStudentToolStripMenuItem1
            // 
            this.addNewStudentToolStripMenuItem1.Name = "addNewStudentToolStripMenuItem1";
            this.addNewStudentToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.addNewStudentToolStripMenuItem1.Text = "Add New Student";
            // 
            // editStudentToolStripMenuItem
            // 
            this.editStudentToolStripMenuItem.Name = "editStudentToolStripMenuItem";
            this.editStudentToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.editStudentToolStripMenuItem.Text = "Edit Student";
            this.editStudentToolStripMenuItem.Click += new System.EventHandler(this.editStudentToolStripMenuItem_Click);
            // 
            // deleteStudentToolStripMenuItem
            // 
            this.deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            this.deleteStudentToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.deleteStudentToolStripMenuItem.Text = "Delete Student";
            this.deleteStudentToolStripMenuItem.Click += new System.EventHandler(this.deleteStudentToolStripMenuItem_Click);
            // 
            // viewDatabaseToolStripMenuItem
            // 
            this.viewDatabaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshHomeToolStripMenuItem,
            this.viewInNewWindowToolStripMenuItem});
            this.viewDatabaseToolStripMenuItem.Name = "viewDatabaseToolStripMenuItem";
            this.viewDatabaseToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.viewDatabaseToolStripMenuItem.Text = "View Database";
            // 
            // refreshHomeToolStripMenuItem
            // 
            this.refreshHomeToolStripMenuItem.Name = "refreshHomeToolStripMenuItem";
            this.refreshHomeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.refreshHomeToolStripMenuItem.Text = "Refresh Home";
            this.refreshHomeToolStripMenuItem.Click += new System.EventHandler(this.refreshHomeToolStripMenuItem_Click);
            // 
            // viewInNewWindowToolStripMenuItem
            // 
            this.viewInNewWindowToolStripMenuItem.Name = "viewInNewWindowToolStripMenuItem";
            this.viewInNewWindowToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.viewInNewWindowToolStripMenuItem.Text = "View in New Window";
            this.viewInNewWindowToolStripMenuItem.Click += new System.EventHandler(this.viewInNewWindowToolStripMenuItem_Click);
            // 
            // viewHistoryToolStripMenuItem
            // 
            this.viewHistoryToolStripMenuItem.Name = "viewHistoryToolStripMenuItem";
            this.viewHistoryToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.viewHistoryToolStripMenuItem.Text = "View History";
            this.viewHistoryToolStripMenuItem.Click += new System.EventHandler(this.viewHistoryToolStripMenuItem_Click);
            // 
            // btnHomeAdd
            // 
            this.btnHomeAdd.Location = new System.Drawing.Point(398, 370);
            this.btnHomeAdd.Name = "btnHomeAdd";
            this.btnHomeAdd.Size = new System.Drawing.Size(75, 23);
            this.btnHomeAdd.TabIndex = 1;
            this.btnHomeAdd.Text = "Add";
            this.btnHomeAdd.UseVisualStyleBackColor = true;
            this.btnHomeAdd.Click += new System.EventHandler(this.btnHomeAdd_Click);
            // 
            // btnHomeEdit
            // 
            this.btnHomeEdit.Location = new System.Drawing.Point(588, 370);
            this.btnHomeEdit.Name = "btnHomeEdit";
            this.btnHomeEdit.Size = new System.Drawing.Size(75, 23);
            this.btnHomeEdit.TabIndex = 2;
            this.btnHomeEdit.Text = "Edit";
            this.btnHomeEdit.UseVisualStyleBackColor = true;
            this.btnHomeEdit.Click += new System.EventHandler(this.btnHomeEdit_Click);
            // 
            // btnHomeDelete
            // 
            this.btnHomeDelete.Location = new System.Drawing.Point(683, 370);
            this.btnHomeDelete.Name = "btnHomeDelete";
            this.btnHomeDelete.Size = new System.Drawing.Size(75, 23);
            this.btnHomeDelete.TabIndex = 3;
            this.btnHomeDelete.Text = "Delete";
            this.btnHomeDelete.UseVisualStyleBackColor = true;
            this.btnHomeDelete.Click += new System.EventHandler(this.btnHomeDelete_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AutoGenerateColumns = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.DataSource = this.studentsBindingSource;
            this.dgvStudents.Location = new System.Drawing.Point(12, 27);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(1135, 326);
            this.dgvStudents.TabIndex = 4;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            // 
            // btnHomeRefresh
            // 
            this.btnHomeRefresh.Location = new System.Drawing.Point(494, 370);
            this.btnHomeRefresh.Name = "btnHomeRefresh";
            this.btnHomeRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnHomeRefresh.TabIndex = 5;
            this.btnHomeRefresh.Text = "Refresh";
            this.btnHomeRefresh.UseVisualStyleBackColor = true;
            this.btnHomeRefresh.Click += new System.EventHandler(this.btnHomeRefresh_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 405);
            this.Controls.Add(this.btnHomeRefresh);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnHomeDelete);
            this.Controls.Add(this.btnHomeEdit);
            this.Controls.Add(this.btnHomeAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHistoryToolStripMenuItem;
        private System.Windows.Forms.Button btnHomeAdd;
        private System.Windows.Forms.Button btnHomeEdit;
        private System.Windows.Forms.Button btnHomeDelete;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.Button btnHomeRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem refreshHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInNewWindowToolStripMenuItem;
    }
}