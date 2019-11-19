namespace BankAppUI
{
    partial class CustomerLogin
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
            this.btnCustomerLogin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerUsername = new System.Windows.Forms.TextBox();
            this.txtCustomerPassword = new System.Windows.Forms.TextBox();
            this.txtCustomerLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCustomerLogin
            // 
            this.btnCustomerLogin.Location = new System.Drawing.Point(352, 313);
            this.btnCustomerLogin.Name = "btnCustomerLogin";
            this.btnCustomerLogin.Size = new System.Drawing.Size(142, 47);
            this.btnCustomerLogin.TabIndex = 22;
            this.btnCustomerLogin.Text = "button1";
            this.btnCustomerLogin.UseVisualStyleBackColor = true;
            this.btnCustomerLogin.Click += new System.EventHandler(this.btnCustomerLogin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "User Name:";
            // 
            // txtCustomerUsername
            // 
            this.txtCustomerUsername.Location = new System.Drawing.Point(304, 174);
            this.txtCustomerUsername.Name = "txtCustomerUsername";
            this.txtCustomerUsername.Size = new System.Drawing.Size(300, 22);
            this.txtCustomerUsername.TabIndex = 19;
            // 
            // txtCustomerPassword
            // 
            this.txtCustomerPassword.Location = new System.Drawing.Point(304, 215);
            this.txtCustomerPassword.Name = "txtCustomerPassword";
            this.txtCustomerPassword.Size = new System.Drawing.Size(300, 22);
            this.txtCustomerPassword.TabIndex = 18;
            this.txtCustomerPassword.UseSystemPasswordChar = true;
            // 
            // txtCustomerLogin
            // 
            this.txtCustomerLogin.AutoSize = true;
            this.txtCustomerLogin.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerLogin.Location = new System.Drawing.Point(315, 90);
            this.txtCustomerLogin.Name = "txtCustomerLogin";
            this.txtCustomerLogin.Size = new System.Drawing.Size(96, 33);
            this.txtCustomerLogin.TabIndex = 17;
            this.txtCustomerLogin.Text = "label1";
            // 
            // CustomerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCustomerLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCustomerUsername);
            this.Controls.Add(this.txtCustomerPassword);
            this.Controls.Add(this.txtCustomerLogin);
            this.Name = "CustomerLogin";
            this.Text = "CustomerLogin";
            this.Load += new System.EventHandler(this.CustomerLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerUsername;
        private System.Windows.Forms.TextBox txtCustomerPassword;
        private System.Windows.Forms.Label txtCustomerLogin;
    }
}