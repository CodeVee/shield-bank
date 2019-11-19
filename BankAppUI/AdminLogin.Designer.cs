namespace BankAppUI
{
    partial class AdminLogin
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
            this.txtAdminLogin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdminUserName = new System.Windows.Forms.TextBox();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAdminLogin
            // 
            this.txtAdminLogin.AutoSize = true;
            this.txtAdminLogin.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminLogin.Location = new System.Drawing.Point(305, 75);
            this.txtAdminLogin.Name = "txtAdminLogin";
            this.txtAdminLogin.Size = new System.Drawing.Size(96, 33);
            this.txtAdminLogin.TabIndex = 0;
            this.txtAdminLogin.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "User Name:";
            // 
            // txtAdminUserName
            // 
            this.txtAdminUserName.Location = new System.Drawing.Point(294, 159);
            this.txtAdminUserName.Name = "txtAdminUserName";
            this.txtAdminUserName.Size = new System.Drawing.Size(300, 22);
            this.txtAdminUserName.TabIndex = 13;
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Location = new System.Drawing.Point(294, 200);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(300, 22);
            this.txtAdminPassword.TabIndex = 12;
            this.txtAdminPassword.UseSystemPasswordChar = true;
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(342, 298);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(142, 47);
            this.btnAdminLogin.TabIndex = 16;
            this.btnAdminLogin.Text = "button1";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 464);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdminUserName);
            this.Controls.Add(this.txtAdminPassword);
            this.Controls.Add(this.txtAdminLogin);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAdminLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdminUserName;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.Button btnAdminLogin;
    }
}