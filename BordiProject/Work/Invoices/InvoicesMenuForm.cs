using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BordiProject
{
    public partial class InvoicesMenuForm : Form
    {
        public void openForm(Form x)
        {
            x.ShowDialog();
            this.Show();
        }

        public InvoicesMenuForm()
        {
            InitializeComponent();
        }

        private void insertInvoices_Click(object sender, EventArgs e)
        {
            openForm(new InvoicesInsertForm());
        }

        private void customerMenu_Click(object sender, EventArgs e)
        {
            openForm(new InvoicesHistoryForm());
        }

        private void attendancePanel_Paint(object sender, PaintEventArgs e)
        {
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT * FROM UserRole WHERE userID = @userID AND roleID = 'INV1'";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@userID", GlobalVariable.loginUserId);
            //        if (cmd.ExecuteScalar() == null)
            //        {
            //            attendanceLabel.Text = "";
            //            attendancePanel.Enabled = false;
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT * FROM UserRole WHERE userID = @userID AND roleID = 'INV1'";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", GlobalVariable.loginUserId);
                    if (cmd.ExecuteScalar() == null)
                    {
                        attendanceLabel.Text = "";
                        attendancePanel.Enabled = false;
                    }
                }
                conn.Close();
            }
        }

        private void customerPanel_Paint(object sender, PaintEventArgs e)
        {
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT * FROM UserRole WHERE userID = @userID AND roleID = 'INV2'";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@userID", GlobalVariable.loginUserId);
            //        if (cmd.ExecuteScalar() == null)
            //        {
            //            customerLabel.Text = "";
            //            customerPanel.Enabled = false;
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT * FROM UserRole WHERE userID = @userID AND roleID = 'INV2'";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", GlobalVariable.loginUserId);
                    if (cmd.ExecuteScalar() == null)
                    {
                        customerLabel.Text = "";
                        customerPanel.Enabled = false;
                    }
                }
                conn.Close();
            }
        }
    }
}
