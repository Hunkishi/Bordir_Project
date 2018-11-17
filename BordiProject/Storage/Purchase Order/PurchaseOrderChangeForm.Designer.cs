namespace BordiProject
{
    partial class PurchaseOrderChangeForm
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
            this.insertGroup = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.inserttypeGroup = new System.Windows.Forms.GroupBox();
            this.typecashRadio = new System.Windows.Forms.RadioButton();
            this.typecreditRadio = new System.Windows.Forms.RadioButton();
            this.insertdateDateTime = new System.Windows.Forms.DateTimePicker();
            this.insertpurchaseGroup = new System.Windows.Forms.GroupBox();
            this.insertpurchaseButton = new System.Windows.Forms.Button();
            this.insertpurchasequantityNumeric = new System.Windows.Forms.NumericUpDown();
            this.insertpurchasepriceunitNumeric = new System.Windows.Forms.NumericUpDown();
            this.insertpurchaseunitText = new System.Windows.Forms.TextBox();
            this.insertpurchasedescriptionText = new System.Windows.Forms.TextBox();
            this.insertpurchaseunitLabel = new System.Windows.Forms.Label();
            this.insertpurchasedescriptionLabel = new System.Windows.Forms.Label();
            this.insertpurchasepriceunitLabel = new System.Windows.Forms.Label();
            this.insertpurchasequantityLabel = new System.Windows.Forms.Label();
            this.insertpurchaseDataGrid = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertpurchasetotalLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.insertpurchasetotalText = new System.Windows.Forms.TextBox();
            this.insertrangetimeText = new System.Windows.Forms.TextBox();
            this.insertrangetimeLabel = new System.Windows.Forms.Label();
            this.insertdateLabel = new System.Windows.Forms.Label();
            this.insertcostumerLabel = new System.Windows.Forms.Label();
            this.insertnumberPOLabel = new System.Windows.Forms.Label();
            this.insertnumberPOText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.insertGroup.SuspendLayout();
            this.inserttypeGroup.SuspendLayout();
            this.insertpurchaseGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insertpurchasequantityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertpurchasepriceunitNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertpurchaseDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // insertGroup
            // 
            this.insertGroup.Controls.Add(this.button4);
            this.insertGroup.Controls.Add(this.button1);
            this.insertGroup.Controls.Add(this.comboBox1);
            this.insertGroup.Controls.Add(this.inserttypeGroup);
            this.insertGroup.Controls.Add(this.insertdateDateTime);
            this.insertGroup.Controls.Add(this.insertpurchaseGroup);
            this.insertGroup.Controls.Add(this.insertrangetimeText);
            this.insertGroup.Controls.Add(this.insertrangetimeLabel);
            this.insertGroup.Controls.Add(this.insertdateLabel);
            this.insertGroup.Controls.Add(this.insertcostumerLabel);
            this.insertGroup.Controls.Add(this.insertnumberPOLabel);
            this.insertGroup.Controls.Add(this.insertnumberPOText);
            this.insertGroup.Enabled = false;
            this.insertGroup.Location = new System.Drawing.Point(11, 68);
            this.insertGroup.Name = "insertGroup";
            this.insertGroup.Size = new System.Drawing.Size(680, 563);
            this.insertGroup.TabIndex = 1;
            this.insertGroup.TabStop = false;
            this.insertGroup.Text = "Ubah PO";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(553, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Hapus PO";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ubah PO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(311, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // inserttypeGroup
            // 
            this.inserttypeGroup.Controls.Add(this.typecashRadio);
            this.inserttypeGroup.Controls.Add(this.typecreditRadio);
            this.inserttypeGroup.Location = new System.Drawing.Point(28, 45);
            this.inserttypeGroup.Name = "inserttypeGroup";
            this.inserttypeGroup.Size = new System.Drawing.Size(166, 52);
            this.inserttypeGroup.TabIndex = 4;
            this.inserttypeGroup.TabStop = false;
            this.inserttypeGroup.Text = "Jenis Pembayaran";
            // 
            // typecashRadio
            // 
            this.typecashRadio.AutoSize = true;
            this.typecashRadio.Location = new System.Drawing.Point(26, 19);
            this.typecashRadio.Name = "typecashRadio";
            this.typecashRadio.Size = new System.Drawing.Size(49, 17);
            this.typecashRadio.TabIndex = 0;
            this.typecashRadio.TabStop = true;
            this.typecashRadio.Text = "Cash";
            this.typecashRadio.UseVisualStyleBackColor = true;
            // 
            // typecreditRadio
            // 
            this.typecreditRadio.AutoSize = true;
            this.typecreditRadio.Checked = true;
            this.typecreditRadio.Location = new System.Drawing.Point(94, 19);
            this.typecreditRadio.Name = "typecreditRadio";
            this.typecreditRadio.Size = new System.Drawing.Size(52, 17);
            this.typecreditRadio.TabIndex = 0;
            this.typecreditRadio.TabStop = true;
            this.typecreditRadio.Text = "Credit";
            this.typecreditRadio.UseVisualStyleBackColor = true;
            // 
            // insertdateDateTime
            // 
            this.insertdateDateTime.Location = new System.Drawing.Point(311, 48);
            this.insertdateDateTime.Name = "insertdateDateTime";
            this.insertdateDateTime.Size = new System.Drawing.Size(200, 20);
            this.insertdateDateTime.TabIndex = 2;
            // 
            // insertpurchaseGroup
            // 
            this.insertpurchaseGroup.Controls.Add(this.insertpurchaseButton);
            this.insertpurchaseGroup.Controls.Add(this.insertpurchasequantityNumeric);
            this.insertpurchaseGroup.Controls.Add(this.insertpurchasepriceunitNumeric);
            this.insertpurchaseGroup.Controls.Add(this.insertpurchaseunitText);
            this.insertpurchaseGroup.Controls.Add(this.insertpurchasedescriptionText);
            this.insertpurchaseGroup.Controls.Add(this.insertpurchaseunitLabel);
            this.insertpurchaseGroup.Controls.Add(this.insertpurchasedescriptionLabel);
            this.insertpurchaseGroup.Controls.Add(this.insertpurchasepriceunitLabel);
            this.insertpurchaseGroup.Controls.Add(this.insertpurchasequantityLabel);
            this.insertpurchaseGroup.Controls.Add(this.insertpurchaseDataGrid);
            this.insertpurchaseGroup.Controls.Add(this.insertpurchasetotalLabel);
            this.insertpurchaseGroup.Controls.Add(this.button2);
            this.insertpurchaseGroup.Controls.Add(this.insertpurchasetotalText);
            this.insertpurchaseGroup.Location = new System.Drawing.Point(9, 106);
            this.insertpurchaseGroup.Name = "insertpurchaseGroup";
            this.insertpurchaseGroup.Size = new System.Drawing.Size(661, 451);
            this.insertpurchaseGroup.TabIndex = 4;
            this.insertpurchaseGroup.TabStop = false;
            this.insertpurchaseGroup.Text = "Tambah Pembelian";
            // 
            // insertpurchaseButton
            // 
            this.insertpurchaseButton.Location = new System.Drawing.Point(334, 377);
            this.insertpurchaseButton.Name = "insertpurchaseButton";
            this.insertpurchaseButton.Size = new System.Drawing.Size(116, 50);
            this.insertpurchaseButton.TabIndex = 14;
            this.insertpurchaseButton.Text = "Tambah Pembelian";
            this.insertpurchaseButton.UseVisualStyleBackColor = true;
            this.insertpurchaseButton.Click += new System.EventHandler(this.insertpurchaseButton_Click);
            // 
            // insertpurchasequantityNumeric
            // 
            this.insertpurchasequantityNumeric.Location = new System.Drawing.Point(256, 377);
            this.insertpurchasequantityNumeric.Maximum = new decimal(new int[] {
            2123123123,
            0,
            0,
            0});
            this.insertpurchasequantityNumeric.Name = "insertpurchasequantityNumeric";
            this.insertpurchasequantityNumeric.Size = new System.Drawing.Size(72, 20);
            this.insertpurchasequantityNumeric.TabIndex = 7;
            // 
            // insertpurchasepriceunitNumeric
            // 
            this.insertpurchasepriceunitNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.insertpurchasepriceunitNumeric.Location = new System.Drawing.Point(220, 407);
            this.insertpurchasepriceunitNumeric.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.insertpurchasepriceunitNumeric.Name = "insertpurchasepriceunitNumeric";
            this.insertpurchasepriceunitNumeric.Size = new System.Drawing.Size(108, 20);
            this.insertpurchasepriceunitNumeric.TabIndex = 13;
            this.insertpurchasepriceunitNumeric.ThousandsSeparator = true;
            // 
            // insertpurchaseunitText
            // 
            this.insertpurchaseunitText.Location = new System.Drawing.Point(52, 407);
            this.insertpurchaseunitText.Name = "insertpurchaseunitText";
            this.insertpurchaseunitText.Size = new System.Drawing.Size(86, 20);
            this.insertpurchaseunitText.TabIndex = 12;
            // 
            // insertpurchasedescriptionText
            // 
            this.insertpurchasedescriptionText.Location = new System.Drawing.Point(73, 377);
            this.insertpurchasedescriptionText.Name = "insertpurchasedescriptionText";
            this.insertpurchasedescriptionText.Size = new System.Drawing.Size(112, 20);
            this.insertpurchasedescriptionText.TabIndex = 6;
            // 
            // insertpurchaseunitLabel
            // 
            this.insertpurchaseunitLabel.AutoSize = true;
            this.insertpurchaseunitLabel.Location = new System.Drawing.Point(5, 411);
            this.insertpurchaseunitLabel.Name = "insertpurchaseunitLabel";
            this.insertpurchaseunitLabel.Size = new System.Drawing.Size(41, 13);
            this.insertpurchaseunitLabel.TabIndex = 8;
            this.insertpurchaseunitLabel.Text = "Satuan";
            // 
            // insertpurchasedescriptionLabel
            // 
            this.insertpurchasedescriptionLabel.AutoSize = true;
            this.insertpurchasedescriptionLabel.Location = new System.Drawing.Point(5, 381);
            this.insertpurchasedescriptionLabel.Name = "insertpurchasedescriptionLabel";
            this.insertpurchasedescriptionLabel.Size = new System.Drawing.Size(62, 13);
            this.insertpurchasedescriptionLabel.TabIndex = 9;
            this.insertpurchasedescriptionLabel.Text = "Keterangan";
            // 
            // insertpurchasepriceunitLabel
            // 
            this.insertpurchasepriceunitLabel.AutoSize = true;
            this.insertpurchasepriceunitLabel.Location = new System.Drawing.Point(144, 411);
            this.insertpurchasepriceunitLabel.Name = "insertpurchasepriceunitLabel";
            this.insertpurchasepriceunitLabel.Size = new System.Drawing.Size(73, 13);
            this.insertpurchasepriceunitLabel.TabIndex = 10;
            this.insertpurchasepriceunitLabel.Text = "Harga Satuan";
            // 
            // insertpurchasequantityLabel
            // 
            this.insertpurchasequantityLabel.AutoSize = true;
            this.insertpurchasequantityLabel.Location = new System.Drawing.Point(205, 381);
            this.insertpurchasequantityLabel.Name = "insertpurchasequantityLabel";
            this.insertpurchasequantityLabel.Size = new System.Drawing.Size(46, 13);
            this.insertpurchasequantityLabel.TabIndex = 11;
            this.insertpurchasequantityLabel.Text = "Quantity";
            // 
            // insertpurchaseDataGrid
            // 
            this.insertpurchaseDataGrid.AllowUserToAddRows = false;
            this.insertpurchaseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.insertpurchaseDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.nameItem,
            this.quantity,
            this.unit,
            this.unitPrice,
            this.total});
            this.insertpurchaseDataGrid.Location = new System.Drawing.Point(6, 19);
            this.insertpurchaseDataGrid.Name = "insertpurchaseDataGrid";
            this.insertpurchaseDataGrid.ReadOnly = true;
            this.insertpurchaseDataGrid.Size = new System.Drawing.Size(639, 339);
            this.insertpurchaseDataGrid.TabIndex = 0;
            // 
            // number
            // 
            this.number.HeaderText = "No.";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // nameItem
            // 
            this.nameItem.HeaderText = "Keterangan";
            this.nameItem.Name = "nameItem";
            this.nameItem.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "QTY";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.HeaderText = "Satuan";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // unitPrice
            // 
            this.unitPrice.HeaderText = "Harga Satuan";
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Jumlah";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // insertpurchasetotalLabel
            // 
            this.insertpurchasetotalLabel.AutoSize = true;
            this.insertpurchasetotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertpurchasetotalLabel.Location = new System.Drawing.Point(456, 377);
            this.insertpurchasetotalLabel.Name = "insertpurchasetotalLabel";
            this.insertpurchasetotalLabel.Size = new System.Drawing.Size(72, 24);
            this.insertpurchasetotalLabel.TabIndex = 1;
            this.insertpurchasetotalLabel.Text = "TOTAL";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(544, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Kosongkan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // insertpurchasetotalText
            // 
            this.insertpurchasetotalText.Enabled = false;
            this.insertpurchasetotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertpurchasetotalText.Location = new System.Drawing.Point(456, 407);
            this.insertpurchasetotalText.Name = "insertpurchasetotalText";
            this.insertpurchasetotalText.ReadOnly = true;
            this.insertpurchasetotalText.Size = new System.Drawing.Size(189, 29);
            this.insertpurchasetotalText.TabIndex = 2;
            this.insertpurchasetotalText.Text = "Rp. 0.00";
            // 
            // insertrangetimeText
            // 
            this.insertrangetimeText.Location = new System.Drawing.Point(311, 77);
            this.insertrangetimeText.Name = "insertrangetimeText";
            this.insertrangetimeText.Size = new System.Drawing.Size(117, 20);
            this.insertrangetimeText.TabIndex = 3;
            // 
            // insertrangetimeLabel
            // 
            this.insertrangetimeLabel.AutoSize = true;
            this.insertrangetimeLabel.Location = new System.Drawing.Point(224, 81);
            this.insertrangetimeLabel.Name = "insertrangetimeLabel";
            this.insertrangetimeLabel.Size = new System.Drawing.Size(77, 13);
            this.insertrangetimeLabel.TabIndex = 1;
            this.insertrangetimeLabel.Text = "Jangka Waktu";
            // 
            // insertdateLabel
            // 
            this.insertdateLabel.AutoSize = true;
            this.insertdateLabel.Location = new System.Drawing.Point(224, 52);
            this.insertdateLabel.Name = "insertdateLabel";
            this.insertdateLabel.Size = new System.Drawing.Size(46, 13);
            this.insertdateLabel.TabIndex = 1;
            this.insertdateLabel.Text = "Tanggal";
            // 
            // insertcostumerLabel
            // 
            this.insertcostumerLabel.AutoSize = true;
            this.insertcostumerLabel.Location = new System.Drawing.Point(224, 23);
            this.insertcostumerLabel.Name = "insertcostumerLabel";
            this.insertcostumerLabel.Size = new System.Drawing.Size(64, 13);
            this.insertcostumerLabel.TabIndex = 1;
            this.insertcostumerLabel.Text = "Perusahaan";
            // 
            // insertnumberPOLabel
            // 
            this.insertnumberPOLabel.AutoSize = true;
            this.insertnumberPOLabel.Location = new System.Drawing.Point(35, 23);
            this.insertnumberPOLabel.Name = "insertnumberPOLabel";
            this.insertnumberPOLabel.Size = new System.Drawing.Size(42, 13);
            this.insertnumberPOLabel.TabIndex = 1;
            this.insertnumberPOLabel.Text = "No. PO";
            // 
            // insertnumberPOText
            // 
            this.insertnumberPOText.Location = new System.Drawing.Point(84, 19);
            this.insertnumberPOText.Name = "insertnumberPOText";
            this.insertnumberPOText.Size = new System.Drawing.Size(86, 20);
            this.insertnumberPOText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "No. PO";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(79, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.TextChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.insertGroup);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 642);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Berdasarkan Nomor PO";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(212, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cari";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PurchaseOrderChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 655);
            this.Controls.Add(this.groupBox1);
            this.Name = "PurchaseOrderChangeForm";
            this.Text = "Ubah Pembelanjaan";
            this.insertGroup.ResumeLayout(false);
            this.insertGroup.PerformLayout();
            this.inserttypeGroup.ResumeLayout(false);
            this.inserttypeGroup.PerformLayout();
            this.insertpurchaseGroup.ResumeLayout(false);
            this.insertpurchaseGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insertpurchasequantityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertpurchasepriceunitNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertpurchaseDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox insertGroup;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox inserttypeGroup;
        private System.Windows.Forms.RadioButton typecashRadio;
        private System.Windows.Forms.RadioButton typecreditRadio;
        private System.Windows.Forms.DateTimePicker insertdateDateTime;
        private System.Windows.Forms.GroupBox insertpurchaseGroup;
        private System.Windows.Forms.DataGridView insertpurchaseDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label insertpurchasetotalLabel;
        private System.Windows.Forms.TextBox insertpurchasetotalText;
        private System.Windows.Forms.TextBox insertrangetimeText;
        private System.Windows.Forms.Label insertrangetimeLabel;
        private System.Windows.Forms.Label insertdateLabel;
        private System.Windows.Forms.Label insertcostumerLabel;
        private System.Windows.Forms.Label insertnumberPOLabel;
        private System.Windows.Forms.TextBox insertnumberPOText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button insertpurchaseButton;
        private System.Windows.Forms.NumericUpDown insertpurchasequantityNumeric;
        private System.Windows.Forms.NumericUpDown insertpurchasepriceunitNumeric;
        private System.Windows.Forms.TextBox insertpurchaseunitText;
        private System.Windows.Forms.TextBox insertpurchasedescriptionText;
        private System.Windows.Forms.Label insertpurchaseunitLabel;
        private System.Windows.Forms.Label insertpurchasedescriptionLabel;
        private System.Windows.Forms.Label insertpurchasepriceunitLabel;
        private System.Windows.Forms.Label insertpurchasequantityLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}