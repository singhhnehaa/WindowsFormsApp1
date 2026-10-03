namespace WindowsFormsApp1
{
    partial class frmRegistration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTellUs = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblCellNumber = new System.Windows.Forms.Label();
            this.lblIDPassport = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.grpEmergencyInfo = new System.Windows.Forms.GroupBox();
            this.mtxtNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mtxtCell = new System.Windows.Forms.MaskedTextBox();
            this.mtxtID = new System.Windows.Forms.MaskedTextBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpEmergencyInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 47);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Legacy Fitness";
            // 
            // lblTellUs
            // 
            this.lblTellUs.AutoSize = true;
            this.lblTellUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTellUs.Location = new System.Drawing.Point(174, 70);
            this.lblTellUs.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTellUs.Name = "lblTellUs";
            this.lblTellUs.Size = new System.Drawing.Size(567, 32);
            this.lblTellUs.TabIndex = 1;
            this.lblTellUs.Text = "Registration Page. Tell us about yourself";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(101, 154);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(125, 26);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(101, 223);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(124, 26);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last name:";
            // 
            // lblCellNumber
            // 
            this.lblCellNumber.AutoSize = true;
            this.lblCellNumber.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellNumber.Location = new System.Drawing.Point(101, 335);
            this.lblCellNumber.Name = "lblCellNumber";
            this.lblCellNumber.Size = new System.Drawing.Size(137, 26);
            this.lblCellNumber.TabIndex = 4;
            this.lblCellNumber.Text = "Cell number:";
            // 
            // lblIDPassport
            // 
            this.lblIDPassport.AutoSize = true;
            this.lblIDPassport.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDPassport.Location = new System.Drawing.Point(101, 392);
            this.lblIDPassport.Name = "lblIDPassport";
            this.lblIDPassport.Size = new System.Drawing.Size(231, 26);
            this.lblIDPassport.TabIndex = 5;
            this.lblIDPassport.Text = "ID / Passport number:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(103, 449);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(142, 26);
            this.lblDOB.TabIndex = 6;
            this.lblDOB.Text = "Date of birth:";
            // 
            // grpEmergencyInfo
            // 
            this.grpEmergencyInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpEmergencyInfo.Controls.Add(this.mtxtNumber);
            this.grpEmergencyInfo.Controls.Add(this.txtName);
            this.grpEmergencyInfo.Controls.Add(this.lblPhone);
            this.grpEmergencyInfo.Controls.Add(this.lblName);
            this.grpEmergencyInfo.Location = new System.Drawing.Point(667, 156);
            this.grpEmergencyInfo.Name = "grpEmergencyInfo";
            this.grpEmergencyInfo.Size = new System.Drawing.Size(517, 205);
            this.grpEmergencyInfo.TabIndex = 7;
            this.grpEmergencyInfo.TabStop = false;
            this.grpEmergencyInfo.Text = "Emergency contact info";
            // 
            // mtxtNumber
            // 
            this.mtxtNumber.Location = new System.Drawing.Point(233, 120);
            this.mtxtNumber.Mask = "000 000 0000";
            this.mtxtNumber.Name = "mtxtNumber";
            this.mtxtNumber.Size = new System.Drawing.Size(196, 30);
            this.mtxtNumber.TabIndex = 25;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(233, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 30);
            this.txtName.TabIndex = 2;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(25, 127);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(137, 26);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Cell number:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(25, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 26);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(688, 717);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(142, 53);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(413, 146);
            this.txtFirstname.Multiline = true;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(226, 34);
            this.txtFirstname.TabIndex = 1;
            this.txtFirstname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFirstname_KeyDown);
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(413, 211);
            this.txtLastname.Multiline = true;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(226, 34);
            this.txtLastname.TabIndex = 2;
            this.txtLastname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLastname_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(413, 270);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(226, 36);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 527);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 23);
            this.label10.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(378, 747);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 23);
            this.label11.TabIndex = 15;
            this.label11.Text = "Almost there......";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(111, 527);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(124, 26);
            this.lblUsername.TabIndex = 16;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(108, 604);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(118, 26);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(300, 524);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(192, 30);
            this.txtUsername.TabIndex = 7;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(300, 597);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(192, 30);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.IndianRed;
            this.label14.Location = new System.Drawing.Point(104, 747);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 23);
            this.label14.TabIndex = 20;
            this.label14.Text = "Registration....";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(103, 281);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 26);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email:";
            // 
            // mtxtCell
            // 
            this.mtxtCell.Location = new System.Drawing.Point(413, 331);
            this.mtxtCell.Mask = "000 000 0000";
            this.mtxtCell.Name = "mtxtCell";
            this.mtxtCell.Size = new System.Drawing.Size(226, 30);
            this.mtxtCell.TabIndex = 4;
            this.mtxtCell.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtCell_KeyDown);
            // 
            // mtxtID
            // 
            this.mtxtID.Location = new System.Drawing.Point(413, 388);
            this.mtxtID.Mask = "000000 0000 000";
            this.mtxtID.Name = "mtxtID";
            this.mtxtID.Size = new System.Drawing.Size(226, 30);
            this.mtxtID.TabIndex = 5;
            this.mtxtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtID_KeyDown);
            // 
            // dtpDob
            // 
            this.dtpDob.CustomFormat = "yy/MM/dd";
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDob.Location = new System.Drawing.Point(413, 449);
            this.dtpDob.MaxDate = new System.DateTime(2026, 9, 18, 0, 0, 0, 0);
            this.dtpDob.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(226, 30);
            this.dtpDob.TabIndex = 6;
            this.dtpDob.Value = new System.DateTime(2026, 9, 18, 0, 0, 0, 0);
            this.dtpDob.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDob_KeyDown);
            // 
            // chkShow
            // 
            this.chkShow.AutoSize = true;
            this.chkShow.Location = new System.Drawing.Point(300, 633);
            this.chkShow.Name = "chkShow";
            this.chkShow.Size = new System.Drawing.Size(175, 27);
            this.chkShow.TabIndex = 26;
            this.chkShow.Text = "Show Password";
            this.chkShow.UseVisualStyleBackColor = true;
            this.chkShow.CheckedChanged += new System.EventHandler(this.chkShow_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(688, 633);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 53);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1214, 829);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkShow);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.mtxtID);
            this.Controls.Add(this.mtxtCell);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grpEmergencyInfo);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblIDPassport);
            this.Controls.Add(this.lblCellNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblTellUs);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmRegistration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpEmergencyInfo.ResumeLayout(false);
            this.grpEmergencyInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTellUs;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblCellNumber;
        private System.Windows.Forms.Label lblIDPassport;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.GroupBox grpEmergencyInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox mtxtCell;
        private System.Windows.Forms.MaskedTextBox mtxtID;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.MaskedTextBox mtxtNumber;
        private System.Windows.Forms.CheckBox chkShow;
        private System.Windows.Forms.Button btnSave;
    }
}