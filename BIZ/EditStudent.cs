using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BIZ
{      
    public class EditStudent
    {
        EditData ed = new EditData();

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

        public void BizEditStudent(int sI, string fn, string sn, string em, string ph, string a1, string a2,
            string cy, string co, string lv, string cu)
        {
            ed.EditStudent(sI, fn, sn, em, ph, a1, a2, cy, co, lv, cu);
        }
    }
}
