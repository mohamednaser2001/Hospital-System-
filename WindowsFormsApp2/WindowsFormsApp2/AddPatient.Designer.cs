namespace WindowsFormsApp2
{
    partial class AddPatient
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.textDepartment = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSearcH = new System.Windows.Forms.Label();
            this.textSearcH = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDisPAtient = new System.Windows.Forms.Label();
            this.btnDis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 22);
            this.label2.TabIndex = 62;
            this.label2.Text = "Welcome To Our Hospital";
            // 
            // comboGender
            // 
            this.comboGender.BackColor = System.Drawing.Color.Gainsboro;
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboGender.Location = new System.Drawing.Point(168, 421);
            this.comboGender.Margin = new System.Windows.Forms.Padding(4);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(246, 29);
            this.comboGender.TabIndex = 61;
            this.comboGender.SelectedIndexChanged += new System.EventHandler(this.comboGender_SelectedIndexChanged);
            // 
            // textDepartment
            // 
            this.textDepartment.BackColor = System.Drawing.Color.Gainsboro;
            this.textDepartment.Location = new System.Drawing.Point(168, 364);
            this.textDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.textDepartment.Name = "textDepartment";
            this.textDepartment.Size = new System.Drawing.Size(246, 28);
            this.textDepartment.TabIndex = 60;
            this.textDepartment.TextChanged += new System.EventHandler(this.textDepartment_TextChanged);
            // 
            // textAddress
            // 
            this.textAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.textAddress.Location = new System.Drawing.Point(168, 312);
            this.textAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(246, 28);
            this.textAddress.TabIndex = 59;
            this.textAddress.TextChanged += new System.EventHandler(this.textAddress_TextChanged);
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.textEmail.Location = new System.Drawing.Point(168, 257);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(246, 28);
            this.textEmail.TabIndex = 58;
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            // 
            // textNumber
            // 
            this.textNumber.BackColor = System.Drawing.Color.Gainsboro;
            this.textNumber.Location = new System.Drawing.Point(168, 204);
            this.textNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(246, 28);
            this.textNumber.TabIndex = 57;
            this.textNumber.TextChanged += new System.EventHandler(this.textNumber_TextChanged);
            // 
            // textAge
            // 
            this.textAge.BackColor = System.Drawing.Color.Gainsboro;
            this.textAge.Location = new System.Drawing.Point(168, 150);
            this.textAge.Margin = new System.Windows.Forms.Padding(4);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(246, 28);
            this.textAge.TabIndex = 56;
            this.textAge.TextChanged += new System.EventHandler(this.textAge_TextChanged);
            // 
            // textLastName
            // 
            this.textLastName.BackColor = System.Drawing.Color.Gainsboro;
            this.textLastName.Location = new System.Drawing.Point(168, 99);
            this.textLastName.Margin = new System.Windows.Forms.Padding(4);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(246, 28);
            this.textLastName.TabIndex = 55;
            this.textLastName.TextChanged += new System.EventHandler(this.textLastName_TextChanged);
            // 
            // textFirstName
            // 
            this.textFirstName.BackColor = System.Drawing.Color.Gainsboro;
            this.textFirstName.Location = new System.Drawing.Point(168, 53);
            this.textFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(246, 28);
            this.textFirstName.TabIndex = 54;
            this.textFirstName.TextChanged += new System.EventHandler(this.textFirstName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 364);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 53;
            this.label1.Text = "Disease :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(4, 256);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 22);
            this.lblEmail.TabIndex = 52;
            this.lblEmail.Text = "Email :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(4, 311);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(98, 22);
            this.lblAddress.TabIndex = 51;
            this.lblAddress.Text = "Address :";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(4, 203);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(94, 22);
            this.lblNumber.TabIndex = 50;
            this.lblNumber.Text = "Number :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(4, 420);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(89, 22);
            this.lblGender.TabIndex = 49;
            this.lblGender.Text = "Gender :";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(4, 149);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(58, 22);
            this.lblAge.TabIndex = 48;
            this.lblAge.Text = "Age :";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(4, 98);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(113, 22);
            this.lblLastName.TabIndex = 47;
            this.lblLastName.Text = "LastName :";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(4, 56);
            this.lblFirstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(115, 22);
            this.lblFirstname.TabIndex = 46;
            this.lblFirstname.Text = "FirstName :";
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.LawnGreen;
            this.btnAddPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddPatient.FlatAppearance.BorderSize = 0;
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPatient.Location = new System.Drawing.Point(3, 625);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(131, 56);
            this.btnAddPatient.TabIndex = 63;
            this.btnAddPatient.Text = "Add";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(141, 625);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 56);
            this.btnClear.TabIndex = 64;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblSearcH
            // 
            this.lblSearcH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSearcH.Location = new System.Drawing.Point(626, 370);
            this.lblSearcH.Name = "lblSearcH";
            this.lblSearcH.Size = new System.Drawing.Size(410, 298);
            this.lblSearcH.TabIndex = 75;
            this.lblSearcH.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // textSearcH
            // 
            this.textSearcH.BackColor = System.Drawing.Color.Gainsboro;
            this.textSearcH.Location = new System.Drawing.Point(764, 325);
            this.textSearcH.Name = "textSearcH";
            this.textSearcH.Size = new System.Drawing.Size(272, 28);
            this.textSearcH.TabIndex = 74;
            this.textSearcH.TextChanged += new System.EventHandler(this.textSearcH_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(626, 310);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 56);
            this.btnSearch.TabIndex = 72;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblDisPAtient
            // 
            this.lblDisPAtient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisPAtient.Location = new System.Drawing.Point(626, 13);
            this.lblDisPAtient.Name = "lblDisPAtient";
            this.lblDisPAtient.Size = new System.Drawing.Size(410, 293);
            this.lblDisPAtient.TabIndex = 73;
            this.lblDisPAtient.Click += new System.EventHandler(this.lblDisPAtient_Click);
            // 
            // btnDis
            // 
            this.btnDis.BackColor = System.Drawing.Color.Blue;
            this.btnDis.FlatAppearance.BorderSize = 0;
            this.btnDis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDis.Location = new System.Drawing.Point(280, 626);
            this.btnDis.Margin = new System.Windows.Forms.Padding(4);
            this.btnDis.Name = "btnDis";
            this.btnDis.Size = new System.Drawing.Size(131, 56);
            this.btnDis.TabIndex = 76;
            this.btnDis.Text = "Display";
            this.btnDis.UseVisualStyleBackColor = false;
            this.btnDis.Click += new System.EventHandler(this.btnDis_Click);
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.btnDis);
            this.Controls.Add(this.lblSearcH);
            this.Controls.Add(this.textSearcH);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblDisPAtient);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.textDepartment);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstname);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddPatient";
            this.Size = new System.Drawing.Size(1067, 685);
            this.Load += new System.EventHandler(this.AddPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.TextBox textDepartment;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSearcH;
        private System.Windows.Forms.TextBox textSearcH;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDisPAtient;
        private System.Windows.Forms.Button btnDis;
    }
}
