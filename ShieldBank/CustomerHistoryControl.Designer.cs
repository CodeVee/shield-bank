namespace ShieldBank
{
    partial class CustomerHistoryControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerHistoryControl));
            this.HistoryGridView = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTransactionHistory = new System.Windows.Forms.Button();
            this.pbGenerate = new System.Windows.Forms.PictureBox();
            this.timerTransact = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.HistoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenerate)).BeginInit();
            this.SuspendLayout();
            // 
            // HistoryGridView
            // 
            this.HistoryGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HistoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.HistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.Amount,
            this.Time});
            this.HistoryGridView.GridColor = System.Drawing.SystemColors.Control;
            this.HistoryGridView.Location = new System.Drawing.Point(0, 62);
            this.HistoryGridView.Name = "HistoryGridView";
            this.HistoryGridView.RowHeadersWidth = 51;
            this.HistoryGridView.RowTemplate.Height = 24;
            this.HistoryGridView.Size = new System.Drawing.Size(659, 383);
            this.HistoryGridView.TabIndex = 0;
            this.HistoryGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HistoryGridView_CellContentClick);
            // 
            // Description
            // 
            this.Description.DataPropertyName = "TransactionDescription";
            this.Description.HeaderText = "                         Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 210;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "TransactionAmount";
            this.Amount.HeaderText = "          Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 120;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "TransactionTime";
            this.Time.HeaderText = "          Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.Width = 120;
            // 
            // btnTransactionHistory
            // 
            this.btnTransactionHistory.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTransactionHistory.FlatAppearance.BorderSize = 0;
            this.btnTransactionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionHistory.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTransactionHistory.Location = new System.Drawing.Point(473, 20);
            this.btnTransactionHistory.Name = "btnTransactionHistory";
            this.btnTransactionHistory.Size = new System.Drawing.Size(119, 36);
            this.btnTransactionHistory.TabIndex = 117;
            this.btnTransactionHistory.Text = "Transactions";
            this.btnTransactionHistory.UseVisualStyleBackColor = false;
            this.btnTransactionHistory.Click += new System.EventHandler(this.btnTransactionHistory_Click);
            // 
            // pbGenerate
            // 
            this.pbGenerate.Image = ((System.Drawing.Image)(resources.GetObject("pbGenerate.Image")));
            this.pbGenerate.Location = new System.Drawing.Point(608, 20);
            this.pbGenerate.Name = "pbGenerate";
            this.pbGenerate.Size = new System.Drawing.Size(38, 36);
            this.pbGenerate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbGenerate.TabIndex = 118;
            this.pbGenerate.TabStop = false;
            // 
            // timerTransact
            // 
            this.timerTransact.Interval = 5000;
            this.timerTransact.Tick += new System.EventHandler(this.timerTransact_Tick);
            // 
            // CustomerHistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbGenerate);
            this.Controls.Add(this.btnTransactionHistory);
            this.Controls.Add(this.HistoryGridView);
            this.Name = "CustomerHistoryControl";
            this.Size = new System.Drawing.Size(659, 445);
            this.Load += new System.EventHandler(this.CustomerHistoryControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HistoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenerate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView HistoryGridView;
        private System.Windows.Forms.Button btnTransactionHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.PictureBox pbGenerate;
        private System.Windows.Forms.Timer timerTransact;
    }
}
