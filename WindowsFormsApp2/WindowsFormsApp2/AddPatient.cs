using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.NewFolder1;
namespace WindowsFormsApp2
{
    public partial class AddPatient : UserControl
    {
        // creating a list to store objects from type doctor or patient.
        List<Person> Person;
        //create object from type doctor to use it in some operation. 
        Patient p ;        
        public AddPatient()
        {
            InitializeComponent();
            // Initialize the person list.
            Person = new List<Person>();
            // Initializing the object p.
            p = new Patient();
        }
        //imaginary room id using Random Class.
        private int RoomID() 
        {
            Random random = new Random();
            int RoomID = random.Next(1, 20);
            return RoomID;
        }
        //create a method to save the data about the doctor object.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // store the data from the textboxes.
            p.FirstName = textFirstName.Text;
            p.LastName = textLastName.Text;
            p.PhoneNumber = textNumber.Text;
            p.Email = textEmail.Text;
            p.Address = textAddress.Text;
            p.Age = int.Parse(textAge.Text);
            p.Gender = comboGender.Text;
            p.Disease = textDepartment.Text;
            p.Patient_Room_ID = RoomID().ToString();
            //adding the object to the list.
            Person.Add(p);
            //print a message to the screen.
            MessageBox.Show("Added Successfully");
        }
        // method for clearing all textboes and labeles.
        private void btnClear_Click(object sender, EventArgs e)
        {
            textFirstName.Text = "";
            textLastName.Text = "";
            textEmail.Text = "";
            textDepartment.Text = "";
            textAge.Text = "";
            textNumber.Text = "";
            comboGender.Text = "";
            textAddress.Text = "";
            lblSearcH.Text = "";
            lblDisPAtient.Text = "";
            textSearcH.Text = "";
        }
        //Display the information about the current patient object.
        private void btnDis_Click(object sender, EventArgs e)
        {
            p.FirstName = textFirstName.Text;
            p.LastName = textLastName.Text;
            p.PhoneNumber = textNumber.Text;
            p.Email = textEmail.Text;
            p.Address = textAddress.Text;
            p.Age = int.Parse(textAge.Text);
            p.Gender = comboGender.Text;
            p.Disease = textDepartment.Text;
            p.Patient_Room_ID = RoomID().ToString();
            lblDisPAtient.Text = $"Name : {p.FirstName + p.LastName} \n Age : {p.Age}\n Gender : {p.Gender} \n PhoneNumber : {p.PhoneNumber}\n Email : {p.Email}\n Address : {p.Address}\n Disease : {p.Disease}\n Room-ID : {p.Patient_Room_ID}\n";
           
        }
        // method for searching about specified Patient using his/her name.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Looping through the list.
            foreach (var pe in Person)
            {
                //if we Found the patient by the name.
                    if (p.FirstName.ToLower() + p.LastName.ToLower() == textSearcH.Text.ToLower())
                    {
                       //display his/her information.
                        lblSearcH.Text = $"Name : {p.FirstName + p.LastName} \n Age : {p.Age}\n Gender : {p.Gender} \n PhoneNumber : {p.PhoneNumber}\n Email : {p.Email}\n Address : {p.Address}\n Disease : {p.Disease}\n Room-ID : {p.Patient_Room_ID}\n";
                    }
            }
        }
        private void AddPatient_Load(object sender, EventArgs e)
        {

        }
        private void lblSearch_Click(object sender, EventArgs e)
        {

        }
        private void lblDisPAtient_Click(object sender, EventArgs e)
        {

        }
        private void textFirstName_TextChanged(object sender, EventArgs e)
        {

        }
        private void textLastName_TextChanged(object sender, EventArgs e)
        {

        }
        private void textAge_TextChanged(object sender, EventArgs e)
        {

        }
        private void textNumber_TextChanged(object sender, EventArgs e)
        {

        }
        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }
        private void textAddress_TextChanged(object sender, EventArgs e)
        {

        }
        private void textDepartment_TextChanged(object sender, EventArgs e)
        {

        }
        private void textSearcH_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
