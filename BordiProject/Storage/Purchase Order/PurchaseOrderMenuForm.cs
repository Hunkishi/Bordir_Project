using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BordiProject
{
    public partial class PurchaseOrderMenuForm : Form
    {
        public void openForm(Form x)
        {
            x.ShowDialog();
            this.Show();
        }

        public PurchaseOrderMenuForm()
        {
            InitializeComponent();
        }

        private void historyPurchaseOrder_Click(object sender, EventArgs e)
        {
            openForm(new PurchaseOrderHistoryForm());
        }

        private void insertPurchaseOrder_Click(object sender, EventArgs e)
        {
            openForm(new PurchaseOrderInsertForm());
        }

        private void productionPanel_Paint(object sender, PaintEventArgs e)
        {
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT * FROM UserRole WHERE userID = @userID AND roleID = 'PUR1'";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@userID", GlobalVariable.loginUserId);
            //        if (cmd.ExecuteScalar() == null)
            //        {
            //            productionLabel.Text = "";
            //            productionPanel.Enabled = false;
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT * FROM UserRole WHERE userID = @userID AND roleID = 'PUR1'";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", GlobalVariable.loginUserId);
                    if (cmd.ExecuteScalar() == null)
                    {
                        productionLabel.Text = "";
                        productionPanel.Enabled = false;
                    }
                }
                conn.Close();
            }
        }

        private void receiptPanel_Paint(object sender, PaintEventArgs e)
        {
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT * FROM UserRole WHERE userID = @userID AND roleID = 'PUR2'";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@userID", GlobalVariable.loginUserId);
            //        if (cmd.ExecuteScalar() == null)
            //        {
            //            receiptLabel.Text = "";
            //            receiptPanel.Enabled = false;
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT * FROM UserRole WHERE userID = @userID AND roleID = 'PUR2'";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", GlobalVariable.loginUserId);
                    if (cmd.ExecuteScalar() == null)
                    {
                        receiptLabel.Text = "";
                        receiptPanel.Enabled = false;
                    }
                }
                conn.Close();
            }
        }

        private void orderLabel_Click(object sender, EventArgs e)
        {
            openForm(new PurchaseOrderChangeForm());
        }

        private void orderPanel_Paint(object sender, PaintEventArgs e)
        {
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT * FROM UserRole WHERE userID = @userID AND roleID = 'PUR3'";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@userID", GlobalVariable.loginUserId);
            //        if (cmd.ExecuteScalar() == null)
            //        {
            //            orderLabel.Text = "";
            //            orderPanel.Enabled = false;
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT * FROM UserRole WHERE userID = @userID AND roleID = 'PUR3'";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", GlobalVariable.loginUserId);
                    if (cmd.ExecuteScalar() == null)
                    {
                        orderLabel.Text = "";
                        orderPanel.Enabled = false;
                    }
                }
                conn.Close();
            }
        }
    }
}
