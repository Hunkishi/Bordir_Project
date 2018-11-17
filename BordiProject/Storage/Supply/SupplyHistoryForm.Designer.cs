namespace BordiProject
{
    partial class SupplyHistoryForm
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
            this.transactionhistoryGroup = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.typetransactionGroup = new System.Windows.Forms.GroupBox();
            this.typeoutCheckBox = new System.Windows.Forms.CheckBox();
            this.typeinCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bynameGroup = new System.Windows.Forms.GroupBox();
            this.bynameitemnameLabel = new System.Windows.Forms.Label();
            this.bynameitemnameComboBox = new System.Windows.Forms.ComboBox();
            this.bydateGroup = new System.Windows.Forms.GroupBox();
            this.bydatefromDateTime = new System.Windows.Forms.DateTimePicker();
            this.bydateuntilDateTime = new System.Windows.Forms.DateTimePicker();
            this.bydatefromLabel = new System.Windows.Forms.Label();
            this.bydateuntilLabel = new System.Windows.Forms.Label();
            this.transactionhistorysearchButton = new System.Windows.Forms.Button();
            this.transactionhistoryDataGrid = new System.Windows.Forms.DataGridView();
            this.stockGroup = new System.Windows.Forms.GroupBox();
            this.stockbynameGroup = new System.Windows.Forms.GroupBox();
            this.stockbynameitemnameLabel = new System.Windows.Forms.Label();
            this.stockbynameitemnameButton = new System.Windows.Forms.Button();
            this.stockbynameitemnameComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.transactionhistoryGroup.SuspendLayout();
            this.typetransactionGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.bynameGroup.SuspendLayout();
            this.bydateGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionhistoryDataGrid)).BeginInit();
            this.stockGroup.SuspendLayout();
            this.stockbynameGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // transactionhistoryGroup
            // 
            this.transactionhistoryGroup.Controls.Add(this.checkBox3);
            this.transactionhistoryGroup.Controls.Add(this.checkBox2);
            this.transactionhistoryGroup.Controls.Add(this.checkBox1);
            this.transactionhistoryGroup.Controls.Add(this.typetransactionGroup);
            this.transactionhistoryGroup.Controls.Add(this.groupBox2);
            this.transactionhistoryGroup.Controls.Add(this.bynameGroup);
            this.transactionhistoryGroup.Controls.Add(this.bydateGroup);
            this.transactionhistoryGroup.Controls.Add(this.transactionhistorysearchButton);
            this.transactionhistoryGroup.Location = new System.Drawing.Point(7, 19);
            this.transactionhistoryGroup.Name = "transactionhistoryGroup";
            this.transactionhistoryGroup.Size = new System.Drawing.Size(551, 160);
            this.transactionhistoryGroup.TabIndex = 1;
            this.transactionhistoryGroup.TabStop = false;
            this.transactionhistoryGroup.Text = "Transaksi Barang";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(348, 88);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(151, 17);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Berdasarkan Kode Barang";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(348, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(154, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Berdasarkan Nama Barang";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(16, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Berdasarkan Tanggal";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // typetransactionGroup
            // 
            this.typetransactionGroup.Controls.Add(this.typeoutCheckBox);
            this.typetransactionGroup.Controls.Add(this.typeinCheckBox);
            this.typetransactionGroup.Location = new System.Drawing.Point(173, 105);
            this.typetransactionGroup.Name = "typetransactionGroup";
            this.typetransactionGroup.Size = new System.Drawing.Size(159, 47);
            this.typetransactionGroup.TabIndex = 1;
            this.typetransactionGroup.TabStop = false;
            this.typetransactionGroup.Text = "Jenis Transaksi";
            // 
            // typeoutCheckBox
            // 
            this.typeoutCheckBox.AutoSize = true;
            this.typeoutCheckBox.Checked = true;
            this.typeoutCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.typeoutCheckBox.Location = new System.Drawing.Point(84, 19);
            this.typeoutCheckBox.Name = "typeoutCheckBox";
            this.typeoutCheckBox.Size = new System.Drawing.Size(56, 17);
            this.typeoutCheckBox.TabIndex = 1;
            this.typeoutCheckBox.Text = "Keluar";
            this.typeoutCheckBox.UseVisualStyleBackColor = true;
            // 
            // typeinCheckBox
            // 
            this.typeinCheckBox.AutoSize = true;
            this.typeinCheckBox.Checked = true;
            this.typeinCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.typeinCheckBox.Location = new System.Drawing.Point(18, 21);
            this.typeinCheckBox.Name = "typeinCheckBox";
            this.typeinCheckBox.Size = new System.Drawing.Size(58, 17);
            this.typeinCheckBox.TabIndex = 0;
            this.typeinCheckBox.Text = "Masuk";
            this.typeinCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(338, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nama Barang";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // bynameGroup
            // 
            this.bynameGroup.Controls.Add(this.bynameitemnameLabel);
            this.bynameGroup.Controls.Add(this.bynameitemnameComboBox);
            this.bynameGroup.Location = new System.Drawing.Point(338, 88);
            this.bynameGroup.Name = "bynameGroup";
            this.bynameGroup.Size = new System.Drawing.Size(207, 64);
            this.bynameGroup.TabIndex = 1;
            this.bynameGroup.TabStop = false;
            // 
            // bynameitemnameLabel
            // 
            this.bynameitemnameLabel.AutoSize = true;
            this.bynameitemnameLabel.Location = new System.Drawing.Point(5, 28);
            this.bynameitemnameLabel.Name = "bynameitemnameLabel";
            this.bynameitemnameLabel.Size = new System.Drawing.Size(69, 13);
            this.bynameitemnameLabel.TabIndex = 5;
            this.bynameitemnameLabel.Text = "Kode Barang";
            // 
            // bynameitemnameComboBox
            // 
            this.bynameitemnameComboBox.FormattingEnabled = true;
            this.bynameitemnameComboBox.Location = new System.Drawing.Point(83, 23);
            this.bynameitemnameComboBox.Name = "bynameitemnameComboBox";
            this.bynameitemnameComboBox.Size = new System.Drawing.Size(116, 21);
            this.bynameitemnameComboBox.TabIndex = 0;
            // 
            // bydateGroup
            // 
            this.bydateGroup.Controls.Add(this.bydatefromDateTime);
            this.bydateGroup.Controls.Add(this.bydateuntilDateTime);
            this.bydateGroup.Controls.Add(this.bydatefromLabel);
            this.bydateGroup.Controls.Add(this.bydateuntilLabel);
            this.bydateGroup.Location = new System.Drawing.Point(6, 19);
            this.bydateGroup.Name = "bydateGroup";
            this.bydateGroup.Size = new System.Drawing.Size(326, 82);
            this.bydateGroup.TabIndex = 6;
            this.bydateGroup.TabStop = false;
            // 
            // bydatefromDateTime
            // 
            this.bydatefromDateTime.Location = new System.Drawing.Point(107, 22);
            this.bydatefromDateTime.Name = "bydatefromDateTime";
            this.bydatefromDateTime.Size = new System.Drawing.Size(200, 20);
            this.bydatefromDateTime.TabIndex = 0;
            // 
            // bydateuntilDateTime
            // 
            this.bydateuntilDateTime.Location = new System.Drawing.Point(107, 52);
            this.bydateuntilDateTime.Name = "bydateuntilDateTime";
            this.bydateuntilDateTime.Size = new System.Drawing.Size(200, 20);
            this.bydateuntilDateTime.TabIndex = 1;
            // 
            // bydatefromLabel
            // 
            this.bydatefromLabel.AutoSize = true;
            this.bydatefromLabel.Location = new System.Drawing.Point(11, 27);
            this.bydatefromLabel.Name = "bydatefromLabel";
            this.bydatefromLabel.Size = new System.Drawing.Size(68, 13);
            this.bydatefromLabel.TabIndex = 2;
            this.bydatefromLabel.Text = "Dari Tanggal";
            // 
            // bydateuntilLabel
            // 
            this.bydateuntilLabel.AutoSize = true;
            this.bydateuntilLabel.Location = new System.Drawing.Point(11, 53);
            this.bydateuntilLabel.Name = "bydateuntilLabel";
            this.bydateuntilLabel.Size = new System.Drawing.Size(84, 13);
            this.bydateuntilLabel.TabIndex = 2;
            this.bydateuntilLabel.Text = "Sampai Tanggal";
            // 
            // transactionhistorysearchButton
            // 
            this.transactionhistorysearchButton.Location = new System.Drawing.Point(6, 107);
            this.transactionhistorysearchButton.Name = "transactionhistorysearchButton";
            this.transactionhistorysearchButton.Size = new System.Drawing.Size(157, 45);
            this.transactionhistorysearchButton.TabIndex = 4;
            this.transactionhistorysearchButton.Text = "Cari";
            this.transactionhistorysearchButton.UseVisualStyleBackColor = true;
            this.transactionhistorysearchButton.Click += new System.EventHandler(this.transactionhistorysearchButton_Click);
            // 
            // transactionhistoryDataGrid
            // 
            this.transactionhistoryDataGrid.AllowUserToAddRows = false;
            this.transactionhistoryDataGrid.AllowUserToDeleteRows = false;
            this.transactionhistoryDataGrid.AllowUserToOrderColumns = true;
            this.transactionhistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionhistoryDataGrid.Location = new System.Drawing.Point(12, 199);
            this.transactionhistoryDataGrid.Name = "transactionhistoryDataGrid";
            this.transactionhistoryDataGrid.ReadOnly = true;
            this.transactionhistoryDataGrid.Size = new System.Drawing.Size(818, 329);
            this.transactionhistoryDataGrid.TabIndex = 3;
            // 
            // stockGroup
            // 
            this.stockGroup.Controls.Add(this.checkBox4);
            this.stockGroup.Controls.Add(this.checkBox5);
            this.stockGroup.Controls.Add(this.stockbynameitemnameButton);
            this.stockGroup.Controls.Add(this.groupBox3);
            this.stockGroup.Controls.Add(this.stockbynameGroup);
            this.stockGroup.Location = new System.Drawing.Point(564, 19);
            this.stockGroup.Name = "stockGroup";
            this.stockGroup.Size = new System.Drawing.Size(317, 160);
            this.stockGroup.TabIndex = 2;
            this.stockGroup.TabStop = false;
            this.stockGroup.Text = "Stok Barang";
            // 
            // stockbynameGroup
            // 
            this.stockbynameGroup.Controls.Add(this.stockbynameitemnameLabel);
            this.stockbynameGroup.Controls.Add(this.stockbynameitemnameComboBox);
            this.stockbynameGroup.Location = new System.Drawing.Point(7, 88);
            this.stockbynameGroup.Name = "stockbynameGroup";
            this.stockbynameGroup.Size = new System.Drawing.Size(226, 64);
            this.stockbynameGroup.TabIndex = 1;
            this.stockbynameGroup.TabStop = false;
            // 
            // stockbynameitemnameLabel
            // 
            this.stockbynameitemnameLabel.AutoSize = true;
            this.stockbynameitemnameLabel.Location = new System.Drawing.Point(9, 28);
            this.stockbynameitemnameLabel.Name = "stockbynameitemnameLabel";
            this.stockbynameitemnameLabel.Size = new System.Drawing.Size(69, 13);
            this.stockbynameitemnameLabel.TabIndex = 5;
            this.stockbynameitemnameLabel.Text = "Kode Barang";
            // 
            // stockbynameitemnameButton
            // 
            this.stockbynameitemnameButton.Location = new System.Drawing.Point(239, 19);
            this.stockbynameitemnameButton.Name = "stockbynameitemnameButton";
            this.stockbynameitemnameButton.Size = new System.Drawing.Size(67, 133);
            this.stockbynameitemnameButton.TabIndex = 4;
            this.stockbynameitemnameButton.Text = "Cari";
            this.stockbynameitemnameButton.UseVisualStyleBackColor = true;
            this.stockbynameitemnameButton.Click += new System.EventHandler(this.stockbynameitemnameButton_Click);
            // 
            // stockbynameitemnameComboBox
            // 
            this.stockbynameitemnameComboBox.FormattingEnabled = true;
            this.stockbynameitemnameComboBox.Location = new System.Drawing.Point(87, 24);
            this.stockbynameitemnameComboBox.Name = "stockbynameitemnameComboBox";
            this.stockbynameitemnameComboBox.Size = new System.Drawing.Size(121, 21);
            this.stockbynameitemnameComboBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.transactionhistoryGroup);
            this.groupBox1.Controls.Add(this.stockGroup);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(891, 189);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Riwayat Stok";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(836, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ekspor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(836, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.transactionhistoryprintButton_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Location = new System.Drawing.Point(7, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 64);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama Barang";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(87, 24);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(17, 88);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(151, 17);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "Berdasarkan Kode Barang";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(17, 19);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(154, 17);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "Berdasarkan Nama Barang";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // SupplyHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.transactionhistoryDataGrid);
            this.Controls.Add(this.button2);
            this.Name = "SupplyHistoryForm";
            this.Text = "Riwayat Stok";
            this.transactionhistoryGroup.ResumeLayout(false);
            this.transactionhistoryGroup.PerformLayout();
            this.typetransactionGroup.ResumeLayout(false);
            this.typetransactionGroup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.bynameGroup.ResumeLayout(false);
            this.bynameGroup.PerformLayout();
            this.bydateGroup.ResumeLayout(false);
            this.bydateGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionhistoryDataGrid)).EndInit();
            this.stockGroup.ResumeLayout(false);
            this.stockGroup.PerformLayout();
            this.stockbynameGroup.ResumeLayout(false);
            this.stockbynameGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox transactionhistoryGroup;
        private System.Windows.Forms.GroupBox typetransactionGroup;
        private System.Windows.Forms.CheckBox typeoutCheckBox;
        private System.Windows.Forms.CheckBox typeinCheckBox;
        private System.Windows.Forms.GroupBox bynameGroup;
        private System.Windows.Forms.Label bynameitemnameLabel;
        private System.Windows.Forms.ComboBox bynameitemnameComboBox;
        private System.Windows.Forms.GroupBox bydateGroup;
        private System.Windows.Forms.DateTimePicker bydatefromDateTime;
        private System.Windows.Forms.DateTimePicker bydateuntilDateTime;
        private System.Windows.Forms.Label bydatefromLabel;
        private System.Windows.Forms.Label bydateuntilLabel;
        private System.Windows.Forms.Button transactionhistorysearchButton;
        private System.Windows.Forms.DataGridView transactionhistoryDataGrid;
        private System.Windows.Forms.GroupBox stockGroup;
        private System.Windows.Forms.GroupBox stockbynameGroup;
        private System.Windows.Forms.Label stockbynameitemnameLabel;
        private System.Windows.Forms.Button stockbynameitemnameButton;
        private System.Windows.Forms.ComboBox stockbynameitemnameComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}