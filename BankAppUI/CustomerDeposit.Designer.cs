namespace BankAppUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEnterAmt = new System.Windows.Forms.Label();
            this.txtDepositAmnt = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lblBal = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterAmt
            // 
            this.lblEnterAmt.AutoSize = true;
            this.lblEnterAmt.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterAmt.Location = new System.Drawing.Point(308, 120);
            this.lblEnterAmt.Name = "lblEnterAmt";
            this.lblEnterAmt.Size = new System.Drawing.Size(199, 33);
            this.lblEnterAmt.TabIndex = 20;
            this.lblEnterAmt.Text = "Enter Amount";
            this.lblEnterAmt.Click += new System.EventHandler(this.lblCreateFName_Click);
            // 
            // txtDepositAmnt
            // 
            this.txtDepositAmnt.Location = new System.Drawing.Point(263, 192);
            this.txtDepositAmnt.Name = "txtDepositAmnt";
            this.txtDepositAmnt.Size = new System.Drawing.Size(300, 22);
            this.txtDepositAmnt.TabIndex = 19;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(348, 302);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(116, 39);
            this.btnDeposit.TabIndex = 21;
            this.btnDeposit.Text = "button1";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lblBal
            // 
            this.lblBal.AutoSize = true;
            this.lblBal.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBal.Location = new System.Drawing.Point(83, 41);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(123, 33);
            this.lblBal.TabIndex = 22;
            this.lblBal.Text = "Balance";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(617, 302);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(116, 39);
            this.btnHome.TabIndex = 23;
            this.btnHome.Text = "button1";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // CustomerDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblBal);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.lblEnterAmt);
            this.Controls.Add(this.txtDepositAmnt);
            this.Name = "CustomerDeposit";
            this.Text = "CustomerDeposit";
            this.Load += new System.EventHandler(this.CustomerDeposit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterAmt;
        private System.Windows.Forms.TextBox txtDepositAmnt;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.Button btnHome;
    }
}