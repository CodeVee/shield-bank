namespace BankAppUI
{
    partial class CustomerTransfer
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
            this.btnTransfer = new System.Windows.Forms.Button();
            this.lblEnterAmt = new System.Windows.Forms.Label();
            this.txtTransferAmnt = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblEnterAcctNo = new System.Windows.Forms.Label();
            this.txtCheckAcctNo = new System.Windows.Forms.TextBox();
            this.lblAcctHolderName = new System.Windows.Forms.Label();
            this.lblAcctHolderNo = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(638, 399);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(116, 39);
            this.btnHome.TabIndex = 33;
            this.btnHome.Text = "button1";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblBal
            // 
            this.lblBal.AutoSize = true;
            this.lblBal.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBal.Location = new System.Drawing.Point(47, 23);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(123, 33);
            this.lblBal.TabIndex = 32;
            this.lblBal.Text = "Balance";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(362, 399);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(116, 39);
            this.btnTransfer.TabIndex = 31;
            this.btnTransfer.Text = "button1";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // lblEnterAmt
            // 
            this.lblEnterAmt.AutoSize = true;
            this.lblEnterAmt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterAmt.Location = new System.Drawing.Point(31, 354);
            this.lblEnterAmt.Name = "lblEnterAmt";
            this.lblEnterAmt.Size = new System.Drawing.Size(146, 24);
            this.lblEnterAmt.TabIndex = 30;
            this.lblEnterAmt.Text = "Enter Amount:";
            // 
            // txtTransferAmnt
            // 
            this.txtTransferAmnt.Location = new System.Drawing.Point(310, 357);
            this.txtTransferAmnt.Name = "txtTransferAmnt";
            this.txtTransferAmnt.Size = new System.Drawing.Size(300, 22);
            this.txtTransferAmnt.TabIndex = 29;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(638, 81);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(116, 39);
            this.btnCheck.TabIndex = 34;
            this.btnCheck.Text = "button1";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblEnterAcctNo
            // 
            this.lblEnterAcctNo.AutoSize = true;
            this.lblEnterAcctNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterAcctNo.Location = new System.Drawing.Point(31, 89);
            this.lblEnterAcctNo.Name = "lblEnterAcctNo";
            this.lblEnterAcctNo.Size = new System.Drawing.Size(231, 24);
            this.lblEnterAcctNo.TabIndex = 36;
            this.lblEnterAcctNo.Text = "Enter Account Number:";
            // 
            // txtCheckAcctNo
            // 
            this.txtCheckAcctNo.Location = new System.Drawing.Point(310, 89);
            this.txtCheckAcctNo.Name = "txtCheckAcctNo";
            this.txtCheckAcctNo.Size = new System.Drawing.Size(300, 22);
            this.txtCheckAcctNo.TabIndex = 35;
            // 
            // lblAcctHolderName
            // 
            this.lblAcctHolderName.AutoSize = true;
            this.lblAcctHolderName.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcctHolderName.Location = new System.Drawing.Point(346, 201);
            this.lblAcctHolderName.Name = "lblAcctHolderName";
            this.lblAcctHolderName.Size = new System.Drawing.Size(161, 33);
            this.lblAcctHolderName.TabIndex = 37;
            this.lblAcctHolderName.Text = "Acct Name";
            // 
            // lblAcctHolderNo
            // 
            this.lblAcctHolderNo.AutoSize = true;
            this.lblAcctHolderNo.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcctHolderNo.Location = new System.Drawing.Point(346, 265);
            this.lblAcctHolderNo.Name = "lblAcctHolderNo";
            this.lblAcctHolderNo.Size = new System.Drawing.Size(120, 33);
            this.lblAcctHolderNo.TabIndex = 38;
            this.lblAcctHolderNo.Text = "Acct No";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblWarning.Location = new System.Drawing.Point(306, 137);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(93, 19);
            this.lblWarning.TabIndex = 39;
            this.lblWarning.Text = "Acct Name";
            // 
            // CustomerTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblAcctHolderNo);
            this.Controls.Add(this.lblAcctHolderName);
            this.Controls.Add(this.lblEnterAcctNo);
            this.Controls.Add(this.txtCheckAcctNo);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblBal);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.lblEnterAmt);
            this.Controls.Add(this.txtTransferAmnt);
            this.Name = "CustomerTransfer";
            this.Text = "CustomerTransfer";
            this.Load += new System.EventHandler(this.CustomerTransfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label lblEnterAmt;
        private System.Windows.Forms.TextBox txtTransferAmnt;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblEnterAcctNo;
        private System.Windows.Forms.TextBox txtCheckAcctNo;
        private System.Windows.Forms.Label lblAcctHolderName;
        private System.Windows.Forms.Label lblAcctHolderNo;
        private System.Windows.Forms.Label lblWarning;
    }
}