namespace ShieldBank
{
    partial class CustomerWithdrwalControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerWithdrwalControl));
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtWithdrawAmount = new System.Windows.Forms.TextBox();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.pbTransact = new System.Windows.Forms.PictureBox();
            this.timerTransact = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbTransact)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Location = new System.Drawing.Point(247, 186);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 1);
            this.panel5.TabIndex = 92;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(112, 170);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(98, 17);
            this.lblAmount.TabIndex = 91;
            this.lblAmount.Text = "Enter Amount:";
            // 
            // txtWithdrawAmount
            // 
            this.txtWithdrawAmount.BackColor = System.Drawing.SystemColors.Control;
            this.txtWithdrawAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWithdrawAmount.Location = new System.Drawing.Point(247, 165);
            this.txtWithdrawAmount.Name = "txtWithdrawAmount";
            this.txtWithdrawAmount.Size = new System.Drawing.Size(300, 15);
            this.txtWithdrawAmount.TabIndex = 90;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess.ForeColor = System.Drawing.Color.LightGreen;
            this.lblSuccess.Location = new System.Drawing.Point(254, 310);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(18, 21);
            this.lblSuccess.TabIndex = 89;
            this.lblSuccess.Text = "..";
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnWithdrawal.FlatAppearance.BorderSize = 0;
            this.btnWithdrawal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdrawal.ForeColor = System.Drawing.SystemColors.Control;
            this.btnWithdrawal.Location = new System.Drawing.Point(297, 232);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(89, 34);
            this.btnWithdrawal.TabIndex = 88;
            this.btnWithdrawal.Text = "Withdraw";
            this.btnWithdrawal.UseVisualStyleBackColor = false;
            this.btnWithdrawal.Click += new System.EventHandler(this.btnWithdrawal_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblWarning.Location = new System.Drawing.Point(254, 280);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(14, 21);
            this.lblWarning.TabIndex = 93;
            this.lblWarning.Text = ".";
            // 
            // pbTransact
            // 
            this.pbTransact.Image = ((System.Drawing.Image)(resources.GetObject("pbTransact.Image")));
            this.pbTransact.Location = new System.Drawing.Point(187, 321);
            this.pbTransact.Name = "pbTransact";
            this.pbTransact.Size = new System.Drawing.Size(325, 51);
            this.pbTransact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTransact.TabIndex = 94;
            this.pbTransact.TabStop = false;
            // 
            // timerTransact
            // 
            this.timerTransact.Interval = 6000;
            this.timerTransact.Tick += new System.EventHandler(this.timerTransact_Tick);
            // 
            // CustomerWithdrwalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbTransact);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtWithdrawAmount);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.btnWithdrawal);
            this.Name = "CustomerWithdrwalControl";
            this.Size = new System.Drawing.Size(659, 445);
            this.Load += new System.EventHandler(this.CustomerWithdrwalControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTransact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtWithdrawAmount;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Button btnWithdrawal;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.PictureBox pbTransact;
        private System.Windows.Forms.Timer timerTransact;
    }
}
