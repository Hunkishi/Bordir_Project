namespace BordiProject.PettyCash
{
    partial class PettyCashMenuForm
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
            this.attendancePanel = new System.Windows.Forms.Panel();
            this.attendanceLabel = new System.Windows.Forms.Label();
            this.customerPanel = new System.Windows.Forms.Panel();
            this.customerLabel = new System.Windows.Forms.Label();
            this.attendancePanel.SuspendLayout();
            this.customerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // attendancePanel
            // 
            this.attendancePanel.BackColor = System.Drawing.Color.IndianRed;
            this.attendancePanel.Controls.Add(this.attendanceLabel);
            this.attendancePanel.Location = new System.Drawing.Point(12, 14);
            this.attendancePanel.Name = "attendancePanel";
            this.attendancePanel.Size = new System.Drawing.Size(231, 107);
            this.attendancePanel.TabIndex = 4;
            this.attendancePanel.Click += new System.EventHandler(this.attendanceLabel_Click);
            // 
            // attendanceLabel
            // 
            this.attendanceLabel.AutoSize = true;
            this.attendanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendanceLabel.ForeColor = System.Drawing.Color.Maroon;
            this.attendanceLabel.Location = new System.Drawing.Point(44, 34);
            this.attendanceLabel.Name = "attendanceLabel";
            this.attendanceLabel.Size = new System.Drawing.Size(142, 37);
            this.attendanceLabel.TabIndex = 0;
            this.attendanceLabel.Text = "Tambah";
            this.attendanceLabel.Click += new System.EventHandler(this.attendanceLabel_Click);
            // 
            // customerPanel
            // 
            this.customerPanel.BackColor = System.Drawing.Color.Yellow;
            this.customerPanel.Controls.Add(this.customerLabel);
            this.customerPanel.Location = new System.Drawing.Point(259, 14);
            this.customerPanel.Name = "customerPanel";
            this.customerPanel.Size = new System.Drawing.Size(231, 107);
            this.customerPanel.TabIndex = 3;
            this.customerPanel.Click += new System.EventHandler(this.customerLabel_Click);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Enabled = false;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.customerLabel.Location = new System.Drawing.Point(49, 34);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(136, 37);
            this.customerLabel.TabIndex = 0;
            this.customerLabel.Text = "Riwayat";
            this.customerLabel.Click += new System.EventHandler(this.customerLabel_Click);
            // 
            // PettyCashMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 133);
            this.Controls.Add(this.customerPanel);
            this.Controls.Add(this.attendancePanel);
            this.Name = "PettyCashMenuForm";
            this.Text = "Petty Cash";
            this.attendancePanel.ResumeLayout(false);
            this.attendancePanel.PerformLayout();
            this.customerPanel.ResumeLayout(false);
            this.customerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel attendancePanel;
        private System.Windows.Forms.Label attendanceLabel;
        private System.Windows.Forms.Panel customerPanel;
        private System.Windows.Forms.Label customerLabel;
    }
}