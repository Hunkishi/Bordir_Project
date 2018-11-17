using BordiProject.PettyCash;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BordiProject
{
    public partial class MenuForm : Form
    {
        public void openForm(Form x)
        {
            x.ShowDialog();
            this.Show();
        }

        public MenuForm()
        {
            InitializeComponent();
        }

        private void productionMenu_Click(object sender, EventArgs e)
        {
            openForm(new ProductionMenuForm());
        }

        private void receiptMenu_Click(object sender, EventArgs e)
        {
            openForm(new MenuReceiptForm());
        }

        private void deliveryMenu_Click(object sender, EventArgs e)
        {
            openForm(new DeliveryMenuForm());
        }

        private void supplyMenu_Click(object sender, EventArgs e)
        {
            openForm(new SupplyMenuForm());
        }

        private void attendanceMenu_Click(object sender, EventArgs e)
        {
            openForm(new AttendanceForm());
        }

        private void salaryMenu_Click(object sender, EventArgs e)
        {
            openForm(new SalaryForm());
        }

        private void employeeMenu_Click(object sender, EventArgs e)
        {
            openForm(new EmployeeForm());
        }

        private void accountMenu_Click(object sender, EventArgs e)
        {
            openForm(new AccountForm());
        }

        private void invoicesMenu_Click(object sender, EventArgs e)
        {
            openForm(new InvoicesMenuForm());
        }

        private void purchaseMenu_Click(object sender, EventArgs e)
        {
            openForm(new PurchaseOrderMenuForm());
        }

        private void customerMenu_Click(object sender, EventArgs e)
        {
            openForm(new CustomerMenuForm());
        }

        private void pettyCash_Click(object sender, EventArgs e)
        {
            openForm(new PettyCashMenuForm());
        }

        private void productionPanel_Paint(object sender, PaintEventArgs e)
        {
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT * FROM UserRole WHERE userID = @userID AND (roleID = 'PRO1' OR roleID = 'PRO2')";
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
                String query = "SELECT * FROM UserRole WHERE userID = @userID AND (roleID = 'PRO1' OR roleID = 'PRO2')";
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

        private void orderPanel_Paint(object sender, PaintEventArgs e)
        {
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT * FROM UserRole WHERE userID = @userID AND (roleID = 'ORD1' OR roleID = 'ORD2')";
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
                String query = "SELECT * FROM UserRole WHERE userID = @userID AND (roleID = 'ORD1' OR roleID = 'ORD2')";
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT * FROM UserRole WHERE userID = @userID AND (roleID = 'INV1' OR roleID = 'INV2')";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@userID", GlobalVariable.loginUserId);
            //        if (cmd.ExecuteScalar() == null)
            //        {
            //            label1.Text = "";
            //            panel1.Enabled = false;
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT * FROM UserRole WHERE userID = @userID AND (roleID = 'INV1' OR roleID = 'INV2')";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", GlobalVariable.loginUserId);
                    if (cmd.ExecuteScalar() == null)
                    {
                        label1.Text = "";
                        panel1.Enabled = false;
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
            //    String query = "SELECT * FROM UserRole WHERE userID = @userID AND (roleID = 'REC1' OR roleID = 'REC2')";
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
                String query = "SELECT * FROM UserRole WHERE userID = @userID AND (roleID = 'REC1' OR roleID = 'REC2')";
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

        private void supplyPanel_Paint(object sender, PaintEventArgs e)
        {
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT * FROM UserRole WHERE userID = @userID AND (roleID = 'STO1' OR roleID = 'STO2')";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@userID", GlobalVariable.loginUserId);
            //        if (cmd.ExecuteScalar() == null)
            //        {
            //            supplyLabel.Text = "";
            //            supplyPanel.Enabled = false;
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT * FROM UserRole WHERE userID = @userID AND (roleID = 'STO1' OR roleID = 'STO2')";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", GlobalVariable.loginUserId);
                    if (cmd.ExecuteScalar() == null)
                    {
                        supplyLabel.Text = "";
                        supplyPanel.Enabled = false;
                    }
                }
                conn.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT * FROM UserRole WHERE userID = @userID AND (roleID = 'PUR1' OR roleID = 'PUR2' OR roleID = 'PUR3')";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@userID", GlobalVariable.loginUserId);
            //        if (cmd.ExecuteScalar() == null)
            //        {
            //            label2.Text = "";
            //            panel2.Enabled = false;
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT * FROM UserRole WHERE userID = @userID AND (roleID = 'PUR1' OR roleID = 'PUR2' OR roleID = 'PUR3')";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", GlobalVariable.loginUserId);
                    if (cmd.ExecuteScalar() == null)
                    {
                        label2.Text = "";
                        panel2.Enabled = false;
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
            //    String query = "SELECT * FROM UserRole WHERE userID = @userID AND (roleID = 'CUS1' OR roleID = 'CUS2')";
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
                String query = "SELECT * FROM UserRole WHERE userID = @userID AND (roleID = 'CUS1' OR roleID = 'CUS2')";
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

        private void accountPanel_Paint(object sender, PaintEventArgs e)
        {
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT * FROM UserRole WHERE userID = @userID AND roleID = 'USR' ";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@userID", GlobalVariable.loginUserId);
            //        if (cmd.ExecuteScalar() == null)
            //        {
            //            accountLabel.Text = "";
            //            accountPanel.Enabled = false;
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT * FROM UserRole WHERE userID = @userID AND roleID = 'USR' ";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", GlobalVariable.loginUserId);
                    if (cmd.ExecuteScalar() == null)
                    {
                        accountLabel.Text = "";
                        accountPanel.Enabled = false;
                    }
                }
                conn.Close();
            }
        }
    }
}
