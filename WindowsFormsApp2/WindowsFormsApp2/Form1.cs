using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.NewFolder1;
using FontAwesome.Sharp;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private IconButton curbtn;
        private Panel leftbordbtn;
        public Form1()
        {
            InitializeComponent();
            leftbordbtn = new Panel();
            leftbordbtn.Size = new Size(7, 60);
            paMenu.Controls.Add(leftbordbtn);
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249,118,176);
            public static Color color3 = Color.FromArgb(253, 138, 114);  
            public static Color color4 = Color.FromArgb(95, 77, 221);   
            public static Color color5 = Color.FromArgb(249, 88, 155);  
            public static Color color6 = Color.FromArgb(24, 161, 251); 
        
        }
        private void ActiveBTn(object sender , Color color) 
        {
            if (sender != null)
            {
                DisableBtn();
                //btn
                curbtn = (IconButton)sender;
                curbtn.BackColor = Color.FromArgb(37, 36, 81);
                curbtn.ForeColor = color;
                curbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                curbtn.ImageAlign = ContentAlignment.MiddleRight;

                //LeftBorderbtn
                leftbordbtn.BackColor = color;
                leftbordbtn.Location = new Point(0, curbtn.Location.Y);
                leftbordbtn.Visible = true;
                leftbordbtn.BringToFront();
                // Icon Current Child Form
                iconcur.IconChar = curbtn.IconChar;
                iconcur.IconColor = color;
                lblcur.Text = curbtn.Text;
            }
        }
        private void DisableBtn()
        {
            if (curbtn != null)
            {
                curbtn.BackColor = Color.FromArgb(31, 30, 68);
                curbtn.ForeColor = Color.Gainsboro;
                curbtn.TextAlign = ContentAlignment.MiddleLeft;
                curbtn.ForeColor = Color.Gainsboro;
                curbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                curbtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            addDoctor1.Hide();
            addPatient1.Hide();
            department1.Hide();
            payments1.Hide();
            
        }
        private void Doctor(object sender, EventArgs e)
        {
            ActiveBTn(sender, RGBColors.color1);
            addPatient1.Hide();
            payments1.Hide();
            department1.Hide();
            addDoctor1.Show();
            addDoctor1.BringToFront();
        }
        private void Patient(object sender, EventArgs e)
        {
            ActiveBTn(sender, RGBColors.color3);
            addDoctor1.Hide();
            addPatient1.Show();
            payments1.Hide();
            addPatient1.BringToFront();

        }
        private void Reset()
        {
            DisableBtn();
            leftbordbtn.Visible = false;
            iconcur.IconChar = IconChar.Home;
            iconcur.IconColor = Color.MediumPurple;
            lblcur.Text = "Home";
        }
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            addDoctor1.Hide();
            addPatient1.Hide();
            payments1.Hide();
            department1.Hide();
            Reset();
        }
        private void Departments(object sender, EventArgs e)
        {
            ActiveBTn(sender, RGBColors.color5);
            addDoctor1.Hide();
            addPatient1.Hide();
            payments1.Hide();
            department1.Show();
            department1.BringToFront();
        }
        private void Payments(object sender, EventArgs e)
        {
            ActiveBTn(sender, RGBColors.color6);
            addDoctor1.Hide();
            addPatient1.Hide();
            department1.Hide();
            payments1.Show();
            payments1.BringToFront();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void department1_Load_1(object sender, EventArgs e)
        {

        }
        private void payments1_Load(object sender, EventArgs e)
        {

        }
        private void iconcur_Click(object sender, EventArgs e)
        {

        }
        private void lblcur_Click(object sender, EventArgs e)
        {

        }
        private void iconPictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void paMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        private void addPatient1_Load_1(object sender, EventArgs e)
        {

        }
        private void addDoctor1_Load(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
