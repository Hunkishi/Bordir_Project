namespace BordiProject
{
    partial class SupplyInsertForm
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
            this.processGroup = new System.Windows.Forms.GroupBox();
            this.transactionGroup = new System.Windows.Forms.GroupBox();
            this.transactionitemkodeLabel = new System.Windows.Forms.Label();
            this.transactiondescriptionRichBox = new System.Windows.Forms.RichTextBox();
            this.transactionquantityNumeric = new System.Windows.Forms.NumericUpDown();
            this.transactiondescriptionLabel = new System.Windows.Forms.Label();
            this.transactionquantityLabel = new System.Windows.Forms.Label();
            this.transactionoutRadio = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.transactionButton = new System.Windows.Forms.Button();
            this.transactioninRadio = new System.Windows.Forms.RadioButton();
            this.transactionitemkodeCombo = new System.Windows.Forms.ComboBox();
            this.transactionitemnameCombo = new System.Windows.Forms.ComboBox();
            this.transactiondateDateTime = new System.Windows.Forms.DateTimePicker();
            this.transactiontypeLabel = new System.Windows.Forms.Label();
            this.transactionitemnameLabel = new System.Windows.Forms.Label();
            this.transactiondateLabel = new System.Windows.Forms.Label();
            this.insertGroup = new System.Windows.Forms.GroupBox();
            this.insertCodeLabel = new System.Windows.Forms.Label();
            this.insertitemLabel = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.insertCodeText = new System.Windows.Forms.TextBox();
            this.insertitemText = new System.Windows.Forms.TextBox();
            this.processGroup.SuspendLayout();
            this.transactionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionquantityNumeric)).BeginInit();
            this.insertGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // processGroup
            // 
            this.processGroup.Controls.Add(this.transactionGroup);
            this.processGroup.Controls.Add(this.insertGroup);
            this.processGroup.Location = new System.Drawing.Point(12, 12);
            this.processGroup.Name = "processGroup";
            this.processGroup.Size = new System.Drawing.Size(394, 384);
            this.processGroup.TabIndex = 0;
            this.processGroup.TabStop = false;
            this.processGroup.Text = "Pengolahan";
            // 
            // transactionGroup
            // 
            this.transactionGroup.Controls.Add(this.transactionitemkodeLabel);
            this.transactionGroup.Controls.Add(this.transactiondescriptionRichBox);
            this.transactionGroup.Controls.Add(this.transactionquantityNumeric);
            this.transactionGroup.Controls.Add(this.transactiondescriptionLabel);
            this.transactionGroup.Controls.Add(this.transactionquantityLabel);
            this.transactionGroup.Controls.Add(this.transactionoutRadio);
            this.transactionGroup.Controls.Add(this.button1);
            this.transactionGroup.Controls.Add(this.transactionButton);
            this.transactionGroup.Controls.Add(this.transactioninRadio);
            this.transactionGroup.Controls.Add(this.transactionitemkodeCombo);
            this.transactionGroup.Controls.Add(this.transactionitemnameCombo);
            this.transactionGroup.Controls.Add(this.transactiondateDateTime);
            this.transactionGroup.Controls.Add(this.transactiontypeLabel);
            this.transactionGroup.Controls.Add(this.transactionitemnameLabel);
            this.transactionGroup.Controls.Add(this.transactiondateLabel);
            this.transactionGroup.Location = new System.Drawing.Point(6, 117);
            this.transactionGroup.Name = "transactionGroup";
            this.transactionGroup.Size = new System.Drawing.Size(382, 257);
            this.transactionGroup.TabIndex = 1;
            this.transactionGroup.TabStop = false;
            this.transactionGroup.Text = "Tambah Transaksi";
            // 
            // transactionitemkodeLabel
            // 
            this.transactionitemkodeLabel.AutoSize = true;
            this.transactionitemkodeLabel.Location = new System.Drawing.Point(8, 84);
            this.transactionitemkodeLabel.Name = "transactionitemkodeLabel";
            this.transactionitemkodeLabel.Size = new System.Drawing.Size(32, 13);
            this.transactionitemkodeLabel.TabIndex = 6;
            this.transactionitemkodeLabel.Text = "Kode";
            // 
            // transactiondescriptionRichBox
            // 
            this.transactiondescriptionRichBox.Location = new System.Drawing.Point(97, 168);
            this.transactiondescriptionRichBox.Name = "transactiondescriptionRichBox";
            this.transactiondescriptionRichBox.Size = new System.Drawing.Size(279, 80);
            this.transactiondescriptionRichBox.TabIndex = 6;
            this.transactiondescriptionRichBox.Text = "";
            // 
            // transactionquantityNumeric
            // 
            this.transactionquantityNumeric.Location = new System.Drawing.Point(97, 137);
            this.transactionquantityNumeric.Maximum = new decimal(new int[] {
            2123123123,
            0,
            0,
            0});
            this.transactionquantityNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.transactionquantityNumeric.Name = "transactionquantityNumeric";
            this.transactionquantityNumeric.Size = new System.Drawing.Size(200, 20);
            this.transactionquantityNumeric.TabIndex = 5;
            this.transactionquantityNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // transactiondescriptionLabel
            // 
            this.transactiondescriptionLabel.AutoSize = true;
            this.transactiondescriptionLabel.Location = new System.Drawing.Point(8, 171);
            this.transactiondescriptionLabel.Name = "transactiondescriptionLabel";
            this.transactiondescriptionLabel.Size = new System.Drawing.Size(50, 13);
            this.transactiondescriptionLabel.TabIndex = 5;
            this.transactiondescriptionLabel.Text = "Deskripsi";
            // 
            // transactionquantityLabel
            // 
            this.transactionquantityLabel.AutoSize = true;
            this.transactionquantityLabel.Location = new System.Drawing.Point(8, 141);
            this.transactionquantityLabel.Name = "transactionquantityLabel";
            this.transactionquantityLabel.Size = new System.Drawing.Size(40, 13);
            this.transactionquantityLabel.TabIndex = 5;
            this.transactionquantityLabel.Text = "Jumlah";
            // 
            // transactionoutRadio
            // 
            this.transactionoutRadio.AutoSize = true;
            this.transactionoutRadio.Location = new System.Drawing.Point(211, 109);
            this.transactionoutRadio.Name = "transactionoutRadio";
            this.transactionoutRadio.Size = new System.Drawing.Size(55, 17);
            this.transactionoutRadio.TabIndex = 4;
            this.transactionoutRadio.TabStop = true;
            this.transactionoutRadio.Text = "Keluar";
            this.transactionoutRadio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 65);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kosongkan Transaksi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // transactionButton
            // 
            this.transactionButton.Location = new System.Drawing.Point(303, 18);
            this.transactionButton.Name = "transactionButton";
            this.transactionButton.Size = new System.Drawing.Size(73, 68);
            this.transactionButton.TabIndex = 7;
            this.transactionButton.Text = "Lakukan Transaksi";
            this.transactionButton.UseVisualStyleBackColor = true;
            this.transactionButton.Click += new System.EventHandler(this.transactionButton_Click);
            // 
            // transactioninRadio
            // 
            this.transactioninRadio.AutoSize = true;
            this.transactioninRadio.Checked = true;
            this.transactioninRadio.Location = new System.Drawing.Point(118, 109);
            this.transactioninRadio.Name = "transactioninRadio";
            this.transactioninRadio.Size = new System.Drawing.Size(57, 17);
            this.transactioninRadio.TabIndex = 3;
            this.transactioninRadio.TabStop = true;
            this.transactioninRadio.Text = "Masuk";
            this.transactioninRadio.UseVisualStyleBackColor = true;
            // 
            // transactionitemkodeCombo
            // 
            this.transactionitemkodeCombo.Enabled = false;
            this.transactionitemkodeCombo.FormattingEnabled = true;
            this.transactionitemkodeCombo.Location = new System.Drawing.Point(97, 81);
            this.transactionitemkodeCombo.Name = "transactionitemkodeCombo";
            this.transactionitemkodeCombo.Size = new System.Drawing.Size(200, 21);
            this.transactionitemkodeCombo.Sorted = true;
            this.transactionitemkodeCombo.TabIndex = 2;
            // 
            // transactionitemnameCombo
            // 
            this.transactionitemnameCombo.FormattingEnabled = true;
            this.transactionitemnameCombo.Location = new System.Drawing.Point(97, 51);
            this.transactionitemnameCombo.Name = "transactionitemnameCombo";
            this.transactionitemnameCombo.Size = new System.Drawing.Size(200, 21);
            this.transactionitemnameCombo.Sorted = true;
            this.transactionitemnameCombo.TabIndex = 1;
            this.transactionitemnameCombo.SelectedIndexChanged += new System.EventHandler(this.transactionitemnameCombo_SelectedIndexChanged);
            this.transactionitemnameCombo.TextUpdate += new System.EventHandler(this.transactionitemnameCombo_SelectedIndexChanged);
            // 
            // transactiondateDateTime
            // 
            this.transactiondateDateTime.Location = new System.Drawing.Point(97, 21);
            this.transactiondateDateTime.Name = "transactiondateDateTime";
            this.transactiondateDateTime.Size = new System.Drawing.Size(200, 20);
            this.transactiondateDateTime.TabIndex = 0;
            // 
            // transactiontypeLabel
            // 
            this.transactiontypeLabel.AutoSize = true;
            this.transactiontypeLabel.Location = new System.Drawing.Point(8, 111);
            this.transactiontypeLabel.Name = "transactiontypeLabel";
            this.transactiontypeLabel.Size = new System.Drawing.Size(80, 13);
            this.transactiontypeLabel.TabIndex = 5;
            this.transactiontypeLabel.Text = "Jenis Transaksi";
            // 
            // transactionitemnameLabel
            // 
            this.transactionitemnameLabel.AutoSize = true;
            this.transactionitemnameLabel.Location = new System.Drawing.Point(8, 54);
            this.transactionitemnameLabel.Name = "transactionitemnameLabel";
            this.transactionitemnameLabel.Size = new System.Drawing.Size(72, 13);
            this.transactionitemnameLabel.TabIndex = 5;
            this.transactionitemnameLabel.Text = "Nama Barang";
            // 
            // transactiondateLabel
            // 
            this.transactiondateLabel.AutoSize = true;
            this.transactiondateLabel.Location = new System.Drawing.Point(8, 25);
            this.transactiondateLabel.Name = "transactiondateLabel";
            this.transactiondateLabel.Size = new System.Drawing.Size(46, 13);
            this.transactiondateLabel.TabIndex = 4;
            this.transactiondateLabel.Text = "Tanggal";
            // 
            // insertGroup
            // 
            this.insertGroup.Controls.Add(this.insertCodeLabel);
            this.insertGroup.Controls.Add(this.insertitemLabel);
            this.insertGroup.Controls.Add(this.insertButton);
            this.insertGroup.Controls.Add(this.insertCodeText);
            this.insertGroup.Controls.Add(this.insertitemText);
            this.insertGroup.Location = new System.Drawing.Point(6, 19);
            this.insertGroup.Name = "insertGroup";
            this.insertGroup.Size = new System.Drawing.Size(382, 92);
            this.insertGroup.TabIndex = 0;
            this.insertGroup.TabStop = false;
            this.insertGroup.Text = "Tambah Barang";
            // 
            // insertCodeLabel
            // 
            this.insertCodeLabel.AutoSize = true;
            this.insertCodeLabel.Location = new System.Drawing.Point(6, 57);
            this.insertCodeLabel.Name = "insertCodeLabel";
            this.insertCodeLabel.Size = new System.Drawing.Size(32, 13);
            this.insertCodeLabel.TabIndex = 6;
            this.insertCodeLabel.Text = "Kode";
            // 
            // insertitemLabel
            // 
            this.insertitemLabel.AutoSize = true;
            this.insertitemLabel.Location = new System.Drawing.Point(6, 27);
            this.insertitemLabel.Name = "insertitemLabel";
            this.insertitemLabel.Size = new System.Drawing.Size(72, 13);
            this.insertitemLabel.TabIndex = 5;
            this.insertitemLabel.Text = "Nama Barang";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(301, 24);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 50);
            this.insertButton.TabIndex = 2;
            this.insertButton.Text = "Tambah";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // insertCodeText
            // 
            this.insertCodeText.Location = new System.Drawing.Point(95, 54);
            this.insertCodeText.Name = "insertCodeText";
            this.insertCodeText.Size = new System.Drawing.Size(200, 20);
            this.insertCodeText.TabIndex = 1;
            // 
            // insertitemText
            // 
            this.insertitemText.Location = new System.Drawing.Point(95, 24);
            this.insertitemText.Name = "insertitemText";
            this.insertitemText.Size = new System.Drawing.Size(200, 20);
            this.insertitemText.TabIndex = 0;
            // 
            // SupplyInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 406);
            this.Controls.Add(this.processGroup);
            this.Name = "SupplyInsertForm";
            this.Text = "Tambah Stok";
            this.processGroup.ResumeLayout(false);
            this.transactionGroup.ResumeLayout(false);
            this.transactionGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionquantityNumeric)).EndInit();
            this.insertGroup.ResumeLayout(false);
            this.insertGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox processGroup;
        private System.Windows.Forms.GroupBox insertGroup;
        private System.Windows.Forms.Button transactionButton;
        private System.Windows.Forms.Label insertitemLabel;
        private System.Windows.Forms.TextBox insertitemText;
        private System.Windows.Forms.GroupBox transactionGroup;
        private System.Windows.Forms.ComboBox transactionitemnameCombo;
        private System.Windows.Forms.DateTimePicker transactiondateDateTime;
        private System.Windows.Forms.Label transactionitemnameLabel;
        private System.Windows.Forms.Label transactiondateLabel;
        private System.Windows.Forms.NumericUpDown transactionquantityNumeric;
        private System.Windows.Forms.Label transactionquantityLabel;
        private System.Windows.Forms.RadioButton transactionoutRadio;
        private System.Windows.Forms.RadioButton transactioninRadio;
        private System.Windows.Forms.Label transactiontypeLabel;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.RichTextBox transactiondescriptionRichBox;
        private System.Windows.Forms.Label transactiondescriptionLabel;
        private System.Windows.Forms.Label insertCodeLabel;
        private System.Windows.Forms.TextBox insertCodeText;
        private System.Windows.Forms.Label transactionitemkodeLabel;
        private System.Windows.Forms.ComboBox transactionitemkodeCombo;
        private System.Windows.Forms.Button button1;
    }
}