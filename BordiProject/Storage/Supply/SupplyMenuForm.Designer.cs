namespace BordiProject
{
    partial class SupplyMenuForm
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
            this.orderPanel = new System.Windows.Forms.Panel();
            this.orderLabel = new System.Windows.Forms.Label();
            this.productionPanel.SuspendLayout();
            this.receiptPanel.SuspendLayout();
            this.orderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // productionPanel
            // 
            this.productionPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.productionPanel.Controls.Add(this.productionLabel);
            this.productionPanel.Location = new System.Drawing.Point(11, 12);
            this.productionPanel.Name = "productionPanel";
            this.productionPanel.Size = new System.Drawing.Size(231, 107);
            this.productionPanel.TabIndex = 1;
            this.productionPanel.Click += new System.EventHandler(this.insertSupply_Click);
            this.productionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.productionPanel_Paint);
            // 
            // productionLabel
            // 
            this.productionLabel.AutoSize = true;
            this.productionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionLabel.ForeColor = System.Drawing.Color.Navy;
            this.productionLabel.Location = new System.Drawing.Point(40, 34);
            this.productionLabel.Name = "productionLabel";
            this.productionLabel.Size = new System.Drawing.Size(142, 37);
            this.productionLabel.TabIndex = 0;
            this.productionLabel.Text = "Tambah";
            this.productionLabel.Click += new System.EventHandler(this.insertSupply_Click);
            // 
            // receiptPanel
            // 
            this.receiptPanel.BackColor = System.Drawing.Color.Violet;
            this.receiptPanel.Controls.Add(this.receiptLabel);
            this.receiptPanel.Location = new System.Drawing.Point(264, 12);
            this.receiptPanel.Name = "receiptPanel";
            this.receiptPanel.Size = new System.Drawing.Size(231, 107);
            this.receiptPanel.TabIndex = 2;
            this.receiptPanel.Click += new System.EventHandler(this.historySupply_Click);
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
            this.receiptLabel.Click += new System.EventHandler(this.historySupply_Click);
            // 
            // orderPanel
            // 
            this.orderPanel.BackColor = System.Drawing.Color.DarkSalmon;
            this.orderPanel.Controls.Add(this.orderLabel);
            this.orderPanel.Location = new System.Drawing.Point(512, 12);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(231, 107);
            this.orderPanel.TabIndex = 3;
            this.orderPanel.Click += new System.EventHandler(this.changeSupply_Click);
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.orderLabel.Location = new System.Drawing.Point(67, 34);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(98, 37);
            this.orderLabel.TabIndex = 0;
            this.orderLabel.Text = "Ubah";
            this.orderLabel.Click += new System.EventHandler(this.changeSupply_Click);
            // 
            // SupplyMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 144);
            this.Controls.Add(this.productionPanel);
            this.Controls.Add(this.receiptPanel);
            this.Controls.Add(this.orderPanel);
            this.Name = "SupplyMenuForm";
            this.Text = " Stok";
            this.productionPanel.ResumeLayout(false);
            this.productionPanel.PerformLayout();
            this.receiptPanel.ResumeLayout(false);
            this.receiptPanel.PerformLayout();
            this.orderPanel.ResumeLayout(false);
            this.orderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel productionPanel;
        private System.Windows.Forms.Label productionLabel;
        private System.Windows.Forms.Panel receiptPanel;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Panel orderPanel;
        private System.Windows.Forms.Label orderLabel;
    }
}