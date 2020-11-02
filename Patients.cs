using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class Patient
    {
        public string Name { get; set; }        
        public string Blood_Group { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Treatment { get; set; }
        public string Address { get; set; }
        public long Phone { get; set; }
        public string Bill { get; set; }
        public string Next_Of_Kin { get; set; }                
        public long Next_Of_Kin_Phone { get; set; }
        public string Next_Of_Kin_Address { get; set; }

    }
}
