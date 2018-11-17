namespace BordiProject
{
    partial class PurchaseOrderInsertForm
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
            this.insertpurchaseDataGrid = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertnumberPOLabel = new System.Windows.Forms.Label();
            this.insertnumberPOText = new System.Windows.Forms.TextBox();
            this.insertcostumerLabel = new System.Windows.Forms.Label();
            this.insertGroup = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.insertPOButton = new System.Windows.Forms.Button();
            this.inserttypeGroup = new System.Windows.Forms.GroupBox();
            this.typecashRadio = new System.Windows.Forms.RadioButton();
            this.typecreditRadio = new System.Windows.Forms.RadioButton();
            this.insertdateDateTime = new System.Windows.Forms.DateTimePicker();
            this.insertpurchaseGroup = new System.Windows.Forms.GroupBox();
            this.insertpurchaseclearButton = new System.Windows.Forms.Button();
            this.insertpurchaseButton = new System.Windows.Forms.Button();
            this.insertpurchasequantityNumeric = new System.Windows.Forms.NumericUpDown();
            this.insertpurchasepriceunitNumeric = new System.Windows.Forms.NumericUpDown();
            this.insertpurchaseunitText = new System.Windows.Forms.TextBox();
            this.insertpurchasedescriptionText = new System.Windows.Forms.TextBox();
            this.insertpurchaseunitLabel = new System.Windows.Forms.Label();
            this.insertpurchasedescriptionLabel = new System.Windows.Forms.Label();
            this.insertpurchasepriceunitLabel = new System.Windows.Forms.Label();
            this.insertpurchasetotalLabel = new System.Windows.Forms.Label();
            this.insertpurchasequantityLabel = new System.Windows.Forms.Label();
            this.insertpurchasetotalText = new System.Windows.Forms.TextBox();
            this.insertrangetimeText = new System.Windows.Forms.TextBox();
            this.insertrangetimeLabel = new System.Windows.Forms.Label();
            this.insertdateLabel = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.insertpurchaseDataGrid)).BeginInit();
            this.insertGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.inserttypeGroup.SuspendLayout();
            this.insertpurchaseGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insertpurchasequantityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertpurchasepriceunitNumeric)).BeginInit();
            this.SuspendLayout();
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
            this.insertpurchaseDataGrid.Size = new System.Drawing.Size(690, 339);
            this.insertpurchaseDataGrid.TabIndex = 0;
            this.insertpurchaseDataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.insertpurchaseDataGrid_RowsRemoved);
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
            // insertnumberPOLabel
            // 
            this.insertnumberPOLabel.AutoSize = true;
            this.insertnumberPOLabel.Location = new System.Drawing.Point(13, 23);
            this.insertnumberPOLabel.Name = "insertnumberPOLabel";
            this.insertnumberPOLabel.Size = new System.Drawing.Size(42, 13);
            this.insertnumberPOLabel.TabIndex = 1;
            this.insertnumberPOLabel.Text = "No. PO";
            // 
            // insertnumberPOText
            // 
            this.insertnumberPOText.Location = new System.Drawing.Point(62, 19);
            this.insertnumberPOText.Name = "insertnumberPOText";
            this.insertnumberPOText.Size = new System.Drawing.Size(86, 20);
            this.insertnumberPOText.TabIndex = 0;
            // 
            // insertcostumerLabel
            // 
            this.insertcostumerLabel.AutoSize = true;
            this.insertcostumerLabel.Location = new System.Drawing.Point(175, 23);
            this.insertcostumerLabel.Name = "insertcostumerLabel";
            this.insertcostumerLabel.Size = new System.Drawing.Size(64, 13);
            this.insertcostumerLabel.TabIndex = 1;
            this.insertcostumerLabel.Text = "Perusahaan";
            // 
            // insertGroup
            // 
            this.insertGroup.Controls.Add(this.groupBox1);
            this.insertGroup.Controls.Add(this.button1);
            this.insertGroup.Controls.Add(this.comboBox1);
            this.insertGroup.Controls.Add(this.button2);
            this.insertGroup.Controls.Add(this.insertPOButton);
            this.insertGroup.Controls.Add(this.inserttypeGroup);
            this.insertGroup.Controls.Add(this.insertdateDateTime);
            this.insertGroup.Controls.Add(this.insertpurchaseGroup);
            this.insertGroup.Controls.Add(this.insertrangetimeText);
            this.insertGroup.Controls.Add(this.insertrangetimeLabel);
            this.insertGroup.Controls.Add(this.insertdateLabel);
            this.insertGroup.Controls.Add(this.insertcostumerLabel);
            this.insertGroup.Controls.Add(this.insertnumberPOLabel);
            this.insertGroup.Controls.Add(this.insertnumberPOText);
            this.insertGroup.Location = new System.Drawing.Point(16, 12);
            this.insertGroup.Name = "insertGroup";
            this.insertGroup.Size = new System.Drawing.Size(727, 556);
            this.insertGroup.TabIndex = 0;
            this.insertGroup.TabStop = false;
            this.insertGroup.Text = "Tambah PO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(576, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 81);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opsi Print";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 34);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(122, 39);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Perusahaan";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kosongkan Semua Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(262, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(468, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // insertPOButton
            // 
            this.insertPOButton.Location = new System.Drawing.Point(468, 18);
            this.insertPOButton.Name = "insertPOButton";
            this.insertPOButton.Size = new System.Drawing.Size(101, 23);
            this.insertPOButton.TabIndex = 5;
            this.insertPOButton.Text = "Tambah PO";
            this.insertPOButton.UseVisualStyleBackColor = true;
            this.insertPOButton.Click += new System.EventHandler(this.insertPOButton_Click);
            // 
            // inserttypeGroup
            // 
            this.inserttypeGroup.Controls.Add(this.typecashRadio);
            this.inserttypeGroup.Controls.Add(this.typecreditRadio);
            this.inserttypeGroup.Location = new System.Drawing.Point(6, 45);
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
            this.insertdateDateTime.Location = new System.Drawing.Point(262, 48);
            this.insertdateDateTime.Name = "insertdateDateTime";
            this.insertdateDateTime.Size = new System.Drawing.Size(200, 20);
            this.insertdateDateTime.TabIndex = 2;
            // 
            // insertpurchaseGroup
            // 
            this.insertpurchaseGroup.Controls.Add(this.insertpurchaseclearButton);
            this.insertpurchaseGroup.Controls.Add(this.insertpurchaseButton);
            this.insertpurchaseGroup.Controls.Add(this.insertpurchasequantityNumeric);
            this.insertpurchaseGroup.Controls.Add(this.insertpurchasepriceunitNumeric);
            this.insertpurchaseGroup.Controls.Add(this.insertpurchaseDataGrid);
            this.insertpurchaseGroup.Controls.Add(this.insertpurchaseunitText);
            this.insertpurchaseGroup.Controls.Add(this.insertpurchasedescriptionText);
            this.insertpurchaseGroup.Controls.Add(this.insertpurchaseunitLabel);
            this.insertpurchaseGroup.Controls.Add(this.insertpurchasedescriptionLabel);
            this.insertpurchaseGroup.Controls.Add(this.insertpurchasepriceunitLabel);
            this.insertpurchaseGroup.Controls.Add(this.insertpurchasetotalLabel);
            this.insertpurchaseGroup.Controls.Add(this.insertpurchasequantityLabel);
            this.insertpurchaseGroup.Controls.Add(this.insertpurchasetotalText);
            this.insertpurchaseGroup.Location = new System.Drawing.Point(3, 105);
            this.insertpurchaseGroup.Name = "insertpurchaseGroup";
            this.insertpurchaseGroup.Size = new System.Drawing.Size(708, 439);
            this.insertpurchaseGroup.TabIndex = 4;
            this.insertpurchaseGroup.TabStop = false;
            this.insertpurchaseGroup.Text = "Tambah Pembelian";
            // 
            // insertpurchaseclearButton
            // 
            this.insertpurchaseclearButton.Location = new System.Drawing.Point(555, 366);
            this.insertpurchaseclearButton.Name = "insertpurchaseclearButton";
            this.insertpurchaseclearButton.Size = new System.Drawing.Size(141, 25);
            this.insertpurchaseclearButton.TabIndex = 5;
            this.insertpurchaseclearButton.Text = "Kosongkan Data";
            this.insertpurchaseclearButton.UseVisualStyleBackColor = true;
            this.insertpurchaseclearButton.Click += new System.EventHandler(this.insertpurchaseclearButton_Click);
            // 
            // insertpurchaseButton
            // 
            this.insertpurchaseButton.Location = new System.Drawing.Point(343, 370);
            this.insertpurchaseButton.Name = "insertpurchaseButton";
            this.insertpurchaseButton.Size = new System.Drawing.Size(116, 50);
            this.insertpurchaseButton.TabIndex = 4;
            this.insertpurchaseButton.Text = "Tambah Pembelian";
            this.insertpurchaseButton.UseVisualStyleBackColor = true;
            this.insertpurchaseButton.Click += new System.EventHandler(this.insertpurchaseButton_Click);
            // 
            // insertpurchasequantityNumeric
            // 
            this.insertpurchasequantityNumeric.DecimalPlaces = 2;
            this.insertpurchasequantityNumeric.Location = new System.Drawing.Point(258, 370);
            this.insertpurchasequantityNumeric.Maximum = new decimal(new int[] {
            2123123123,
            0,
            0,
            0});
            this.insertpurchasequantityNumeric.Name = "insertpurchasequantityNumeric";
            this.insertpurchasequantityNumeric.Size = new System.Drawing.Size(72, 20);
            this.insertpurchasequantityNumeric.TabIndex = 1;
            // 
            // insertpurchasepriceunitNumeric
            // 
            this.insertpurchasepriceunitNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.insertpurchasepriceunitNumeric.Location = new System.Drawing.Point(222, 400);
            this.insertpurchasepriceunitNumeric.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.insertpurchasepriceunitNumeric.Name = "insertpurchasepriceunitNumeric";
            this.insertpurchasepriceunitNumeric.Size = new System.Drawing.Size(108, 20);
            this.insertpurchasepriceunitNumeric.TabIndex = 3;
            this.insertpurchasepriceunitNumeric.ThousandsSeparator = true;
            // 
            // insertpurchaseunitText
            // 
            this.insertpurchaseunitText.Location = new System.Drawing.Point(54, 400);
            this.insertpurchaseunitText.Name = "insertpurchaseunitText";
            this.insertpurchaseunitText.Size = new System.Drawing.Size(86, 20);
            this.insertpurchaseunitText.TabIndex = 2;
            // 
            // insertpurchasedescriptionText
            // 
            this.insertpurchasedescriptionText.Location = new System.Drawing.Point(75, 370);
            this.insertpurchasedescriptionText.Name = "insertpurchasedescriptionText";
            this.insertpurchasedescriptionText.Size = new System.Drawing.Size(112, 20);
            this.insertpurchasedescriptionText.TabIndex = 0;
            // 
            // insertpurchaseunitLabel
            // 
            this.insertpurchaseunitLabel.AutoSize = true;
            this.insertpurchaseunitLabel.Location = new System.Drawing.Point(7, 404);
            this.insertpurchaseunitLabel.Name = "insertpurchaseunitLabel";
            this.insertpurchaseunitLabel.Size = new System.Drawing.Size(41, 13);
            this.insertpurchaseunitLabel.TabIndex = 1;
            this.insertpurchaseunitLabel.Text = "Satuan";
            // 
            // insertpurchasedescriptionLabel
            // 
            this.insertpurchasedescriptionLabel.AutoSize = true;
            this.insertpurchasedescriptionLabel.Location = new System.Drawing.Point(7, 374);
            this.insertpurchasedescriptionLabel.Name = "insertpurchasedescriptionLabel";
            this.insertpurchasedescriptionLabel.Size = new System.Drawing.Size(62, 13);
            this.insertpurchasedescriptionLabel.TabIndex = 1;
            this.insertpurchasedescriptionLabel.Text = "Keterangan";
            // 
            // insertpurchasepriceunitLabel
            // 
            this.insertpurchasepriceunitLabel.AutoSize = true;
            this.insertpurchasepriceunitLabel.Location = new System.Drawing.Point(146, 404);
            this.insertpurchasepriceunitLabel.Name = "insertpurchasepriceunitLabel";
            this.insertpurchasepriceunitLabel.Size = new System.Drawing.Size(73, 13);
            this.insertpurchasepriceunitLabel.TabIndex = 1;
            this.insertpurchasepriceunitLabel.Text = "Harga Satuan";
            // 
            // insertpurchasetotalLabel
            // 
            this.insertpurchasetotalLabel.AutoSize = true;
            this.insertpurchasetotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertpurchasetotalLabel.Location = new System.Drawing.Point(477, 368);
            this.insertpurchasetotalLabel.Name = "insertpurchasetotalLabel";
            this.insertpurchasetotalLabel.Size = new System.Drawing.Size(72, 24);
            this.insertpurchasetotalLabel.TabIndex = 1;
            this.insertpurchasetotalLabel.Text = "TOTAL";
            // 
            // insertpurchasequantityLabel
            // 
            this.insertpurchasequantityLabel.AutoSize = true;
            this.insertpurchasequantityLabel.Location = new System.Drawing.Point(207, 374);
            this.insertpurchasequantityLabel.Name = "insertpurchasequantityLabel";
            this.insertpurchasequantityLabel.Size = new System.Drawing.Size(46, 13);
            this.insertpurchasequantityLabel.TabIndex = 1;
            this.insertpurchasequantityLabel.Text = "Quantity";
            // 
            // insertpurchasetotalText
            // 
            this.insertpurchasetotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertpurchasetotalText.Location = new System.Drawing.Point(477, 396);
            this.insertpurchasetotalText.Name = "insertpurchasetotalText";
            this.insertpurchasetotalText.ReadOnly = true;
            this.insertpurchasetotalText.Size = new System.Drawing.Size(219, 29);
            this.insertpurchasetotalText.TabIndex = 2;
            this.insertpurchasetotalText.Text = "Rp. 0.00";
            // 
            // insertrangetimeText
            // 
            this.insertrangetimeText.Location = new System.Drawing.Point(262, 77);
            this.insertrangetimeText.Name = "insertrangetimeText";
            this.insertrangetimeText.Size = new System.Drawing.Size(117, 20);
            this.insertrangetimeText.TabIndex = 3;
            // 
            // insertrangetimeLabel
            // 
            this.insertrangetimeLabel.AutoSize = true;
            this.insertrangetimeLabel.Location = new System.Drawing.Point(175, 81);
            this.insertrangetimeLabel.Name = "insertrangetimeLabel";
            this.insertrangetimeLabel.Size = new System.Drawing.Size(77, 13);
            this.insertrangetimeLabel.TabIndex = 1;
            this.insertrangetimeLabel.Text = "Jangka Waktu";
            // 
            // insertdateLabel
            // 
            this.insertdateLabel.AutoSize = true;
            this.insertdateLabel.Location = new System.Drawing.Point(175, 52);
            this.insertdateLabel.Name = "insertdateLabel";
            this.insertdateLabel.Size = new System.Drawing.Size(46, 13);
            this.insertdateLabel.TabIndex = 1;
            this.insertdateLabel.Text = "Tanggal";
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // PurchaseOrderInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 582);
            this.Controls.Add(this.insertGroup);
            this.Name = "PurchaseOrderInsertForm";
            this.Text = "Tambah Pembelanjaan";
            ((System.ComponentModel.ISupportInitialize)(this.insertpurchaseDataGrid)).EndInit();
            this.insertGroup.ResumeLayout(false);
            this.insertGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.inserttypeGroup.ResumeLayout(false);
            this.inserttypeGroup.PerformLayout();
            this.insertpurchaseGroup.ResumeLayout(false);
            this.insertpurchaseGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insertpurchasequantityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertpurchasepriceunitNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView insertpurchaseDataGrid;
        private System.Windows.Forms.Label insertnumberPOLabel;
        private System.Windows.Forms.TextBox insertnumberPOText;
        private System.Windows.Forms.Label insertcostumerLabel;
        private System.Windows.Forms.GroupBox insertGroup;
        private System.Windows.Forms.Button insertPOButton;
        private System.Windows.Forms.GroupBox insertpurchaseGroup;
        private System.Windows.Forms.Button insertpurchaseButton;
        private System.Windows.Forms.NumericUpDown insertpurchasequantityNumeric;
        private System.Windows.Forms.NumericUpDown insertpurchasepriceunitNumeric;
        private System.Windows.Forms.TextBox insertpurchaseunitText;
        private System.Windows.Forms.TextBox insertpurchasedescriptionText;
        private System.Windows.Forms.Label insertpurchaseunitLabel;
        private System.Windows.Forms.Label insertpurchasedescriptionLabel;
        private System.Windows.Forms.Label insertpurchasepriceunitLabel;
        private System.Windows.Forms.Label insertpurchasequantityLabel;
        private System.Windows.Forms.Label insertdateLabel;
        private System.Windows.Forms.TextBox insertrangetimeText;
        private System.Windows.Forms.Label insertrangetimeLabel;
        private System.Windows.Forms.Label insertpurchasetotalLabel;
        private System.Windows.Forms.TextBox insertpurchasetotalText;
        private System.Windows.Forms.Button insertpurchaseclearButton;
        private System.Windows.Forms.GroupBox inserttypeGroup;
        private System.Windows.Forms.RadioButton typecashRadio;
        private System.Windows.Forms.RadioButton typecreditRadio;
        private System.Windows.Forms.DateTimePicker insertdateDateTime;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}