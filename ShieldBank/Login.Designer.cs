namespace ShieldBank
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.panelPass = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblNotFound = new System.Windows.Forms.Label();
            this.lblEmptyUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.iconPass = new System.Windows.Forms.PictureBox();
            this.iconUser = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltxt = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbltxt2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(402, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome To Shield Bank";
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.White;
            this.panelUser.Location = new System.Drawing.Point(405, 242);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(300, 1);
            this.panelUser.TabIndex = 3;
            // 
            // panelPass
            // 
            this.panelPass.BackColor = System.Drawing.Color.White;
            this.panelPass.Location = new System.Drawing.Point(406, 364);
            this.panelPass.Name = "panelPass";
            this.panelPass.Size = new System.Drawing.Size(299, 1);
            this.panelPass.TabIndex = 6;
            this.panelPass.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnLogin.Location = new System.Drawing.Point(459, 449);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(163, 50);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblNotFound
            // 
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotFound.ForeColor = System.Drawing.Color.Salmon;
            this.lblNotFound.Location = new System.Drawing.Point(402, 386);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(81, 21);
            this.lblNotFound.TabIndex = 10;
            this.lblNotFound.Text = "Username";
            // 
            // lblEmptyUsername
            // 
            this.lblEmptyUsername.AutoSize = true;
            this.lblEmptyUsername.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmptyUsername.ForeColor = System.Drawing.Color.Salmon;
            this.lblEmptyUsername.Location = new System.Drawing.Point(402, 257);
            this.lblEmptyUsername.Name = "lblEmptyUsername";
            this.lblEmptyUsername.Size = new System.Drawing.Size(81, 21);
            this.lblEmptyUsername.TabIndex = 12;
            this.lblEmptyUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(442, 215);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(254, 20);
            this.txtUsername.TabIndex = 13;
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(442, 338);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(258, 20);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // iconPass
            // 
            this.iconPass.Image = ((System.Drawing.Image)(resources.GetObject("iconPass.Image")));
            this.iconPass.Location = new System.Drawing.Point(404, 332);
            this.iconPass.Name = "iconPass";
            this.iconPass.Size = new System.Drawing.Size(31, 30);
            this.iconPass.TabIndex = 15;
            this.iconPass.TabStop = false;
            // 
            // iconUser
            // 
            this.iconUser.Image = ((System.Drawing.Image)(resources.GetObject("iconUser.Image")));
            this.iconUser.Location = new System.Drawing.Point(404, 211);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(31, 30);
            this.iconUser.TabIndex = 14;
            this.iconUser.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(699, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 33);
            this.btnExit.TabIndex = 11;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 607);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbltxt
            // 
            this.lbltxt.AutoSize = true;
            this.lbltxt.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxt.ForeColor = System.Drawing.SystemColors.Control;
            this.lbltxt.Location = new System.Drawing.Point(441, 215);
            this.lbltxt.Name = "lbltxt";
            this.lbltxt.Size = new System.Drawing.Size(83, 19);
            this.lbltxt.TabIndex = 17;
            this.lbltxt.Text = "Username";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPass.Location = new System.Drawing.Point(438, 338);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(80, 19);
            this.lblPass.TabIndex = 18;
            this.lblPass.Text = "Password";
            // 
            // pbLoading
            // 
            this.pbLoading.BackColor = System.Drawing.Color.Transparent;
            this.pbLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbLoading.Image")));
            this.pbLoading.Location = new System.Drawing.Point(332, 230);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(151, 127);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLoading.TabIndex = 19;
            this.pbLoading.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbltxt2
            // 
            this.lbltxt2.AutoSize = true;
            this.lbltxt2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxt2.ForeColor = System.Drawing.SystemColors.Control;
            this.lbltxt2.Location = new System.Drawing.Point(441, 338);
            this.lbltxt2.Name = "lbltxt2";
            this.lbltxt2.Size = new System.Drawing.Size(80, 19);
            this.lbltxt2.TabIndex = 20;
            this.lbltxt2.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 612);
            this.Controls.Add(this.lbltxt2);
            this.Controls.Add(this.iconPass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbltxt);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panelPass);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.iconUser);
            this.Controls.Add(this.lblEmptyUsername);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblNotFound);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panelPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblNotFound;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblEmptyUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox iconUser;
        private System.Windows.Forms.PictureBox iconPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbltxt;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltxt2;
    }
}

