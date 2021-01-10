using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.NewFolder1
{
    // class for patient inherit from person class and with two addtional props.                                                                    
    class Patient : Person
    {
        public string  Disease { get; set; }
        public int Payment { get; set; }
        public string Patient_Room_ID { get; set; }
     
    }
}
