namespace ShieldBank
{
    partial class CustomerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboard));
            this.displayPanel = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblAcctType = new System.Windows.Forms.Label();
            this.lblAcctBal = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.adminPicture = new System.Windows.Forms.PictureBox();
            this.activePanel = new System.Windows.Forms.Panel();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AcctNoComboBox = new System.Windows.Forms.ComboBox();
            this.changePasswordControl1 = new ShieldBank.ChangePasswordControl();
            this.customerDeposit1 = new ShieldBank.CustomerDeposit();
            this.customerWithdrwalControl1 = new ShieldBank.CustomerWithdrwalControl();
            this.customerTransformControl1 = new ShieldBank.CustomerTransformControl();
            this.customerHistoryControl1 = new ShieldBank.CustomerHistoryControl();
            this.displayPanel.SuspendLayout();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminPicture)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayPanel
            // 
            this.displayPanel.BackColor = System.Drawing.Color.LightGray;
            this.displayPanel.Controls.Add(this.btnRefresh);
            this.displayPanel.Controls.Add(this.lblAcctType);
            this.displayPanel.Controls.Add(this.lblAcctBal);
            this.displayPanel.Location = new System.Drawing.Point(205, 0);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(659, 58);
            this.displayPanel.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(601, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(46, 40);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblAcctType
            // 
            this.lblAcctType.AutoSize = true;
            this.lblAcctType.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcctType.Location = new System.Drawing.Point(34, 23);
            this.lblAcctType.Name = "lblAcctType";
            this.lblAcctType.Size = new System.Drawing.Size(91, 29);
            this.lblAcctType.TabIndex = 4;
            this.lblAcctType.Text = "Balance";
            // 
            // lblAcctBal
            // 
            this.lblAcctBal.AutoSize = true;
            this.lblAcctBal.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcctBal.Location = new System.Drawing.Point(420, 23);
            this.lblAcctBal.Name = "lblAcctBal";
            this.lblAcctBal.Size = new System.Drawing.Size(91, 29);
            this.lblAcctBal.TabIndex = 3;
            this.lblAcctBal.Text = "Balance";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.SidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SidePanel.Controls.Add(this.btnPassword);
            this.SidePanel.Controls.Add(this.btnTransfer);
            this.SidePanel.Controls.Add(this.btnWithdraw);
            this.SidePanel.Controls.Add(this.btnLogout);
            this.SidePanel.Controls.Add(this.btnHistory);
            this.SidePanel.Controls.Add(this.adminPicture);
            this.SidePanel.Controls.Add(this.activePanel);
            this.SidePanel.Controls.Add(this.btnDeposit);
            this.SidePanel.Controls.Add(this.panel1);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(205, 560);
            this.SidePanel.TabIndex = 3;
            this.SidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SidePanel_Paint);
            // 
            // btnPassword
            // 
            this.btnPassword.FlatAppearance.BorderSize = 0;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassword.ForeColor = System.Drawing.Color.White;
            this.btnPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnPassword.Image")));
            this.btnPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPassword.Location = new System.Drawing.Point(16, 432);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(183, 79);
            this.btnPassword.TabIndex = 11;
            this.btnPassword.Text = "Change  Password";
            this.btnPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Image = ((System.Drawing.Image)(resources.GetObject("btnTransfer.Image")));
            this.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.Location = new System.Drawing.Point(12, 288);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(183, 62);
            this.btnTransfer.TabIndex = 10;
            this.btnTransfer.Text = "   Transfer";
            this.btnTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Image = ((System.Drawing.Image)(resources.GetObject("btnWithdraw.Image")));
            this.btnWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdraw.Location = new System.Drawing.Point(12, 219);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(197, 72);
            this.btnWithdraw.TabIndex = 8;
            this.btnWithdraw.Text = "   Withdrawal";
            this.btnWithdraw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(19, 517);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(40, 31);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(12, 356);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(183, 68);
            this.btnHistory.TabIndex = 6;
            this.btnHistory.Text = "   History";
            this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // adminPicture
            // 
            this.adminPicture.Image = ((System.Drawing.Image)(resources.GetObject("adminPicture.Image")));
            this.adminPicture.Location = new System.Drawing.Point(46, 23);
            this.adminPicture.Name = "adminPicture";
            this.adminPicture.Size = new System.Drawing.Size(96, 95);
            this.adminPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adminPicture.TabIndex = 3;
            this.adminPicture.TabStop = false;
            // 
            // activePanel
            // 
            this.activePanel.BackColor = System.Drawing.Color.GreenYellow;
            this.activePanel.Location = new System.Drawing.Point(1, 151);
            this.activePanel.Name = "activePanel";
            this.activePanel.Size = new System.Drawing.Size(10, 62);
            this.activePanel.TabIndex = 3;
            // 
            // btnDeposit
            // 
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.Image = ((System.Drawing.Image)(resources.GetObject("btnDeposit.Image")));
            this.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposit.Location = new System.Drawing.Point(12, 151);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(183, 62);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "   Deposit";
            this.btnDeposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(274, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 71);
            this.panel1.TabIndex = 0;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCustomerName.Location = new System.Drawing.Point(626, 79);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(61, 24);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "label3";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.changePasswordControl1);
            this.panel4.Controls.Add(this.customerDeposit1);
            this.panel4.Controls.Add(this.customerWithdrwalControl1);
            this.panel4.Controls.Add(this.customerTransformControl1);
            this.panel4.Controls.Add(this.customerHistoryControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(205, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(659, 445);
            this.panel4.TabIndex = 5;
            // 
            // AcctNoComboBox
            // 
            this.AcctNoComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.AcctNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AcctNoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcctNoComboBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcctNoComboBox.FormattingEnabled = true;
            this.AcctNoComboBox.Location = new System.Drawing.Point(235, 79);
            this.AcctNoComboBox.Name = "AcctNoComboBox";
            this.AcctNoComboBox.Size = new System.Drawing.Size(133, 29);
            this.AcctNoComboBox.TabIndex = 6;
            this.AcctNoComboBox.SelectedIndexChanged += new System.EventHandler(this.AcctNoComboBox_SelectedIndexChanged);
            // 
            // changePasswordControl1
            // 
            this.changePasswordControl1.Location = new System.Drawing.Point(0, 0);
            this.changePasswordControl1.Name = "changePasswordControl1";
            this.changePasswordControl1.Size = new System.Drawing.Size(659, 445);
            this.changePasswordControl1.TabIndex = 4;
            // 
            // customerDeposit1
            // 
            this.customerDeposit1.Location = new System.Drawing.Point(0, 0);
            this.customerDeposit1.Name = "customerDeposit1";
            this.customerDeposit1.Size = new System.Drawing.Size(659, 445);
            this.customerDeposit1.TabIndex = 3;
            // 
            // customerWithdrwalControl1
            // 
            this.customerWithdrwalControl1.Location = new System.Drawing.Point(0, 0);
            this.customerWithdrwalControl1.Name = "customerWithdrwalControl1";
            this.customerWithdrwalControl1.Size = new System.Drawing.Size(659, 445);
            this.customerWithdrwalControl1.TabIndex = 2;
            // 
            // customerTransformControl1
            // 
            this.customerTransformControl1.Location = new System.Drawing.Point(0, 0);
            this.customerTransformControl1.Name = "customerTransformControl1";
            this.customerTransformControl1.Size = new System.Drawing.Size(659, 445);
            this.customerTransformControl1.TabIndex = 1;
            // 
            // customerHistoryControl1
            // 
            this.customerHistoryControl1.Location = new System.Drawing.Point(0, -1);
            this.customerHistoryControl1.Name = "customerHistoryControl1";
            this.customerHistoryControl1.Size = new System.Drawing.Size(659, 445);
            this.customerHistoryControl1.TabIndex = 0;
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 560);
            this.Controls.Add(this.AcctNoComboBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerDashboard";
            this.Load += new System.EventHandler(this.CustomerDashboard_Load);
            this.displayPanel.ResumeLayout(false);
            this.displayPanel.PerformLayout();
            this.SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminPicture)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.Label lblAcctBal;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.PictureBox adminPicture;
        private System.Windows.Forms.Panel activePanel;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Label lblAcctType;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ComboBox AcctNoComboBox;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnTransfer;
        private CustomerDeposit customerDeposit1;
        private CustomerWithdrwalControl customerWithdrwalControl1;
        private CustomerTransformControl customerTransformControl1;
        private CustomerHistoryControl customerHistoryControl1;
        private System.Windows.Forms.Button btnPassword;
        private ChangePasswordControl changePasswordControl1;
    }
}