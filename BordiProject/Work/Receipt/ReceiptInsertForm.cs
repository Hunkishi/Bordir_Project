using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BordiProject
{
    public partial class ReceiptInsertForm : Form
    {
        long pure = 0;

        private long calculateTotal()
        {
            long addition = 0;
            if (checkBox1.Checked)
                addition += pure / 10;
            if (checkBox2.Checked)
                addition -= pure / 50;
            return pure + addition;
        }

        private void resetInputDataGrid()
        {
            comboBox1.SelectedIndex = -1;
            richTextBox1.Text = "";
            GlobalVariable.comboBoxLoadItem(ref comboBox1, "invoicesID", "Invoice");
        }

        private void resetInput()
        {
            dataGridView1.Rows.Clear();
            textBox1.Text = "";
            comboBox2.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Today;
            GlobalVariable.comboBoxLoadItem(ref comboBox2, "nameCustomer", "Customer WHERE customer = 'YES'");
            resetInputDataGrid();
        }

        public ReceiptInsertForm()
        {
            InitializeComponent();
            GlobalVariable.comboBoxLoadItem(ref comboBox1, "invoicesID", "Invoice");
            GlobalVariable.comboBoxLoadItem(ref comboBox2, "nameCustomer", "Customer WHERE customer = 'YES'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String desc = richTextBox1.Text;
            if (comboBox1.SelectedIndex == -1 || comboBox1.Text == "")
            {
                MessageBox.Show("Nomor Faktur tidak boleh kosong");
                return;
            }
            int Number = Convert.ToInt32(comboBox1.Text);
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToInt32(dataGridView1[2,i].Value) == Number)
                {
                    MessageBox.Show("Nomor faktur sudah dimasukkan sebelumnya");
                    return;
                }
            }
            List<String> temp = new List<String>() { };
            temp.Add(Convert.ToString(dataGridView1.Rows.Count + 1));
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT date FROM Invoice WHERE invoicesID = @invoicesID;";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@invoicesID", Number);
            //        temp.Add(Convert.ToDateTime(cmd.ExecuteScalar()).ToString("dd-MMM-yyyy"));
            //    }
            //    temp.Add(Number.ToString());
            //    query = "SELECT SUM(price*quantity) FROM InvoiceList WHERE invoicesID = @invoicesID;";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@invoicesID", Number);
            //        temp.Add("Rp. " + Convert.ToInt64(cmd.ExecuteScalar()).ToString("N"));
            //        pure += Convert.ToInt64(cmd.ExecuteScalar());
            //        textBox2.Text = "Rp. " + (calculateTotal()).ToString("N");
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT date FROM Invoice WHERE invoicesID = @invoicesID;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@invoicesID", Number);
                    temp.Add(Convert.ToDateTime(cmd.ExecuteScalar()).ToString("yyyy-MM-dd"));
                }
                temp.Add(Number.ToString());
                query = "SELECT SUM(price*quantity) FROM InvoiceList WHERE invoicesID = @invoicesID;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@invoicesID", Number);
                    temp.Add("Rp. " + Convert.ToInt64(cmd.ExecuteScalar()).ToString("N"));
                    pure += Convert.ToInt64(cmd.ExecuteScalar());
                    textBox2.Text = "Rp. " + (calculateTotal()).ToString("N");
                }
                conn.Close();
            }
            temp.Add(desc);
            dataGridView1.Rows.Add(temp.ToArray());
            resetInputDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //input No tanda terima
            if (textBox1.Text != "" && !Regex.IsMatch(textBox1.Text, @"^\d+$"))
            {
                MessageBox.Show("Format nomor tanda terima salah");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Nomor tanda terima tidak boleh kosong");
                return;
            }
            int Number = Convert.ToInt32(textBox1.Text);
            //input customer
            if (comboBox2.SelectedIndex == -1|| comboBox2.Text == "")
            {
                MessageBox.Show("Perusahaan tidak boleh kosong");
                return;
            }
            //cek faktur
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Referensi Faktur tidak boleh kosong");
                return;
            }
            String customer = comboBox2.Text;
            //input Date
            DateTime date = dateTimePicker1.Value;
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT customerID FROM Customer WHERE nameCustomer = @nameCustomer AND customer = 'YES';";
            //    //Get CustomerID
            //    int customerID;
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@nameCustomer", customer);
            //        customerID = Convert.ToInt32(cmd.ExecuteScalar());
            //    }
            //    //Masukkan Data
            //    query = "INSERT INTO Receipt (receiptID,customerID,date,ppn,pph) VALUES (@receiptID,@customerID,@date,@ppn,@pph);";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@receiptID", Number);
            //        cmd.Parameters.AddWithValue("@customerID", customerID);
            //        cmd.Parameters.AddWithValue("@date", date);
            //        cmd.Parameters.AddWithValue("@ppn", checkBox1.Checked);
            //        cmd.Parameters.AddWithValue("@pph", checkBox2.Checked);
            //        cmd.ExecuteNonQuery();
            //    }
            //    //Masukkan Data Grid
            //    for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //    {
            //        List<String> values = new List<String>();
            //        for (int j = 1; j < dataGridView1.Columns.Count; j++)
            //        {
            //            if (j == 1 || j == 3) continue;
            //            String temp = dataGridView1[j, i].Value.ToString();
            //            values.Add(temp);
            //        }
            //        query = "INSERT INTO ReceiptInvoice (receiptID,invoicesID,description) VALUES (@receiptID,@invoicesID,@description);";
            //        using (var cmd = new SqlCommand(query, conn))
            //        {
            //            cmd.Parameters.AddWithValue("@receiptID", Number);
            //            cmd.Parameters.AddWithValue("@invoicesID", Convert.ToInt32(values[0]));
            //            cmd.Parameters.AddWithValue("@description", values[1]);
            //            cmd.ExecuteNonQuery();
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT customerID FROM Customer WHERE nameCustomer = @nameCustomer AND customer = 'YES';";
                //Get CustomerID
                int customerID;
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nameCustomer", customer);
                    customerID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                //Masukkan Data
                query = "INSERT INTO Receipt (receiptID,customerID,date,ppn,pph) VALUES (@receiptID,@customerID,@date,@ppn,@pph);";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@receiptID", Number);
                    cmd.Parameters.AddWithValue("@customerID", customerID);
                    cmd.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@ppn", checkBox1.Checked);
                    cmd.Parameters.AddWithValue("@pph", checkBox2.Checked);
                    cmd.ExecuteNonQuery();
                }
                //Masukkan Data Grid
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    List<String> values = new List<String>();
                    for (int j = 1; j < dataGridView1.Columns.Count; j++)
                    {
                        if (j == 1 || j == 3) continue;
                        String temp = dataGridView1[j, i].Value.ToString();
                        values.Add(temp);
                    }
                    query = "INSERT INTO ReceiptInvoice (receiptID,invoicesID,description) VALUES (@receiptID,@invoicesID,@description);";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@receiptID", Number);
                        cmd.Parameters.AddWithValue("@invoicesID", Convert.ToInt32(values[0]));
                        cmd.Parameters.AddWithValue("@description", values[1]);
                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
            MessageBox.Show("Data Berhasil dimasukkan");
            resetInput();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            pure = 0;
            textBox2.Text = "Rp. 0.00";
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1[0, i].Value = i + 1;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "Rp. " + (calculateTotal()).ToString("N");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "Rp. " + (calculateTotal()).ToString("N");
        }
    }
}
