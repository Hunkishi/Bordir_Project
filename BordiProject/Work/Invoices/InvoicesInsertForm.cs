using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BordiProject
{
    public partial class InvoicesInsertForm : Form
    {
        private void loadComboOrder()
        {
            GlobalVariable.comboBoxLoadItem(ref comboBox1, "nameCustomer", "Customer WHERE customer = 'YES'");
            GlobalVariable.comboBoxLoadItem(ref comboBox3, "nameCustomer", "Customer WHERE customer = 'YES'");
            comboBox2.Text = "";
            GlobalVariable.comboBoxLoadItem(ref comboBox2, "orderID", @"Customer[C], 
                (SELECT orderID, buyerCustomerID FROM OrderStatus[OS],Customer[C] WHERE 
                OS.status = 'KELUAR' AND C.customerID = OS.cmtCustomerID AND C.customer = 'YES' 
                AND C.nameCustomer = '"+ comboBox3.Text + @"') AS OS2  
                WHERE C.customerID = OS2.buyerCustomerID AND C.nameCustomer = '" + comboBox1.Text + "'");
        }

        private void resetInput()
        {
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 0;
            textBox5.Text = "";
            comboBox4.SelectedIndex = 0;
        }

        public InvoicesInsertForm()
        {
            InitializeComponent();
            comboBox4.SelectedIndex = 0;
            textBox1.Text = "Rp. 0.00";
            loadComboOrder();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1 || comboBox2.Text == "")
            {
                MessageBox.Show("Tidak dapat memasukkan nomor surat jalan kosong");
                return;
            }
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1[0,i].Value.ToString() == comboBox2.Text)
                {
                    MessageBox.Show("Nomor surat jalan sudah pernah dimasukkan");
                    return;
                }
            }
            dataGridView1.Rows.Add(comboBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Referensi nomor surat jalan tidak boleh kosong");
                return;
            }
            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("Keterangan Barang tidak boleh kosong");
                return;
            }
            //input no faktur
            if (textBox2.Text == "")
            {
                MessageBox.Show("Nomor Faktur tidak boleh kosong");
                return;
            }
            if (!Regex.IsMatch(textBox2.Text, @"^\d+$"))
            {
                MessageBox.Show("Format Nomor Faktur salah");
                return;
            }
            int Number = Convert.ToInt32(textBox2.Text);
            //input customer
            String buyerCustomer = comboBox1.Text;
            String cmtCustomer = comboBox3.Text;
            //input date
            DateTime date = dateTimePicker1.Value;
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT customerID FROM Customer WHERE nameCustomer = @nameCustomer AND customer = 'YES';";
            //    int buyerCustomerID;
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@nameCustomer", buyerCustomer);
            //        buyerCustomerID = (int)cmd.ExecuteScalar();
            //    }
            //    query = "SELECT customerID FROM Customer WHERE nameCustomer = @nameCustomer AND customer = 'YES';";
            //    int cmtCustomerID;
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@nameCustomer", cmtCustomer);
            //        cmtCustomerID = (int)cmd.ExecuteScalar();
            //    }
            //    query = "INSERT INTO Invoice (invoicesID,buyerCustomerID,date,cmtCustomerID) VALUES (@invoicesID,@buyerCustomerID,@date,@cmtCustomerID);";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@invoicesID", Number);
            //        cmd.Parameters.AddWithValue("@buyerCustomerID", buyerCustomerID);
            //        cmd.Parameters.AddWithValue("@date", date);
            //        cmd.Parameters.AddWithValue("@cmtCustomerID", cmtCustomerID);
            //        cmd.ExecuteNonQuery();
            //    }
            //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //    {
            //        query = @"INSERT INTO InvoiceOrderList (invoicesID,orderID,buyerCustomerID,cmtCustomerID,status) 
            //            VALUES (@invoicesID,@orderID,@buyerCustomerID,@cmtCustomerID,@status);";
            //        using (var cmd = new SqlCommand(query, conn))
            //        {
            //            cmd.Parameters.AddWithValue("@invoicesID", Number);
            //            cmd.Parameters.AddWithValue("@orderID", dataGridView1[0,i].Value.ToString());
            //            cmd.Parameters.AddWithValue("@buyerCustomerID", buyerCustomerID);
            //            cmd.Parameters.AddWithValue("@cmtCustomerID", cmtCustomerID);
            //            cmd.Parameters.AddWithValue("@status", "KELUAR");
            //            cmd.ExecuteNonQuery();
            //        }
            //    }
            //    for (int i = 0; i < dataGridView2.Rows.Count; i++)
            //    {
            //        List<String> values = new List<String>();
            //        for (int j = 1; j < dataGridView2.Columns.Count - 1; j++)
            //        {
            //            String temp = dataGridView2[j, i].Value.ToString();
            //            if (j == 4) temp = Convert.ToInt64(Convert.ToDouble(temp.Remove(0, 4))).ToString();
            //            values.Add(temp);
            //        }
            //        query = "INSERT INTO InvoiceList (invoicesID,nameItem,price,unit,quantity) VALUES (@invoicesID,@nameItem,@price,@unit,@quantity);";
            //        using (var cmd = new SqlCommand(query, conn))
            //        {
            //            cmd.Parameters.AddWithValue("@invoicesID", Number);
            //            cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(values[0]));
            //            cmd.Parameters.AddWithValue("@nameItem", values[1]);
            //            cmd.Parameters.AddWithValue("@unit", values[2]);
            //            cmd.Parameters.AddWithValue("@price", Convert.ToInt64(values[3]));
            //            cmd.ExecuteNonQuery();
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT customerID FROM Customer WHERE nameCustomer = @nameCustomer AND customer = 'YES';";
                int buyerCustomerID;
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nameCustomer", buyerCustomer);
                    buyerCustomerID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                query = "SELECT customerID FROM Customer WHERE nameCustomer = @nameCustomer AND customer = 'YES';";
                int cmtCustomerID;
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nameCustomer", cmtCustomer);
                    cmtCustomerID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                query = "INSERT INTO Invoice (invoicesID,buyerCustomerID,date,cmtCustomerID) VALUES (@invoicesID,@buyerCustomerID,@date,@cmtCustomerID);";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@invoicesID", Number);
                    cmd.Parameters.AddWithValue("@buyerCustomerID", buyerCustomerID);
                    cmd.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@cmtCustomerID", cmtCustomerID);
                    cmd.ExecuteNonQuery();
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    query = @"INSERT INTO InvoiceOrderList (invoicesID,orderID,buyerCustomerID,cmtCustomerID,status) 
                        VALUES (@invoicesID,@orderID,@buyerCustomerID,@cmtCustomerID,@status);";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@invoicesID", Number);
                        cmd.Parameters.AddWithValue("@orderID", dataGridView1[0, i].Value.ToString());
                        cmd.Parameters.AddWithValue("@buyerCustomerID", buyerCustomerID);
                        cmd.Parameters.AddWithValue("@cmtCustomerID", cmtCustomerID);
                        cmd.Parameters.AddWithValue("@status", "KELUAR");
                        cmd.ExecuteNonQuery();
                    }
                }
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    List<String> values = new List<String>();
                    for (int j = 1; j < dataGridView2.Columns.Count - 1; j++)
                    {
                        String temp = dataGridView2[j, i].Value.ToString();
                        if (j == 4) temp = Convert.ToInt64(Convert.ToDouble(temp.Remove(0, 4))).ToString();
                        values.Add(temp);
                    }
                    query = "INSERT INTO InvoiceList (invoicesID,nameItem,price,unit,quantity) VALUES (@invoicesID,@nameItem,@price,@unit,@quantity);";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@invoicesID", Number);
                        cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(values[0]));
                        cmd.Parameters.AddWithValue("@nameItem", values[1]);
                        cmd.Parameters.AddWithValue("@unit", values[2]);
                        cmd.Parameters.AddWithValue("@price", Convert.ToInt64(values[3]));
                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
            MessageBox.Show("Data berhasil dimasukkan");
            textBox2.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            loadComboOrder();
            dataGridView1.Rows.Clear();
            button4_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String name = textBox5.Text;
            String unit = comboBox4.Text;
            int quantity = (int)numericUpDown1.Value;
            long price = (long)numericUpDown2.Value;
            if (name.Length <= 0)
            {
                MessageBox.Show("Kolom keterangan tidak boleh kosong");
                return;
            }
            if (unit == "")
            {
                MessageBox.Show("Satuan tidak boleh kosong");
                return;
            }
            if (quantity <= 0)
            {
                MessageBox.Show("Nilai quantity tidak boleh lebih kecil sama dengan 0");
                return;
            }
            if (price <= 0)
            {
                MessageBox.Show("Harga tidak boleh lebih kecil sama dengan 0");
                return;
            }
            List<String> temp = new List<String>() { };
            temp.Add(Convert.ToString(dataGridView2.Rows.Count + 1));
            temp.Add(Convert.ToString(quantity));
            temp.Add(name);
            temp.Add(unit);
            temp.Add("Rp. " + price.ToString("N"));
            long subtotal = price * quantity;
            temp.Add("Rp. " + subtotal.ToString("N"));
            String txt = textBox1.Text;
            long total = Convert.ToInt64(Convert.ToDouble(txt.Remove(0, 4)));
            total += quantity * price;
            textBox1.Text = "Rp. " + total.ToString("N");
            dataGridView2.Rows.Add(temp.ToArray());
            resetInput();
        }

        private void dataGridView2_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            long ret = 0;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2[0, i].Value = i + 1;
                String txt = dataGridView2[4, i].Value.ToString();
                long temp = Convert.ToInt64(Convert.ToDouble(txt.Remove(0, 4)));
                ret += temp;
            }
            textBox1.Text = "Rp. " + ret.ToString("N");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            textBox1.Text = "Rp. 0.00";
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            dataGridView1.Rows.Clear();
            GlobalVariable.comboBoxLoadItem(ref comboBox2, "orderID", @"Customer[C], 
                (SELECT orderID, buyerCustomerID FROM OrderStatus[OS],Customer[C] WHERE 
                OS.status = 'KELUAR' AND C.customerID = OS.cmtCustomerID AND C.customer = 'YES' 
                AND C.nameCustomer = '" + comboBox3.Text + @"') AS OS2  
                WHERE C.customerID = OS2.buyerCustomerID AND C.nameCustomer = '" + comboBox1.Text + "'");
        }
    }
}
