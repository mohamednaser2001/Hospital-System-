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
    public partial class AddDoctor : UserControl
    {
        // creating a list to store objects from type doctor or patient.
        List<Doctor> Person;
        //create object from type doctor to use it in some operation. 
        Doctor p ;
        public AddDoctor()
        {
            InitializeComponent();
            // Initializing the object p.
            p = new Doctor();
            // Initialize the person list.
            Person = new List<Doctor>();
        }
        private void AddDoctor_Load(object sender, EventArgs e)
        {
        }
        //create a method to save the data about the doctor object.
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            // store the data from the textboxes.
            p.FirstName = textFirstName.Text;
            p.LastName = textLastName.Text;
            p.ID = textDocId.Text;
            p.PhoneNumber = textNumber.Text;
            p.Email = textEmail.Text;
            p.Address = textAddress.Text;
            p.Age = int.Parse(textAge.Text);
            p.Gender = comboGender.Text;
            p.Medical_Section = textDepartment.Text;
            //adding the object to the list.
            Person.Add(p);
            //print a message to the screen.
            MessageBox.Show("Added Successfully");
        }
        private void lblDOcid_Click(object sender, EventArgs e)
        {

        }
        // method for clearing all textboes and labeles.
        private void btnClear_Click(object sender, EventArgs e)
        {
           textFirstName.Text = "";
           textLastName.Text= "";
           textDocId.Text = "";
           textEmail.Text = "";
           textDepartment.Text = "";
           textAge.Text = "";
           textNumber.Text = "";
           comboGender.Text = "";
           textAddress.Text = "";
           lblSearch.Text = "";
           lblDis.Text = "";
           textSearch.Text = "";
        }
        private void comboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        // method for displaying the information about the objects.
        private void Display(object sender, EventArgs e)
        {
            //Display the Information to make sure that it is right.
            p.FirstName = textFirstName.Text;
            p.LastName = textLastName.Text;
            p.ID = textDocId.Text;
            p.PhoneNumber = textNumber.Text;
            p.Email = textEmail.Text;
            p.Address = textAddress.Text;
            p.Age = int.Parse(textAge.Text);
            p.Gender = comboGender.Text;
            p.Medical_Section = textDepartment.Text;
            //print the information about the object.
            lblDis.Text = $"INFO :  \n Name : {p.FirstName + p.LastName} \n Age : {p.Age}\n ID : {p.ID}\n Gender : {p.Gender} \n PhoneNumber : {p.PhoneNumber} \n Email : {p.Email}\n Address : {p.Address}\n ";
        }
        // method for searching about specified doctor using his ID.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Looping through the list.
            foreach (Doctor pe in Person)
            {
                //checking if the id of the doctor is match the giving id.
                if (pe.ID == textSearch.Text)
                {
                    //display the information about the doctor.
                    lblSearch.Text = $"Found The Doctor. \nINFO :  \n Name : {p.FirstName + p.LastName} \n Age : {p.Age}\n ID : {p.ID}\n Gender : {p.Gender} \n PhoneNumber : {p.PhoneNumber} \n Email : {p.Email}\n Address : {p.Address}\n ";
                }
                else 
                {
                    lblSearch.Text = "Not Found!";
                }
            }
        }
        private void textSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void textLastName_TextChanged(object sender, EventArgs e)
        {

        }
        private void textDocId_TextChanged(object sender, EventArgs e)
        {

        }
        private void textAge_TextChanged(object sender, EventArgs e)
        {

        }
        private void textNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
