using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModel
{
    public class Publisher
    {
        public int PubID { get; set; }
        public string Name { get; set; }
        public int Telephonenum { get; set; }
        public string Address { get; set; }
        public Publisher() 
        {
        }
        public Publisher(int id)
        {
            this.PubID = id;
        }
    }
}
