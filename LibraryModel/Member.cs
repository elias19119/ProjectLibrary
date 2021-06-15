using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModel
{
    public class Member
    {
        public int MembID { get; set; }
        public string First_Name { get; set; }
        public string Memb_Type { get; set; }
        public string Address { get; set; }
        public DateTime Memb_Date { get; set; }
        public DateTime Expiry_Date { get; set; }

    }
}
