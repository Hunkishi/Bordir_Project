using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BordiProject
{
    public partial class CustomerInsertForm : Form
    {
        public CustomerInsertForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //input nama perusahaan
            if (textBox1.Text == "")
            {
                MessageBox.Show("Nama Perusahaan tidak boleh kosong");
                return;
            }
            String nameCustomer = textBox1.Text;
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
            String fax = textBox6.Text;
            //input Customer
            String isCustomer = (checkBox1.Checked) ? "YES" : "NO";
            //input Supplier
            String isSupplier = (checkBox2.Checked) ? "YES" : "NO";
            //input Address
            String address = richTextBox1.Text;
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    //cek perusahaan
            //    String query = "SELECT * FROM Customer WHERE nameCustomer = @nameCustomer COLLATE SQL_Latin1_General_CP1_CI_AS;";
            //    using (var cmd = new SqlCommand(query,conn))
            //    {
            //        cmd.Parameters.AddWithValue("@nameCustomer", nameCustomer);
            //        if (cmd.ExecuteScalar() != null)
            //        {
            //            MessageBox.Show("Nama perusahaan sudah terdaftar");
            //            return;
            //        }
            //    }
            //    //get customerID
            //    query = "SELECT COALESCE(COUNT(*),0) FROM Customer;";
            //    int customerID;
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        customerID = (int)cmd.ExecuteScalar()+1;
            //    }
            //    //masukkan data
            //    query = "INSERT INTO Customer (customerID,nameCustomer,address,fax,customer,supplier) VALUES (@customerID,@nameCustomer,@address,@fax,@customer,@supplier);";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@customerID", customerID);
            //        cmd.Parameters.AddWithValue("@nameCustomer", nameCustomer);
            //        cmd.Parameters.AddWithValue("@address", address);
            //        cmd.Parameters.AddWithValue("@fax", fax);
            //        cmd.Parameters.AddWithValue("@customer", isCustomer);
            //        cmd.Parameters.AddWithValue("@supplier", isSupplier);
            //        cmd.ExecuteNonQuery();
            //    }
            //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //    {
            //        String values = dataGridView1[0,i].Value.ToString();
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
                //cek perusahaan
                String query = "SELECT * FROM Customer WHERE nameCustomer = @nameCustomer;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nameCustomer", nameCustomer);
                    if (cmd.ExecuteScalar() != null)
                    {
                        MessageBox.Show("Nama perusahaan sudah terdaftar");
                        return;
                    }
                }
                //get customerID
                query = "SELECT COALESCE(COUNT(*),0) FROM Customer;";
                int customerID;
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    customerID = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                }
                //masukkan data
                query = "INSERT INTO Customer (customerID,nameCustomer,address,fax,customer,supplier) VALUES (@customerID,@nameCustomer,@address,@fax,@customer,@supplier);";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customerID", customerID);
                    cmd.Parameters.AddWithValue("@nameCustomer", nameCustomer);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@fax", fax);
                    cmd.Parameters.AddWithValue("@customer", isCustomer);
                    cmd.Parameters.AddWithValue("@supplier", isSupplier);
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
            MessageBox.Show("Data berhasil dimasukkan");
            textBox1.Text = textBox2.Text = textBox6.Text = richTextBox1.Text = "";
            textBox4.Text = textBox3.Text = textBox5.Text = "" ;
            checkBox1.Checked = true;
            checkBox2.Checked = false;
            button5_Click(sender, e);
            button3_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox2.Text);
            textBox2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
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
    }
}
