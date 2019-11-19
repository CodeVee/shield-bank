namespace ShieldBank
{
    partial class SuperAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAdminDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnCreateAdmin = new System.Windows.Forms.Button();
            this.btnMultipleAcct = new System.Windows.Forms.Button();
            this.lblSAdminName = new System.Windows.Forms.Label();
            this.SAdminPicBox = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.activePanel = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSuperAdmin = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.createUserControl1 = new ShieldBank.CreateUserControl();
            this.updateUserControl1 = new ShieldBank.UpdateUserControl();
            this.multipleAccountControl1 = new ShieldBank.MultipleAccountControl();
            this.createAdminControl1 = new ShieldBank.CreateAdminControl();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SAdminPicBox)).BeginInit();
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
            this.SidePanel.Controls.Add(this.btnCreateAdmin);
            this.SidePanel.Controls.Add(this.btnMultipleAcct);
            this.SidePanel.Controls.Add(this.lblSAdminName);
            this.SidePanel.Controls.Add(this.SAdminPicBox);
            this.SidePanel.Controls.Add(this.lblWelcome);
            this.SidePanel.Controls.Add(this.btnUpdate);
            this.SidePanel.Controls.Add(this.activePanel);
            this.SidePanel.Controls.Add(this.btnCreate);
            this.SidePanel.Controls.Add(this.panel1);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(205, 560);
            this.SidePanel.TabIndex = 6;
            // 
            // btnCreateAdmin
            // 
            this.btnCreateAdmin.FlatAppearance.BorderSize = 0;
            this.btnCreateAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAdmin.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAdmin.ForeColor = System.Drawing.Color.White;
            this.btnCreateAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateAdmin.Image")));
            this.btnCreateAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateAdmin.Location = new System.Drawing.Point(12, 465);
            this.btnCreateAdmin.Name = "btnCreateAdmin";
            this.btnCreateAdmin.Size = new System.Drawing.Size(183, 62);
            this.btnCreateAdmin.TabIndex = 6;
            this.btnCreateAdmin.Text = "    Create Admin";
            this.btnCreateAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateAdmin.UseVisualStyleBackColor = true;
            this.btnCreateAdmin.Click += new System.EventHandler(this.btnCreateAdmin_Click);
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
            // lblSAdminName
            // 
            this.lblSAdminName.AutoSize = true;
            this.lblSAdminName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSAdminName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSAdminName.Location = new System.Drawing.Point(12, 148);
            this.lblSAdminName.Name = "lblSAdminName";
            this.lblSAdminName.Size = new System.Drawing.Size(61, 24);
            this.lblSAdminName.TabIndex = 4;
            this.lblSAdminName.Text = "label3";
            this.lblSAdminName.Click += new System.EventHandler(this.lblSAdminName_Click);
            // 
            // SAdminPicBox
            // 
            this.SAdminPicBox.Image = ((System.Drawing.Image)(resources.GetObject("SAdminPicBox.Image")));
            this.SAdminPicBox.Location = new System.Drawing.Point(0, 3);
            this.SAdminPicBox.Name = "SAdminPicBox";
            this.SAdminPicBox.Size = new System.Drawing.Size(118, 112);
            this.SAdminPicBox.TabIndex = 3;
            this.SAdminPicBox.TabStop = false;
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
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(12, 302);
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
            this.btnCreate.Location = new System.Drawing.Point(12, 216);
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
            this.panel3.Controls.Add(this.lblSuperAdmin);
            this.panel3.Location = new System.Drawing.Point(205, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 58);
            this.panel3.TabIndex = 7;
            // 
            // lblSuperAdmin
            // 
            this.lblSuperAdmin.AutoSize = true;
            this.lblSuperAdmin.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperAdmin.Location = new System.Drawing.Point(430, 23);
            this.lblSuperAdmin.Name = "lblSuperAdmin";
            this.lblSuperAdmin.Size = new System.Drawing.Size(217, 29);
            this.lblSuperAdmin.TabIndex = 3;
            this.lblSuperAdmin.Text = "Super Administrator";
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.createUserControl1);
            this.MainPanel.Controls.Add(this.updateUserControl1);
            this.MainPanel.Controls.Add(this.multipleAccountControl1);
            this.MainPanel.Controls.Add(this.createAdminControl1);
            this.MainPanel.Location = new System.Drawing.Point(205, 115);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(659, 445);
            this.MainPanel.TabIndex = 8;
            // 
            // createUserControl1
            // 
            this.createUserControl1.BackColor = System.Drawing.SystemColors.Control;
            this.createUserControl1.Location = new System.Drawing.Point(0, 0);
            this.createUserControl1.Name = "createUserControl1";
            this.createUserControl1.Size = new System.Drawing.Size(659, 445);
            this.createUserControl1.TabIndex = 3;
            this.createUserControl1.Load += new System.EventHandler(this.createUserControl1_Load);
            // 
            // updateUserControl1
            // 
            this.updateUserControl1.Location = new System.Drawing.Point(0, 0);
            this.updateUserControl1.Name = "updateUserControl1";
            this.updateUserControl1.Size = new System.Drawing.Size(659, 445);
            this.updateUserControl1.TabIndex = 2;
            // 
            // multipleAccountControl1
            // 
            this.multipleAccountControl1.Location = new System.Drawing.Point(0, 0);
            this.multipleAccountControl1.Name = "multipleAccountControl1";
            this.multipleAccountControl1.Size = new System.Drawing.Size(659, 445);
            this.multipleAccountControl1.TabIndex = 1;
            // 
            // createAdminControl1
            // 
            this.createAdminControl1.Location = new System.Drawing.Point(0, 0);
            this.createAdminControl1.Name = "createAdminControl1";
            this.createAdminControl1.Size = new System.Drawing.Size(659, 445);
            this.createAdminControl1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(787, 68);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(47, 41);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // SuperAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 560);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuperAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperAdminDashboard";
            this.Load += new System.EventHandler(this.SuperAdminDashboard_Load);
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SAdminPicBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnMultipleAcct;
        private System.Windows.Forms.Label lblSAdminName;
        private System.Windows.Forms.PictureBox SAdminPicBox;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel activePanel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSuperAdmin;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCreateAdmin;
        private CreateUserControl createUserControl1;
        private UpdateUserControl updateUserControl1;
        private MultipleAccountControl multipleAccountControl1;
        private CreateAdminControl createAdminControl1;
    }
}