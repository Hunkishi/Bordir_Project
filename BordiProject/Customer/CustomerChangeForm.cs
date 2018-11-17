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
    public partial class CustomerChangeForm : Form
    {
        private void resetHistory()
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            textBox6.Text = textBox1.Text = richTextBox1.Text = "";
            checkBox1.Checked = checkBox2.Checked = false;
            groupBox5.Enabled = false;
        }

        public CustomerChangeForm()
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
            //                textBox6.Text = reader["nameCustomer"].ToString();
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
                            textBox6.Text = reader["nameCustomer"].ToString();
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
            groupBox5.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<String> temp = new List<String> { (dataGridView2.Rows.Count + 1).ToString(), textBox3.Text,
                textBox4.Text, textBox5.Text };
            dataGridView2.Rows.Add(temp.ToArray());
            textBox4.Text = textBox3.Text = textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox2.Text);
            textBox2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resetHistory();
            //using (SqlConnection conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    int customerID;
            //    String query = "SELECT * FROM Customer WHERE nameCustomer = @nameCustomer";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@nameCustomer", comboBox1.Text);
            //        if (cmd.ExecuteScalar() == null)
            //        {
            //            MessageBox.Show("Perusahaan tidak ditemukan");
            //            return;
            //        }
            //        customerID = (int)cmd.ExecuteScalar();
            //    }
            //    query = "DELETE FROM CustomerContactPerson WHERE customerID = @customerID";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@customerID", customerID);
            //        cmd.ExecuteNonQuery();
            //    }
            //    query = "DELETE FROM CustomerTelephone WHERE customerID = @customerID";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@customerID", customerID);
            //        cmd.ExecuteNonQuery();
            //    }
            //    query = "DELETE FROM Customer WHERE customerID = @customerID";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@customerID", customerID);
            //        cmd.ExecuteNonQuery();
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                int customerID;
                String query = "SELECT * FROM Customer WHERE nameCustomer = @nameCustomer";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nameCustomer", comboBox1.Text);
                    if (cmd.ExecuteScalar() == null)
                    {
                        MessageBox.Show("Perusahaan tidak ditemukan");
                        return;
                    }
                    customerID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                query = "DELETE FROM CustomerContactPerson WHERE customerID = @customerID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customerID", customerID);
                    cmd.ExecuteNonQuery();
                }
                query = "DELETE FROM CustomerTelephone WHERE customerID = @customerID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customerID", customerID);
                    cmd.ExecuteNonQuery();
                }
                query = "DELETE FROM Customer WHERE customerID = @customerID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customerID", customerID);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            GlobalVariable.comboBoxLoadItem(ref comboBox1, "nameCustomer", "Customer");
            MessageBox.Show("Data Berhasil Dihapus");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //input nama perusahaan
            if (textBox6.Text == "")
            {
                MessageBox.Show("Nama Perusahaan tidak boleh kosong");
                return;
            }
            String nameCustomer = textBox6.Text;
            //input nomor telepon
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nomor telepon tidak boleh kosong");
                return;
            }
            //input contact person
            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("Contact Person tidak boleh kosong");
                return;
            }
            //input No Fax
            String fax = textBox1.Text;
            //input Customer
            String isCustomer = (checkBox1.Checked) ? "YES" : "NO";
            //input Supplier
            String isSupplier = (checkBox2.Checked) ? "YES" : "NO";
            //input Address
            String address = richTextBox1.Text;
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    //Get customerID
            //    String query = "SELECT customerID FROM Customer WHERE nameCustomer = @nameCustomer;";
            //    int customerID;
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@nameCustomer", nameCustomer);
            //        if (cmd.ExecuteScalar() == null)
            //        {
            //            MessageBox.Show("Perusahaan tidak terdapat pada database");
            //            return;
            //        }
            //        customerID = (int)cmd.ExecuteScalar();
            //    }
            //    query = "DELETE FROM CustomerContactPerson WHERE customerID = @customerID";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@customerID", customerID);
            //        cmd.ExecuteNonQuery();
            //    }
            //    query = "DELETE FROM CustomerTelephone WHERE customerID = @customerID";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@customerID", customerID);
            //        cmd.ExecuteNonQuery();
            //    }
            //    //Update Customer
            //    query = @"UPDATE Customer SET nameCustomer = @nameCustomer, address = @address,
            //        supplier = @supplier, customer = @customer, fax = @fax WHERE customerID = @customerID";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@nameCustomer", nameCustomer);
            //        cmd.Parameters.AddWithValue("@address", address);
            //        cmd.Parameters.AddWithValue("@supplier", isSupplier);
            //        cmd.Parameters.AddWithValue("@customer", isCustomer);
            //        cmd.Parameters.AddWithValue("@fax", fax);
            //        cmd.Parameters.AddWithValue("@customerID", customerID);
            //        cmd.ExecuteNonQuery();
            //    }
            //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //    {
            //        String values = dataGridView1[0, i].Value.ToString();
            //        query = "INSERT INTO CustomerTelephone (customerID,telephone) VALUES (@customerID,@telephone);";
            //        using (var cmd = new SqlCommand(query, conn))
            //        {
            //            cmd.Parameters.AddWithValue("@customerID", customerID);
            //            cmd.Parameters.AddWithValue("@telephone", values);
            //            cmd.ExecuteNonQuery();
            //        }
            //    }
            //    for (int i = 0; i < dataGridView2.Rows.Count; i++)
            //    {
            //        List<String> values = new List<String>();
            //        for (int j = 1; j < dataGridView2.Columns.Count; j++)
            //        {
            //            String temp = dataGridView2[j, i].Value.ToString();
            //            values.Add(temp);
            //        }
            //        query = "INSERT INTO CustomerContactPerson (customerID,name,hp,ext) VALUES (@customerID,@name,@hp,@ext);";
            //        using (var cmd = new SqlCommand(query, conn))
            //        {
            //            cmd.Parameters.AddWithValue("@customerID", customerID);
            //            cmd.Parameters.AddWithValue("@name", values[0]);
            //            cmd.Parameters.AddWithValue("@hp", values[1]);
            //            cmd.Parameters.AddWithValue("@ext", values[2]);
            //            cmd.ExecuteNonQuery();
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                //Get customerID
                String query = "SELECT customerID FROM Customer WHERE nameCustomer = @nameCustomer;";
                int customerID;
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nameCustomer", nameCustomer);
                    if (cmd.ExecuteScalar() == null)
                    {
                        MessageBox.Show("Perusahaan tidak terdapat pada database");
                        return;
                    }
                    customerID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                query = "DELETE FROM CustomerContactPerson WHERE customerID = @customerID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customerID", customerID);
                    cmd.ExecuteNonQuery();
                }
                query = "DELETE FROM CustomerTelephone WHERE customerID = @customerID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customerID", customerID);
                    cmd.ExecuteNonQuery();
                }
                //Update Customer
                query = @"UPDATE Customer SET nameCustomer = @nameCustomer, address = @address,
                        supplier = @supplier, customer = @customer, fax = @fax WHERE customerID = @customerID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nameCustomer", nameCustomer);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@supplier", isSupplier);
                    cmd.Parameters.AddWithValue("@customer", isCustomer);
                    cmd.Parameters.AddWithValue("@fax", fax);
                    cmd.Parameters.AddWithValue("@customerID", customerID);
                    cmd.ExecuteNonQuery();
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    String values = dataGridView1[0, i].Value.ToString();
                    query = "INSERT INTO CustomerTelephone (customerID,telephone) VALUES (@customerID,@telephone);";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerID", customerID);
                        cmd.Parameters.AddWithValue("@telephone", values);
                        cmd.ExecuteNonQuery();
                    }
                }
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    List<String> values = new List<String>();
                    for (int j = 1; j < dataGridView2.Columns.Count; j++)
                    {
                        String temp = dataGridView2[j, i].Value.ToString();
                        values.Add(temp);
                    }
                    query = "INSERT INTO CustomerContactPerson (customerID,name,hp,ext) VALUES (@customerID,@name,@hp,@ext);";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerID", customerID);
                        cmd.Parameters.AddWithValue("@name", values[0]);
                        cmd.Parameters.AddWithValue("@hp", values[1]);
                        cmd.Parameters.AddWithValue("@ext", values[2]);
                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
            MessageBox.Show("Data Berhasil Diubah");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetHistory();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            resetHistory();
        }
    }
}
