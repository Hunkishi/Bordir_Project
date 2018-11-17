using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BordiProject
{
    public partial class ReceiptPaymentForm : Form
    {
        long pure = 0, pay = 0, remain = 0;

        private void resetHistory()
        {
            pure = pay = remain = 0;
            dateTimePicker1.Value = DateTime.Today;
            numericUpDown1.Value =  0;
            textBox3.Text = textBox2.Text = textBox4.Text = "Rp. 0.00";
            dataGridView1.Rows.Clear();
            groupBox1.Enabled = false;
        }

        private void countRemainder()
        {
            remain = Math.Max(0, pay - pure);
            textBox2.Text = "Rp. " + remain.ToString("N");
            if (remain == 0)
            {
                textBox1.Text = "LUNAS";
            }
            else
            {
                textBox1.Text = "BELUM LUNAS";
            }
        }

        private void sortDate()
        {
            for(int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = i+1; j < dataGridView1.RowCount; j++)
                {
                    if (Convert.ToDateTime(dataGridView1[0, i].Value) > Convert.ToDateTime(dataGridView1[0, j].Value))
                    {
                        for (int k = 0; k < dataGridView1.ColumnCount; k++)
                        {
                            var temp = dataGridView1[k, i].Value;
                            dataGridView1[k, i].Value = dataGridView1[k, j].Value;
                            dataGridView1[k, j].Value = temp;
                        }
                    }
                }
            }
        }

        public ReceiptPaymentForm()
        {
            InitializeComponent();
            GlobalVariable.comboBoxLoadItem(ref comboBox1, "receiptID", "Receipt");
            GlobalVariable.comboBoxLoadItem(ref comboBox2, "nameCustomer", "Customer");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetHistory();
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Nomor Tanda Terima tidak boleh kosong");
                return;
            }
            if (!Regex.IsMatch(comboBox1.Text, @"^\d+$"))
            {
                MessageBox.Show("Format Nomor Tanda Terima salah");
                return;
            }
            int receiptID = Convert.ToInt32(comboBox1.Text);
            //using (SqlConnection conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT receiptID FROM Receipt WHERE receiptID = @receiptID";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@receiptID", receiptID);
            //        if (cmd.ExecuteScalar() == null)
            //        {
            //            MessageBox.Show("Nomor Tanda Terima tidak ditemukan");
            //            return;
            //        }
            //    }
            //    query = "SELECT * FROM ReceiptTransaction WHERE receiptID = @receiptID";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@receiptID", receiptID);
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                List<String> temp = new List<String>();
            //                temp.Add(Convert.ToDateTime(reader["date"]).ToString("dd-MMM-yyyy"));
            //                temp.Add("Rp. " + Convert.ToInt32(reader["payment"]).ToString("N"));
            //                temp.Add(reader["description"].ToString());
            //                dataGridView1.Rows.Add(temp.ToArray());
            //            }
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT receiptID FROM Receipt WHERE receiptID = @receiptID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@receiptID", receiptID);
                    if (cmd.ExecuteScalar() == null)
                    {
                        MessageBox.Show("Nomor Tanda Terima tidak ditemukan");
                        return;
                    }
                }
                query = "SELECT * FROM ReceiptTransaction WHERE receiptID = @receiptID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@receiptID", receiptID);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            List<String> temp = new List<String>();
                            temp.Add(Convert.ToDateTime(reader["date"]).ToString("D"));
                            temp.Add("Rp. " + Convert.ToInt64(reader["payment"]).ToString("N"));
                            pure += Convert.ToInt64(reader["payment"]);
                            textBox3.Text = "Rp." + pure.ToString("N");
                            temp.Add(reader["description"].ToString());
                            dataGridView1.Rows.Add(temp.ToArray());
                        }
                    }
                }
                query = "SELECT SUM(price*quantity) FROM InvoiceList[IL], ReceiptInvoice[RI] WHERE RI.receiptID = @receiptID AND IL.invoicesID = RI.invoicesID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@receiptID", receiptID);
                    pay = Convert.ToInt64(cmd.ExecuteScalar());
                }
                query = "SELECT ppn, pph FROM Receipt WHERE receiptID = @receiptID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@receiptID", receiptID);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long BeforeTax = pay;
                            if (Convert.ToBoolean(reader["ppn"])) pay += BeforeTax / 10;
                            if (Convert.ToBoolean(reader["pph"])) pay -= BeforeTax / 50;
                        }
                    }
                }
                textBox4.Text = "Rp. " + pay.ToString("N");
                conn.Close();
            }
            countRemainder();
            groupBox1.Enabled = true;
            sortDate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "DELETE FROM ReceiptTransaction WHERE receiptID = @receiptID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@receiptID", Convert.ToInt32(comboBox1.Text));
                    cmd.ExecuteNonQuery();
                }
                query = @"INSERT INTO ReceiptTransaction (receiptID, date, payment, description) 
                                VALUES (@receiptID, @date, @payment, @description)";
                using(var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@receiptID", Convert.ToInt32(comboBox1.Text));
                    cmd.Parameters.Add("@date", DbType.String);
                    cmd.Parameters.Add("@payment", DbType.Int64);
                    cmd.Parameters.Add("@description", DbType.String);
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        DateTime foo = Convert.ToDateTime(dataGridView1[0, i].Value);
                        cmd.Parameters["@date"].Value = foo.ToString("yyyy-MM-dd");
                        cmd.Parameters["@payment"].Value = Convert.ToInt64(Convert.ToDouble(dataGridView1[1, i].Value.ToString().Remove(0, 4)));
                        cmd.Parameters["@description"].Value = dataGridView1[2, i].Value.ToString();
                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
            MessageBox.Show("Pembayaran Berhasil Diperbaharui");
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            pure = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                String txt = dataGridView1[1, i].Value.ToString();
                long temp = Convert.ToInt64(Convert.ToDouble(txt.Remove(0, 4)));
                pure += temp;
            }
            textBox3.Text = "Rp. " + pure.ToString("N");
            countRemainder();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                dataGridView2.Columns.Clear();
                dataGridView2.Rows.Clear();
                List<String> columns = new List<String>() { "Tanggal", "No. Tanda Terima", "Total Biaya" ,"Jumlah Pembayaran", "Sisa Pembayaran" };
                foreach (var column in columns)
                {
                    dataGridView2.Columns.Add(column, column);
                }
                dataGridView2.Columns[0].Width = 150;
                for (int i = 1; i < 5; i++)
                {
                    dataGridView2.Columns[i].Width = 125;
                }

                String query = @"SELECT R.date as date, R.receiptID as receiptID, R.ppn as ppn, R.pph as pph FROM Customer[C], Receipt[R] WHERE 
                                C.customerID = R.customerID AND C.nameCustomer = @nameCustomer;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nameCustomer", comboBox2.Text);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long payed = 0, mustpay = 0;
                            List<String> temp = new List<String>() { };
                            temp.Add(Convert.ToDateTime(reader["date"]).ToString("D"));
                            temp.Add(reader["receiptID"].ToString());
                            int receiptID = Convert.ToInt32(reader["receiptID"]);
                            using (var conn2 = new SQLiteConnection(GlobalVariable.builder))
                            {
                                conn2.Open();
                                String query2 = @"SELECT COALESCE(SUM(price*quantity),0) FROM Receipt[R], ReceiptInvoice[RI], InvoiceList[IL] 
                                    WHERE R.receiptID = @receiptID AND R.receiptID = RI.receiptID AND RI.invoicesID = IL.invoicesID";
                                using (var cmd2 = new SQLiteCommand(query2, conn2))
                                {
                                    cmd2.Parameters.AddWithValue("@receiptID", receiptID);
                                    mustpay = Convert.ToInt64(cmd2.ExecuteScalar());
                                    long BeforeTax = mustpay;
                                    if (Convert.ToBoolean(reader["ppn"])) mustpay += BeforeTax / 10;
                                    if (Convert.ToBoolean(reader["pph"])) mustpay -= BeforeTax / 50;
                                }
                                query2 = @"SELECT COALESCE(SUM(payment),0) FROM ReceiptTransaction WHERE receiptID = @receiptID";
                                using (var cmd2 = new SQLiteCommand(query2, conn2))
                                {
                                    cmd2.Parameters.AddWithValue("@receiptID", receiptID);
                                    payed = Convert.ToInt64(cmd2.ExecuteScalar());
                                }
                                temp.Add("Rp. " + mustpay.ToString("N"));
                                temp.Add("Rp. " + payed.ToString("N") );
                                temp.Add("Rp. " + Math.Max(0,mustpay-payed).ToString("N"));
                                conn2.Close();
                            }
                            dataGridView2.Rows.Add(temp.ToArray());

                        }
                    }
                }
                conn.Close();
            }
        }

        private void comboBox2_TextUpdate(object sender, EventArgs e)
        {
            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = remain;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<String> temp = new List<String>();
            temp.Add(dateTimePicker1.Text);
            temp.Add("Rp. " + numericUpDown1.Value.ToString("N"));
            pure += Convert.ToInt64(numericUpDown1.Value);
            textBox3.Text = "Rp. " + pure.ToString("N");
            temp.Add(richTextBox1.Text);
            dataGridView1.Rows.Add(temp.ToArray());
            countRemainder();
            sortDate();
        }
        
    }
}
