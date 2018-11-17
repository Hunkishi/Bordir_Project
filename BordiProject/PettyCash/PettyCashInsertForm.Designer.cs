namespace BordiProject.PettyCash
{
    partial class PettyCashInsertForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.inserttypeGroup = new System.Windows.Forms.GroupBox();
            this.typecashRadio = new System.Windows.Forms.RadioButton();
            this.typecreditRadio = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.insertpurchasetotalText = new System.Windows.Forms.TextBox();
            this.insertpurchasetotalLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.inserttypeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.inserttypeGroup);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.insertpurchasetotalLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.insertpurchasetotalText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tambah Petty Cash";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Keterangan";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PIC";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Jumlah";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tanggal Transaksi";
            // 
            // inserttypeGroup
            // 
            this.inserttypeGroup.Controls.Add(this.typecashRadio);
            this.inserttypeGroup.Controls.Add(this.typecreditRadio);
            this.inserttypeGroup.Location = new System.Drawing.Point(10, 149);
            this.inserttypeGroup.Name = "inserttypeGroup";
            this.inserttypeGroup.Size = new System.Drawing.Size(166, 52);
            this.inserttypeGroup.TabIndex = 8;
            this.inserttypeGroup.TabStop = false;
            this.inserttypeGroup.Text = "Status";
            // 
            // typecashRadio
            // 
            this.typecashRadio.AutoSize = true;
            this.typecashRadio.Checked = true;
            this.typecashRadio.Location = new System.Drawing.Point(26, 19);
            this.typecashRadio.Name = "typecashRadio";
            this.typecashRadio.Size = new System.Drawing.Size(50, 17);
            this.typecashRadio.TabIndex = 0;
            this.typecashRadio.TabStop = true;
            this.typecashRadio.Text = "Debit";
            this.typecashRadio.UseVisualStyleBackColor = true;
            // 
            // typecreditRadio
            // 
            this.typecreditRadio.AutoSize = true;
            this.typecreditRadio.Location = new System.Drawing.Point(94, 19);
            this.typecreditRadio.Name = "typecreditRadio";
            this.typecreditRadio.Size = new System.Drawing.Size(52, 17);
            this.typecreditRadio.TabIndex = 1;
            this.typecreditRadio.Text = "Credit";
            this.typecreditRadio.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(111, 114);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.description,
            this.pic,
            this.debit,
            this.credit});
            this.dataGridView1.Location = new System.Drawing.Point(328, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(458, 217);
            this.dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 63);
            this.button1.TabIndex = 9;
            this.button1.Text = "Tambah Transaksi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // insertpurchasetotalText
            // 
            this.insertpurchasetotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertpurchasetotalText.Location = new System.Drawing.Point(401, 242);
            this.insertpurchasetotalText.Name = "insertpurchasetotalText";
            this.insertpurchasetotalText.ReadOnly = true;
            this.insertpurchasetotalText.Size = new System.Drawing.Size(193, 29);
            this.insertpurchasetotalText.TabIndex = 13;
            this.insertpurchasetotalText.Text = "Rp. 0.00";
            // 
            // insertpurchasetotalLabel
            // 
            this.insertpurchasetotalLabel.AutoSize = true;
            this.insertpurchasetotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertpurchasetotalLabel.Location = new System.Drawing.Point(328, 244);
            this.insertpurchasetotalLabel.Name = "insertpurchasetotalLabel";
            this.insertpurchasetotalLabel.Size = new System.Drawing.Size(72, 24);
            this.insertpurchasetotalLabel.TabIndex = 12;
            this.insertpurchasetotalLabel.Text = "TOTAL";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 63);
            this.button2.TabIndex = 10;
            this.button2.Text = "Kosongkan Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // description
            // 
            this.description.HeaderText = "Keterangan";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 150;
            // 
            // pic
            // 
            this.pic.HeaderText = "PIC";
            this.pic.Name = "pic";
            this.pic.ReadOnly = true;
            this.pic.Width = 75;
            // 
            // debit
            // 
            this.debit.HeaderText = "Debit";
            this.debit.Name = "debit";
            this.debit.ReadOnly = true;
            this.debit.Width = 120;
            // 
            // credit
            // 
            this.credit.HeaderText = "Credit";
            this.credit.Name = "credit";
            this.credit.ReadOnly = true;
            this.credit.Width = 120;
            // 
            // PettyCashInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 303);
            this.Controls.Add(this.groupBox1);
            this.Name = "PettyCashInsertForm";
            this.Text = "Tambah Petty Cash";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.inserttypeGroup.ResumeLayout(false);
            this.inserttypeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox inserttypeGroup;
        private System.Windows.Forms.RadioButton typecashRadio;
        private System.Windows.Forms.RadioButton typecreditRadio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox insertpurchasetotalText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label insertpurchasetotalLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn pic;
        private System.Windows.Forms.DataGridViewTextBoxColumn debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit;
    }
}