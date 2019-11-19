namespace BankAppUI
{
    partial class CustomerInterface
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
            this.txtWelcome = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.Label();
            this.txtAccType = new System.Windows.Forms.Label();
            this.txtAcctNo = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWelcome
            // 
            this.txtWelcome.AutoSize = true;
            this.txtWelcome.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelcome.Location = new System.Drawing.Point(212, 24);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(132, 46);
            this.txtWelcome.TabIndex = 0;
            this.txtWelcome.Text = "label1";
            // 
            // txtBalance
            // 
            this.txtBalance.AutoSize = true;
            this.txtBalance.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(215, 267);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 35);
            this.txtBalance.TabIndex = 1;
            this.txtBalance.Text = "label1";
            // 
            // txtAccType
            // 
            this.txtAccType.AutoSize = true;
            this.txtAccType.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccType.Location = new System.Drawing.Point(214, 132);
            this.txtAccType.Name = "txtAccType";
            this.txtAccType.Size = new System.Drawing.Size(100, 34);
            this.txtAccType.TabIndex = 2;
            this.txtAccType.Text = "label1";
            // 
            // txtAcctNo
            // 
            this.txtAcctNo.AutoSize = true;
            this.txtAcctNo.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctNo.Location = new System.Drawing.Point(216, 186);
            this.txtAcctNo.Name = "txtAcctNo";
            this.txtAcctNo.Size = new System.Drawing.Size(81, 29);
            this.txtAcctNo.TabIndex = 3;
            this.txtAcctNo.Text = "label1";
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(159, 357);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(115, 44);
            this.btnDeposit.TabIndex = 4;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(379, 357);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(92, 44);
            this.btnWithdraw.TabIndex = 5;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(576, 357);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(97, 44);
            this.btnTransfer.TabIndex = 6;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 26);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(97, 44);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // CustomerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txtAcctNo);
            this.Controls.Add(this.txtAccType);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtWelcome);
            this.Name = "CustomerInterface";
            this.Text = "CustomerInterface";
            this.Load += new System.EventHandler(this.CustomerInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtWelcome;
        private System.Windows.Forms.Label txtBalance;
        private System.Windows.Forms.Label txtAccType;
        private System.Windows.Forms.Label txtAcctNo;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnLogout;
    }
}