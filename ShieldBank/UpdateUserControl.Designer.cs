namespace ShieldBank
{
    partial class UpdateUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateUserControl));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtUpdatePhone = new System.Windows.Forms.TextBox();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCreateLName = new System.Windows.Forms.Label();
            this.lblCreateFName = new System.Windows.Forms.Label();
            this.txtUpdateLName = new System.Windows.Forms.TextBox();
            this.txtUpdateFName = new System.Windows.Forms.TextBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblCheck = new System.Windows.Forms.Label();
            this.txtCheckAcctNo = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblNotFound = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.pbGenerate = new System.Windows.Forms.PictureBox();
            this.pbTransact = new System.Windows.Forms.PictureBox();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbGenerate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTransact)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(187, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 1);
            this.panel3.TabIndex = 100;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(187, 238);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 1);
            this.panel4.TabIndex = 99;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(82, 262);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 17);
            this.lblPhone.TabIndex = 98;
            this.lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(82, 222);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 97;
            this.lblEmail.Text = "Email:";
            // 
            // txtUpdatePhone
            // 
            this.txtUpdatePhone.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdatePhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpdatePhone.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatePhone.Location = new System.Drawing.Point(187, 257);
            this.txtUpdatePhone.Name = "txtUpdatePhone";
            this.txtUpdatePhone.Size = new System.Drawing.Size(300, 21);
            this.txtUpdatePhone.TabIndex = 96;
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdateEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpdateEmail.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateEmail.Location = new System.Drawing.Point(187, 217);
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(300, 21);
            this.txtUpdateEmail.TabIndex = 95;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(187, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 1);
            this.panel2.TabIndex = 94;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(187, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1);
            this.panel1.TabIndex = 93;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(397, 352);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 35);
            this.btnClear.TabIndex = 92;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCreateLName
            // 
            this.lblCreateLName.AutoSize = true;
            this.lblCreateLName.Location = new System.Drawing.Point(82, 187);
            this.lblCreateLName.Name = "lblCreateLName";
            this.lblCreateLName.Size = new System.Drawing.Size(80, 17);
            this.lblCreateLName.TabIndex = 87;
            this.lblCreateLName.Text = "Last Name:";
            // 
            // lblCreateFName
            // 
            this.lblCreateFName.AutoSize = true;
            this.lblCreateFName.Location = new System.Drawing.Point(82, 147);
            this.lblCreateFName.Name = "lblCreateFName";
            this.lblCreateFName.Size = new System.Drawing.Size(80, 17);
            this.lblCreateFName.TabIndex = 86;
            this.lblCreateFName.Text = "First Name:";
            // 
            // txtUpdateLName
            // 
            this.txtUpdateLName.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdateLName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpdateLName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateLName.Location = new System.Drawing.Point(187, 182);
            this.txtUpdateLName.Name = "txtUpdateLName";
            this.txtUpdateLName.Size = new System.Drawing.Size(300, 21);
            this.txtUpdateLName.TabIndex = 85;
            // 
            // txtUpdateFName
            // 
            this.txtUpdateFName.BackColor = System.Drawing.SystemColors.Control;
            this.txtUpdateFName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpdateFName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateFName.Location = new System.Drawing.Point(187, 142);
            this.txtUpdateFName.Name = "txtUpdateFName";
            this.txtUpdateFName.Size = new System.Drawing.Size(300, 21);
            this.txtUpdateFName.TabIndex = 84;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCreateUser.FlatAppearance.BorderSize = 0;
            this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateUser.Location = new System.Drawing.Point(187, 352);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(75, 34);
            this.btnCreateUser.TabIndex = 83;
            this.btnCreateUser.Text = "Update";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DimGray;
            this.panel7.Location = new System.Drawing.Point(187, 57);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 1);
            this.panel7.TabIndex = 115;
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(82, 41);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(85, 17);
            this.lblCheck.TabIndex = 114;
            this.lblCheck.Text = "Account No:";
            // 
            // txtCheckAcctNo
            // 
            this.txtCheckAcctNo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCheckAcctNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCheckAcctNo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckAcctNo.Location = new System.Drawing.Point(187, 36);
            this.txtCheckAcctNo.Name = "txtCheckAcctNo";
            this.txtCheckAcctNo.Size = new System.Drawing.Size(300, 21);
            this.txtCheckAcctNo.TabIndex = 113;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCheck.Location = new System.Drawing.Point(525, 41);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(70, 26);
            this.btnCheck.TabIndex = 116;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblNotFound
            // 
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.ForeColor = System.Drawing.Color.Tomato;
            this.lblNotFound.Location = new System.Drawing.Point(184, 65);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(16, 17);
            this.lblNotFound.TabIndex = 117;
            this.lblNotFound.Text = "..";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblWarning.Location = new System.Drawing.Point(184, 318);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(16, 17);
            this.lblWarning.TabIndex = 89;
            this.lblWarning.Text = "..";
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.ForeColor = System.Drawing.Color.LightGreen;
            this.lblSuccess.Location = new System.Drawing.Point(184, 405);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(16, 17);
            this.lblSuccess.TabIndex = 118;
            this.lblSuccess.Text = "..";
            // 
            // pbGenerate
            // 
            this.pbGenerate.Image = ((System.Drawing.Image)(resources.GetObject("pbGenerate.Image")));
            this.pbGenerate.Location = new System.Drawing.Point(601, 36);
            this.pbGenerate.Name = "pbGenerate";
            this.pbGenerate.Size = new System.Drawing.Size(38, 36);
            this.pbGenerate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbGenerate.TabIndex = 120;
            this.pbGenerate.TabStop = false;
            // 
            // pbTransact
            // 
            this.pbTransact.Image = ((System.Drawing.Image)(resources.GetObject("pbTransact.Image")));
            this.pbTransact.Location = new System.Drawing.Point(286, 350);
            this.pbTransact.Name = "pbTransact";
            this.pbTransact.Size = new System.Drawing.Size(91, 36);
            this.pbTransact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTransact.TabIndex = 119;
            this.pbTransact.TabStop = false;
            // 
            // timerCheck
            // 
            this.timerCheck.Interval = 1000;
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 1000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // UpdateUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbGenerate);
            this.Controls.Add(this.pbTransact);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.lblNotFound);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.txtCheckAcctNo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtUpdatePhone);
            this.Controls.Add(this.txtUpdateEmail);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblCreateLName);
            this.Controls.Add(this.lblCreateFName);
            this.Controls.Add(this.txtUpdateLName);
            this.Controls.Add(this.txtUpdateFName);
            this.Controls.Add(this.btnCreateUser);
            this.Name = "UpdateUserControl";
            this.Size = new System.Drawing.Size(659, 445);
            this.Load += new System.EventHandler(this.UpdateUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGenerate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTransact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtUpdatePhone;
        private System.Windows.Forms.TextBox txtUpdateEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCreateLName;
        private System.Windows.Forms.Label lblCreateFName;
        private System.Windows.Forms.TextBox txtUpdateLName;
        private System.Windows.Forms.TextBox txtUpdateFName;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.TextBox txtCheckAcctNo;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblNotFound;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.PictureBox pbGenerate;
        private System.Windows.Forms.PictureBox pbTransact;
        private System.Windows.Forms.Timer timerCheck;
        private System.Windows.Forms.Timer timerUpdate;
    }
}
