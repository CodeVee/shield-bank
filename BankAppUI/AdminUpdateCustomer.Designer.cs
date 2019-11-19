namespace BankAppUI
{
    partial class AdminUpdateCustomer
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
            this.lblCreatePhone = new System.Windows.Forms.Label();
            this.lblCreateEmail = new System.Windows.Forms.Label();
            this.lblCreateLName = new System.Windows.Forms.Label();
            this.lblCreateFName = new System.Windows.Forms.Label();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.txtUpdateLName = new System.Windows.Forms.TextBox();
            this.txtUpdateFName = new System.Windows.Forms.TextBox();
            this.txtUpdatePhone = new System.Windows.Forms.TextBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.txtCheck = new System.Windows.Forms.TextBox();
            this.btnCheckCustomer = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCreatePhone
            // 
            this.lblCreatePhone.AutoSize = true;
            this.lblCreatePhone.Location = new System.Drawing.Point(170, 309);
            this.lblCreatePhone.Name = "lblCreatePhone";
            this.lblCreatePhone.Size = new System.Drawing.Size(53, 17);
            this.lblCreatePhone.TabIndex = 30;
            this.lblCreatePhone.Text = "Phone:";
            // 
            // lblCreateEmail
            // 
            this.lblCreateEmail.AutoSize = true;
            this.lblCreateEmail.Location = new System.Drawing.Point(170, 269);
            this.lblCreateEmail.Name = "lblCreateEmail";
            this.lblCreateEmail.Size = new System.Drawing.Size(46, 17);
            this.lblCreateEmail.TabIndex = 29;
            this.lblCreateEmail.Text = "Email:";
            // 
            // lblCreateLName
            // 
            this.lblCreateLName.AutoSize = true;
            this.lblCreateLName.Location = new System.Drawing.Point(170, 227);
            this.lblCreateLName.Name = "lblCreateLName";
            this.lblCreateLName.Size = new System.Drawing.Size(80, 17);
            this.lblCreateLName.TabIndex = 28;
            this.lblCreateLName.Text = "Last Name:";
            // 
            // lblCreateFName
            // 
            this.lblCreateFName.AutoSize = true;
            this.lblCreateFName.Location = new System.Drawing.Point(170, 190);
            this.lblCreateFName.Name = "lblCreateFName";
            this.lblCreateFName.Size = new System.Drawing.Size(80, 17);
            this.lblCreateFName.TabIndex = 27;
            this.lblCreateFName.Text = "First Name:";
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Location = new System.Drawing.Point(305, 264);
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(300, 22);
            this.txtUpdateEmail.TabIndex = 26;
            // 
            // txtUpdateLName
            // 
            this.txtUpdateLName.Location = new System.Drawing.Point(305, 222);
            this.txtUpdateLName.Name = "txtUpdateLName";
            this.txtUpdateLName.Size = new System.Drawing.Size(300, 22);
            this.txtUpdateLName.TabIndex = 25;
            // 
            // txtUpdateFName
            // 
            this.txtUpdateFName.Location = new System.Drawing.Point(305, 185);
            this.txtUpdateFName.Name = "txtUpdateFName";
            this.txtUpdateFName.Size = new System.Drawing.Size(300, 22);
            this.txtUpdateFName.TabIndex = 24;
            // 
            // txtUpdatePhone
            // 
            this.txtUpdatePhone.Location = new System.Drawing.Point(305, 304);
            this.txtUpdatePhone.Name = "txtUpdatePhone";
            this.txtUpdatePhone.Size = new System.Drawing.Size(300, 22);
            this.txtUpdatePhone.TabIndex = 23;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(393, 388);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(75, 34);
            this.btnCreateUser.TabIndex = 22;
            this.btnCreateUser.Text = "Update";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            // 
            // txtCheck
            // 
            this.txtCheck.Location = new System.Drawing.Point(305, 54);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.Size = new System.Drawing.Size(300, 22);
            this.txtCheck.TabIndex = 31;
            // 
            // btnCheckCustomer
            // 
            this.btnCheckCustomer.Location = new System.Drawing.Point(672, 48);
            this.btnCheckCustomer.Name = "btnCheckCustomer";
            this.btnCheckCustomer.Size = new System.Drawing.Size(75, 34);
            this.btnCheckCustomer.TabIndex = 32;
            this.btnCheckCustomer.Text = "Check";
            this.btnCheckCustomer.UseVisualStyleBackColor = true;
            this.btnCheckCustomer.Click += new System.EventHandler(this.btnCheckCustomer_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblWarning.Location = new System.Drawing.Point(301, 105);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(19, 19);
            this.lblWarning.TabIndex = 33;
            this.lblWarning.Text = "..";
            // 
            // AdminUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnCheckCustomer);
            this.Controls.Add(this.txtCheck);
            this.Controls.Add(this.lblCreatePhone);
            this.Controls.Add(this.lblCreateEmail);
            this.Controls.Add(this.lblCreateLName);
            this.Controls.Add(this.lblCreateFName);
            this.Controls.Add(this.txtUpdateEmail);
            this.Controls.Add(this.txtUpdateLName);
            this.Controls.Add(this.txtUpdateFName);
            this.Controls.Add(this.txtUpdatePhone);
            this.Controls.Add(this.btnCreateUser);
            this.Name = "AdminUpdateCustomer";
            this.Text = "AdminUpdateCustomer";
            this.Load += new System.EventHandler(this.AdminUpdateCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreatePhone;
        private System.Windows.Forms.Label lblCreateEmail;
        private System.Windows.Forms.Label lblCreateLName;
        private System.Windows.Forms.Label lblCreateFName;
        private System.Windows.Forms.TextBox txtUpdateEmail;
        private System.Windows.Forms.TextBox txtUpdateLName;
        private System.Windows.Forms.TextBox txtUpdateFName;
        private System.Windows.Forms.TextBox txtUpdatePhone;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.TextBox txtCheck;
        private System.Windows.Forms.Button btnCheckCustomer;
        private System.Windows.Forms.Label lblWarning;
    }
}