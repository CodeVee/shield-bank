namespace ShieldBank
{
    partial class CustomerTransformControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerTransformControl));
            this.lblFoundAcctName = new System.Windows.Forms.Label();
            this.lblFoundAcctNo = new System.Windows.Forms.Label();
            this.lblNotFound = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblCheck = new System.Windows.Forms.Label();
            this.txtCheckAcctNo = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.lblAcctNo = new System.Windows.Forms.Label();
            this.lblAcctName = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtTransferAmount = new System.Windows.Forms.TextBox();
            this.pbGenerate = new System.Windows.Forms.PictureBox();
            this.pbTransact = new System.Windows.Forms.PictureBox();
            this.timerTransact = new System.Windows.Forms.Timer(this.components);
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbGenerate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTransact)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFoundAcctName
            // 
            this.lblFoundAcctName.AutoSize = true;
            this.lblFoundAcctName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoundAcctName.Location = new System.Drawing.Point(229, 169);
            this.lblFoundAcctName.Name = "lblFoundAcctName";
            this.lblFoundAcctName.Size = new System.Drawing.Size(15, 21);
            this.lblFoundAcctName.TabIndex = 151;
            this.lblFoundAcctName.Text = ".";
            // 
            // lblFoundAcctNo
            // 
            this.lblFoundAcctNo.AutoSize = true;
            this.lblFoundAcctNo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoundAcctNo.Location = new System.Drawing.Point(229, 218);
            this.lblFoundAcctNo.Name = "lblFoundAcctNo";
            this.lblFoundAcctNo.Size = new System.Drawing.Size(15, 21);
            this.lblFoundAcctNo.TabIndex = 150;
            this.lblFoundAcctNo.Text = ".";
            // 
            // lblNotFound
            // 
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.ForeColor = System.Drawing.Color.Tomato;
            this.lblNotFound.Location = new System.Drawing.Point(175, 87);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(16, 17);
            this.lblNotFound.TabIndex = 149;
            this.lblNotFound.Text = "..";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCheck.Location = new System.Drawing.Point(516, 63);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(70, 26);
            this.btnCheck.TabIndex = 148;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DimGray;
            this.panel7.Location = new System.Drawing.Point(178, 79);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 1);
            this.panel7.TabIndex = 147;
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(52, 68);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(85, 17);
            this.lblCheck.TabIndex = 146;
            this.lblCheck.Text = "Account No:";
            // 
            // txtCheckAcctNo
            // 
            this.txtCheckAcctNo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCheckAcctNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCheckAcctNo.Location = new System.Drawing.Point(178, 58);
            this.txtCheckAcctNo.Name = "txtCheckAcctNo";
            this.txtCheckAcctNo.Size = new System.Drawing.Size(300, 15);
            this.txtCheckAcctNo.TabIndex = 145;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(388, 355);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 35);
            this.btnClear.TabIndex = 144;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.ForeColor = System.Drawing.Color.LightGreen;
            this.lblSuccess.Location = new System.Drawing.Point(175, 408);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(16, 17);
            this.lblSuccess.TabIndex = 143;
            this.lblSuccess.Text = "..";
            // 
            // lblAcctNo
            // 
            this.lblAcctNo.AutoSize = true;
            this.lblAcctNo.Location = new System.Drawing.Point(52, 223);
            this.lblAcctNo.Name = "lblAcctNo";
            this.lblAcctNo.Size = new System.Drawing.Size(85, 17);
            this.lblAcctNo.TabIndex = 142;
            this.lblAcctNo.Text = "Account No:";
            // 
            // lblAcctName
            // 
            this.lblAcctName.AutoSize = true;
            this.lblAcctName.Location = new System.Drawing.Point(52, 174);
            this.lblAcctName.Name = "lblAcctName";
            this.lblAcctName.Size = new System.Drawing.Size(104, 17);
            this.lblAcctName.TabIndex = 141;
            this.lblAcctName.Text = "Account Name:";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTransfer.Location = new System.Drawing.Point(169, 355);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(75, 34);
            this.btnTransfer.TabIndex = 140;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblWarning.Location = new System.Drawing.Point(185, 299);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(18, 21);
            this.lblWarning.TabIndex = 155;
            this.lblWarning.Text = "..";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Location = new System.Drawing.Point(178, 283);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 1);
            this.panel5.TabIndex = 154;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(52, 267);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(98, 17);
            this.lblAmount.TabIndex = 153;
            this.lblAmount.Text = "Enter Amount:";
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // txtTransferAmount
            // 
            this.txtTransferAmount.BackColor = System.Drawing.SystemColors.Control;
            this.txtTransferAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTransferAmount.Location = new System.Drawing.Point(178, 262);
            this.txtTransferAmount.Name = "txtTransferAmount";
            this.txtTransferAmount.Size = new System.Drawing.Size(300, 15);
            this.txtTransferAmount.TabIndex = 152;
            // 
            // pbGenerate
            // 
            this.pbGenerate.Image = ((System.Drawing.Image)(resources.GetObject("pbGenerate.Image")));
            this.pbGenerate.Location = new System.Drawing.Point(603, 58);
            this.pbGenerate.Name = "pbGenerate";
            this.pbGenerate.Size = new System.Drawing.Size(38, 36);
            this.pbGenerate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbGenerate.TabIndex = 157;
            this.pbGenerate.TabStop = false;
            // 
            // pbTransact
            // 
            this.pbTransact.Image = ((System.Drawing.Image)(resources.GetObject("pbTransact.Image")));
            this.pbTransact.Location = new System.Drawing.Point(223, 396);
            this.pbTransact.Name = "pbTransact";
            this.pbTransact.Size = new System.Drawing.Size(268, 36);
            this.pbTransact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTransact.TabIndex = 156;
            this.pbTransact.TabStop = false;
            // 
            // timerTransact
            // 
            this.timerTransact.Interval = 7000;
            this.timerTransact.Tick += new System.EventHandler(this.timerTransact_Tick);
            // 
            // timerCheck
            // 
            this.timerCheck.Interval = 1000;
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // CustomerTransformControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbGenerate);
            this.Controls.Add(this.pbTransact);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtTransferAmount);
            this.Controls.Add(this.lblFoundAcctName);
            this.Controls.Add(this.lblFoundAcctNo);
            this.Controls.Add(this.lblNotFound);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.txtCheckAcctNo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.lblAcctNo);
            this.Controls.Add(this.lblAcctName);
            this.Controls.Add(this.btnTransfer);
            this.Name = "CustomerTransformControl";
            this.Size = new System.Drawing.Size(659, 445);
            this.Load += new System.EventHandler(this.CustomerTransformControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGenerate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTransact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFoundAcctName;
        private System.Windows.Forms.Label lblFoundAcctNo;
        private System.Windows.Forms.Label lblNotFound;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.TextBox txtCheckAcctNo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Label lblAcctNo;
        private System.Windows.Forms.Label lblAcctName;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtTransferAmount;
        private System.Windows.Forms.PictureBox pbGenerate;
        private System.Windows.Forms.PictureBox pbTransact;
        private System.Windows.Forms.Timer timerTransact;
        private System.Windows.Forms.Timer timerCheck;
    }
}
