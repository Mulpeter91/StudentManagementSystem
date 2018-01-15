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
using DAL;

namespace Mulpeter_10346867_AP_Assignment
{
    public partial class HomeForm : Form
    {
        //move to correct Tier
        DAO dao = new DAO();
        SqlDataAdapter da;
        DataTable dt;
        BindingSource bs;


        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            ShowStudents showStudents = new ShowStudents();
            dgvStudents.DataSource = showStudents.GetStudents();
        }

        private void btnHomeAdd_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.Show();
        }

        private void addNewStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.Show();            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //more to correct Tier
        private void updateGrid()
        {
            dt = new DataTable();
            bs = new BindingSource();
            da = new SqlDataAdapter();

            SqlCommand command = new SqlCommand(" SELECT * FROM students", dao.OpenConnection());
            da.SelectCommand = command;
            da.Fill(dt);
            bs.DataSource = dt;
            dgvStudents.DataSource = bs;

            dao.CloseConnection();

        }

        //move to correct Tier
        private void btnHomeDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                SqlCommand command = new SqlCommand(" DELETE FROM students WHERE studentId=@stuID", dao.OpenConnection());

                command.Parameters.AddWithValue("@stuID", dgvStudents.SelectedRows[0].Cells[0].Value);
                command.ExecuteScalar();

                dao.CloseConnection();
                updateGrid();
            }
            else
            {
                MessageBox.Show("Select Full Row");
            }        
        }

        private void btnHomeRefresh_Click(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void btnHomeEdit_Click(object sender, EventArgs e)
        {
            EditStudent editStudent = new EditStudent();
            EditStudentForm editStudentForm = new EditStudentForm();
            if (dgvStudents.SelectedRows.Count > 0)
            {
                string selectedRow = dgvStudents.SelectedRows[0].Cells[0].Value.ToString();

                foreach (DataGridViewRow row in dgvStudents.SelectedRows)
                {
                    editStudent.StudentID = int.Parse(row.Cells[0].Value.ToString());
                    editStudent.FirstName = row.Cells[1].Value.ToString();
                    editStudent.Surname = row.Cells[2].Value.ToString();
                    editStudent.Email = row.Cells[3].Value.ToString();
                    editStudent.Phone = row.Cells[4].Value.ToString();
                    editStudent.AddressLine1 = row.Cells[5].Value.ToString();
                    editStudent.AddressLine2 = row.Cells[6].Value.ToString();
                    editStudent.City = row.Cells[7].Value.ToString();
                    editStudent.County = row.Cells[8].Value.ToString();

                    if (row.Cells[9].Value.ToString() == "Postgraduate")
                    {
                        editStudent.Level = "Postgraduate";
                    }
                    else if (row.Cells[9].Value.ToString() == "Undergraduate")
                    {
                        editStudent.Level = "Undergraduate";
                    }
                    editStudent.Course = row.Cells[10].Value.ToString();

                    editStudentForm.EditStudentList.Add(editStudent);
                }
                editStudentForm.Show();
            }
            else
            {
                MessageBox.Show("Select Full Row");
            }
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditStudentForm editStudentForm = new EditStudentForm();
            editStudentForm.Show();
        }

        //move to correct Tier
        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(" DELETE FROM students WHERE studentId = @stuID", dao.OpenConnection());

            command.Parameters.AddWithValue("@stuID", dgvStudents.SelectedRows[0].Cells[0].Value);
            command.ExecuteScalar();

            dao.CloseConnection();
            updateGrid();
        }

        private void refreshHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void viewInNewWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //New Form Needed
        }

        private void viewHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewHistoryForm vh = new ViewHistoryForm();
            vh.Show();
        }
    }
}
