using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BordiProject
{
    public partial class CustomerDataForm : Form
    {
        private void resetHistory()
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            textBox1.Text = richTextBox1.Text = "";
            checkBox1.Checked = checkBox2.Checked = false;
            groupBox4.Enabled = false;
        }

        public CustomerDataForm()
        {
            InitializeComponent();
            GlobalVariable.comboBoxLoadItem(ref comboBox1, "nameCustomer", "Customer");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetHistory();
            //using (SqlConnection conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT * FROM Customer WHERE nameCustomer = @nameCustomer";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@nameCustomer", comboBox1.Text);
            //        if (cmd.ExecuteScalar() == null)
            //        {
            //            MessageBox.Show("Perusahaan tidak ditemukan");
            //            return;
            //        }
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                textBox1.Text = reader["fax"].ToString();
            //                checkBox1.Checked = (reader["customer"].ToString() == "YES");
            //                checkBox2.Checked = (reader["supplier"].ToString() == "YES");
            //                richTextBox1.Text = reader["address"].ToString();
            //            }
            //        }
            //    }
            //    query = @"SELECT telephone FROM Customer[C], CustomerTelephone[CT] 
            //            WHERE C.customerID = CT.customerID AND C.nameCustomer = @nameCustomer";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@nameCustomer", comboBox1.Text);
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                dataGridView1.Rows.Add(reader["telephone"].ToString());
            //            }
            //        }
            //    }
            //    query = @"SELECT name,hp,ext FROM Customer[C], CustomerContactPerson[CCP] 
            //            WHERE C.customerID = CCP.customerID AND C.nameCustomer = @nameCustomer";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@nameCustomer", comboBox1.Text);
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                List<String> temp = new List<String>() { };
            //                temp.Add((dataGridView2.RowCount + 1).ToString());
            //                temp.Add(reader["name"].ToString());
            //                temp.Add(reader["hp"].ToString());
            //                temp.Add(reader["ext"].ToString());
            //                dataGridView2.Rows.Add(temp.ToArray());
            //            }
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT * FROM Customer WHERE nameCustomer = @nameCustomer";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nameCustomer", comboBox1.Text);
                    if (cmd.ExecuteScalar() == null)
                    {
                        MessageBox.Show("Perusahaan tidak ditemukan");
                        return;
                    }
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            textBox1.Text = reader["fax"].ToString();
                            checkBox1.Checked = (reader["customer"].ToString() == "YES");
                            checkBox2.Checked = (reader["supplier"].ToString() == "YES");
                            richTextBox1.Text = reader["address"].ToString();
                        }
                    }
                }
                query = @"SELECT telephone FROM Customer[C], CustomerTelephone[CT] 
                            WHERE C.customerID = CT.customerID AND C.nameCustomer = @nameCustomer";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nameCustomer", comboBox1.Text);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["telephone"].ToString());
                        }
                    }
                }
                query = @"SELECT name,hp,ext FROM Customer[C], CustomerContactPerson[CCP] 
                            WHERE C.customerID = CCP.customerID AND C.nameCustomer = @nameCustomer";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nameCustomer", comboBox1.Text);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            List<String> temp = new List<String>() { };
                            temp.Add((dataGridView2.RowCount + 1).ToString());
                            temp.Add(reader["name"].ToString());
                            temp.Add(reader["hp"].ToString());
                            temp.Add(reader["ext"].ToString());
                            dataGridView2.Rows.Add(temp.ToArray());
                        }
                    }
                }
                conn.Close();
            }
            groupBox4.Enabled = true;
        }
    }
}
