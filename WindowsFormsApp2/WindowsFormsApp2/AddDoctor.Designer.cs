namespace WindowsFormsApp2
{
    partial class AddDoctor
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
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.textDepartment = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblDOcid = new System.Windows.Forms.Label();
            this.textDocId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDis = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboGender
            // 
            this.comboGender.BackColor = System.Drawing.Color.Gainsboro;
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboGender.Location = new System.Drawing.Point(168, 464);
            this.comboGender.Margin = new System.Windows.Forms.Padding(4);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(241, 29);
            this.comboGender.TabIndex = 60;
            this.comboGender.SelectedIndexChanged += new System.EventHandler(this.comboGender_SelectedIndexChanged);
            // 
            // textDepartment
            // 
            this.textDepartment.BackColor = System.Drawing.Color.Gainsboro;
            this.textDepartment.Location = new System.Drawing.Point(168, 407);
            this.textDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.textDepartment.Name = "textDepartment";
            this.textDepartment.Size = new System.Drawing.Size(241, 28);
            this.textDepartment.TabIndex = 59;
            // 
            // textAddress
            // 
            this.textAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.textAddress.Location = new System.Drawing.Point(168, 355);
            this.textAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(241, 28);
            this.textAddress.TabIndex = 58;
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.textEmail.Location = new System.Drawing.Point(168, 300);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(241, 28);
            this.textEmail.TabIndex = 57;
            // 
            // textNumber
            // 
            this.textNumber.BackColor = System.Drawing.Color.Gainsboro;
            this.textNumber.Location = new System.Drawing.Point(168, 247);
            this.textNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(241, 28);
            this.textNumber.TabIndex = 56;
            this.textNumber.TextChanged += new System.EventHandler(this.textNumber_TextChanged);
            // 
            // textAge
            // 
            this.textAge.BackColor = System.Drawing.Color.Gainsboro;
            this.textAge.Location = new System.Drawing.Point(168, 201);
            this.textAge.Margin = new System.Windows.Forms.Padding(4);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(241, 28);
            this.textAge.TabIndex = 55;
            this.textAge.TextChanged += new System.EventHandler(this.textAge_TextChanged);
            // 
            // textLastName
            // 
            this.textLastName.BackColor = System.Drawing.Color.Gainsboro;
            this.textLastName.Location = new System.Drawing.Point(168, 104);
            this.textLastName.Margin = new System.Windows.Forms.Padding(4);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(241, 28);
            this.textLastName.TabIndex = 54;
            this.textLastName.TextChanged += new System.EventHandler(this.textLastName_TextChanged);
            // 
            // textFirstName
            // 
            this.textFirstName.BackColor = System.Drawing.Color.Gainsboro;
            this.textFirstName.Location = new System.Drawing.Point(168, 58);
            this.textFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(241, 28);
            this.textFirstName.TabIndex = 53;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(3, 407);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(166, 22);
            this.lblDepartment.TabIndex = 52;
            this.lblDepartment.Text = "Medical Section :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(4, 299);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 22);
            this.lblEmail.TabIndex = 51;
            this.lblEmail.Text = "Email :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(4, 354);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(98, 22);
            this.lblAddress.TabIndex = 50;
            this.lblAddress.Text = "Address :";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(4, 246);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(94, 22);
            this.lblNumber.TabIndex = 49;
            this.lblNumber.Text = "Number :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(4, 464);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(89, 22);
            this.lblGender.TabIndex = 48;
            this.lblGender.Text = "Gender :";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(4, 201);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(58, 22);
            this.lblAge.TabIndex = 47;
            this.lblAge.Text = "Age :";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(4, 103);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(113, 22);
            this.lblLastName.TabIndex = 46;
            this.lblLastName.Text = "LastName :";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(4, 61);
            this.lblFirstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(115, 22);
            this.lblFirstname.TabIndex = 45;
            this.lblFirstname.Text = "FirstName :";
            // 
            // lblDOcid
            // 
            this.lblDOcid.AutoSize = true;
            this.lblDOcid.Location = new System.Drawing.Point(4, 156);
            this.lblDOcid.Name = "lblDOcid";
            this.lblDOcid.Size = new System.Drawing.Size(113, 22);
            this.lblDOcid.TabIndex = 61;
            this.lblDOcid.Text = "Doctor ID  :";
            this.lblDOcid.Click += new System.EventHandler(this.lblDOcid_Click);
            // 
            // textDocId
            // 
            this.textDocId.BackColor = System.Drawing.Color.Gainsboro;
            this.textDocId.Location = new System.Drawing.Point(168, 156);
            this.textDocId.Margin = new System.Windows.Forms.Padding(4);
            this.textDocId.Name = "textDocId";
            this.textDocId.Size = new System.Drawing.Size(241, 28);
            this.textDocId.TabIndex = 62;
            this.textDocId.TextChanged += new System.EventHandler(this.textDocId_TextChanged);
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
            this.btnSearch.TabIndex = 66;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblDis
            // 
            this.lblDis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDis.Location = new System.Drawing.Point(626, 13);
            this.lblDis.Name = "lblDis";
            this.lblDis.Size = new System.Drawing.Size(410, 293);
            this.lblDis.TabIndex = 69;
            this.lblDis.Click += new System.EventHandler(this.label1_Click);
            // 
            // textSearch
            // 
            this.textSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.textSearch.Location = new System.Drawing.Point(764, 325);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(272, 28);
            this.textSearch.TabIndex = 70;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSearch.Location = new System.Drawing.Point(626, 370);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(410, 293);
            this.lblSearch.TabIndex = 71;
            this.lblSearch.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.BackColor = System.Drawing.Color.LawnGreen;
            this.btnAddDoctor.FlatAppearance.BorderSize = 0;
            this.btnAddDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddDoctor.Location = new System.Drawing.Point(3, 625);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(131, 56);
            this.btnAddDoctor.TabIndex = 64;
            this.btnAddDoctor.Text = "Add";
            this.btnAddDoctor.UseVisualStyleBackColor = false;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddPatient_Click);
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
            this.btnClear.TabIndex = 65;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnDis.TabIndex = 68;
            this.btnDis.Text = "Display";
            this.btnDis.UseVisualStyleBackColor = false;
            this.btnDis.Click += new System.EventHandler(this.Display);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 38);
            this.label1.TabIndex = 72;
            this.label1.Text = "Welcome To Our Hospital ";
            // 
            // AddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.btnDis);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddDoctor);
            this.Controls.Add(this.textDocId);
            this.Controls.Add(this.lblDOcid);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.textDepartment);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.lblDis);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddDoctor";
            this.Size = new System.Drawing.Size(1067, 685);
            this.Load += new System.EventHandler(this.AddDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.TextBox textDepartment;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblDOcid;
        private System.Windows.Forms.TextBox textDocId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDis;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDis;
        private System.Windows.Forms.Label label1;
    }
}
