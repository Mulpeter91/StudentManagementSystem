using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BIZ;

namespace Mulpeter_10346867_AP_Assignment
{
    public partial class LoginForm : Form
    {
        CheckLoginToDB checkLoginCredentials = new CheckLoginToDB();
        HashCode hashCode = new HashCode();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLoginLogin_Click(object sender, EventArgs e)
        {
            string staffId = mtxtLoginStaffId.Text;
            //string password = txtLoginPassword.Text;
            string password = hashCode.PasswordHash(txtLoginPassword.Text);
            string status = checkLoginCredentials.CheckAdmin(staffId, password);

            if (status == "no")
            {
                MessageBox.Show("Invalid Login");
                mtxtLoginStaffId.Clear();
                txtLoginPassword.Clear();
            }
            else
            {                
                HomeForm homeForm = new HomeForm();
                homeForm.Show();
            }
        }

        private void btnLoginRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm register = new RegistrationForm();
            register.Show();
        }

        private void lblLoginHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginHelpForm helpForm = new LoginHelpForm();
            helpForm.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set to refresh
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm register = new RegistrationForm();
            register.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginHelpForm helpForm = new LoginHelpForm();
            helpForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
