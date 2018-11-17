namespace BordiProject
{
    partial class MenuForm
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
            this.productionPanel = new System.Windows.Forms.Panel();
            this.productionLabel = new System.Windows.Forms.Label();
            this.receiptPanel = new System.Windows.Forms.Panel();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.supplyPanel = new System.Windows.Forms.Panel();
            this.supplyLabel = new System.Windows.Forms.Label();
            this.orderPanel = new System.Windows.Forms.Panel();
            this.orderLabel = new System.Windows.Forms.Label();
            this.attendancePanel = new System.Windows.Forms.Panel();
            this.attendanceLabel = new System.Windows.Forms.Label();
            this.salaryPanel = new System.Windows.Forms.Panel();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.employeePanel = new System.Windows.Forms.Panel();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.accountPanel = new System.Windows.Forms.Panel();
            this.accountLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.customerPanel = new System.Windows.Forms.Panel();
            this.customerLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.productionPanel.SuspendLayout();
            this.receiptPanel.SuspendLayout();
            this.supplyPanel.SuspendLayout();
            this.orderPanel.SuspendLayout();
            this.attendancePanel.SuspendLayout();
            this.salaryPanel.SuspendLayout();
            this.employeePanel.SuspendLayout();
            this.accountPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupbox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.customerPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // productionPanel
            // 
            this.productionPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.productionPanel.Controls.Add(this.productionLabel);
            this.productionPanel.Location = new System.Drawing.Point(22, 19);
            this.productionPanel.Name = "productionPanel";
            this.productionPanel.Size = new System.Drawing.Size(231, 107);
            this.productionPanel.TabIndex = 0;
            this.productionPanel.Click += new System.EventHandler(this.productionMenu_Click);
            this.productionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.productionPanel_Paint);
            // 
            // productionLabel
            // 
            this.productionLabel.AutoSize = true;
            this.productionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionLabel.ForeColor = System.Drawing.Color.Navy;
            this.productionLabel.Location = new System.Drawing.Point(40, 34);
            this.productionLabel.Name = "productionLabel";
            this.productionLabel.Size = new System.Drawing.Size(150, 37);
            this.productionLabel.TabIndex = 0;
            this.productionLabel.Text = "Produksi";
            this.productionLabel.Click += new System.EventHandler(this.productionMenu_Click);
            // 
            // receiptPanel
            // 
            this.receiptPanel.BackColor = System.Drawing.Color.Violet;
            this.receiptPanel.Controls.Add(this.receiptLabel);
            this.receiptPanel.Location = new System.Drawing.Point(778, 19);
            this.receiptPanel.Name = "receiptPanel";
            this.receiptPanel.Size = new System.Drawing.Size(231, 107);
            this.receiptPanel.TabIndex = 0;
            this.receiptPanel.Click += new System.EventHandler(this.receiptMenu_Click);
            this.receiptPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.receiptPanel_Paint);
            // 
            // receiptLabel
            // 
            this.receiptLabel.AutoSize = true;
            this.receiptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.ForeColor = System.Drawing.Color.DarkMagenta;
            this.receiptLabel.Location = new System.Drawing.Point(1, 34);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(230, 37);
            this.receiptLabel.TabIndex = 0;
            this.receiptLabel.Text = "Tanda Terima";
            this.receiptLabel.Click += new System.EventHandler(this.receiptMenu_Click);
            // 
            // supplyPanel
            // 
            this.supplyPanel.BackColor = System.Drawing.Color.Goldenrod;
            this.supplyPanel.Controls.Add(this.supplyLabel);
            this.supplyPanel.Location = new System.Drawing.Point(22, 19);
            this.supplyPanel.Name = "supplyPanel";
            this.supplyPanel.Size = new System.Drawing.Size(231, 107);
            this.supplyPanel.TabIndex = 0;
            this.supplyPanel.Click += new System.EventHandler(this.supplyMenu_Click);
            this.supplyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.supplyPanel_Paint);
            // 
            // supplyLabel
            // 
            this.supplyLabel.AutoSize = true;
            this.supplyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplyLabel.ForeColor = System.Drawing.Color.Yellow;
            this.supplyLabel.Location = new System.Drawing.Point(73, 34);
            this.supplyLabel.Name = "supplyLabel";
            this.supplyLabel.Size = new System.Drawing.Size(85, 37);
            this.supplyLabel.TabIndex = 0;
            this.supplyLabel.Text = "Stok";
            this.supplyLabel.Click += new System.EventHandler(this.supplyMenu_Click);
            // 
            // orderPanel
            // 
            this.orderPanel.BackColor = System.Drawing.Color.DarkSalmon;
            this.orderPanel.Controls.Add(this.orderLabel);
            this.orderPanel.Location = new System.Drawing.Point(275, 19);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(231, 107);
            this.orderPanel.TabIndex = 0;
            this.orderPanel.Click += new System.EventHandler(this.deliveryMenu_Click);
            this.orderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.orderPanel_Paint);
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.orderLabel.Location = new System.Drawing.Point(22, 34);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(191, 37);
            this.orderLabel.TabIndex = 0;
            this.orderLabel.Text = "Surat Jalan";
            this.orderLabel.Click += new System.EventHandler(this.deliveryMenu_Click);
            // 
            // attendancePanel
            // 
            this.attendancePanel.BackColor = System.Drawing.Color.IndianRed;
            this.attendancePanel.Controls.Add(this.attendanceLabel);
            this.attendancePanel.Location = new System.Drawing.Point(522, 19);
            this.attendancePanel.Name = "attendancePanel";
            this.attendancePanel.Size = new System.Drawing.Size(231, 107);
            this.attendancePanel.TabIndex = 0;
            this.attendancePanel.Click += new System.EventHandler(this.attendanceMenu_Click);
            // 
            // attendanceLabel
            // 
            this.attendanceLabel.AutoSize = true;
            this.attendanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendanceLabel.ForeColor = System.Drawing.Color.Maroon;
            this.attendanceLabel.Location = new System.Drawing.Point(63, 34);
            this.attendanceLabel.Name = "attendanceLabel";
            this.attendanceLabel.Size = new System.Drawing.Size(113, 37);
            this.attendanceLabel.TabIndex = 0;
            this.attendanceLabel.Text = "Absen";
            this.attendanceLabel.Visible = false;
            this.attendanceLabel.Click += new System.EventHandler(this.attendanceMenu_Click);
            // 
            // salaryPanel
            // 
            this.salaryPanel.BackColor = System.Drawing.Color.Chartreuse;
            this.salaryPanel.Controls.Add(this.salaryLabel);
            this.salaryPanel.Location = new System.Drawing.Point(274, 19);
            this.salaryPanel.Name = "salaryPanel";
            this.salaryPanel.Size = new System.Drawing.Size(231, 107);
            this.salaryPanel.TabIndex = 0;
            this.salaryPanel.Click += new System.EventHandler(this.salaryMenu_Click);
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.BackColor = System.Drawing.Color.Chartreuse;
            this.salaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.salaryLabel.Location = new System.Drawing.Point(78, 34);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(78, 37);
            this.salaryLabel.TabIndex = 0;
            this.salaryLabel.Text = "Gaji";
            this.salaryLabel.Visible = false;
            this.salaryLabel.Click += new System.EventHandler(this.salaryMenu_Click);
            // 
            // employeePanel
            // 
            this.employeePanel.BackColor = System.Drawing.Color.Indigo;
            this.employeePanel.Controls.Add(this.employeeLabel);
            this.employeePanel.Location = new System.Drawing.Point(21, 19);
            this.employeePanel.Name = "employeePanel";
            this.employeePanel.Size = new System.Drawing.Size(231, 107);
            this.employeePanel.TabIndex = 0;
            this.employeePanel.Click += new System.EventHandler(this.employeeMenu_Click);
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLabel.ForeColor = System.Drawing.Color.Violet;
            this.employeeLabel.Location = new System.Drawing.Point(34, 34);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(167, 37);
            this.employeeLabel.TabIndex = 0;
            this.employeeLabel.Text = "Karyawan";
            this.employeeLabel.Visible = false;
            this.employeeLabel.Click += new System.EventHandler(this.employeeMenu_Click);
            // 
            // accountPanel
            // 
            this.accountPanel.BackColor = System.Drawing.Color.Pink;
            this.accountPanel.Controls.Add(this.accountLabel);
            this.accountPanel.Location = new System.Drawing.Point(790, 330);
            this.accountPanel.Name = "accountPanel";
            this.accountPanel.Size = new System.Drawing.Size(231, 107);
            this.accountPanel.TabIndex = 0;
            this.accountPanel.Click += new System.EventHandler(this.accountMenu_Click);
            this.accountPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.accountPanel_Paint);
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLabel.ForeColor = System.Drawing.Color.Crimson;
            this.accountLabel.Location = new System.Drawing.Point(17, 34);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(199, 37);
            this.accountLabel.TabIndex = 0;
            this.accountLabel.Text = "Kelola Akun";
            this.accountLabel.Click += new System.EventHandler(this.accountMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(523, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 107);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.invoicesMenu_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(59, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faktur";
            this.label1.Click += new System.EventHandler(this.invoicesMenu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(275, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 107);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.purchaseMenu_Click);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(-1, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pembelanjaan";
            this.label2.Click += new System.EventHandler(this.purchaseMenu_Click);
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.productionPanel);
            this.groupbox1.Controls.Add(this.receiptPanel);
            this.groupbox1.Controls.Add(this.panel1);
            this.groupbox1.Controls.Add(this.orderPanel);
            this.groupbox1.Location = new System.Drawing.Point(12, 12);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(1030, 137);
            this.groupbox1.TabIndex = 1;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Kerjaan";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.employeePanel);
            this.groupBox2.Controls.Add(this.salaryPanel);
            this.groupBox2.Controls.Add(this.attendancePanel);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(13, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 149);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coming Soon";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.supplyPanel);
            this.groupBox3.Location = new System.Drawing.Point(12, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(527, 142);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gudang";
            // 
            // customerPanel
            // 
            this.customerPanel.BackColor = System.Drawing.Color.Yellow;
            this.customerPanel.Controls.Add(this.customerLabel);
            this.customerPanel.Location = new System.Drawing.Point(790, 175);
            this.customerPanel.Name = "customerPanel";
            this.customerPanel.Size = new System.Drawing.Size(231, 107);
            this.customerPanel.TabIndex = 0;
            this.customerPanel.Click += new System.EventHandler(this.customerMenu_Click);
            this.customerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.customerPanel_Paint);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.customerLabel.Location = new System.Drawing.Point(17, 34);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(200, 37);
            this.customerLabel.TabIndex = 0;
            this.customerLabel.Text = "Perusahaan";
            this.customerLabel.Click += new System.EventHandler(this.customerMenu_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleGreen;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(535, 330);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 107);
            this.panel3.TabIndex = 0;
            this.panel3.Click += new System.EventHandler(this.pettyCash_Click);
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(26, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Petty Cash";
            this.label3.Click += new System.EventHandler(this.pettyCash_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 485);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.customerPanel);
            this.Controls.Add(this.accountPanel);
            this.Name = "MenuForm";
            this.Text = "Menu Utama";
            this.productionPanel.ResumeLayout(false);
            this.productionPanel.PerformLayout();
            this.receiptPanel.ResumeLayout(false);
            this.receiptPanel.PerformLayout();
            this.supplyPanel.ResumeLayout(false);
            this.supplyPanel.PerformLayout();
            this.orderPanel.ResumeLayout(false);
            this.orderPanel.PerformLayout();
            this.attendancePanel.ResumeLayout(false);
            this.attendancePanel.PerformLayout();
            this.salaryPanel.ResumeLayout(false);
            this.salaryPanel.PerformLayout();
            this.employeePanel.ResumeLayout(false);
            this.employeePanel.PerformLayout();
            this.accountPanel.ResumeLayout(false);
            this.accountPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupbox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.customerPanel.ResumeLayout(false);
            this.customerPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel productionPanel;
        private System.Windows.Forms.Label productionLabel;
        private System.Windows.Forms.Panel receiptPanel;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Panel supplyPanel;
        private System.Windows.Forms.Label supplyLabel;
        private System.Windows.Forms.Panel orderPanel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Panel attendancePanel;
        private System.Windows.Forms.Label attendanceLabel;
        private System.Windows.Forms.Panel salaryPanel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Panel employeePanel;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Panel accountPanel;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel customerPanel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
    }
}