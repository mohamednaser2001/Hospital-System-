namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWel = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconDepartment = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.IconDoctor = new FontAwesome.Sharp.IconButton();
            this.paMenu = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelHome = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcur = new System.Windows.Forms.Label();
            this.iconcur = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.payments1 = new WindowsFormsApp2.Payments();
            this.department1 = new WindowsFormsApp2.Department();
            this.addPatient1 = new WindowsFormsApp2.AddPatient();
            this.addDoctor1 = new WindowsFormsApp2.AddDoctor();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.paMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcur)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWel
            // 
            this.lblWel.AutoSize = true;
            this.lblWel.BackColor = System.Drawing.SystemColors.Control;
            this.lblWel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.lblWel.Location = new System.Drawing.Point(232, -74);
            this.lblWel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWel.Name = "lblWel";
            this.lblWel.Size = new System.Drawing.Size(248, 24);
            this.lblWel.TabIndex = 23;
            this.lblWel.Text = "Welcome To Our Hospital ";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.iconDepartment);
            this.panelMenu.Controls.Add(this.iconPictureBox2);
            this.panelMenu.Controls.Add(this.iconButton2);
            this.panelMenu.Controls.Add(this.IconDoctor);
            this.panelMenu.Controls.Add(this.paMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 738);
            this.panelMenu.TabIndex = 54;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 386);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(220, 82);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Payments";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.Payments);
            // 
            // iconDepartment
            // 
            this.iconDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconDepartment.FlatAppearance.BorderSize = 0;
            this.iconDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconDepartment.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconDepartment.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.iconDepartment.IconColor = System.Drawing.Color.Gainsboro;
            this.iconDepartment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDepartment.IconSize = 32;
            this.iconDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconDepartment.Location = new System.Drawing.Point(0, 304);
            this.iconDepartment.Name = "iconDepartment";
            this.iconDepartment.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconDepartment.Size = new System.Drawing.Size(220, 82);
            this.iconDepartment.TabIndex = 4;
            this.iconDepartment.Text = "Departments";
            this.iconDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconDepartment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconDepartment.UseVisualStyleBackColor = true;
            this.iconDepartment.Click += new System.EventHandler(this.Departments);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 3;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.PeopleArrows;
            this.iconButton2.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 222);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton2.Size = new System.Drawing.Size(220, 82);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "Patient";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.Patient);
            // 
            // IconDoctor
            // 
            this.IconDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.IconDoctor.FlatAppearance.BorderSize = 0;
            this.IconDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconDoctor.ForeColor = System.Drawing.Color.Gainsboro;
            this.IconDoctor.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            this.IconDoctor.IconColor = System.Drawing.Color.Gainsboro;
            this.IconDoctor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconDoctor.IconSize = 32;
            this.IconDoctor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconDoctor.Location = new System.Drawing.Point(0, 140);
            this.IconDoctor.Name = "IconDoctor";
            this.IconDoctor.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IconDoctor.Size = new System.Drawing.Size(220, 82);
            this.IconDoctor.TabIndex = 1;
            this.IconDoctor.Text = "Doctor";
            this.IconDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconDoctor.UseVisualStyleBackColor = true;
            this.IconDoctor.Click += new System.EventHandler(this.Doctor);
            // 
            // paMenu
            // 
            this.paMenu.Controls.Add(this.iconPictureBox1);
            this.paMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.paMenu.Location = new System.Drawing.Point(0, 0);
            this.paMenu.Name = "paMenu";
            this.paMenu.Size = new System.Drawing.Size(220, 140);
            this.paMenu.TabIndex = 0;
            this.paMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.paMenu_Paint);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.HospitalAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 140;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(220, 140);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Controls.Add(this.lblcur);
            this.panelHome.Controls.Add(this.iconcur);
            this.panelHome.Location = new System.Drawing.Point(220, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1710, 53);
            this.panelHome.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 30);
            this.label1.TabIndex = 57;
            this.label1.Text = "Welcome To Our Hospital";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblcur
            // 
            this.lblcur.AutoSize = true;
            this.lblcur.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblcur.Location = new System.Drawing.Point(59, 14);
            this.lblcur.Name = "lblcur";
            this.lblcur.Size = new System.Drawing.Size(63, 22);
            this.lblcur.TabIndex = 56;
            this.lblcur.Text = "Home";
            this.lblcur.Click += new System.EventHandler(this.lblcur_Click);
            // 
            // iconcur
            // 
            this.iconcur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconcur.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconcur.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconcur.IconColor = System.Drawing.Color.MediumPurple;
            this.iconcur.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconcur.IconSize = 48;
            this.iconcur.Location = new System.Drawing.Point(0, 2);
            this.iconcur.Name = "iconcur";
            this.iconcur.Size = new System.Drawing.Size(59, 48);
            this.iconcur.TabIndex = 0;
            this.iconcur.TabStop = false;
            this.iconcur.Click += new System.EventHandler(this.iconcur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.8F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(232, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(791, 29);
            this.label2.TabIndex = 56;
            this.label2.Text = "You Can Use The Doctor Section To Add Or Seach For A Doctor.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.8F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(232, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(797, 29);
            this.label3.TabIndex = 57;
            this.label3.Text = "You Can Use The Patient Section To Add Or Seach For A Patient.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.8F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(226, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1037, 29);
            this.label4.TabIndex = 59;
            this.label4.Text = "You Can Use The Departments Section IF You Are Looking For A Spceified Section.  " +
    " ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.8F);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(232, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(970, 29);
            this.label5.TabIndex = 62;
            this.label5.Text = "You Can Use The Payments Section To Know The Payments Of Each Section.    ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // payments1
            // 
            this.payments1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.payments1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payments1.Location = new System.Drawing.Point(220, 44);
            this.payments1.Margin = new System.Windows.Forms.Padding(4);
            this.payments1.Name = "payments1";
            this.payments1.Size = new System.Drawing.Size(1284, 725);
            this.payments1.TabIndex = 61;
            this.payments1.Load += new System.EventHandler(this.payments1_Load);
            // 
            // department1
            // 
            this.department1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.department1.Location = new System.Drawing.Point(220, 44);
            this.department1.Margin = new System.Windows.Forms.Padding(4);
            this.department1.Name = "department1";
            this.department1.Size = new System.Drawing.Size(1284, 724);
            this.department1.TabIndex = 60;
            this.department1.Load += new System.EventHandler(this.department1_Load_1);
            // 
            // addPatient1
            // 
            this.addPatient1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.addPatient1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatient1.Location = new System.Drawing.Point(220, 43);
            this.addPatient1.Margin = new System.Windows.Forms.Padding(4);
            this.addPatient1.Name = "addPatient1";
            this.addPatient1.Size = new System.Drawing.Size(1284, 725);
            this.addPatient1.TabIndex = 52;
            this.addPatient1.Load += new System.EventHandler(this.addPatient1_Load_1);
            // 
            // addDoctor1
            // 
            this.addDoctor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.addDoctor1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDoctor1.Location = new System.Drawing.Point(220, 43);
            this.addDoctor1.Margin = new System.Windows.Forms.Padding(4);
            this.addDoctor1.Name = "addDoctor1";
            this.addDoctor1.Size = new System.Drawing.Size(1284, 725);
            this.addDoctor1.TabIndex = 51;
            this.addDoctor1.Load += new System.EventHandler(this.addDoctor1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1391, 738);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.payments1);
            this.Controls.Add(this.department1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.lblWel);
            this.Controls.Add(this.addPatient1);
            this.Controls.Add(this.addDoctor1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.paMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWel;
        private AddDoctor addDoctor1;
        private AddPatient addPatient1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel paMenu;
        private FontAwesome.Sharp.IconButton IconDoctor;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panelHome;
        private FontAwesome.Sharp.IconPictureBox iconcur;
        private System.Windows.Forms.Label lblcur;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconDepartment;
        private System.Windows.Forms.Label label4;
        private Department department1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Payments payments1;
        private System.Windows.Forms.Label label5;
    }
}

