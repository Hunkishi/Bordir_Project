namespace BordiProject
{
    partial class ProductionInsertForm
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
            this.numberLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.costumerCombo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.descriptionRich = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colorItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorString1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorString2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.application = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorString5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorString6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorString7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorString8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineGroup = new System.Windows.Forms.GroupBox();
            this.barudanRadio = new System.Windows.Forms.RadioButton();
            this.swfRadio = new System.Windows.Forms.RadioButton();
            this.tajimaRadio = new System.Windows.Forms.RadioButton();
            this.patternGroup = new System.Windows.Forms.GroupBox();
            this.yesRadio = new System.Windows.Forms.RadioButton();
            this.noRadio = new System.Windows.Forms.RadioButton();
            this.quantityNumeric = new System.Windows.Forms.NumericUpDown();
            this.stitchNumeric = new System.Windows.Forms.NumericUpDown();
            this.startDatetime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateDateTime = new System.Windows.Forms.DateTimePicker();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.positionText = new System.Windows.Forms.TextBox();
            this.textText = new System.Windows.Forms.TextBox();
            this.machinenumberText = new System.Windows.Forms.TextBox();
            this.styleText = new System.Windows.Forms.TextBox();
            this.productionnumberText = new System.Windows.Forms.TextBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.stitchLabel = new System.Windows.Forms.Label();
            this.machinenumberLabel = new System.Windows.Forms.Label();
            this.styleLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.costumerLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.machineGroup.SuspendLayout();
            this.patternGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stitchNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(17, 25);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(38, 13);
            this.numberLabel.TabIndex = 0;
            this.numberLabel.Text = "Nomor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.costumerCombo);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.descriptionRich);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.resetButton);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.machineGroup);
            this.groupBox1.Controls.Add(this.patternGroup);
            this.groupBox1.Controls.Add(this.quantityNumeric);
            this.groupBox1.Controls.Add(this.stitchNumeric);
            this.groupBox1.Controls.Add(this.startDatetime);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateDateTime);
            this.groupBox1.Controls.Add(this.descriptionLabel);
            this.groupBox1.Controls.Add(this.dateLabel);
            this.groupBox1.Controls.Add(this.positionText);
            this.groupBox1.Controls.Add(this.textText);
            this.groupBox1.Controls.Add(this.machinenumberText);
            this.groupBox1.Controls.Add(this.styleText);
            this.groupBox1.Controls.Add(this.productionnumberText);
            this.groupBox1.Controls.Add(this.positionLabel);
            this.groupBox1.Controls.Add(this.quantityLabel);
            this.groupBox1.Controls.Add(this.stitchLabel);
            this.groupBox1.Controls.Add(this.machinenumberLabel);
            this.groupBox1.Controls.Add(this.styleLabel);
            this.groupBox1.Controls.Add(this.textLabel);
            this.groupBox1.Controls.Add(this.costumerLabel);
            this.groupBox1.Controls.Add(this.numberLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 610);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produksi Baru";
            // 
            // costumerCombo
            // 
            this.costumerCombo.FormattingEnabled = true;
            this.costumerCombo.Location = new System.Drawing.Point(107, 55);
            this.costumerCombo.Name = "costumerCombo";
            this.costumerCombo.Size = new System.Drawing.Size(121, 21);
            this.costumerCombo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(597, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // descriptionRich
            // 
            this.descriptionRich.Location = new System.Drawing.Point(685, 42);
            this.descriptionRich.Name = "descriptionRich";
            this.descriptionRich.Size = new System.Drawing.Size(259, 160);
            this.descriptionRich.TabIndex = 15;
            this.descriptionRich.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(597, 562);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 27);
            this.button2.TabIndex = 16;
            this.button2.Text = "Masukkan Gambar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(771, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "Tambah Produksi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(562, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Kosongkan Tabel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(451, 202);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(105, 23);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "Hapus Semua";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colorItem,
            this.colorString1,
            this.colorString2,
            this.application,
            this.etc,
            this.colorString5,
            this.colorString6,
            this.colorString7,
            this.colorString8});
            this.dataGridView1.Location = new System.Drawing.Point(20, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 363);
            this.dataGridView1.TabIndex = 13;
            // 
            // colorItem
            // 
            this.colorItem.HeaderText = "WARNA BAHAN";
            this.colorItem.Name = "colorItem";
            // 
            // colorString1
            // 
            this.colorString1.HeaderText = "WARNA BENANG 1";
            this.colorString1.Name = "colorString1";
            this.colorString1.Width = 75;
            // 
            // colorString2
            // 
            this.colorString2.HeaderText = "WARNA BENANG 2";
            this.colorString2.Name = "colorString2";
            this.colorString2.Width = 75;
            // 
            // application
            // 
            this.application.HeaderText = "WARNA BENANG 3";
            this.application.Name = "application";
            this.application.Width = 75;
            // 
            // etc
            // 
            this.etc.HeaderText = "WARNA BENANG 4";
            this.etc.Name = "etc";
            this.etc.Width = 75;
            // 
            // colorString5
            // 
            this.colorString5.HeaderText = "WARNA BENANG 5";
            this.colorString5.Name = "colorString5";
            this.colorString5.Width = 75;
            // 
            // colorString6
            // 
            this.colorString6.HeaderText = "WARNA BENANG 6";
            this.colorString6.Name = "colorString6";
            this.colorString6.Width = 75;
            // 
            // colorString7
            // 
            this.colorString7.HeaderText = "WARNA BENANG 7";
            this.colorString7.Name = "colorString7";
            this.colorString7.Width = 75;
            // 
            // colorString8
            // 
            this.colorString8.HeaderText = "WARNA BENANG 8";
            this.colorString8.Name = "colorString8";
            this.colorString8.Width = 75;
            // 
            // machineGroup
            // 
            this.machineGroup.Controls.Add(this.barudanRadio);
            this.machineGroup.Controls.Add(this.swfRadio);
            this.machineGroup.Controls.Add(this.tajimaRadio);
            this.machineGroup.Location = new System.Drawing.Point(213, 145);
            this.machineGroup.Name = "machineGroup";
            this.machineGroup.Size = new System.Drawing.Size(242, 52);
            this.machineGroup.TabIndex = 9;
            this.machineGroup.TabStop = false;
            this.machineGroup.Text = "Kerja Di Mesin";
            // 
            // barudanRadio
            // 
            this.barudanRadio.AutoSize = true;
            this.barudanRadio.Checked = true;
            this.barudanRadio.Location = new System.Drawing.Point(22, 26);
            this.barudanRadio.Name = "barudanRadio";
            this.barudanRadio.Size = new System.Drawing.Size(65, 17);
            this.barudanRadio.TabIndex = 0;
            this.barudanRadio.TabStop = true;
            this.barudanRadio.Text = "Barudan";
            this.barudanRadio.UseVisualStyleBackColor = true;
            // 
            // swfRadio
            // 
            this.swfRadio.AutoSize = true;
            this.swfRadio.Location = new System.Drawing.Point(171, 26);
            this.swfRadio.Name = "swfRadio";
            this.swfRadio.Size = new System.Drawing.Size(49, 17);
            this.swfRadio.TabIndex = 2;
            this.swfRadio.Text = "SWF";
            this.swfRadio.UseVisualStyleBackColor = true;
            // 
            // tajimaRadio
            // 
            this.tajimaRadio.AutoSize = true;
            this.tajimaRadio.Location = new System.Drawing.Point(101, 26);
            this.tajimaRadio.Name = "tajimaRadio";
            this.tajimaRadio.Size = new System.Drawing.Size(56, 17);
            this.tajimaRadio.TabIndex = 1;
            this.tajimaRadio.Text = "Tajima";
            this.tajimaRadio.UseVisualStyleBackColor = true;
            // 
            // patternGroup
            // 
            this.patternGroup.Controls.Add(this.yesRadio);
            this.patternGroup.Controls.Add(this.noRadio);
            this.patternGroup.Location = new System.Drawing.Point(20, 145);
            this.patternGroup.Name = "patternGroup";
            this.patternGroup.Size = new System.Drawing.Size(187, 52);
            this.patternGroup.TabIndex = 8;
            this.patternGroup.TabStop = false;
            this.patternGroup.Text = "Pola";
            // 
            // yesRadio
            // 
            this.yesRadio.AutoSize = true;
            this.yesRadio.Location = new System.Drawing.Point(22, 25);
            this.yesRadio.Name = "yesRadio";
            this.yesRadio.Size = new System.Drawing.Size(47, 17);
            this.yesRadio.TabIndex = 0;
            this.yesRadio.Text = "ADA";
            this.yesRadio.UseVisualStyleBackColor = true;
            // 
            // noRadio
            // 
            this.noRadio.AutoSize = true;
            this.noRadio.Checked = true;
            this.noRadio.Location = new System.Drawing.Point(83, 25);
            this.noRadio.Name = "noRadio";
            this.noRadio.Size = new System.Drawing.Size(82, 17);
            this.noRadio.TabIndex = 1;
            this.noRadio.TabStop = true;
            this.noRadio.Text = "TIDAK ADA";
            this.noRadio.UseVisualStyleBackColor = true;
            // 
            // quantityNumeric
            // 
            this.quantityNumeric.Location = new System.Drawing.Point(451, 119);
            this.quantityNumeric.Maximum = new decimal(new int[] {
            2123123123,
            0,
            0,
            0});
            this.quantityNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumeric.Name = "quantityNumeric";
            this.quantityNumeric.Size = new System.Drawing.Size(120, 20);
            this.quantityNumeric.TabIndex = 7;
            this.quantityNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // stitchNumeric
            // 
            this.stitchNumeric.Location = new System.Drawing.Point(451, 87);
            this.stitchNumeric.Maximum = new decimal(new int[] {
            2123123123,
            0,
            0,
            0});
            this.stitchNumeric.Name = "stitchNumeric";
            this.stitchNumeric.Size = new System.Drawing.Size(120, 20);
            this.stitchNumeric.TabIndex = 5;
            this.stitchNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startDatetime
            // 
            this.startDatetime.Location = new System.Drawing.Point(155, 203);
            this.startDatetime.Name = "startDatetime";
            this.startDatetime.Size = new System.Drawing.Size(256, 20);
            this.startDatetime.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tanggal dan Jam Mulai";
            // 
            // dateDateTime
            // 
            this.dateDateTime.Location = new System.Drawing.Point(451, 23);
            this.dateDateTime.Name = "dateDateTime";
            this.dateDateTime.Size = new System.Drawing.Size(200, 20);
            this.dateDateTime.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(682, 26);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(116, 13);
            this.descriptionLabel.TabIndex = 6;
            this.descriptionLabel.Text = "Keterangan Tambahan";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(381, 25);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(46, 13);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Tanggal";
            // 
            // positionText
            // 
            this.positionText.Location = new System.Drawing.Point(107, 119);
            this.positionText.Name = "positionText";
            this.positionText.Size = new System.Drawing.Size(100, 20);
            this.positionText.TabIndex = 6;
            // 
            // textText
            // 
            this.textText.Location = new System.Drawing.Point(107, 87);
            this.textText.Name = "textText";
            this.textText.Size = new System.Drawing.Size(100, 20);
            this.textText.TabIndex = 4;
            // 
            // machinenumberText
            // 
            this.machinenumberText.Location = new System.Drawing.Point(536, 164);
            this.machinenumberText.Name = "machinenumberText";
            this.machinenumberText.Size = new System.Drawing.Size(133, 20);
            this.machinenumberText.TabIndex = 10;
            // 
            // styleText
            // 
            this.styleText.Location = new System.Drawing.Point(451, 55);
            this.styleText.Name = "styleText";
            this.styleText.Size = new System.Drawing.Size(100, 20);
            this.styleText.TabIndex = 3;
            // 
            // productionnumberText
            // 
            this.productionnumberText.Location = new System.Drawing.Point(107, 23);
            this.productionnumberText.Name = "productionnumberText";
            this.productionnumberText.Size = new System.Drawing.Size(193, 20);
            this.productionnumberText.TabIndex = 0;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(17, 122);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(64, 13);
            this.positionLabel.TabIndex = 0;
            this.positionLabel.Text = "Posisi Bordir";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(381, 121);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "Quantity";
            // 
            // stitchLabel
            // 
            this.stitchLabel.AutoSize = true;
            this.stitchLabel.Location = new System.Drawing.Point(381, 89);
            this.stitchLabel.Name = "stitchLabel";
            this.stitchLabel.Size = new System.Drawing.Size(34, 13);
            this.stitchLabel.TabIndex = 0;
            this.stitchLabel.Text = "Stitch";
            // 
            // machinenumberLabel
            // 
            this.machinenumberLabel.AutoSize = true;
            this.machinenumberLabel.Location = new System.Drawing.Point(461, 167);
            this.machinenumberLabel.Name = "machinenumberLabel";
            this.machinenumberLabel.Size = new System.Drawing.Size(69, 13);
            this.machinenumberLabel.TabIndex = 0;
            this.machinenumberLabel.Text = "Nomor Mesin";
            // 
            // styleLabel
            // 
            this.styleLabel.AutoSize = true;
            this.styleLabel.Location = new System.Drawing.Point(381, 57);
            this.styleLabel.Name = "styleLabel";
            this.styleLabel.Size = new System.Drawing.Size(30, 13);
            this.styleLabel.TabIndex = 0;
            this.styleLabel.Text = "Style";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(17, 90);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(83, 13);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Gambar/Tulisan";
            // 
            // costumerLabel
            // 
            this.costumerLabel.AutoSize = true;
            this.costumerLabel.Location = new System.Drawing.Point(17, 58);
            this.costumerLabel.Name = "costumerLabel";
            this.costumerLabel.Size = new System.Drawing.Size(64, 13);
            this.costumerLabel.TabIndex = 0;
            this.costumerLabel.Text = "Perusahaan";
            // 
            // ProductionInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 626);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductionInsertForm";
            this.Text = "Tambah Produksi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.machineGroup.ResumeLayout(false);
            this.machineGroup.PerformLayout();
            this.patternGroup.ResumeLayout(false);
            this.patternGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stitchNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown quantityNumeric;
        private System.Windows.Forms.NumericUpDown stitchNumeric;
        private System.Windows.Forms.DateTimePicker dateDateTime;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.RadioButton noRadio;
        private System.Windows.Forms.RadioButton yesRadio;
        private System.Windows.Forms.TextBox positionText;
        private System.Windows.Forms.TextBox textText;
        private System.Windows.Forms.TextBox styleText;
        private System.Windows.Forms.TextBox productionnumberText;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label stitchLabel;
        private System.Windows.Forms.Label styleLabel;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label costumerLabel;
        private System.Windows.Forms.GroupBox machineGroup;
        private System.Windows.Forms.RadioButton barudanRadio;
        private System.Windows.Forms.RadioButton swfRadio;
        private System.Windows.Forms.RadioButton tajimaRadio;
        private System.Windows.Forms.GroupBox patternGroup;
        private System.Windows.Forms.TextBox machinenumberText;
        private System.Windows.Forms.Label machinenumberLabel;
        private System.Windows.Forms.DateTimePicker startDatetime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.RichTextBox descriptionRich;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox costumerCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorString1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorString2;
        private System.Windows.Forms.DataGridViewTextBoxColumn application;
        private System.Windows.Forms.DataGridViewTextBoxColumn etc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorString5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorString6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorString7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorString8;
    }
}