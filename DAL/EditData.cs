using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class EditData : DAO
    {
        public void EditStudent(int sI, string fn, string sn, string em, string ph, string a1, string a2
            , string cy, string co, string lv, string cu)
        {
            SqlCommand command = new SqlCommand(" UPDATE students SET studentId = @sI, email = @em, phone = @ph, addressLine1 = @a1, addressLine2 = @a2, city = @cy, county = @co, level = @lv WHERE firstName = @fn AND surname = @sn", OpenConnection());

            command.Parameters.AddWithValue("@fn", fn);
            command.Parameters.AddWithValue("@sn", sn);
            command.Parameters.AddWithValue("@sI", sI);
            command.Parameters.AddWithValue("@em", em);
            command.Parameters.AddWithValue("@ph", ph);
            command.Parameters.AddWithValue("@a1", a1);
            command.Parameters.AddWithValue("@a2", a2);
            command.Parameters.AddWithValue("@cy", cy);
            command.Parameters.AddWithValue("@lv", lv);
            command.Parameters.AddWithValue("@co", co);
            command.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
