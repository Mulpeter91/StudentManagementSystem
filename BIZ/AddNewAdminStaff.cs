using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BIZ
{
    public class AddNewAdminStaff : AddData
    {
        public string StaffId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string StaffEmail { get; set; }
        public string Department { get; set; }
        public string Password { get; set; }

        public AddNewAdminStaff(string sI, string fn, string sn, string se, string dp, string pw)
        {
            StaffId = sI;
            FirstName = fn;
            Surname = sn;
            StaffEmail = se;
            Department = dp;
            Password = pw;
        }
        public void AddNewAdminStaffToDB()
        {
            AddNewAdminStaff(StaffId, FirstName, Surname, StaffEmail, Department, Password);
        }
    }
}
