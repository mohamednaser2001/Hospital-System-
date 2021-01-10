using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.NewFolder1
{
    // class for doctor inherit from person class and with two addtional props.                                                                    
    class Doctor : Person
    {
        public string  Medical_Section { get; set; }
        public string ID { get; set; }
       public void print(Doctor p )
       {
            Console.WriteLine( $"Found The Doctor. \n INFO :  \nName : {p.FirstName + p.LastName} \n Age : {p.Age}\n ID : {p.ID}\n Gender : {p.Gender} \n PhoneNumber : {p.PhoneNumber} \n Email : {p.Email}\n Address : {p.Address}\n ");
       }
    }
}
