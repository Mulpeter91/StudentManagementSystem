using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DAL;

namespace BIZ
{
    public class AddNewStudent : AddData
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Level { get; set; }
        public string Course { get; set; }        
        

        public AddNewStudent(int sI, string fn, string sn, string em, string ph, string a1, string a2,
            string cy, string co, string lv, string cu)
        { 
            StudentID = sI;
            FirstName = fn;
            Surname = sn;
            Email = em;
            Phone = ph;
            AddressLine1 = a1;
            AddressLine2 = a2;
            City = cy;
            County = co;
            Level = lv;
            Course = cu;
        }

        public void AddNewStudentToDB()
        {
            AddNewStudent(StudentID, FirstName, Surname, Email, Phone, AddressLine1, AddressLine2,
                City, County, Level, Course);
        }

    }
}
