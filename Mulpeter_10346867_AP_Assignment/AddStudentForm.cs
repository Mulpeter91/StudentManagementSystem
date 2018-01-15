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
using System.IO;
using BIZ;
using DAL;

namespace Mulpeter_10346867_AP_Assignment
{
    public partial class AddStudentForm : Form
    {       
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnAddStudentAdd_Click(object sender, EventArgs e)
        {          


            int studentId = int.Parse(txtAddStudentSNumber.Text);
            string fname = txtAddStudentFirstName.Text;
            string surname = txtAddStudentSurname.Text;
            string email = txtAddStudentEmail.Text + "@mydbs.ie";
            string phone = txtAddStudentPhone.Text;
            string addressLine1 = txtAddStudentAddress1.Text;
            string addressLine2 = txtAddStudentAddress2.Text;
            string city = txtAddStudentCity.Text;
            string county = cbAddStudentCounty.SelectedItem.ToString();
            
            string course = cbAddStudentCourse.Text;
            string level = "Undergraduate";
            

            if (rdoAddStudentUndergrad.Checked)
            {
                level = "Undergraduate";
            }
            else if (rdoAddStudentPostgrad.Checked)
            {
                level = "Postgraduate";
            }

            AddNewStudent addNewStudent = new AddNewStudent(studentId, fname, surname, email, phone, addressLine1, addressLine2,
                city, county, level, course);
            addNewStudent.AddNewStudentToDB();

            ////----------Move to Correct Tier

            //MemoryStream memoryStream = new MemoryStream();
            //imgAddStudentPicture.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            //imgAddStudentPicture.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            //byte[] picture = new byte[memoryStream.Length];
            //memoryStream.Position = 0;
            //memoryStream.Read(picture, 0, picture.Length);

            //DAO dao = new DAO();
            //SqlCommand command = new SqlCommand("INSERT INTO students (images) VALUES (@img)", dao.OpenConnection());
            //command.Parameters.AddWithValue("@img", picture);
            //command.ExecuteNonQuery();
            //dao.CloseConnection();

            ////-----------End of Image

            MessageBox.Show("Student Added to Database");

            txtAddStudentSNumber.Clear();
            txtAddStudentFirstName.Clear();
            txtAddStudentSurname.Clear();
            txtAddStudentCity.Clear();
            txtAddStudentEmail.Clear();
            txtAddStudentPhone.Clear();
            txtAddStudentAddress1.Clear();
            txtAddStudentAddress2.Clear();
            txtAddStudentCity.Clear();
            cbAddStudentCounty.ResetText();
            //imgAddStudentPicture.ResetText();

            rdoAddStudentPostgrad.Checked = false;
            rdoAddStudentUndergrad.Checked = false;

            cbAddStudentCourse.ResetText();            
        }
        private void AddStudentForm_Closing(object sender, CancelEventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            registration.Update();
        }

        ////Move to correct Tier
        private void btnAddStudentPicture_Click(object sender, EventArgs e)
        {
        //    OpenFileDialog openFile = new OpenFileDialog();
        //    openFile.Filter = "JPEGs (*.jpg)|*.jpg|PNGs (*.png)|*.png";
        //    DialogResult dialogResult = openFile.ShowDialog();
            
        //    if(dialogResult == DialogResult.Cancel)
        //    {
        //        return;
        //    }
        //    imgAddStudentPicture.Image = Image.FromFile(openFile.FileName);
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            cbAddStudentCounty.DataSource = Enum.GetValues(typeof(SelectCounty));
            cbAddStudentCourse.DataSource = Enum.GetValues(typeof(SelectCourse));
        }
    }
}
