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
    public partial class EditStudentForm : Form
    {
        EditStudent ed = new EditStudent();

        public List<EditStudent> EditStudentList = new List<EditStudent>();

        public EditStudentForm()
        {
            InitializeComponent();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            int studentId = int.Parse(txtEditStudentSNumber.Text);
            string firstName = txtEditStudentFirstName.Text;
            string surname = txtEditStudentSurname.Text;
            string email = txtEditStudentEmail.Text;
            string phone = txtEditStudentPhone.Text;
            string addressL1 = txtEditStudentAddress1.Text;
            string addressL2 = txtEditStudentAddress2.Text;
            string city = txtEditStudentCity.Text;
            string county = cbEditStudentCounty.Text;
            string level = "";

            if (rdoEditStudentPostgrad.Text == "Postgraduate")
            {
                level = rdoEditStudentPostgrad.Text;
            }
            else if(rdoEditStudentUndergrad.Text == "Undergraduate")
            {
                level = rdoEditStudentUndergrad.Text;
            }
            string course = cbEditStudentCourse.Text;
            
            ed.BizEditStudent(studentId, firstName, surname, email, phone, addressL1, addressL2, city, county, level, course);
            MessageBox.Show("Student Edited in Database");
        }

        private void EditStudentForm_Load(object sender, EventArgs e)
        {
            txtEditStudentSNumber.Text = EditStudentList[0].StudentID.ToString();
            txtEditStudentFirstName.Text = EditStudentList[0].FirstName;
            txtEditStudentSurname.Text = EditStudentList[0].Surname;
            txtEditStudentEmail.Text = EditStudentList[0].Email;
            txtEditStudentPhone.Text = EditStudentList[0].Phone;
            txtEditStudentAddress1.Text = EditStudentList[0].AddressLine1;
            txtEditStudentAddress2.Text = EditStudentList[0].AddressLine2;
            txtEditStudentCity.Text = EditStudentList[0].City;
            cbEditStudentCounty.Text = EditStudentList[0].County;

            if(EditStudentList[0].Level == "Postgraduate")
            {
                rdoEditStudentPostgrad.Checked = true;
            }
            else if(EditStudentList[0].Level == "Undergraduate")
            {
                rdoEditStudentUndergrad.Checked = true;
            }

            cbEditStudentCourse.Text = EditStudentList[0].Course;
            //imgEditStudentPicture.Image = EditStudentList[0];
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
