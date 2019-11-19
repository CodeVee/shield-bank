namespace ShieldBank
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnMultipleAcct = new System.Windows.Forms.Button();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.AdminPicBox = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.activePanel = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.multipleAccountControl1 = new ShieldBank.MultipleAccountControl();
            this.updateUserControl1 = new ShieldBank.UpdateUserControl();
            this.createUserControl1 = new ShieldBank.CreateUserControl();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPicBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(274, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 71);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.SidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SidePanel.Controls.Add(this.btnMultipleAcct);
            this.SidePanel.Controls.Add(this.lblAdminName);
            this.SidePanel.Controls.Add(this.AdminPicBox);
            this.SidePanel.Controls.Add(this.lblWelcome);
            this.SidePanel.Controls.Add(this.btnUpdate);
            this.SidePanel.Controls.Add(this.activePanel);
            this.SidePanel.Controls.Add(this.btnCreate);
            this.SidePanel.Controls.Add(this.panel1);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(205, 560);
            this.SidePanel.TabIndex = 1;
            // 
            // btnMultipleAcct
            // 
            this.btnMultipleAcct.FlatAppearance.BorderSize = 0;
            this.btnMultipleAcct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultipleAcct.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultipleAcct.ForeColor = System.Drawing.Color.White;
            this.btnMultipleAcct.Image = ((System.Drawing.Image)(resources.GetObject("btnMultipleAcct.Image")));
            this.btnMultipleAcct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMultipleAcct.Location = new System.Drawing.Point(12, 380);
            this.btnMultipleAcct.Name = "btnMultipleAcct";
            this.btnMultipleAcct.Size = new System.Drawing.Size(183, 62);
            this.btnMultipleAcct.TabIndex = 5;
            this.btnMultipleAcct.Tag = " ";
            this.btnMultipleAcct.Text = "    Multiple       Accounts";
            this.btnMultipleAcct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMultipleAcct.UseVisualStyleBackColor = true;
            this.btnMultipleAcct.Click += new System.EventHandler(this.btnMultipleAcct_Click);
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdminName.Location = new System.Drawing.Point(12, 148);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(61, 24);
            this.lblAdminName.TabIndex = 4;
            this.lblAdminName.Text = "label3";
            this.lblAdminName.Click += new System.EventHandler(this.lblAdminName_Click);
            // 
            // AdminPicBox
            // 
            this.AdminPicBox.Image = ((System.Drawing.Image)(resources.GetObject("AdminPicBox.Image")));
            this.AdminPicBox.Location = new System.Drawing.Point(16, 22);
            this.AdminPicBox.Name = "AdminPicBox";
            this.AdminPicBox.Size = new System.Drawing.Size(90, 93);
            this.AdminPicBox.TabIndex = 3;
            this.AdminPicBox.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWelcome.Location = new System.Drawing.Point(12, 118);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(76, 21);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(16, 302);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 62);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "    Update User";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // activePanel
            // 
            this.activePanel.BackColor = System.Drawing.Color.GreenYellow;
            this.activePanel.Location = new System.Drawing.Point(-3, 216);
            this.activePanel.Name = "activePanel";
            this.activePanel.Size = new System.Drawing.Size(10, 62);
            this.activePanel.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(16, 216);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(183, 62);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "    Create User";
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(205, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 58);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Administrator";
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(785, 73);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(40, 31);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.createUserControl1);
            this.MainPanel.Controls.Add(this.updateUserControl1);
            this.MainPanel.Controls.Add(this.multipleAccountControl1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.Location = new System.Drawing.Point(205, 115);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(659, 445);
            this.MainPanel.TabIndex = 3;
            // 
            // multipleAccountControl1
            // 
            this.multipleAccountControl1.Location = new System.Drawing.Point(0, 0);
            this.multipleAccountControl1.Name = "multipleAccountControl1";
            this.multipleAccountControl1.Size = new System.Drawing.Size(659, 445);
            this.multipleAccountControl1.TabIndex = 0;
            // 
            // updateUserControl1
            // 
            this.updateUserControl1.Location = new System.Drawing.Point(0, 0);
            this.updateUserControl1.Name = "updateUserControl1";
            this.updateUserControl1.Size = new System.Drawing.Size(659, 445);
            this.updateUserControl1.TabIndex = 1;
            // 
            // createUserControl1
            // 
            this.createUserControl1.BackColor = System.Drawing.SystemColors.Control;
            this.createUserControl1.Location = new System.Drawing.Point(0, 0);
            this.createUserControl1.Name = "createUserControl1";
            this.createUserControl1.Size = new System.Drawing.Size(659, 445);
            this.createUserControl1.TabIndex = 2;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 560);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPicBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel activePanel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.PictureBox AdminPicBox;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button btnMultipleAcct;
        private CreateUserControl createUserControl1;
        private UpdateUserControl updateUserControl1;
        private MultipleAccountControl multipleAccountControl1;
    }
}