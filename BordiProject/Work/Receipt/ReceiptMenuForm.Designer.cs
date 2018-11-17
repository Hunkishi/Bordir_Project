namespace BordiProject
{
    partial class MenuReceiptForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.productionPanel.SuspendLayout();
            this.receiptPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productionPanel
            // 
            this.productionPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.productionPanel.Controls.Add(this.productionLabel);
            this.productionPanel.Location = new System.Drawing.Point(18, 12);
            this.productionPanel.Name = "productionPanel";
            this.productionPanel.Size = new System.Drawing.Size(231, 107);
            this.productionPanel.TabIndex = 1;
            this.productionPanel.Click += new System.EventHandler(this.insertReceipt_Click);
            this.productionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.productionPanel_Paint);
            // 
            // productionLabel
            // 
            this.productionLabel.AutoSize = true;
            this.productionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionLabel.ForeColor = System.Drawing.Color.Navy;
            this.productionLabel.Location = new System.Drawing.Point(47, 34);
            this.productionLabel.Name = "productionLabel";
            this.productionLabel.Size = new System.Drawing.Size(142, 37);
            this.productionLabel.TabIndex = 0;
            this.productionLabel.Text = "Tambah";
            this.productionLabel.Click += new System.EventHandler(this.insertReceipt_Click);
            // 
            // receiptPanel
            // 
            this.receiptPanel.BackColor = System.Drawing.Color.Violet;
            this.receiptPanel.Controls.Add(this.receiptLabel);
            this.receiptPanel.Location = new System.Drawing.Point(271, 12);
            this.receiptPanel.Name = "receiptPanel";
            this.receiptPanel.Size = new System.Drawing.Size(231, 107);
            this.receiptPanel.TabIndex = 2;
            this.receiptPanel.Click += new System.EventHandler(this.historyReceipt_Click);
            this.receiptPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.receiptPanel_Paint);
            // 
            // receiptLabel
            // 
            this.receiptLabel.AutoSize = true;
            this.receiptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.ForeColor = System.Drawing.Color.DarkMagenta;
            this.receiptLabel.Location = new System.Drawing.Point(50, 34);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(136, 37);
            this.receiptLabel.TabIndex = 0;
            this.receiptLabel.Text = "Riwayat";
            this.receiptLabel.Click += new System.EventHandler(this.historyReceipt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(523, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 107);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.label1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pelunasan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MenuReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 145);
            this.Controls.Add(this.productionPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.receiptPanel);
            this.Name = "MenuReceiptForm";
            this.Text = "Tanda Terima";
            this.productionPanel.ResumeLayout(false);
            this.productionPanel.PerformLayout();
            this.receiptPanel.ResumeLayout(false);
            this.receiptPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel productionPanel;
        private System.Windows.Forms.Label productionLabel;
        private System.Windows.Forms.Panel receiptPanel;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}