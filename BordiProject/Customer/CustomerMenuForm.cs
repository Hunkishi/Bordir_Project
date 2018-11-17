using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BordiProject
{
    public partial class CustomerMenuForm : Form
    {
        public void openForm(Form x)
        {
            x.ShowDialog();
            this.Show();
        }

        public CustomerMenuForm()
        {
            InitializeComponent();
        }

        private void productionPanel_Paint(object sender, PaintEventArgs e)
        {
            //using (var conn = new sqlconnection(globalvariable.builder))
            //{
            //    conn.open();
            //    string query = "select * from userrole where userid = @userid and roleid = 'cus1'";
            //    using (var cmd = new sqlcommand(query, conn))
            //    {
            //        cmd.parameters.addwithvalue("@userid", globalvariable.loginuserid);
            //        if (cmd.executescalar() == null)
            //        {
            //            productionlabel.text = "";
            //            productionpanel.enabled = false;
            //        }
            //    }
            //    conn.close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT * FROM UserRole WHERE userID = @userID AND roleID = 'CUS1'";
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
            //    String query = "SELECT * FROM UserRole WHERE userID = @userID AND roleID = 'CUS2'";
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
                String query = "SELECT * FROM UserRole WHERE userID = @userID AND roleID = 'CUS2'";
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT * FROM UserRole WHERE userID = @userID AND roleID = 'CUS3'";
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
                String query = "SELECT * FROM UserRole WHERE userID = @userID AND roleID = 'CUS3'";
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

        private void receiptLabel_Click(object sender, EventArgs e)
        {
            openForm(new CustomerDataForm());
        }

        private void productionLabel_Click(object sender, EventArgs e)
        {
            openForm(new CustomerInsertForm());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            openForm(new CustomerChangeForm());
        }

    }
}
