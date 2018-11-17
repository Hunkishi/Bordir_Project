namespace BordiProject
{
    partial class CustomerMenuForm
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
            this.productionPanel.Location = new System.Drawing.Point(8, 12);
            this.productionPanel.Name = "productionPanel";
            this.productionPanel.Size = new System.Drawing.Size(231, 107);
            this.productionPanel.TabIndex = 3;
            this.productionPanel.Click += new System.EventHandler(this.productionLabel_Click);
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
            this.productionLabel.Click += new System.EventHandler(this.productionLabel_Click);
            // 
            // receiptPanel
            // 
            this.receiptPanel.BackColor = System.Drawing.Color.Violet;
            this.receiptPanel.Controls.Add(this.receiptLabel);
            this.receiptPanel.Location = new System.Drawing.Point(261, 12);
            this.receiptPanel.Name = "receiptPanel";
            this.receiptPanel.Size = new System.Drawing.Size(231, 107);
            this.receiptPanel.TabIndex = 4;
            this.receiptPanel.Click += new System.EventHandler(this.receiptLabel_Click);
            this.receiptPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.receiptPanel_Paint);
            // 
            // receiptLabel
            // 
            this.receiptLabel.AutoSize = true;
            this.receiptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.ForeColor = System.Drawing.Color.DarkMagenta;
            this.receiptLabel.Location = new System.Drawing.Point(70, 34);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(89, 37);
            this.receiptLabel.TabIndex = 0;
            this.receiptLabel.Text = "Data";
            this.receiptLabel.Click += new System.EventHandler(this.receiptLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(515, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 107);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.label1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(70, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ubah";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CustomerMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 144);
            this.Controls.Add(this.productionPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.receiptPanel);
            this.Name = "CustomerMenuForm";
            this.Text = "Perusahaan";
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