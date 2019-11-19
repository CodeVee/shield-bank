namespace ShieldBank
{
    partial class MultipleAccountControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultipleAccountControl));
            this.lblNotFound = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblCheck = new System.Windows.Forms.Label();
            this.txtCheckAcctNo = new System.Windows.Forms.TextBox();
            this.lblCreateLName = new System.Windows.Forms.Label();
            this.lblCreateFName = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.AcctTypeCombo = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblOpenBal = new System.Windows.Forms.Label();
            this.lblAcctNo = new System.Windows.Forms.Label();
            this.txtOpenBal = new System.Windows.Forms.TextBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAcctNoCreator = new System.Windows.Forms.Button();
            this.lblCreateAcctType = new System.Windows.Forms.Label();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.lblAcctLName = new System.Windows.Forms.Label();
            this.lblAcctFName = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.pbCheck = new System.Windows.Forms.PictureBox();
            this.pbTransact = new System.Windows.Forms.PictureBox();
            this.pbGenerate = new System.Windows.Forms.PictureBox();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.timerGenerate = new System.Windows.Forms.Timer(this.components);
            this.timerTransact = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTransact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenerate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNotFound
            // 
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.ForeColor = System.Drawing.Color.Tomato;
            this.lblNotFound.Location = new System.Drawing.Point(199, 71);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(16, 17);
            this.lblNotFound.TabIndex = 128;
            this.lblNotFound.Text = "..";
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
            this.btnCheck.TabIndex = 127;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DimGray;
            this.panel7.Location = new System.Drawing.Point(202, 57);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 1);
            this.panel7.TabIndex = 126;
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(68, 41);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(85, 17);
            this.lblCheck.TabIndex = 125;
            this.lblCheck.Text = "Account No:";
            // 
            // txtCheckAcctNo
            // 
            this.txtCheckAcctNo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCheckAcctNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCheckAcctNo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckAcctNo.Location = new System.Drawing.Point(202, 36);
            this.txtCheckAcctNo.Name = "txtCheckAcctNo";
            this.txtCheckAcctNo.Size = new System.Drawing.Size(300, 21);
            this.txtCheckAcctNo.TabIndex = 124;
            // 
            // lblCreateLName
            // 
            this.lblCreateLName.AutoSize = true;
            this.lblCreateLName.Location = new System.Drawing.Point(67, 139);
            this.lblCreateLName.Name = "lblCreateLName";
            this.lblCreateLName.Size = new System.Drawing.Size(80, 17);
            this.lblCreateLName.TabIndex = 121;
            this.lblCreateLName.Text = "Last Name:";
            // 
            // lblCreateFName
            // 
            this.lblCreateFName.AutoSize = true;
            this.lblCreateFName.Location = new System.Drawing.Point(67, 99);
            this.lblCreateFName.Name = "lblCreateFName";
            this.lblCreateFName.Size = new System.Drawing.Size(80, 17);
            this.lblCreateFName.TabIndex = 120;
            this.lblCreateFName.Text = "First Name:";
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.ForeColor = System.Drawing.Color.LightGreen;
            this.lblSuccess.Location = new System.Drawing.Point(189, 393);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(16, 17);
            this.lblSuccess.TabIndex = 147;
            this.lblSuccess.Text = "..";
            // 
            // AcctTypeCombo
            // 
            this.AcctTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AcctTypeCombo.FormattingEnabled = true;
            this.AcctTypeCombo.Items.AddRange(new object[] {
            "Savings",
            "Current"});
            this.AcctTypeCombo.Location = new System.Drawing.Point(206, 197);
            this.AcctTypeCombo.Name = "AcctTypeCombo";
            this.AcctTypeCombo.Size = new System.Drawing.Size(138, 24);
            this.AcctTypeCombo.TabIndex = 146;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(202, 301);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 1);
            this.panel3.TabIndex = 139;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DimGray;
            this.panel8.Location = new System.Drawing.Point(202, 261);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(300, 1);
            this.panel8.TabIndex = 138;
            // 
            // lblOpenBal
            // 
            this.lblOpenBal.AutoSize = true;
            this.lblOpenBal.Location = new System.Drawing.Point(68, 285);
            this.lblOpenBal.Name = "lblOpenBal";
            this.lblOpenBal.Size = new System.Drawing.Size(121, 17);
            this.lblOpenBal.TabIndex = 137;
            this.lblOpenBal.Text = "Opening Balance:";
            // 
            // lblAcctNo
            // 
            this.lblAcctNo.AutoSize = true;
            this.lblAcctNo.Location = new System.Drawing.Point(68, 245);
            this.lblAcctNo.Name = "lblAcctNo";
            this.lblAcctNo.Size = new System.Drawing.Size(117, 17);
            this.lblAcctNo.TabIndex = 136;
            this.lblAcctNo.Text = "Account Number:";
            // 
            // txtOpenBal
            // 
            this.txtOpenBal.BackColor = System.Drawing.SystemColors.Control;
            this.txtOpenBal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOpenBal.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpenBal.Location = new System.Drawing.Point(202, 280);
            this.txtOpenBal.Name = "txtOpenBal";
            this.txtOpenBal.Size = new System.Drawing.Size(300, 21);
            this.txtOpenBal.TabIndex = 135;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.BackColor = System.Drawing.SystemColors.Control;
            this.txtAccountNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccountNo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNo.Location = new System.Drawing.Point(202, 240);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(300, 21);
            this.txtAccountNo.TabIndex = 134;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(412, 339);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 35);
            this.btnClear.TabIndex = 133;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAcctNoCreator
            // 
            this.btnAcctNoCreator.BackColor = System.Drawing.Color.Transparent;
            this.btnAcctNoCreator.FlatAppearance.BorderSize = 0;
            this.btnAcctNoCreator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcctNoCreator.Image = ((System.Drawing.Image)(resources.GetObject("btnAcctNoCreator.Image")));
            this.btnAcctNoCreator.Location = new System.Drawing.Point(525, 232);
            this.btnAcctNoCreator.Name = "btnAcctNoCreator";
            this.btnAcctNoCreator.Size = new System.Drawing.Size(64, 43);
            this.btnAcctNoCreator.TabIndex = 131;
            this.btnAcctNoCreator.UseVisualStyleBackColor = false;
            this.btnAcctNoCreator.Click += new System.EventHandler(this.btnAcctNoCreator_Click);
            // 
            // lblCreateAcctType
            // 
            this.lblCreateAcctType.AutoSize = true;
            this.lblCreateAcctType.Location = new System.Drawing.Point(67, 197);
            this.lblCreateAcctType.Name = "lblCreateAcctType";
            this.lblCreateAcctType.Size = new System.Drawing.Size(99, 17);
            this.lblCreateAcctType.TabIndex = 130;
            this.lblCreateAcctType.Text = "Account Type:";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCreateUser.FlatAppearance.BorderSize = 0;
            this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateUser.Location = new System.Drawing.Point(192, 340);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(75, 34);
            this.btnCreateUser.TabIndex = 129;
            this.btnCreateUser.Text = "Create";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // lblAcctLName
            // 
            this.lblAcctLName.AutoSize = true;
            this.lblAcctLName.Location = new System.Drawing.Point(217, 139);
            this.lblAcctLName.Name = "lblAcctLName";
            this.lblAcctLName.Size = new System.Drawing.Size(80, 17);
            this.lblAcctLName.TabIndex = 148;
            this.lblAcctLName.Text = "First Name:";
            // 
            // lblAcctFName
            // 
            this.lblAcctFName.AutoSize = true;
            this.lblAcctFName.Location = new System.Drawing.Point(217, 99);
            this.lblAcctFName.Name = "lblAcctFName";
            this.lblAcctFName.Size = new System.Drawing.Size(80, 17);
            this.lblAcctFName.TabIndex = 149;
            this.lblAcctFName.Text = "First Name:";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Tomato;
            this.lblWarning.Location = new System.Drawing.Point(189, 320);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(16, 17);
            this.lblWarning.TabIndex = 150;
            this.lblWarning.Text = "..";
            // 
            // pbCheck
            // 
            this.pbCheck.Image = ((System.Drawing.Image)(resources.GetObject("pbCheck.Image")));
            this.pbCheck.Location = new System.Drawing.Point(601, 36);
            this.pbCheck.Name = "pbCheck";
            this.pbCheck.Size = new System.Drawing.Size(38, 36);
            this.pbCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCheck.TabIndex = 152;
            this.pbCheck.TabStop = false;
            // 
            // pbTransact
            // 
            this.pbTransact.Image = ((System.Drawing.Image)(resources.GetObject("pbTransact.Image")));
            this.pbTransact.Location = new System.Drawing.Point(297, 338);
            this.pbTransact.Name = "pbTransact";
            this.pbTransact.Size = new System.Drawing.Size(91, 36);
            this.pbTransact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTransact.TabIndex = 151;
            this.pbTransact.TabStop = false;
            // 
            // pbGenerate
            // 
            this.pbGenerate.Image = ((System.Drawing.Image)(resources.GetObject("pbGenerate.Image")));
            this.pbGenerate.Location = new System.Drawing.Point(601, 239);
            this.pbGenerate.Name = "pbGenerate";
            this.pbGenerate.Size = new System.Drawing.Size(38, 36);
            this.pbGenerate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbGenerate.TabIndex = 153;
            this.pbGenerate.TabStop = false;
            // 
            // timerCheck
            // 
            this.timerCheck.Interval = 1000;
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // timerGenerate
            // 
            this.timerGenerate.Interval = 1000;
            this.timerGenerate.Tick += new System.EventHandler(this.timerGenerate_Tick);
            // 
            // timerTransact
            // 
            this.timerTransact.Interval = 1000;
            this.timerTransact.Tick += new System.EventHandler(this.timerTransact_Tick);
            // 
            // MultipleAccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbGenerate);
            this.Controls.Add(this.pbCheck);
            this.Controls.Add(this.pbTransact);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblAcctFName);
            this.Controls.Add(this.lblAcctLName);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.AcctTypeCombo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.lblOpenBal);
            this.Controls.Add(this.lblAcctNo);
            this.Controls.Add(this.txtOpenBal);
            this.Controls.Add(this.txtAccountNo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAcctNoCreator);
            this.Controls.Add(this.lblCreateAcctType);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.lblNotFound);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.txtCheckAcctNo);
            this.Controls.Add(this.lblCreateLName);
            this.Controls.Add(this.lblCreateFName);
            this.Name = "MultipleAccountControl";
            this.Size = new System.Drawing.Size(659, 445);
            this.Load += new System.EventHandler(this.MultipleAccountControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTransact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenerate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotFound;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.TextBox txtCheckAcctNo;
        private System.Windows.Forms.Label lblCreateLName;
        private System.Windows.Forms.Label lblCreateFName;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.ComboBox AcctTypeCombo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblOpenBal;
        private System.Windows.Forms.Label lblAcctNo;
        private System.Windows.Forms.TextBox txtOpenBal;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAcctNoCreator;
        private System.Windows.Forms.Label lblCreateAcctType;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Label lblAcctLName;
        private System.Windows.Forms.Label lblAcctFName;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.PictureBox pbCheck;
        private System.Windows.Forms.PictureBox pbTransact;
        private System.Windows.Forms.PictureBox pbGenerate;
        private System.Windows.Forms.Timer timerCheck;
        private System.Windows.Forms.Timer timerGenerate;
        private System.Windows.Forms.Timer timerTransact;
    }
}
