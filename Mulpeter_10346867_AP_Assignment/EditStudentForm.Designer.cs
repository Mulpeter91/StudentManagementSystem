namespace Mulpeter_10346867_AP_Assignment
{
    partial class EditStudentForm
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
            this.gbAddStudentCollege = new System.Windows.Forms.GroupBox();
            this.cbEditStudentCourse = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.rdoEditStudentPostgrad = new System.Windows.Forms.RadioButton();
            this.rdoEditStudentUndergrad = new System.Windows.Forms.RadioButton();
            this.lblAddStudentLevel = new System.Windows.Forms.Label();
            this.gbAddStudentAddress = new System.Windows.Forms.GroupBox();
            this.cbEditStudentCounty = new System.Windows.Forms.ComboBox();
            this.txtEditStudentCity = new System.Windows.Forms.TextBox();
            this.txtEditStudentAddress2 = new System.Windows.Forms.TextBox();
            this.txtEditStudentAddress1 = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.gpAddStudentPersonal = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEditStudentEmail = new System.Windows.Forms.MaskedTextBox();
            this.txtEditStudentPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtEditStudentSurname = new System.Windows.Forms.TextBox();
            this.txtEditStudentFirstName = new System.Windows.Forms.TextBox();
            this.txtEditStudentSNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imgEditStudentPicture = new System.Windows.Forms.PictureBox();
            this.btnEditStudentPicture = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.gbAddStudentCollege.SuspendLayout();
            this.gbAddStudentAddress.SuspendLayout();
            this.gpAddStudentPersonal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEditStudentPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddStudentCollege
            // 
            this.gbAddStudentCollege.Controls.Add(this.cbEditStudentCourse);
            this.gbAddStudentCollege.Controls.Add(this.lblCourse);
            this.gbAddStudentCollege.Controls.Add(this.rdoEditStudentPostgrad);
            this.gbAddStudentCollege.Controls.Add(this.rdoEditStudentUndergrad);
            this.gbAddStudentCollege.Controls.Add(this.lblAddStudentLevel);
            this.gbAddStudentCollege.Location = new System.Drawing.Point(373, 210);
            this.gbAddStudentCollege.Name = "gbAddStudentCollege";
            this.gbAddStudentCollege.Size = new System.Drawing.Size(252, 156);
            this.gbAddStudentCollege.TabIndex = 6;
            this.gbAddStudentCollege.TabStop = false;
            this.gbAddStudentCollege.Text = "Course Information";
            // 
            // cbEditStudentCourse
            // 
            this.cbEditStudentCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbEditStudentCourse.Enabled = false;
            this.cbEditStudentCourse.FormattingEnabled = true;
            this.cbEditStudentCourse.Items.AddRange(new object[] {
            "Commerce",
            "Computer Science",
            "Engineering",
            "Law",
            "Medicine",
            "Natural Science",
            "Social Science"});
            this.cbEditStudentCourse.Location = new System.Drawing.Point(103, 84);
            this.cbEditStudentCourse.Name = "cbEditStudentCourse";
            this.cbEditStudentCourse.Size = new System.Drawing.Size(135, 21);
            this.cbEditStudentCourse.TabIndex = 11;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(51, 88);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCourse.Size = new System.Drawing.Size(40, 13);
            this.lblCourse.TabIndex = 5;
            this.lblCourse.Text = "Course";
            // 
            // rdoEditStudentPostgrad
            // 
            this.rdoEditStudentPostgrad.AutoSize = true;
            this.rdoEditStudentPostgrad.Location = new System.Drawing.Point(103, 57);
            this.rdoEditStudentPostgrad.Name = "rdoEditStudentPostgrad";
            this.rdoEditStudentPostgrad.Size = new System.Drawing.Size(88, 17);
            this.rdoEditStudentPostgrad.TabIndex = 4;
            this.rdoEditStudentPostgrad.TabStop = true;
            this.rdoEditStudentPostgrad.Text = "Postgraduate";
            this.rdoEditStudentPostgrad.UseVisualStyleBackColor = true;
            // 
            // rdoEditStudentUndergrad
            // 
            this.rdoEditStudentUndergrad.AutoSize = true;
            this.rdoEditStudentUndergrad.Location = new System.Drawing.Point(103, 33);
            this.rdoEditStudentUndergrad.Name = "rdoEditStudentUndergrad";
            this.rdoEditStudentUndergrad.Size = new System.Drawing.Size(96, 17);
            this.rdoEditStudentUndergrad.TabIndex = 3;
            this.rdoEditStudentUndergrad.TabStop = true;
            this.rdoEditStudentUndergrad.Text = "Undergraduate";
            this.rdoEditStudentUndergrad.UseVisualStyleBackColor = true;
            // 
            // lblAddStudentLevel
            // 
            this.lblAddStudentLevel.AutoSize = true;
            this.lblAddStudentLevel.Location = new System.Drawing.Point(18, 35);
            this.lblAddStudentLevel.Name = "lblAddStudentLevel";
            this.lblAddStudentLevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAddStudentLevel.Size = new System.Drawing.Size(73, 13);
            this.lblAddStudentLevel.TabIndex = 2;
            this.lblAddStudentLevel.Text = "Student Level";
            // 
            // gbAddStudentAddress
            // 
            this.gbAddStudentAddress.Controls.Add(this.cbEditStudentCounty);
            this.gbAddStudentAddress.Controls.Add(this.txtEditStudentCity);
            this.gbAddStudentAddress.Controls.Add(this.txtEditStudentAddress2);
            this.gbAddStudentAddress.Controls.Add(this.txtEditStudentAddress1);
            this.gbAddStudentAddress.Controls.Add(this.lblCounty);
            this.gbAddStudentAddress.Controls.Add(this.lblCity);
            this.gbAddStudentAddress.Controls.Add(this.lblAddressLine2);
            this.gbAddStudentAddress.Controls.Add(this.lblAddressLine1);
            this.gbAddStudentAddress.Location = new System.Drawing.Point(13, 210);
            this.gbAddStudentAddress.Name = "gbAddStudentAddress";
            this.gbAddStudentAddress.Size = new System.Drawing.Size(344, 156);
            this.gbAddStudentAddress.TabIndex = 5;
            this.gbAddStudentAddress.TabStop = false;
            this.gbAddStudentAddress.Text = "Address";
            // 
            // cbEditStudentCounty
            // 
            this.cbEditStudentCounty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbEditStudentCounty.FormattingEnabled = true;
            this.cbEditStudentCounty.Items.AddRange(new object[] {
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Derry",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.cbEditStudentCounty.Location = new System.Drawing.Point(135, 112);
            this.cbEditStudentCounty.Name = "cbEditStudentCounty";
            this.cbEditStudentCounty.Size = new System.Drawing.Size(182, 21);
            this.cbEditStudentCounty.TabIndex = 10;
            // 
            // txtEditStudentCity
            // 
            this.txtEditStudentCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEditStudentCity.Location = new System.Drawing.Point(135, 85);
            this.txtEditStudentCity.Name = "txtEditStudentCity";
            this.txtEditStudentCity.Size = new System.Drawing.Size(182, 20);
            this.txtEditStudentCity.TabIndex = 9;
            // 
            // txtEditStudentAddress2
            // 
            this.txtEditStudentAddress2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEditStudentAddress2.Location = new System.Drawing.Point(135, 58);
            this.txtEditStudentAddress2.Name = "txtEditStudentAddress2";
            this.txtEditStudentAddress2.Size = new System.Drawing.Size(182, 20);
            this.txtEditStudentAddress2.TabIndex = 8;
            // 
            // txtEditStudentAddress1
            // 
            this.txtEditStudentAddress1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEditStudentAddress1.Location = new System.Drawing.Point(135, 30);
            this.txtEditStudentAddress1.Name = "txtEditStudentAddress1";
            this.txtEditStudentAddress1.Size = new System.Drawing.Size(182, 20);
            this.txtEditStudentAddress1.TabIndex = 7;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(86, 115);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(40, 13);
            this.lblCounty.TabIndex = 4;
            this.lblCounty.Text = "County";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(102, 88);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City";
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(27, 61);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(99, 13);
            this.lblAddressLine2.TabIndex = 2;
            this.lblAddressLine2.Text = "Add Address Line 2";
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(27, 33);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(99, 13);
            this.lblAddressLine1.TabIndex = 1;
            this.lblAddressLine1.Text = "Add Address Line 1";
            // 
            // gpAddStudentPersonal
            // 
            this.gpAddStudentPersonal.Controls.Add(this.label1);
            this.gpAddStudentPersonal.Controls.Add(this.txtEditStudentEmail);
            this.gpAddStudentPersonal.Controls.Add(this.txtEditStudentPhone);
            this.gpAddStudentPersonal.Controls.Add(this.txtEditStudentSurname);
            this.gpAddStudentPersonal.Controls.Add(this.txtEditStudentFirstName);
            this.gpAddStudentPersonal.Controls.Add(this.txtEditStudentSNumber);
            this.gpAddStudentPersonal.Controls.Add(this.lblPhone);
            this.gpAddStudentPersonal.Controls.Add(this.lblEmail);
            this.gpAddStudentPersonal.Controls.Add(this.lblSurname);
            this.gpAddStudentPersonal.Controls.Add(this.lblFirstName);
            this.gpAddStudentPersonal.Controls.Add(this.lblStudentNumber);
            this.gpAddStudentPersonal.Location = new System.Drawing.Point(13, 13);
            this.gpAddStudentPersonal.Name = "gpAddStudentPersonal";
            this.gpAddStudentPersonal.Size = new System.Drawing.Size(344, 179);
            this.gpAddStudentPersonal.TabIndex = 4;
            this.gpAddStudentPersonal.TabStop = false;
            this.gpAddStudentPersonal.Text = "Personal Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "@mydbs.ie";
            // 
            // txtEditStudentEmail
            // 
            this.txtEditStudentEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEditStudentEmail.Location = new System.Drawing.Point(132, 115);
            this.txtEditStudentEmail.Mask = "00000000";
            this.txtEditStudentEmail.Name = "txtEditStudentEmail";
            this.txtEditStudentEmail.Size = new System.Drawing.Size(61, 20);
            this.txtEditStudentEmail.TabIndex = 9;
            // 
            // txtEditStudentPhone
            // 
            this.txtEditStudentPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEditStudentPhone.Location = new System.Drawing.Point(132, 141);
            this.txtEditStudentPhone.Mask = "(999) 000-0000";
            this.txtEditStudentPhone.Name = "txtEditStudentPhone";
            this.txtEditStudentPhone.Size = new System.Drawing.Size(185, 20);
            this.txtEditStudentPhone.TabIndex = 8;
            // 
            // txtEditStudentSurname
            // 
            this.txtEditStudentSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEditStudentSurname.Location = new System.Drawing.Point(132, 87);
            this.txtEditStudentSurname.Name = "txtEditStudentSurname";
            this.txtEditStudentSurname.ReadOnly = true;
            this.txtEditStudentSurname.Size = new System.Drawing.Size(185, 20);
            this.txtEditStudentSurname.TabIndex = 7;
            // 
            // txtEditStudentFirstName
            // 
            this.txtEditStudentFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEditStudentFirstName.Location = new System.Drawing.Point(132, 61);
            this.txtEditStudentFirstName.Name = "txtEditStudentFirstName";
            this.txtEditStudentFirstName.ReadOnly = true;
            this.txtEditStudentFirstName.Size = new System.Drawing.Size(185, 20);
            this.txtEditStudentFirstName.TabIndex = 6;
            // 
            // txtEditStudentSNumber
            // 
            this.txtEditStudentSNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEditStudentSNumber.Location = new System.Drawing.Point(132, 33);
            this.txtEditStudentSNumber.Mask = "00000000";
            this.txtEditStudentSNumber.Name = "txtEditStudentSNumber";
            this.txtEditStudentSNumber.ReadOnly = true;
            this.txtEditStudentSNumber.Size = new System.Drawing.Size(185, 20);
            this.txtEditStudentSNumber.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(88, 144);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(94, 118);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(77, 91);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(69, 64);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Location = new System.Drawing.Point(42, 36);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(84, 13);
            this.lblStudentNumber.TabIndex = 0;
            this.lblStudentNumber.Text = "Student Number";
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.Location = new System.Drawing.Point(330, 383);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(75, 23);
            this.btnEditCancel.TabIndex = 8;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imgEditStudentPicture);
            this.groupBox1.Controls.Add(this.btnEditStudentPicture);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(373, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 179);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picture";
            // 
            // imgEditStudentPicture
            // 
            this.imgEditStudentPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.imgEditStudentPicture.Location = new System.Drawing.Point(103, 19);
            this.imgEditStudentPicture.Name = "imgEditStudentPicture";
            this.imgEditStudentPicture.Size = new System.Drawing.Size(135, 142);
            this.imgEditStudentPicture.TabIndex = 4;
            this.imgEditStudentPicture.TabStop = false;
            // 
            // btnEditStudentPicture
            // 
            this.btnEditStudentPicture.Location = new System.Drawing.Point(18, 58);
            this.btnEditStudentPicture.Name = "btnEditStudentPicture";
            this.btnEditStudentPicture.Size = new System.Drawing.Size(75, 23);
            this.btnEditStudentPicture.TabIndex = 3;
            this.btnEditStudentPicture.Text = "Browse";
            this.btnEditStudentPicture.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 35);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Picture";
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(235, 383);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEdit.TabIndex = 10;
            this.btnSaveEdit.Text = "Save";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 419);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEditCancel);
            this.Controls.Add(this.gbAddStudentCollege);
            this.Controls.Add(this.gbAddStudentAddress);
            this.Controls.Add(this.gpAddStudentPersonal);
            this.Name = "EditStudentForm";
            this.Text = "EditStudentForm";
            this.Load += new System.EventHandler(this.EditStudentForm_Load);
            this.gbAddStudentCollege.ResumeLayout(false);
            this.gbAddStudentCollege.PerformLayout();
            this.gbAddStudentAddress.ResumeLayout(false);
            this.gbAddStudentAddress.PerformLayout();
            this.gpAddStudentPersonal.ResumeLayout(false);
            this.gpAddStudentPersonal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEditStudentPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.GroupBox gbAddStudentCollege;
        private System.Windows.Forms.ComboBox cbEditStudentCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.RadioButton rdoEditStudentPostgrad;
        private System.Windows.Forms.RadioButton rdoEditStudentUndergrad;
        private System.Windows.Forms.Label lblAddStudentLevel;
        private System.Windows.Forms.GroupBox gbAddStudentAddress;
        private System.Windows.Forms.ComboBox cbEditStudentCounty;
        private System.Windows.Forms.TextBox txtEditStudentCity;
        private System.Windows.Forms.TextBox txtEditStudentAddress2;
        private System.Windows.Forms.TextBox txtEditStudentAddress1;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.GroupBox gpAddStudentPersonal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtEditStudentEmail;
        private System.Windows.Forms.MaskedTextBox txtEditStudentPhone;
        private System.Windows.Forms.TextBox txtEditStudentSurname;
        private System.Windows.Forms.TextBox txtEditStudentFirstName;
        private System.Windows.Forms.MaskedTextBox txtEditStudentSNumber;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imgEditStudentPicture;
        private System.Windows.Forms.Button btnEditStudentPicture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveEdit;
    }
}