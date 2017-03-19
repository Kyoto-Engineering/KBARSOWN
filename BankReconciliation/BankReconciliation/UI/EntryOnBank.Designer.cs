namespace BankReconciliation.UI
{
    partial class EntryOnBank
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchByIDTextBox = new System.Windows.Forms.TextBox();
            this.searchByCreditBalanceTextBox = new System.Windows.Forms.TextBox();
            this.searchByDebitBalanceTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.transactionIdTextBox = new System.Windows.Forms.TextBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.transactionLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dataGridView1.Location = new System.Drawing.Point(243, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(988, 484);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // searchByIDTextBox
            // 
            this.searchByIDTextBox.Location = new System.Drawing.Point(490, 24);
            this.searchByIDTextBox.Name = "searchByIDTextBox";
            this.searchByIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchByIDTextBox.TabIndex = 1;
            this.searchByIDTextBox.TextChanged += new System.EventHandler(this.searchByIDTextBox_TextChanged);
            // 
            // searchByCreditBalanceTextBox
            // 
            this.searchByCreditBalanceTextBox.Location = new System.Drawing.Point(810, 27);
            this.searchByCreditBalanceTextBox.Name = "searchByCreditBalanceTextBox";
            this.searchByCreditBalanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchByCreditBalanceTextBox.TabIndex = 2;
            this.searchByCreditBalanceTextBox.TextChanged += new System.EventHandler(this.searchByCreditBalanceTextBox_TextChanged);
            // 
            // searchByDebitBalanceTextBox
            // 
            this.searchByDebitBalanceTextBox.Location = new System.Drawing.Point(1120, 24);
            this.searchByDebitBalanceTextBox.Name = "searchByDebitBalanceTextBox";
            this.searchByDebitBalanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchByDebitBalanceTextBox.TabIndex = 3;
            this.searchByDebitBalanceTextBox.TextChanged += new System.EventHandler(this.searchByDebitBalanceTextBox_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // transactionIdTextBox
            // 
            this.transactionIdTextBox.Location = new System.Drawing.Point(137, 87);
            this.transactionIdTextBox.Name = "transactionIdTextBox";
            this.transactionIdTextBox.ReadOnly = true;
            this.transactionIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.transactionIdTextBox.TabIndex = 5;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(162, 182);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 6;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(137, 114);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.ReadOnly = true;
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 7;
            // 
            // transactionLabel
            // 
            this.transactionLabel.AutoSize = true;
            this.transactionLabel.Location = new System.Drawing.Point(29, 121);
            this.transactionLabel.Name = "transactionLabel";
            this.transactionLabel.Size = new System.Drawing.Size(102, 13);
            this.transactionLabel.TabIndex = 8;
            this.transactionLabel.Text = "Transaction Amount";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(96, 90);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(16, 13);
            this.idLabel.TabIndex = 9;
            this.idLabel.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(997, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Serch by Debit Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(680, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search by Credit Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Search by Transaction Id";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Bank Name";
            this.Column3.Name = "Column3";
            this.Column3.Width = 55;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Account No";
            this.Column4.Name = "Column4";
            this.Column4.Width = 95;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Txn Type";
            this.Column5.Name = "Column5";
            this.Column5.Width = 55;
            // 
            // Column6
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column6.HeaderText = "Benificiary";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column7.HeaderText = "Txn With Bank";
            this.Column7.Name = "Column7";
            this.Column7.Width = 70;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Cheque No";
            this.Column8.Name = "Column8";
            this.Column8.Width = 70;
            // 
            // Column9
            // 
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column9.HeaderText = "Particulars";
            this.Column9.Name = "Column9";
            this.Column9.Width = 130;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Credit";
            this.Column10.Name = "Column10";
            this.Column10.Width = 70;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Debit";
            this.Column11.Name = "Column11";
            this.Column11.Width = 70;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Actual Balance";
            this.Column12.Name = "Column12";
            this.Column12.Width = 75;
            // 
            // EntryOnBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 533);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.transactionLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.transactionIdTextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.searchByDebitBalanceTextBox);
            this.Controls.Add(this.searchByCreditBalanceTextBox);
            this.Controls.Add(this.searchByIDTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EntryOnBank";
            this.Text = "EntryOnBank";
            this.Load += new System.EventHandler(this.EntryOnBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchByIDTextBox;
        private System.Windows.Forms.TextBox searchByCreditBalanceTextBox;
        private System.Windows.Forms.TextBox searchByDebitBalanceTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox transactionIdTextBox;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label transactionLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}