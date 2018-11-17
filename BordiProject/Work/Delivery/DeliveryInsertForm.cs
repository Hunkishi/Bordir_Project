using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SQLite;

namespace BordiProject
{
    public partial class DeliveryInsertForm : Form
    {
        private void initComp()
        {
            dataGridView2.Rows.Clear();
            GlobalVariable.comboBoxLoadItem(ref comboBox1, "nameCustomer", "Customer WHERE customer = 'YES'");
            GlobalVariable.comboBoxLoadItem(ref comboBox2, "nameCustomer", "Customer WHERE customer = 'YES'");
            textBox5.Text = richTextBox1.Text = textBox4.Text = textBox3.Text = "";
            radioButton3.Checked = true;
            dateTimePicker2.Value = DateTime.Today;
            numericUpDown1.Value = 1;
            textBox6.Text = "0";
            comboBox3.SelectedIndex = 0;
        }

        public DeliveryInsertForm()
        {
            InitializeComponent();
            initComp();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Cek DataGrid
            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("List barang tidak boleh kosong");
                return;
            }
            //input orderID
            String orderID = textBox5.Text;
            if (orderID == "" && radioButton4.Checked)
            {
                MessageBox.Show("Nomor surat jalan harus diisi");
                return;
            }
            if (radioButton4.Checked && orderID != "" && !Regex.IsMatch(orderID, @"^\d+$"))
            {
                MessageBox.Show("Format Nomor Surat Jalan salah");
                return;
            }
            //input date
            DateTime date = dateTimePicker2.Value;
            //input status
            String status = (radioButton3.Checked) ? "MASUK" : "KELUAR";
            //input Buyer costumer
            String buyercustomer = comboBox2.Text;
            if (buyercustomer == "")
            {
                MessageBox.Show("Kolom buyer harus diisi");
                return;
            }
            //input CMT costumer
            String cmtcustomer = comboBox1.Text;
            if (cmtcustomer == "")
            {
                MessageBox.Show("Kolom cmt harus diisi");
                return;
            }
            //input style
            String style = textBox3.Text;
            if (style == "")
            {
                MessageBox.Show("Style tidak boleh kosong");
                return;
            }
            //input description
            String desc = richTextBox1.Text;
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    //Get buyerCustomerID
            //    String query = "SELECT customerID FROM Customer WHERE nameCustomer = @nameCustomer AND customer = 'YES';";
            //    int buyerCustomerID;
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@nameCustomer", buyercustomer);
            //        if (cmd.ExecuteScalar() == null)
            //        {
            //            MessageBox.Show("customer tidak terdapat pada database");
            //            return;
            //        }
            //        buyerCustomerID = (int)cmd.ExecuteScalar();
            //    }
            //    //Get cmtCustomerID
            //    query = "SELECT customerID FROM Customer WHERE nameCustomer = @nameCustomer  AND customer = 'YES';";
            //    int cmtCustomerID;
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@nameCustomer", cmtcustomer);
            //        if (cmd.ExecuteScalar() == null)
            //        {
            //            MessageBox.Show("customer tidak terdapat pada database");
            //            return;
            //        }
            //        cmtCustomerID = (int)cmd.ExecuteScalar();
            //    }
            //    //Cek valid order
            //    query = "SELECT * FROM OrderStatus Purchase WHERE orderID = @orderID AND status = @status AND buyerCustomerID = @buyerCustomerID AND cmtCustomerID = @cmtCustomerID;";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@orderID", orderID);
            //        cmd.Parameters.AddWithValue("@status", status);
            //        cmd.Parameters.AddWithValue("@buyerCustomerID", buyerCustomerID);
            //        cmd.Parameters.AddWithValue("@cmtCustomerID", cmtCustomerID);
            //        if (cmd.ExecuteScalar() != null)
            //        {
            //            MessageBox.Show("nomor surat jalan sudah pernah digunakan");
            //            return;
            //        }
            //    }
            //    //Masukkan Data
            //    query = "INSERT INTO OrderStatus (orderID,status,buyerCustomerID,cmtCustomerID,date,description,style) VALUES (@orderID,@status,@buyerCustomerID,@cmtCustomerID,@date,@description,@style);";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@orderID", orderID);
            //        cmd.Parameters.AddWithValue("@status", status);
            //        cmd.Parameters.AddWithValue("@buyerCustomerID", buyerCustomerID);
            //        cmd.Parameters.AddWithValue("@cmtCustomerID", cmtCustomerID);
            //        cmd.Parameters.AddWithValue("@date", date);
            //        cmd.Parameters.AddWithValue("@style", style);
            //        cmd.Parameters.AddWithValue("@description", desc);
            //        cmd.ExecuteNonQuery();
            //    }
            //    for (int i = 0; i < dataGridView2.Rows.Count; i++)
            //    {
            //        List<String> values = new List<String>();
            //        for (int j = 1; j < dataGridView2.Columns.Count; j++)
            //        {
            //            String temp = dataGridView2[j, i].Value.ToString();
            //            values.Add(temp);
            //        }
            //        query = "INSERT INTO OrderItem (orderID,status,buyerCustomerID,cmtCustomerID,nameItem,quantity,unit) VALUES (@orderID,@status,@buyerCustomerID,@cmtCustomerID,@nameItem,@quantity,@unit);";
            //        using (var cmd = new SqlCommand(query, conn))
            //        {
            //            cmd.Parameters.AddWithValue("@orderID", orderID);
            //            cmd.Parameters.AddWithValue("@status", status);
            //            cmd.Parameters.AddWithValue("@buyerCustomerID", buyerCustomerID);
            //            cmd.Parameters.AddWithValue("@cmtCustomerID", cmtCustomerID);
            //            cmd.Parameters.AddWithValue("@nameItem", values[0]);
            //            cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(values[1]));
            //            cmd.Parameters.AddWithValue("@unit", values[2]);
            //            cmd.ExecuteNonQuery();
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                //Get buyerCustomerID
                String query = "SELECT customerID FROM Customer WHERE nameCustomer = @nameCustomer AND customer = 'YES';";
                int buyerCustomerID;
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nameCustomer", buyercustomer);
                    if (cmd.ExecuteScalar() == null)
                    {
                        MessageBox.Show("customer tidak terdapat pada database");
                        return;
                    }
                    buyerCustomerID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                //Get cmtCustomerID
                query = "SELECT customerID FROM Customer WHERE nameCustomer = @nameCustomer  AND customer = 'YES';";
                int cmtCustomerID;
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nameCustomer", cmtcustomer);
                    if (cmd.ExecuteScalar() == null)
                    {
                        MessageBox.Show("customer tidak terdapat pada database");
                        return;
                    }
                    cmtCustomerID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                //Cek valid order
                query = "SELECT * FROM OrderStatus Purchase WHERE orderID = @orderID AND status = @status AND buyerCustomerID = @buyerCustomerID AND cmtCustomerID = @cmtCustomerID;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@orderID", orderID);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@buyerCustomerID", buyerCustomerID);
                    cmd.Parameters.AddWithValue("@cmtCustomerID", cmtCustomerID);
                    if (cmd.ExecuteScalar() != null)
                    {
                        MessageBox.Show("nomor surat jalan sudah pernah digunakan");
                        return;
                    }
                }
                //Masukkan Data
                query = "INSERT INTO OrderStatus (orderID,status,buyerCustomerID,cmtCustomerID,date,description,style) VALUES (@orderID,@status,@buyerCustomerID,@cmtCustomerID,@date,@description,@style);";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@orderID", orderID);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@buyerCustomerID", buyerCustomerID);
                    cmd.Parameters.AddWithValue("@cmtCustomerID", cmtCustomerID);
                    DateTime dateonly = date.Date;
                    cmd.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@style", style);
                    cmd.Parameters.AddWithValue("@description", desc);
                    cmd.ExecuteNonQuery();
                }
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    List<String> values = new List<String>();
                    for (int j = 1; j < dataGridView2.Columns.Count; j++)
                    {
                        String temp = dataGridView2[j, i].Value.ToString();
                        values.Add(temp);
                    }
                    query = "INSERT INTO OrderItem (orderID,status,buyerCustomerID,cmtCustomerID,nameItem,quantity,unit) VALUES (@orderID,@status,@buyerCustomerID,@cmtCustomerID,@nameItem,@quantity,@unit);";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@orderID", orderID);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@buyerCustomerID", buyerCustomerID);
                        cmd.Parameters.AddWithValue("@cmtCustomerID", cmtCustomerID);
                        cmd.Parameters.AddWithValue("@nameItem", values[0]);
                        cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(values[1]));
                        cmd.Parameters.AddWithValue("@unit", values[2]);
                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
            MessageBox.Show("Data berhasil dimasukkan");
            initComp();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            textBox6.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //input nama barang
            String name = textBox4.Text;
            if (name == "")
            {
                MessageBox.Show("Kolom nama barang tidak boleh kosong");
                return;
            }
            //input quantity
            int quantity = (int)numericUpDown1.Value;
            if (quantity <= 0)
            {
                MessageBox.Show("Nilai quantity tidak boleh lebih kecil sama dengan 0");
                return;
            }
            if (comboBox3.Text == "")
            {
                MessageBox.Show("Satuan tidak boleh kosong");
                return;
            }
            List<String> temp = new List<String>() { };
            temp.Add(Convert.ToString(dataGridView2.Rows.Count + 1));
            temp.Add(name);
            temp.Add(Convert.ToString(quantity));
            temp.Add(comboBox3.Text);
            dataGridView2.Rows.Add(temp.ToArray());
            textBox4.Text = "";
            numericUpDown1.Value = 1;
            textBox6.Text = (Convert.ToInt32(textBox6.Text)+quantity).ToString();
            comboBox3.SelectedIndex = 0;

        }

        private void dataGridView2_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int ret = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                dataGridView2[0, i].Value = i+1; 
                ret += Convert.ToInt32(dataGridView2[2, i].Value);
            }
            textBox6.Text = ret.ToString();
        }
    }
}
