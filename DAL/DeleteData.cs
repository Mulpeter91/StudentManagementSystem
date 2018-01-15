using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DeleteData
    {
        public void DeleteStudent()
        {
            SqlCommand command = new SqlCommand("DELETE FROM students WHERE studentId=@stID");            
        }
    }
}
