namespace BankAppUI
{
    partial class Form1
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
            this.Label1 = new System.Windows.Forms.Label();
            this.txtLoginUserName = new System.Windows.Forms.TextBox();
            this.txtLoginUserPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(259, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(202, 17);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Welcome To Victor\'s Bank App";
            // 
            // txtLoginUserName
            // 
            this.txtLoginUserName.Location = new System.Drawing.Point(279, 100);
            this.txtLoginUserName.Name = "txtLoginUserName";
            this.txtLoginUserName.Size = new System.Drawing.Size(341, 22);
            this.txtLoginUserName.TabIndex = 1;
            // 
            // txtLoginUserPassword
            // 
            this.txtLoginUserPassword.AcceptsTab = true;
            this.txtLoginUserPassword.Location = new System.Drawing.Point(279, 190);
            this.txtLoginUserPassword.Name = "txtLoginUserPassword";
            this.txtLoginUserPassword.PasswordChar = '*';
            this.txtLoginUserPassword.Size = new System.Drawing.Size(341, 22);
            this.txtLoginUserPassword.TabIndex = 2;
            this.txtLoginUserPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(374, 317);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 37);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter User Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLoginUserPassword);
            this.Controls.Add(this.txtLoginUserName);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Bank App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txtLoginUserName;
        private System.Windows.Forms.TextBox txtLoginUserPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

