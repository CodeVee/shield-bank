namespace ShieldBank
{
    partial class CreateUserControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUserControl));
            this.btnClear = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnAcctNoCreator = new System.Windows.Forms.Button();
            this.lblCreateAcctType = new System.Windows.Forms.Label();
            this.lblCreateLName = new System.Windows.Forms.Label();
            this.lblCreateFName = new System.Windows.Forms.Label();
            this.txtCreateLName = new System.Windows.Forms.TextBox();
            this.txtCreateFName = new System.Windows.Forms.TextBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCreatePhone = new System.Windows.Forms.TextBox();
            this.txtCreateEmail = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtCreatePassword = new System.Windows.Forms.TextBox();
            this.txtCreateUsername = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblOpenBal = new System.Windows.Forms.Label();
            this.lblAcctNo = new System.Windows.Forms.Label();
            this.txtOpenBal = new System.Windows.Forms.TextBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.AcctTypeCombo = new System.Windows.Forms.ComboBox();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.pbTransact = new System.Windows.Forms.PictureBox();
            this.pbGenerate = new System.Windows.Forms.PictureBox();
            this.timerGen = new System.Windows.Forms.Timer(this.components);
            this.timerTran = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbTransact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenerate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(422, 395);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 35);
            this.btnClear.TabIndex = 61;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblWarning.Location = new System.Drawing.Point(213, 349);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(16, 17);
            this.lblWarning.TabIndex = 58;
            this.lblWarning.Text = "..";
            // 
            // btnAcctNoCreator
            // 
            this.btnAcctNoCreator.BackColor = System.Drawing.Color.Transparent;
            this.btnAcctNoCreator.FlatAppearance.BorderSize = 0;
            this.btnAcctNoCreator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcctNoCreator.Image = ((System.Drawing.Image)(resources.GetObject("btnAcctNoCreator.Image")));
            this.btnAcctNoCreator.Location = new System.Drawing.Point(535, 201);
            this.btnAcctNoCreator.Name = "btnAcctNoCreator";
            this.btnAcctNoCreator.Size = new System.Drawing.Size(64, 43);
            this.btnAcctNoCreator.TabIndex = 57;
            this.btnAcctNoCreator.UseVisualStyleBackColor = false;
            this.btnAcctNoCreator.Click += new System.EventHandler(this.btnAcctNoCreator_Click);
            // 
            // lblCreateAcctType
            // 
            this.lblCreateAcctType.AutoSize = true;
            this.lblCreateAcctType.Location = new System.Drawing.Point(77, 175);
            this.lblCreateAcctType.Name = "lblCreateAcctType";
            this.lblCreateAcctType.Size = new System.Drawing.Size(99, 17);
            this.lblCreateAcctType.TabIndex = 53;
            this.lblCreateAcctType.Text = "Account Type:";
            // 
            // lblCreateLName
            // 
            this.lblCreateLName.AutoSize = true;
            this.lblCreateLName.Location = new System.Drawing.Point(77, 57);
            this.lblCreateLName.Name = "lblCreateLName";
            this.lblCreateLName.Size = new System.Drawing.Size(80, 17);
            this.lblCreateLName.TabIndex = 45;
            this.lblCreateLName.Text = "Last Name:";
            // 
            // lblCreateFName
            // 
            this.lblCreateFName.AutoSize = true;
            this.lblCreateFName.Location = new System.Drawing.Point(77, 17);
            this.lblCreateFName.Name = "lblCreateFName";
            this.lblCreateFName.Size = new System.Drawing.Size(80, 17);
            this.lblCreateFName.TabIndex = 44;
            this.lblCreateFName.Text = "First Name:";
            // 
            // txtCreateLName
            // 
            this.txtCreateLName.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreateLName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreateLName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateLName.Location = new System.Drawing.Point(212, 52);
            this.txtCreateLName.Name = "txtCreateLName";
            this.txtCreateLName.Size = new System.Drawing.Size(300, 21);
            this.txtCreateLName.TabIndex = 42;
            // 
            // txtCreateFName
            // 
            this.txtCreateFName.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreateFName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreateFName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateFName.Location = new System.Drawing.Point(212, 12);
            this.txtCreateFName.Name = "txtCreateFName";
            this.txtCreateFName.Size = new System.Drawing.Size(300, 21);
            this.txtCreateFName.TabIndex = 41;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCreateUser.FlatAppearance.BorderSize = 0;
            this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateUser.Location = new System.Drawing.Point(216, 396);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(75, 34);
            this.btnCreateUser.TabIndex = 39;
            this.btnCreateUser.Text = "Create";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(212, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1);
            this.panel1.TabIndex = 62;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(212, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 1);
            this.panel2.TabIndex = 64;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(212, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 1);
            this.panel3.TabIndex = 70;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(212, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 1);
            this.panel4.TabIndex = 69;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(77, 132);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 17);
            this.lblPhone.TabIndex = 68;
            this.lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(77, 92);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 67;
            this.lblEmail.Text = "Email:";
            // 
            // txtCreatePhone
            // 
            this.txtCreatePhone.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatePhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreatePhone.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatePhone.Location = new System.Drawing.Point(212, 127);
            this.txtCreatePhone.Name = "txtCreatePhone";
            this.txtCreatePhone.Size = new System.Drawing.Size(300, 21);
            this.txtCreatePhone.TabIndex = 66;
            // 
            // txtCreateEmail
            // 
            this.txtCreateEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreateEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreateEmail.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateEmail.Location = new System.Drawing.Point(212, 87);
            this.txtCreateEmail.Name = "txtCreateEmail";
            this.txtCreateEmail.Size = new System.Drawing.Size(300, 21);
            this.txtCreateEmail.TabIndex = 65;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Location = new System.Drawing.Point(212, 345);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 1);
            this.panel5.TabIndex = 82;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Location = new System.Drawing.Point(212, 305);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 1);
            this.panel6.TabIndex = 81;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(77, 329);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 80;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(77, 289);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 17);
            this.lblUsername.TabIndex = 79;
            this.lblUsername.Text = "Username:";
            // 
            // txtCreatePassword
            // 
            this.txtCreatePassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreatePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreatePassword.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatePassword.Location = new System.Drawing.Point(212, 324);
            this.txtCreatePassword.Name = "txtCreatePassword";
            this.txtCreatePassword.Size = new System.Drawing.Size(300, 21);
            this.txtCreatePassword.TabIndex = 78;
            // 
            // txtCreateUsername
            // 
            this.txtCreateUsername.BackColor = System.Drawing.SystemColors.Control;
            this.txtCreateUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreateUsername.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateUsername.Location = new System.Drawing.Point(212, 284);
            this.txtCreateUsername.Name = "txtCreateUsername";
            this.txtCreateUsername.Size = new System.Drawing.Size(300, 21);
            this.txtCreateUsername.TabIndex = 77;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DimGray;
            this.panel7.Location = new System.Drawing.Point(212, 270);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 1);
            this.panel7.TabIndex = 76;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DimGray;
            this.panel8.Location = new System.Drawing.Point(212, 230);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(300, 1);
            this.panel8.TabIndex = 75;
            // 
            // lblOpenBal
            // 
            this.lblOpenBal.AutoSize = true;
            this.lblOpenBal.Location = new System.Drawing.Point(77, 254);
            this.lblOpenBal.Name = "lblOpenBal";
            this.lblOpenBal.Size = new System.Drawing.Size(121, 17);
            this.lblOpenBal.TabIndex = 74;
            this.lblOpenBal.Text = "Opening Balance:";
            // 
            // lblAcctNo
            // 
            this.lblAcctNo.AutoSize = true;
            this.lblAcctNo.Location = new System.Drawing.Point(77, 214);
            this.lblAcctNo.Name = "lblAcctNo";
            this.lblAcctNo.Size = new System.Drawing.Size(117, 17);
            this.lblAcctNo.TabIndex = 73;
            this.lblAcctNo.Text = "Account Number:";
            // 
            // txtOpenBal
            // 
            this.txtOpenBal.BackColor = System.Drawing.SystemColors.Control;
            this.txtOpenBal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOpenBal.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpenBal.Location = new System.Drawing.Point(212, 249);
            this.txtOpenBal.Name = "txtOpenBal";
            this.txtOpenBal.Size = new System.Drawing.Size(300, 21);
            this.txtOpenBal.TabIndex = 72;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.BackColor = System.Drawing.SystemColors.Control;
            this.txtAccountNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccountNo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNo.Location = new System.Drawing.Point(212, 209);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(300, 21);
            this.txtAccountNo.TabIndex = 71;
            // 
            // AcctTypeCombo
            // 
            this.AcctTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AcctTypeCombo.FormattingEnabled = true;
            this.AcctTypeCombo.Items.AddRange(new object[] {
            "Savings",
            "Current"});
            this.AcctTypeCombo.Location = new System.Drawing.Point(216, 175);
            this.AcctTypeCombo.Name = "AcctTypeCombo";
            this.AcctTypeCombo.Size = new System.Drawing.Size(138, 24);
            this.AcctTypeCombo.TabIndex = 83;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.ForeColor = System.Drawing.Color.LightGreen;
            this.lblSuccess.Location = new System.Drawing.Point(213, 366);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(16, 17);
            this.lblSuccess.TabIndex = 84;
            this.lblSuccess.Text = "..";
            // 
            // pbTransact
            // 
            this.pbTransact.Image = ((System.Drawing.Image)(resources.GetObject("pbTransact.Image")));
            this.pbTransact.Location = new System.Drawing.Point(313, 395);
            this.pbTransact.Name = "pbTransact";
            this.pbTransact.Size = new System.Drawing.Size(91, 36);
            this.pbTransact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTransact.TabIndex = 85;
            this.pbTransact.TabStop = false;
            // 
            // pbGenerate
            // 
            this.pbGenerate.Image = ((System.Drawing.Image)(resources.GetObject("pbGenerate.Image")));
            this.pbGenerate.Location = new System.Drawing.Point(593, 201);
            this.pbGenerate.Name = "pbGenerate";
            this.pbGenerate.Size = new System.Drawing.Size(38, 36);
            this.pbGenerate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbGenerate.TabIndex = 86;
            this.pbGenerate.TabStop = false;
            // 
            // timerGen
            // 
            this.timerGen.Interval = 1000;
            this.timerGen.Tick += new System.EventHandler(this.timerGen_Tick);
            // 
            // timerTran
            // 
            this.timerTran.Interval = 1000;
            this.timerTran.Tick += new System.EventHandler(this.timerTran_Tick);
            // 
            // CreateUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pbGenerate);
            this.Controls.Add(this.pbTransact);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.AcctTypeCombo);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtCreatePassword);
            this.Controls.Add(this.txtCreateUsername);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.lblOpenBal);
            this.Controls.Add(this.lblAcctNo);
            this.Controls.Add(this.txtOpenBal);
            this.Controls.Add(this.txtAccountNo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCreatePhone);
            this.Controls.Add(this.txtCreateEmail);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnAcctNoCreator);
            this.Controls.Add(this.lblCreateAcctType);
            this.Controls.Add(this.lblCreateLName);
            this.Controls.Add(this.lblCreateFName);
            this.Controls.Add(this.txtCreateLName);
            this.Controls.Add(this.txtCreateFName);
            this.Controls.Add(this.btnCreateUser);
            this.Name = "CreateUserControl";
            this.Size = new System.Drawing.Size(659, 445);
            this.Load += new System.EventHandler(this.CreateUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTransact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenerate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnAcctNoCreator;
        private System.Windows.Forms.Label lblCreateAcctType;
        private System.Windows.Forms.Label lblCreateLName;
        private System.Windows.Forms.Label lblCreateFName;
        private System.Windows.Forms.TextBox txtCreateLName;
        private System.Windows.Forms.TextBox txtCreateFName;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCreatePhone;
        private System.Windows.Forms.TextBox txtCreateEmail;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtCreatePassword;
        private System.Windows.Forms.TextBox txtCreateUsername;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblOpenBal;
        private System.Windows.Forms.Label lblAcctNo;
        private System.Windows.Forms.TextBox txtOpenBal;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.ComboBox AcctTypeCombo;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.PictureBox pbTransact;
        private System.Windows.Forms.PictureBox pbGenerate;
        private System.Windows.Forms.Timer timerGen;
        private System.Windows.Forms.Timer timerTran;
    }
}
