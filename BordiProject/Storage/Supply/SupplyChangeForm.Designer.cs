namespace BordiProject
{
    partial class SupplyChangeForm
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
            this.editGroup = new System.Windows.Forms.GroupBox();
            this.updateGroup = new System.Windows.Forms.GroupBox();
            this.updatedescriptionRichBox = new System.Windows.Forms.RichTextBox();
            this.updatequantityNumeric = new System.Windows.Forms.NumericUpDown();
            this.updatedescriptionLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.updateoutRadio = new System.Windows.Forms.RadioButton();
            this.updatequantityLabel = new System.Windows.Forms.Label();
            this.updateinRadio = new System.Windows.Forms.RadioButton();
            this.updatedateDateTime = new System.Windows.Forms.DateTimePicker();
            this.updateitemLabel = new System.Windows.Forms.Label();
            this.updateitemCombo = new System.Windows.Forms.ComboBox();
            this.updatetypeLabel = new System.Windows.Forms.Label();
            this.updatedateLabel = new System.Windows.Forms.Label();
            this.editidtransactionButton = new System.Windows.Forms.Button();
            this.editidtransactionLabel = new System.Windows.Forms.Label();
            this.editidtransactionText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.editGroup.SuspendLayout();
            this.updateGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updatequantityNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // editGroup
            // 
            this.editGroup.Controls.Add(this.updateGroup);
            this.editGroup.Controls.Add(this.editidtransactionButton);
            this.editGroup.Controls.Add(this.editidtransactionLabel);
            this.editGroup.Controls.Add(this.editidtransactionText);
            this.editGroup.Location = new System.Drawing.Point(12, 10);
            this.editGroup.Name = "editGroup";
            this.editGroup.Size = new System.Drawing.Size(382, 310);
            this.editGroup.TabIndex = 1;
            this.editGroup.TabStop = false;
            this.editGroup.Text = "Ubah Transaksi";
            // 
            // updateGroup
            // 
            this.updateGroup.Controls.Add(this.updatedescriptionRichBox);
            this.updateGroup.Controls.Add(this.updatequantityNumeric);
            this.updateGroup.Controls.Add(this.updatedescriptionLabel);
            this.updateGroup.Controls.Add(this.resetButton);
            this.updateGroup.Controls.Add(this.button1);
            this.updateGroup.Controls.Add(this.updateButton);
            this.updateGroup.Controls.Add(this.updateoutRadio);
            this.updateGroup.Controls.Add(this.updatequantityLabel);
            this.updateGroup.Controls.Add(this.updateinRadio);
            this.updateGroup.Controls.Add(this.updatedateDateTime);
            this.updateGroup.Controls.Add(this.label1);
            this.updateGroup.Controls.Add(this.updateitemLabel);
            this.updateGroup.Controls.Add(this.comboBox3);
            this.updateGroup.Controls.Add(this.updateitemCombo);
            this.updateGroup.Controls.Add(this.updatetypeLabel);
            this.updateGroup.Controls.Add(this.updatedateLabel);
            this.updateGroup.Enabled = false;
            this.updateGroup.Location = new System.Drawing.Point(7, 46);
            this.updateGroup.Name = "updateGroup";
            this.updateGroup.Size = new System.Drawing.Size(369, 254);
            this.updateGroup.TabIndex = 6;
            this.updateGroup.TabStop = false;
            this.updateGroup.Text = "Menjadi";
            // 
            // updatedescriptionRichBox
            // 
            this.updatedescriptionRichBox.Location = new System.Drawing.Point(95, 166);
            this.updatedescriptionRichBox.Name = "updatedescriptionRichBox";
            this.updatedescriptionRichBox.Size = new System.Drawing.Size(268, 79);
            this.updatedescriptionRichBox.TabIndex = 7;
            this.updatedescriptionRichBox.Text = "";
            // 
            // updatequantityNumeric
            // 
            this.updatequantityNumeric.Location = new System.Drawing.Point(95, 136);
            this.updatequantityNumeric.Maximum = new decimal(new int[] {
            2123123123,
            0,
            0,
            0});
            this.updatequantityNumeric.Name = "updatequantityNumeric";
            this.updatequantityNumeric.Size = new System.Drawing.Size(200, 20);
            this.updatequantityNumeric.TabIndex = 6;
            // 
            // updatedescriptionLabel
            // 
            this.updatedescriptionLabel.AutoSize = true;
            this.updatedescriptionLabel.Location = new System.Drawing.Point(6, 169);
            this.updatedescriptionLabel.Name = "updatedescriptionLabel";
            this.updatedescriptionLabel.Size = new System.Drawing.Size(50, 13);
            this.updatedescriptionLabel.TabIndex = 5;
            this.updatedescriptionLabel.Text = "Deskripsi";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(301, 112);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(62, 44);
            this.resetButton.TabIndex = 0;
            this.resetButton.Text = "Kembali nilai awal";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(301, 19);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(62, 43);
            this.updateButton.TabIndex = 0;
            this.updateButton.Text = "Ubah";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateoutRadio
            // 
            this.updateoutRadio.AutoSize = true;
            this.updateoutRadio.Location = new System.Drawing.Point(217, 109);
            this.updateoutRadio.Name = "updateoutRadio";
            this.updateoutRadio.Size = new System.Drawing.Size(55, 17);
            this.updateoutRadio.TabIndex = 6;
            this.updateoutRadio.TabStop = true;
            this.updateoutRadio.Text = "Keluar";
            this.updateoutRadio.UseVisualStyleBackColor = true;
            // 
            // updatequantityLabel
            // 
            this.updatequantityLabel.AutoSize = true;
            this.updatequantityLabel.Location = new System.Drawing.Point(6, 140);
            this.updatequantityLabel.Name = "updatequantityLabel";
            this.updatequantityLabel.Size = new System.Drawing.Size(40, 13);
            this.updatequantityLabel.TabIndex = 5;
            this.updatequantityLabel.Text = "Jumlah";
            // 
            // updateinRadio
            // 
            this.updateinRadio.AutoSize = true;
            this.updateinRadio.Checked = true;
            this.updateinRadio.Location = new System.Drawing.Point(124, 109);
            this.updateinRadio.Name = "updateinRadio";
            this.updateinRadio.Size = new System.Drawing.Size(57, 17);
            this.updateinRadio.TabIndex = 6;
            this.updateinRadio.TabStop = true;
            this.updateinRadio.Text = "Masuk";
            this.updateinRadio.UseVisualStyleBackColor = true;
            // 
            // updatedateDateTime
            // 
            this.updatedateDateTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.updatedateDateTime.Location = new System.Drawing.Point(95, 21);
            this.updatedateDateTime.Name = "updatedateDateTime";
            this.updatedateDateTime.Size = new System.Drawing.Size(200, 20);
            this.updatedateDateTime.TabIndex = 1;
            // 
            // updateitemLabel
            // 
            this.updateitemLabel.AutoSize = true;
            this.updateitemLabel.Location = new System.Drawing.Point(6, 53);
            this.updateitemLabel.Name = "updateitemLabel";
            this.updateitemLabel.Size = new System.Drawing.Size(72, 13);
            this.updateitemLabel.TabIndex = 5;
            this.updateitemLabel.Text = "Nama Barang";
            // 
            // updateitemCombo
            // 
            this.updateitemCombo.FormattingEnabled = true;
            this.updateitemCombo.Location = new System.Drawing.Point(95, 49);
            this.updateitemCombo.Name = "updateitemCombo";
            this.updateitemCombo.Size = new System.Drawing.Size(200, 21);
            this.updateitemCombo.Sorted = true;
            this.updateitemCombo.TabIndex = 0;
            this.updateitemCombo.SelectedIndexChanged += new System.EventHandler(this.updateitemCombo_SelectedIndexChanged);
            this.updateitemCombo.TextUpdate += new System.EventHandler(this.updateitemCombo_SelectedIndexChanged);
            // 
            // updatetypeLabel
            // 
            this.updatetypeLabel.AutoSize = true;
            this.updatetypeLabel.Location = new System.Drawing.Point(6, 111);
            this.updatetypeLabel.Name = "updatetypeLabel";
            this.updatetypeLabel.Size = new System.Drawing.Size(80, 13);
            this.updatetypeLabel.TabIndex = 5;
            this.updatetypeLabel.Text = "Jenis Transaksi";
            // 
            // updatedateLabel
            // 
            this.updatedateLabel.AutoSize = true;
            this.updatedateLabel.Location = new System.Drawing.Point(6, 24);
            this.updatedateLabel.Name = "updatedateLabel";
            this.updatedateLabel.Size = new System.Drawing.Size(46, 13);
            this.updatedateLabel.TabIndex = 4;
            this.updatedateLabel.Text = "Tanggal";
            // 
            // editidtransactionButton
            // 
            this.editidtransactionButton.Location = new System.Drawing.Point(306, 17);
            this.editidtransactionButton.Name = "editidtransactionButton";
            this.editidtransactionButton.Size = new System.Drawing.Size(64, 23);
            this.editidtransactionButton.TabIndex = 4;
            this.editidtransactionButton.Text = "Cari";
            this.editidtransactionButton.UseVisualStyleBackColor = true;
            this.editidtransactionButton.Click += new System.EventHandler(this.editidtransactionButton_Click);
            // 
            // editidtransactionLabel
            // 
            this.editidtransactionLabel.AutoSize = true;
            this.editidtransactionLabel.Location = new System.Drawing.Point(6, 22);
            this.editidtransactionLabel.Name = "editidtransactionLabel";
            this.editidtransactionLabel.Size = new System.Drawing.Size(67, 13);
            this.editidtransactionLabel.TabIndex = 5;
            this.editidtransactionLabel.Text = "ID Transaksi";
            // 
            // editidtransactionText
            // 
            this.editidtransactionText.Location = new System.Drawing.Point(95, 18);
            this.editidtransactionText.Name = "editidtransactionText";
            this.editidtransactionText.Size = new System.Drawing.Size(200, 20);
            this.editidtransactionText.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(400, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 263);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Stok Barang";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(95, 78);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 21);
            this.comboBox3.Sorted = true;
            this.comboBox3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kode Barang";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hapus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(6, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 119);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Menjadi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kode Barang";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ubah";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kode Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nama Barang";
            // 
            // comboBox5
            // 
            this.comboBox5.Enabled = false;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(99, 48);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(200, 21);
            this.comboBox5.Sorted = true;
            this.comboBox5.TabIndex = 0;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            this.comboBox5.TextUpdate += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(99, 19);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(200, 21);
            this.comboBox4.Sorted = true;
            this.comboBox4.TabIndex = 0;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            this.comboBox4.TextUpdate += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 235);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Berdasarkan Nama dan Kode Barang";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(99, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cari";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 20);
            this.textBox2.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(186, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Hapus";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SupplyChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 329);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.editGroup);
            this.Name = "SupplyChangeForm";
            this.Text = "Ubah Stok";
            this.editGroup.ResumeLayout(false);
            this.editGroup.PerformLayout();
            this.updateGroup.ResumeLayout(false);
            this.updateGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updatequantityNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox editGroup;
        private System.Windows.Forms.GroupBox updateGroup;
        private System.Windows.Forms.RichTextBox updatedescriptionRichBox;
        private System.Windows.Forms.NumericUpDown updatequantityNumeric;
        private System.Windows.Forms.Label updatedescriptionLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.RadioButton updateoutRadio;
        private System.Windows.Forms.Label updatequantityLabel;
        private System.Windows.Forms.RadioButton updateinRadio;
        private System.Windows.Forms.DateTimePicker updatedateDateTime;
        private System.Windows.Forms.Label updateitemLabel;
        private System.Windows.Forms.ComboBox updateitemCombo;
        private System.Windows.Forms.Label updatetypeLabel;
        private System.Windows.Forms.Label updatedateLabel;
        private System.Windows.Forms.Button editidtransactionButton;
        private System.Windows.Forms.Label editidtransactionLabel;
        private System.Windows.Forms.TextBox editidtransactionText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}