using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BIZ;

namespace Mulpeter_10346867_AP_Assignment
{
    public partial class RegistrationForm : Form
    {
        HashCode hashCode = new HashCode();
        
        public RegistrationForm()
        {
            InitializeComponent();
        }
        private void btnRegisterRegister_Click(object sender, EventArgs e)
        {
            string staffId = txtRegisterStaffID.Text;
            string firstName = txtRegisterFirstName.Text;
            string surname = txtRegisterSurname.Text;
            string staffEmail = txtRegisterStaffEmail.Text + "@dbs.ie";
            string department = comTxtRegisterDepartment.Text;
            //string password = txtRegisterPassword.Text;
            string password = hashCode.PasswordHash(txtRegisterPassword.Text);

            AddNewAdminStaff addNewAdmin = new AddNewAdminStaff(staffId, firstName, surname, staffEmail, department, password);
            addNewAdmin.AddNewAdminStaffToDB();
            MessageBox.Show("New Admin Added");

            txtRegisterStaffID.Clear();
            txtRegisterFirstName.Clear();
            txtRegisterSurname.Clear();
            txtRegisterStaffEmail.Clear();
            comTxtRegisterDepartment.ResetText();
            txtRegisterPassword.Clear();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //refresh
            RegistrationForm register = new RegistrationForm();
            register.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterHelpForm helpForm = new RegisterHelpForm();
            helpForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblRegisterHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterHelpForm helpForm = new RegisterHelpForm();
            helpForm.Show();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            comTxtRegisterDepartment.DataSource = Enum.GetValues(typeof(SelectDepartment));
        }
    }
}
