namespace BankAppUI
{
    partial class AdminControlPanel
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
            this.btnSubmitAdminData = new System.Windows.Forms.Button();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.txtAdminUserName = new System.Windows.Forms.TextBox();
            this.txtAdminFirstNAme = new System.Windows.Forms.TextBox();
            this.txtAdminLastName = new System.Windows.Forms.TextBox();
            this.txtAdminEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmitAdminData
            // 
            this.btnSubmitAdminData.Location = new System.Drawing.Point(327, 322);
            this.btnSubmitAdminData.Name = "btnSubmitAdminData";
            this.btnSubmitAdminData.Size = new System.Drawing.Size(75, 34);
            this.btnSubmitAdminData.TabIndex = 0;
            this.btnSubmitAdminData.Text = "Submit Data";
            this.btnSubmitAdminData.UseVisualStyleBackColor = true;
            this.btnSubmitAdminData.Click += new System.EventHandler(this.btnSubmitAdminData_Click);
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Location = new System.Drawing.Point(249, 243);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.PasswordChar = '*';
            this.txtAdminPassword.Size = new System.Drawing.Size(300, 22);
            this.txtAdminPassword.TabIndex = 1;
            this.txtAdminPassword.TextChanged += new System.EventHandler(this.txtAdminPassword_TextChanged);
            // 
            // txtAdminUserName
            // 
            this.txtAdminUserName.Location = new System.Drawing.Point(249, 202);
            this.txtAdminUserName.Name = "txtAdminUserName";
            this.txtAdminUserName.Size = new System.Drawing.Size(300, 22);
            this.txtAdminUserName.TabIndex = 2;
            // 
            // txtAdminFirstNAme
            // 
            this.txtAdminFirstNAme.Location = new System.Drawing.Point(249, 83);
            this.txtAdminFirstNAme.Name = "txtAdminFirstNAme";
            this.txtAdminFirstNAme.Size = new System.Drawing.Size(300, 22);
            this.txtAdminFirstNAme.TabIndex = 4;
            // 
            // txtAdminLastName
            // 
            this.txtAdminLastName.Location = new System.Drawing.Point(249, 120);
            this.txtAdminLastName.Name = "txtAdminLastName";
            this.txtAdminLastName.Size = new System.Drawing.Size(300, 22);
            this.txtAdminLastName.TabIndex = 5;
            // 
            // txtAdminEmail
            // 
            this.txtAdminEmail.Location = new System.Drawing.Point(249, 162);
            this.txtAdminEmail.Name = "txtAdminEmail";
            this.txtAdminEmail.Size = new System.Drawing.Size(300, 22);
            this.txtAdminEmail.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "User Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password:";
            // 
            // AdminControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdminEmail);
            this.Controls.Add(this.txtAdminLastName);
            this.Controls.Add(this.txtAdminFirstNAme);
            this.Controls.Add(this.txtAdminUserName);
            this.Controls.Add(this.txtAdminPassword);
            this.Controls.Add(this.btnSubmitAdminData);
            this.Name = "AdminControlPanel";
            this.Text = "AdminControlPanel";
            this.Load += new System.EventHandler(this.AdminControlPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitAdminData;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.TextBox txtAdminUserName;
        private System.Windows.Forms.TextBox txtAdminFirstNAme;
        private System.Windows.Forms.TextBox txtAdminLastName;
        private System.Windows.Forms.TextBox txtAdminEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}