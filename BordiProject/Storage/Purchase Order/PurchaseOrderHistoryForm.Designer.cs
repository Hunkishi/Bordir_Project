namespace BordiProject
{
    partial class PurchaseOrderHistoryForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.historybydateGroup = new System.Windows.Forms.GroupBox();
            this.historybydatefromDateTime = new System.Windows.Forms.DateTimePicker();
            this.historybydateuntilDateTime = new System.Windows.Forms.DateTimePicker();
            this.historybydatefromLabel = new System.Windows.Forms.Label();
            this.historybydateuntilLabel = new System.Windows.Forms.Label();
            this.historybydateButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.historybynumberGroup = new System.Windows.Forms.GroupBox();
            this.historynumberPOCombo = new System.Windows.Forms.ComboBox();
            this.historysearchbynumberPOButton = new System.Windows.Forms.Button();
            this.historynumberPOLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.historyspesificPOGroup = new System.Windows.Forms.GroupBox();
            this.historyspesificsdateDateTime = new System.Windows.Forms.DateTimePicker();
            this.historytypeGroup = new System.Windows.Forms.GroupBox();
            this.historyspesifictypecashRadio = new System.Windows.Forms.RadioButton();
            this.historyspesifictypecreditRadio = new System.Windows.Forms.RadioButton();
            this.historyspesificsupplierLabel = new System.Windows.Forms.Label();
            this.historyspesificsrangeText = new System.Windows.Forms.TextBox();
            this.historyspesificsdateLabel = new System.Windows.Forms.Label();
            this.historyspesificsupplierText = new System.Windows.Forms.TextBox();
            this.historyspesificsrangeLabel = new System.Windows.Forms.Label();
            this.historypurchasetotalLabel = new System.Windows.Forms.Label();
            this.historypurchasetotalText = new System.Windows.Forms.TextBox();
            this.historypurchaseDataGrid = new System.Windows.Forms.DataGridView();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.historybydateGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.historybynumberGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.historyspesificPOGroup.SuspendLayout();
            this.historytypeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historypurchaseDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.historybynumberGroup);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(6, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 575);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Riwayat PO";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.historybydateGroup);
            this.groupBox4.Controls.Add(this.historybydateButton);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(259, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(558, 132);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pencarian Kategori";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(301, 73);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(148, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Berdasarkan Pembayaran";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(301, 21);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(146, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Berdasarkan Perusahaan";
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
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Berdasarkan Tanggal";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Location = new System.Drawing.Point(291, 73);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(172, 51);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(26, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Cash";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(101, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Credit";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // historybydateGroup
            // 
            this.historybydateGroup.Controls.Add(this.historybydatefromDateTime);
            this.historybydateGroup.Controls.Add(this.historybydateuntilDateTime);
            this.historybydateGroup.Controls.Add(this.historybydatefromLabel);
            this.historybydateGroup.Controls.Add(this.historybydateuntilLabel);
            this.historybydateGroup.Location = new System.Drawing.Point(6, 19);
            this.historybydateGroup.Name = "historybydateGroup";
            this.historybydateGroup.Size = new System.Drawing.Size(279, 105);
            this.historybydateGroup.TabIndex = 7;
            this.historybydateGroup.TabStop = false;
            // 
            // historybydatefromDateTime
            // 
            this.historybydatefromDateTime.Location = new System.Drawing.Point(61, 27);
            this.historybydatefromDateTime.Name = "historybydatefromDateTime";
            this.historybydatefromDateTime.Size = new System.Drawing.Size(200, 20);
            this.historybydatefromDateTime.TabIndex = 0;
            this.historybydatefromDateTime.ValueChanged += new System.EventHandler(this.historybydatefromDateTime_ValueChanged);
            // 
            // historybydateuntilDateTime
            // 
            this.historybydateuntilDateTime.Location = new System.Drawing.Point(61, 62);
            this.historybydateuntilDateTime.Name = "historybydateuntilDateTime";
            this.historybydateuntilDateTime.Size = new System.Drawing.Size(200, 20);
            this.historybydateuntilDateTime.TabIndex = 1;
            this.historybydateuntilDateTime.ValueChanged += new System.EventHandler(this.historybydateuntilDateTime_ValueChanged);
            // 
            // historybydatefromLabel
            // 
            this.historybydatefromLabel.AutoSize = true;
            this.historybydatefromLabel.Location = new System.Drawing.Point(8, 31);
            this.historybydatefromLabel.Name = "historybydatefromLabel";
            this.historybydatefromLabel.Size = new System.Drawing.Size(26, 13);
            this.historybydatefromLabel.TabIndex = 2;
            this.historybydatefromLabel.Text = "Dari";
            // 
            // historybydateuntilLabel
            // 
            this.historybydateuntilLabel.AutoSize = true;
            this.historybydateuntilLabel.Location = new System.Drawing.Point(8, 66);
            this.historybydateuntilLabel.Name = "historybydateuntilLabel";
            this.historybydateuntilLabel.Size = new System.Drawing.Size(42, 13);
            this.historybydateuntilLabel.TabIndex = 2;
            this.historybydateuntilLabel.Text = "Sampai";
            // 
            // historybydateButton
            // 
            this.historybydateButton.Location = new System.Drawing.Point(469, 77);
            this.historybydateButton.Name = "historybydateButton";
            this.historybydateButton.Size = new System.Drawing.Size(80, 46);
            this.historybydateButton.TabIndex = 2;
            this.historybydateButton.Text = "Cari";
            this.historybydateButton.UseVisualStyleBackColor = true;
            this.historybydateButton.Click += new System.EventHandler(this.historybydateButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(291, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 51);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextUpdate += new System.EventHandler(this.comboBox1_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Perusahaan";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ekspor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(136, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 43);
            this.button4.TabIndex = 4;
            this.button4.Text = "Print";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // historybynumberGroup
            // 
            this.historybynumberGroup.Controls.Add(this.historynumberPOCombo);
            this.historybynumberGroup.Controls.Add(this.historysearchbynumberPOButton);
            this.historybynumberGroup.Controls.Add(this.historynumberPOLabel);
            this.historybynumberGroup.Location = new System.Drawing.Point(10, 16);
            this.historybynumberGroup.Name = "historybynumberGroup";
            this.historybynumberGroup.Size = new System.Drawing.Size(243, 78);
            this.historybynumberGroup.TabIndex = 6;
            this.historybynumberGroup.TabStop = false;
            this.historybynumberGroup.Text = "Pencarian Spesifik";
            // 
            // historynumberPOCombo
            // 
            this.historynumberPOCombo.FormattingEnabled = true;
            this.historynumberPOCombo.Location = new System.Drawing.Point(65, 16);
            this.historynumberPOCombo.Name = "historynumberPOCombo";
            this.historynumberPOCombo.Size = new System.Drawing.Size(156, 21);
            this.historynumberPOCombo.TabIndex = 3;
            this.historynumberPOCombo.SelectedIndexChanged += new System.EventHandler(this.historynumberPOCombo_SelectedIndexChanged);
            this.historynumberPOCombo.TextUpdate += new System.EventHandler(this.historynumberPOCombo_TextUpdate);
            // 
            // historysearchbynumberPOButton
            // 
            this.historysearchbynumberPOButton.Location = new System.Drawing.Point(12, 46);
            this.historysearchbynumberPOButton.Name = "historysearchbynumberPOButton";
            this.historysearchbynumberPOButton.Size = new System.Drawing.Size(209, 23);
            this.historysearchbynumberPOButton.TabIndex = 2;
            this.historysearchbynumberPOButton.Text = "Cari";
            this.historysearchbynumberPOButton.UseVisualStyleBackColor = true;
            this.historysearchbynumberPOButton.Click += new System.EventHandler(this.historysearchbynumberPOButton_Click);
            // 
            // historynumberPOLabel
            // 
            this.historynumberPOLabel.AutoSize = true;
            this.historynumberPOLabel.Location = new System.Drawing.Point(17, 20);
            this.historynumberPOLabel.Name = "historynumberPOLabel";
            this.historynumberPOLabel.Size = new System.Drawing.Size(42, 13);
            this.historynumberPOLabel.TabIndex = 1;
            this.historynumberPOLabel.Text = "No. PO";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.historyspesificPOGroup);
            this.groupBox3.Controls.Add(this.historypurchaseDataGrid);
            this.groupBox3.Location = new System.Drawing.Point(3, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(814, 424);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data PO";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.richTextBox1);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(662, 296);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(143, 122);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Opsi Print";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(130, 77);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama Perusahaan";
            // 
            // historyspesificPOGroup
            // 
            this.historyspesificPOGroup.Controls.Add(this.historyspesificsdateDateTime);
            this.historyspesificPOGroup.Controls.Add(this.historytypeGroup);
            this.historyspesificPOGroup.Controls.Add(this.historyspesificsupplierLabel);
            this.historyspesificPOGroup.Controls.Add(this.historyspesificsrangeText);
            this.historyspesificPOGroup.Controls.Add(this.historyspesificsdateLabel);
            this.historyspesificPOGroup.Controls.Add(this.historyspesificsupplierText);
            this.historyspesificPOGroup.Controls.Add(this.historyspesificsrangeLabel);
            this.historyspesificPOGroup.Controls.Add(this.historypurchasetotalLabel);
            this.historyspesificPOGroup.Controls.Add(this.historypurchasetotalText);
            this.historyspesificPOGroup.Enabled = false;
            this.historyspesificPOGroup.Location = new System.Drawing.Point(7, 295);
            this.historyspesificPOGroup.Name = "historyspesificPOGroup";
            this.historyspesificPOGroup.Size = new System.Drawing.Size(649, 123);
            this.historyspesificPOGroup.TabIndex = 3;
            this.historyspesificPOGroup.TabStop = false;
            this.historyspesificPOGroup.Text = "Data PO spesifik";
            // 
            // historyspesificsdateDateTime
            // 
            this.historyspesificsdateDateTime.Enabled = false;
            this.historyspesificsdateDateTime.Location = new System.Drawing.Point(126, 52);
            this.historyspesificsdateDateTime.Name = "historyspesificsdateDateTime";
            this.historyspesificsdateDateTime.Size = new System.Drawing.Size(200, 20);
            this.historyspesificsdateDateTime.TabIndex = 9;
            // 
            // historytypeGroup
            // 
            this.historytypeGroup.Controls.Add(this.historyspesifictypecashRadio);
            this.historytypeGroup.Controls.Add(this.historyspesifictypecreditRadio);
            this.historytypeGroup.Location = new System.Drawing.Point(350, 17);
            this.historytypeGroup.Name = "historytypeGroup";
            this.historytypeGroup.Size = new System.Drawing.Size(166, 51);
            this.historytypeGroup.TabIndex = 4;
            this.historytypeGroup.TabStop = false;
            this.historytypeGroup.Text = "Jenis Pembayaran";
            // 
            // historyspesifictypecashRadio
            // 
            this.historyspesifictypecashRadio.AutoCheck = false;
            this.historyspesifictypecashRadio.AutoSize = true;
            this.historyspesifictypecashRadio.Location = new System.Drawing.Point(26, 19);
            this.historyspesifictypecashRadio.Name = "historyspesifictypecashRadio";
            this.historyspesifictypecashRadio.Size = new System.Drawing.Size(49, 17);
            this.historyspesifictypecashRadio.TabIndex = 0;
            this.historyspesifictypecashRadio.TabStop = true;
            this.historyspesifictypecashRadio.Text = "Cash";
            this.historyspesifictypecashRadio.UseVisualStyleBackColor = true;
            // 
            // historyspesifictypecreditRadio
            // 
            this.historyspesifictypecreditRadio.AutoCheck = false;
            this.historyspesifictypecreditRadio.AutoSize = true;
            this.historyspesifictypecreditRadio.Checked = true;
            this.historyspesifictypecreditRadio.Location = new System.Drawing.Point(94, 19);
            this.historyspesifictypecreditRadio.Name = "historyspesifictypecreditRadio";
            this.historyspesifictypecreditRadio.Size = new System.Drawing.Size(52, 17);
            this.historyspesifictypecreditRadio.TabIndex = 0;
            this.historyspesifictypecreditRadio.TabStop = true;
            this.historyspesifictypecreditRadio.Text = "Credit";
            this.historyspesifictypecreditRadio.UseVisualStyleBackColor = true;
            // 
            // historyspesificsupplierLabel
            // 
            this.historyspesificsupplierLabel.AutoSize = true;
            this.historyspesificsupplierLabel.Location = new System.Drawing.Point(43, 28);
            this.historyspesificsupplierLabel.Name = "historyspesificsupplierLabel";
            this.historyspesificsupplierLabel.Size = new System.Drawing.Size(44, 13);
            this.historyspesificsupplierLabel.TabIndex = 4;
            this.historyspesificsupplierLabel.Text = "Kepada";
            // 
            // historyspesificsrangeText
            // 
            this.historyspesificsrangeText.Location = new System.Drawing.Point(126, 80);
            this.historyspesificsrangeText.Name = "historyspesificsrangeText";
            this.historyspesificsrangeText.ReadOnly = true;
            this.historyspesificsrangeText.Size = new System.Drawing.Size(117, 20);
            this.historyspesificsrangeText.TabIndex = 8;
            // 
            // historyspesificsdateLabel
            // 
            this.historyspesificsdateLabel.AutoSize = true;
            this.historyspesificsdateLabel.Location = new System.Drawing.Point(43, 55);
            this.historyspesificsdateLabel.Name = "historyspesificsdateLabel";
            this.historyspesificsdateLabel.Size = new System.Drawing.Size(46, 13);
            this.historyspesificsdateLabel.TabIndex = 5;
            this.historyspesificsdateLabel.Text = "Tanggal";
            // 
            // historyspesificsupplierText
            // 
            this.historyspesificsupplierText.Location = new System.Drawing.Point(126, 24);
            this.historyspesificsupplierText.Name = "historyspesificsupplierText";
            this.historyspesificsupplierText.ReadOnly = true;
            this.historyspesificsupplierText.Size = new System.Drawing.Size(202, 20);
            this.historyspesificsupplierText.TabIndex = 6;
            // 
            // historyspesificsrangeLabel
            // 
            this.historyspesificsrangeLabel.AutoSize = true;
            this.historyspesificsrangeLabel.Location = new System.Drawing.Point(43, 82);
            this.historyspesificsrangeLabel.Name = "historyspesificsrangeLabel";
            this.historyspesificsrangeLabel.Size = new System.Drawing.Size(77, 13);
            this.historyspesificsrangeLabel.TabIndex = 7;
            this.historyspesificsrangeLabel.Text = "Jangka Waktu";
            // 
            // historypurchasetotalLabel
            // 
            this.historypurchasetotalLabel.AutoSize = true;
            this.historypurchasetotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historypurchasetotalLabel.Location = new System.Drawing.Point(346, 79);
            this.historypurchasetotalLabel.Name = "historypurchasetotalLabel";
            this.historypurchasetotalLabel.Size = new System.Drawing.Size(72, 24);
            this.historypurchasetotalLabel.TabIndex = 1;
            this.historypurchasetotalLabel.Text = "TOTAL";
            // 
            // historypurchasetotalText
            // 
            this.historypurchasetotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historypurchasetotalText.Location = new System.Drawing.Point(424, 76);
            this.historypurchasetotalText.Name = "historypurchasetotalText";
            this.historypurchasetotalText.ReadOnly = true;
            this.historypurchasetotalText.Size = new System.Drawing.Size(213, 29);
            this.historypurchasetotalText.TabIndex = 2;
            this.historypurchasetotalText.Text = "Rp. 0.00";
            // 
            // historypurchaseDataGrid
            // 
            this.historypurchaseDataGrid.AllowUserToAddRows = false;
            this.historypurchaseDataGrid.AllowUserToDeleteRows = false;
            this.historypurchaseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historypurchaseDataGrid.Location = new System.Drawing.Point(7, 19);
            this.historypurchaseDataGrid.Name = "historypurchaseDataGrid";
            this.historypurchaseDataGrid.ReadOnly = true;
            this.historypurchaseDataGrid.RowHeadersVisible = false;
            this.historypurchaseDataGrid.Size = new System.Drawing.Size(798, 270);
            this.historypurchaseDataGrid.TabIndex = 0;
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
            // PurchaseOrderHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 588);
            this.Controls.Add(this.groupBox1);
            this.Name = "PurchaseOrderHistoryForm";
            this.Text = "Riwayat Pembelanjaan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.historybydateGroup.ResumeLayout(false);
            this.historybydateGroup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.historybynumberGroup.ResumeLayout(false);
            this.historybynumberGroup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.historyspesificPOGroup.ResumeLayout(false);
            this.historyspesificPOGroup.PerformLayout();
            this.historytypeGroup.ResumeLayout(false);
            this.historytypeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historypurchaseDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox historybydateGroup;
        private System.Windows.Forms.Button historybydateButton;
        private System.Windows.Forms.DateTimePicker historybydatefromDateTime;
        private System.Windows.Forms.DateTimePicker historybydateuntilDateTime;
        private System.Windows.Forms.Label historybydatefromLabel;
        private System.Windows.Forms.Label historybydateuntilLabel;
        private System.Windows.Forms.GroupBox historybynumberGroup;
        private System.Windows.Forms.ComboBox historynumberPOCombo;
        private System.Windows.Forms.Button historysearchbynumberPOButton;
        private System.Windows.Forms.Label historynumberPOLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox historyspesificPOGroup;
        private System.Windows.Forms.DateTimePicker historyspesificsdateDateTime;
        private System.Windows.Forms.GroupBox historytypeGroup;
        private System.Windows.Forms.RadioButton historyspesifictypecashRadio;
        private System.Windows.Forms.RadioButton historyspesifictypecreditRadio;
        private System.Windows.Forms.Label historyspesificsupplierLabel;
        private System.Windows.Forms.TextBox historyspesificsrangeText;
        private System.Windows.Forms.Label historyspesificsdateLabel;
        private System.Windows.Forms.TextBox historyspesificsupplierText;
        private System.Windows.Forms.Label historyspesificsrangeLabel;
        private System.Windows.Forms.Label historypurchasetotalLabel;
        private System.Windows.Forms.TextBox historypurchasetotalText;
        private System.Windows.Forms.DataGridView historypurchaseDataGrid;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}