namespace BankAppUI
{
    partial class AdminOrCustomer
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
            this.txtSelect = new System.Windows.Forms.Label();
            this.rdBtnAdmin = new System.Windows.Forms.RadioButton();
            this.rdBtnCustomer = new System.Windows.Forms.RadioButton();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWelcome
            // 
            this.txtWelcome.AutoSize = true;
            this.txtWelcome.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelcome.Location = new System.Drawing.Point(223, 61);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(159, 38);
            this.txtWelcome.TabIndex = 0;
            this.txtWelcome.Text = "Welcome";
            // 
            // txtSelect
            // 
            this.txtSelect.AutoSize = true;
            this.txtSelect.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelect.Location = new System.Drawing.Point(51, 165);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(112, 29);
            this.txtSelect.TabIndex = 1;
            this.txtSelect.Text = "txtSelect";
            // 
            // rdBtnAdmin
            // 
            this.rdBtnAdmin.AutoSize = true;
            this.rdBtnAdmin.Location = new System.Drawing.Point(346, 172);
            this.rdBtnAdmin.Name = "rdBtnAdmin";
            this.rdBtnAdmin.Size = new System.Drawing.Size(110, 21);
            this.rdBtnAdmin.TabIndex = 2;
            this.rdBtnAdmin.TabStop = true;
            this.rdBtnAdmin.Text = "radioButton1";
            this.rdBtnAdmin.UseVisualStyleBackColor = true;
            // 
            // rdBtnCustomer
            // 
            this.rdBtnCustomer.AutoSize = true;
            this.rdBtnCustomer.Location = new System.Drawing.Point(532, 172);
            this.rdBtnCustomer.Name = "rdBtnCustomer";
            this.rdBtnCustomer.Size = new System.Drawing.Size(110, 21);
            this.rdBtnCustomer.TabIndex = 3;
            this.rdBtnCustomer.TabStop = true;
            this.rdBtnCustomer.Text = "radioButton2";
            this.rdBtnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(346, 289);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(110, 48);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "button1";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // AdminOrCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.rdBtnCustomer);
            this.Controls.Add(this.rdBtnAdmin);
            this.Controls.Add(this.txtSelect);
            this.Controls.Add(this.txtWelcome);
            this.Name = "AdminOrCustomer";
            this.Text = "AdminOrCustomer";
            this.Load += new System.EventHandler(this.AdminOrCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtWelcome;
        private System.Windows.Forms.Label txtSelect;
        private System.Windows.Forms.RadioButton rdBtnAdmin;
        private System.Windows.Forms.RadioButton rdBtnCustomer;
        private System.Windows.Forms.Button btnSelect;
    }
}