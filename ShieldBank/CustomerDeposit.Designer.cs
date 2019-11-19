namespace ShieldBank
{
    partial class CustomerDeposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDeposit));
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.pbTransact = new System.Windows.Forms.PictureBox();
            this.timerTransact = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbTransact)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Location = new System.Drawing.Point(247, 193);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 1);
            this.panel5.TabIndex = 87;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(112, 177);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(98, 17);
            this.lblAmount.TabIndex = 86;
            this.lblAmount.Text = "Enter Amount:";
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.BackColor = System.Drawing.SystemColors.Control;
            this.txtDepositAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDepositAmount.Location = new System.Drawing.Point(247, 172);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(300, 15);
            this.txtDepositAmount.TabIndex = 85;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess.ForeColor = System.Drawing.Color.LightGreen;
            this.lblSuccess.Location = new System.Drawing.Point(254, 295);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(18, 21);
            this.lblSuccess.TabIndex = 84;
            this.lblSuccess.Text = "..";
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeposit.Location = new System.Drawing.Point(332, 245);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 34);
            this.btnDeposit.TabIndex = 83;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblWarning.Location = new System.Drawing.Point(254, 209);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(18, 21);
            this.lblWarning.TabIndex = 88;
            this.lblWarning.Text = "..";
            // 
            // pbTransact
            // 
            this.pbTransact.Image = ((System.Drawing.Image)(resources.GetObject("pbTransact.Image")));
            this.pbTransact.Location = new System.Drawing.Point(225, 319);
            this.pbTransact.Name = "pbTransact";
            this.pbTransact.Size = new System.Drawing.Size(288, 51);
            this.pbTransact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTransact.TabIndex = 89;
            this.pbTransact.TabStop = false;
            // 
            // timerTransact
            // 
            this.timerTransact.Interval = 6000;
            this.timerTransact.Tick += new System.EventHandler(this.timerTransact_Tick);
            // 
            // CustomerDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbTransact);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtDepositAmount);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.btnDeposit);
            this.Name = "CustomerDeposit";
            this.Size = new System.Drawing.Size(659, 445);
            this.Load += new System.EventHandler(this.CustomerDeposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTransact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.PictureBox pbTransact;
        private System.Windows.Forms.Timer timerTransact;
    }
}
