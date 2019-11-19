namespace ShieldBank
{
    partial class ChangePasswordControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordControl));
            this.lblWarning = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblOld = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pbUpdate = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNew = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.timerPass = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblWarning.Location = new System.Drawing.Point(251, 227);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(20, 24);
            this.lblWarning.TabIndex = 95;
            this.lblWarning.Text = "..";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Location = new System.Drawing.Point(236, 152);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 1);
            this.panel5.TabIndex = 94;
            // 
            // lblOld
            // 
            this.lblOld.AutoSize = true;
            this.lblOld.Location = new System.Drawing.Point(101, 136);
            this.lblOld.Name = "lblOld";
            this.lblOld.Size = new System.Drawing.Size(99, 17);
            this.lblOld.TabIndex = 93;
            this.lblOld.Text = "Old Password:";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOldPassword.Location = new System.Drawing.Point(236, 131);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(300, 15);
            this.txtOldPassword.TabIndex = 92;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSuccess.Location = new System.Drawing.Point(251, 309);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(20, 24);
            this.lblSuccess.TabIndex = 91;
            this.lblSuccess.Text = "..";
            this.lblSuccess.Click += new System.EventHandler(this.lblSuccess_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(315, 264);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnUpdate.TabIndex = 90;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pbUpdate
            // 
            this.pbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("pbUpdate.Image")));
            this.pbUpdate.Location = new System.Drawing.Point(219, 349);
            this.pbUpdate.Name = "pbUpdate";
            this.pbUpdate.Size = new System.Drawing.Size(288, 51);
            this.pbUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbUpdate.TabIndex = 96;
            this.pbUpdate.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(236, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1);
            this.panel1.TabIndex = 99;
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Location = new System.Drawing.Point(101, 188);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(104, 17);
            this.lblNew.TabIndex = 98;
            this.lblNew.Text = "New Password:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.Location = new System.Drawing.Point(236, 183);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(300, 15);
            this.txtNewPassword.TabIndex = 97;
            // 
            // timerPass
            // 
            this.timerPass.Interval = 6000;
            this.timerPass.Tick += new System.EventHandler(this.timerPass_Tick);
            // 
            // ChangePasswordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.pbUpdate);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblOld);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.btnUpdate);
            this.Name = "ChangePasswordControl";
            this.Size = new System.Drawing.Size(659, 445);
            this.Load += new System.EventHandler(this.ChangePasswordControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUpdate;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblOld;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Timer timerPass;
    }
}
