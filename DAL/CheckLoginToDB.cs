using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class CheckLoginToDB : DAO
    {
        public string UserLoginName { get; set; }

        public string CheckAdmin (string sI, string pw)
        {
            SqlDataReader dataReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM adminStaff WHERE staffId=@sI AND password=@pw", OpenConnection());
            command.Parameters.AddWithValue("@sI", sI);
            command.Parameters.AddWithValue("@pw", pw);

            dataReader = command.ExecuteReader();

            if (dataReader.Read())
            {
                UserLoginName = dataReader.GetString(3);
                CloseConnection();
                return UserLoginName;
            }
            else
            {
                CloseConnection();
                string no = "no";
                return no;
            }
        }
    }
}
