namespace Mulpeter_10346867_AP_Assignment
{
    partial class RegistrationForm
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
            this.txtRegisterStaffID = new System.Windows.Forms.MaskedTextBox();
            this.lblRegisterStaffIdNumber = new System.Windows.Forms.Label();
            this.lblRegisterNewAdminRegistration = new System.Windows.Forms.Label();
            this.lblRegisterFirstName = new System.Windows.Forms.Label();
            this.txtRegisterFirstName = new System.Windows.Forms.TextBox();
            this.txtRegisterSurname = new System.Windows.Forms.TextBox();
            this.lblRegisterSurname = new System.Windows.Forms.Label();
            this.lblRegisterStaffEmail = new System.Windows.Forms.Label();
            this.lblRegisterDepartment = new System.Windows.Forms.Label();
            this.comTxtRegisterDepartment = new System.Windows.Forms.ComboBox();
            this.lblRegisterSetPassword = new System.Windows.Forms.Label();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.btnRegisterRegister = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRegisterHelp = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRegisterStaffEmail = new System.Windows.Forms.TextBox();
            this.lblAtEmail = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRegisterStaffID
            // 
            this.txtRegisterStaffID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtRegisterStaffID.Location = new System.Drawing.Point(135, 25);
            this.txtRegisterStaffID.Mask = "00000";
            this.txtRegisterStaffID.Name = "txtRegisterStaffID";
            this.txtRegisterStaffID.Size = new System.Drawing.Size(181, 20);
            this.txtRegisterStaffID.TabIndex = 0;
            this.txtRegisterStaffID.ValidatingType = typeof(int);
            // 
            // lblRegisterStaffIdNumber
            // 
            this.lblRegisterStaffIdNumber.AutoSize = true;
            this.lblRegisterStaffIdNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterStaffIdNumber.Location = new System.Drawing.Point(21, 26);
            this.lblRegisterStaffIdNumber.Name = "lblRegisterStaffIdNumber";
            this.lblRegisterStaffIdNumber.Size = new System.Drawing.Size(108, 17);
            this.lblRegisterStaffIdNumber.TabIndex = 1;
            this.lblRegisterStaffIdNumber.Text = "Staff ID Number";
            // 
            // lblRegisterNewAdminRegistration
            // 
            this.lblRegisterNewAdminRegistration.AutoSize = true;
            this.lblRegisterNewAdminRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterNewAdminRegistration.Location = new System.Drawing.Point(154, 44);
            this.lblRegisterNewAdminRegistration.Name = "lblRegisterNewAdminRegistration";
            this.lblRegisterNewAdminRegistration.Size = new System.Drawing.Size(179, 20);
            this.lblRegisterNewAdminRegistration.TabIndex = 16;
            this.lblRegisterNewAdminRegistration.Text = "New Admin Registration";
            // 
            // lblRegisterFirstName
            // 
            this.lblRegisterFirstName.AutoSize = true;
            this.lblRegisterFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterFirstName.Location = new System.Drawing.Point(53, 29);
            this.lblRegisterFirstName.Name = "lblRegisterFirstName";
            this.lblRegisterFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblRegisterFirstName.TabIndex = 17;
            this.lblRegisterFirstName.Text = "First Name";
            // 
            // txtRegisterFirstName
            // 
            this.txtRegisterFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtRegisterFirstName.Location = new System.Drawing.Point(135, 29);
            this.txtRegisterFirstName.Name = "txtRegisterFirstName";
            this.txtRegisterFirstName.Size = new System.Drawing.Size(181, 20);
            this.txtRegisterFirstName.TabIndex = 18;
            // 
            // txtRegisterSurname
            // 
            this.txtRegisterSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtRegisterSurname.Location = new System.Drawing.Point(135, 55);
            this.txtRegisterSurname.Name = "txtRegisterSurname";
            this.txtRegisterSurname.Size = new System.Drawing.Size(181, 20);
            this.txtRegisterSurname.TabIndex = 20;
            // 
            // lblRegisterSurname
            // 
            this.lblRegisterSurname.AutoSize = true;
            this.lblRegisterSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterSurname.Location = new System.Drawing.Point(63, 55);
            this.lblRegisterSurname.Name = "lblRegisterSurname";
            this.lblRegisterSurname.Size = new System.Drawing.Size(65, 17);
            this.lblRegisterSurname.TabIndex = 19;
            this.lblRegisterSurname.Text = "Surname";
            // 
            // lblRegisterStaffEmail
            // 
            this.lblRegisterStaffEmail.AutoSize = true;
            this.lblRegisterStaffEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterStaffEmail.Location = new System.Drawing.Point(53, 56);
            this.lblRegisterStaffEmail.Name = "lblRegisterStaffEmail";
            this.lblRegisterStaffEmail.Size = new System.Drawing.Size(75, 17);
            this.lblRegisterStaffEmail.TabIndex = 21;
            this.lblRegisterStaffEmail.Text = "Staff Email";
            // 
            // lblRegisterDepartment
            // 
            this.lblRegisterDepartment.AutoSize = true;
            this.lblRegisterDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterDepartment.Location = new System.Drawing.Point(46, 82);
            this.lblRegisterDepartment.Name = "lblRegisterDepartment";
            this.lblRegisterDepartment.Size = new System.Drawing.Size(82, 17);
            this.lblRegisterDepartment.TabIndex = 22;
            this.lblRegisterDepartment.Text = "Department";
            // 
            // comTxtRegisterDepartment
            // 
            this.comTxtRegisterDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comTxtRegisterDepartment.FormattingEnabled = true;
            this.comTxtRegisterDepartment.Items.AddRange(new object[] {
            "Admin",
            "Commerce",
            "Computer Science",
            "Engineering",
            "Law",
            "Medicine",
            "Natural Science",
            "Social Science"});
            this.comTxtRegisterDepartment.Location = new System.Drawing.Point(135, 81);
            this.comTxtRegisterDepartment.Name = "comTxtRegisterDepartment";
            this.comTxtRegisterDepartment.Size = new System.Drawing.Size(181, 21);
            this.comTxtRegisterDepartment.TabIndex = 23;
            // 
            // lblRegisterSetPassword
            // 
            this.lblRegisterSetPassword.AutoSize = true;
            this.lblRegisterSetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterSetPassword.Location = new System.Drawing.Point(99, 329);
            this.lblRegisterSetPassword.Name = "lblRegisterSetPassword";
            this.lblRegisterSetPassword.Size = new System.Drawing.Size(94, 17);
            this.lblRegisterSetPassword.TabIndex = 25;
            this.lblRegisterSetPassword.Text = "Set Password";
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtRegisterPassword.Location = new System.Drawing.Point(200, 328);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(181, 20);
            this.txtRegisterPassword.TabIndex = 26;
            // 
            // btnRegisterRegister
            // 
            this.btnRegisterRegister.Location = new System.Drawing.Point(206, 371);
            this.btnRegisterRegister.Name = "btnRegisterRegister";
            this.btnRegisterRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterRegister.TabIndex = 27;
            this.btnRegisterRegister.Text = "Register";
            this.btnRegisterRegister.UseVisualStyleBackColor = true;
            this.btnRegisterRegister.Click += new System.EventHandler(this.btnRegisterRegister_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.registerToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblRegisterHelp
            // 
            this.lblRegisterHelp.AutoSize = true;
            this.lblRegisterHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterHelp.Location = new System.Drawing.Point(439, 391);
            this.lblRegisterHelp.Name = "lblRegisterHelp";
            this.lblRegisterHelp.Size = new System.Drawing.Size(37, 17);
            this.lblRegisterHelp.TabIndex = 29;
            this.lblRegisterHelp.TabStop = true;
            this.lblRegisterHelp.Text = "Help";
            this.lblRegisterHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRegisterHelp_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRegisterFirstName);
            this.groupBox1.Controls.Add(this.txtRegisterFirstName);
            this.groupBox1.Controls.Add(this.lblRegisterSurname);
            this.groupBox1.Controls.Add(this.txtRegisterSurname);
            this.groupBox1.Location = new System.Drawing.Point(65, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 100);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRegisterStaffEmail);
            this.groupBox2.Controls.Add(this.lblAtEmail);
            this.groupBox2.Controls.Add(this.lblRegisterStaffEmail);
            this.groupBox2.Controls.Add(this.txtRegisterStaffID);
            this.groupBox2.Controls.Add(this.lblRegisterStaffIdNumber);
            this.groupBox2.Controls.Add(this.lblRegisterDepartment);
            this.groupBox2.Controls.Add(this.comTxtRegisterDepartment);
            this.groupBox2.Location = new System.Drawing.Point(65, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 122);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee Information";
            // 
            // txtRegisterStaffEmail
            // 
            this.txtRegisterStaffEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtRegisterStaffEmail.Location = new System.Drawing.Point(134, 54);
            this.txtRegisterStaffEmail.Name = "txtRegisterStaffEmail";
            this.txtRegisterStaffEmail.Size = new System.Drawing.Size(116, 20);
            this.txtRegisterStaffEmail.TabIndex = 21;
            // 
            // lblAtEmail
            // 
            this.lblAtEmail.AutoSize = true;
            this.lblAtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtEmail.Location = new System.Drawing.Point(256, 54);
            this.lblAtEmail.Name = "lblAtEmail";
            this.lblAtEmail.Size = new System.Drawing.Size(60, 17);
            this.lblAtEmail.TabIndex = 26;
            this.lblAtEmail.Text = "@dbs.ie";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 417);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRegisterHelp);
            this.Controls.Add(this.btnRegisterRegister);
            this.Controls.Add(this.txtRegisterPassword);
            this.Controls.Add(this.lblRegisterSetPassword);
            this.Controls.Add(this.lblRegisterNewAdminRegistration);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RegistrationForm";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtRegisterStaffID;
        private System.Windows.Forms.Label lblRegisterStaffIdNumber;
        private System.Windows.Forms.Label lblRegisterNewAdminRegistration;
        private System.Windows.Forms.Label lblRegisterFirstName;
        private System.Windows.Forms.TextBox txtRegisterFirstName;
        private System.Windows.Forms.TextBox txtRegisterSurname;
        private System.Windows.Forms.Label lblRegisterSurname;
        private System.Windows.Forms.Label lblRegisterStaffEmail;
        private System.Windows.Forms.Label lblRegisterDepartment;
        private System.Windows.Forms.ComboBox comTxtRegisterDepartment;
        private System.Windows.Forms.Label lblRegisterSetPassword;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.Button btnRegisterRegister;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lblRegisterHelp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAtEmail;
        private System.Windows.Forms.TextBox txtRegisterStaffEmail;
    }
}