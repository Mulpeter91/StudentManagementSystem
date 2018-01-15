using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Drawing;


namespace DAL
{
    public class AddData : DAO
    {
        public void AddNewAdminStaff(string sI, string fn, string sn, string se, string dp, string pw)
        {  
            SqlCommand command = new SqlCommand (" INSERT INTO adminStaff (staffId, firstName, surname, staffEmail, department, password) VALUES (@sI, @fn, @sn, @se, @dp, @pw)", OpenConnection());

            command.Parameters.AddWithValue("@sI", sI);
            command.Parameters.AddWithValue("@fn", fn);
            command.Parameters.AddWithValue("@sn", sn);
            command.Parameters.AddWithValue("@se", se);
            command.Parameters.AddWithValue("@dp", dp);
            command.Parameters.AddWithValue("@pw", pw);
            command.ExecuteNonQuery();
            CloseConnection();
        } 
        public void AddNewStudent(int sI, string fn, string sn, string em, string ph, string a1, string a2
            , string cy, string co, string lv, string cu)
        {
            SqlCommand command = new SqlCommand(" INSERT INTO students (studentId, firstName, surname, email, phone, addressLine1, addressLine2, city, county, level, course) VALUES (@sI, @fn, @sn, @em, @ph, @a1, @a2, @cy, @co, @lv, @cu)", OpenConnection());

            command.Parameters.AddWithValue("@sI", sI);
            command.Parameters.AddWithValue("@fn", fn);
            command.Parameters.AddWithValue("@sn", sn);
            command.Parameters.AddWithValue("@em", em);
            command.Parameters.AddWithValue("@ph", ph);
            command.Parameters.AddWithValue("@a1", a1);
            command.Parameters.AddWithValue("@a2", a2);
            command.Parameters.AddWithValue("@cy", cy);
            command.Parameters.AddWithValue("@co", co);
            command.Parameters.AddWithValue("@lv", lv);
            command.Parameters.AddWithValue("@cu", cu);
            command.ExecuteNonQuery();
            CloseConnection();
        }  
    }
}
