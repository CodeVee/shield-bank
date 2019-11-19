namespace BankAppUI
{
    partial class CustomerWithdrawal
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
            this.btnHome = new System.Windows.Forms.Button();
            this.lblBal = new System.Windows.Forms.Label();
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.lblEnterAmt = new System.Windows.Forms.Label();
            this.txtDepositAmnt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(609, 336);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(116, 39);
            this.btnHome.TabIndex = 28;
            this.btnHome.Text = "button1";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblBal
            // 
            this.lblBal.AutoSize = true;
            this.lblBal.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBal.Location = new System.Drawing.Point(75, 75);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(123, 33);
            this.lblBal.TabIndex = 27;
            this.lblBal.Text = "Balance";
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.Location = new System.Drawing.Point(340, 336);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(116, 39);
            this.btnWithdrawal.TabIndex = 26;
            this.btnWithdrawal.Text = "button1";
            this.btnWithdrawal.UseVisualStyleBackColor = true;
            this.btnWithdrawal.Click += new System.EventHandler(this.btnWithdrawal_Click);
            // 
            // lblEnterAmt
            // 
            this.lblEnterAmt.AutoSize = true;
            this.lblEnterAmt.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterAmt.Location = new System.Drawing.Point(300, 154);
            this.lblEnterAmt.Name = "lblEnterAmt";
            this.lblEnterAmt.Size = new System.Drawing.Size(199, 33);
            this.lblEnterAmt.TabIndex = 25;
            this.lblEnterAmt.Text = "Enter Amount";
            // 
            // txtDepositAmnt
            // 
            this.txtDepositAmnt.Location = new System.Drawing.Point(255, 226);
            this.txtDepositAmnt.Name = "txtDepositAmnt";
            this.txtDepositAmnt.Size = new System.Drawing.Size(300, 22);
            this.txtDepositAmnt.TabIndex = 24;
            // 
            // CustomerWithdrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblBal);
            this.Controls.Add(this.btnWithdrawal);
            this.Controls.Add(this.lblEnterAmt);
            this.Controls.Add(this.txtDepositAmnt);
            this.Name = "CustomerWithdrawal";
            this.Text = "CustomerWithdrawal";
            this.Load += new System.EventHandler(this.CustomerWithdrawal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.Button btnWithdrawal;
        private System.Windows.Forms.Label lblEnterAmt;
        private System.Windows.Forms.TextBox txtDepositAmnt;
    }
}