using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BordiProject.PettyCash
{
    public partial class PettyCashInsertForm : Form
    {
        private long initializePettyCashResult(DateTime date)
        {
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                long total = 0;
                String query = "SELECT total FROM PettyCashResult WHERE strftime('%s', date) < strftime('%s', @date) ORDER BY date(date) DESC LIMIT 1";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@date", date.Date);
                    Object objectTotal = cmd.ExecuteScalar();
                    if (objectTotal != null)
                    {
                        total = (long)objectTotal;
                    }
                }
                String query2 = "INSERT INTO PettyCashResult (date, total) VALUES (@date, @total)";
                using (var cmd = new SQLiteCommand(query2, conn))
                {
                    cmd.Parameters.AddWithValue("@date", date.Date);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                return total;
            }
        }

        private void initializeData()
        {
            dataGridView1.Rows.Clear();
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT * FROM PettyCash WHERE strftime('%s', date) == strftime('%s', @date) ORDER BY pettyCashID ASC";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            List<String> temp = new List<string>() { };
                            temp.Add(reader["description"].ToString());
                            temp.Add(reader["pic"].ToString());
                            String status = reader["status"].ToString();
                            if (status.Equals("CREDIT"))
                            {
                                temp.Add("");
                            }
                            temp.Add("Rp. " + Convert.ToInt64(reader["amount"]).ToString("N"));
                            if (status.Equals("DEBIT"))
                            {
                                temp.Add("");
                            }
                            dataGridView1.Rows.Add(temp.ToArray());
                        }
                    }
                }

                String query2 = "SELECT total FROM PettyCashResult WHERE strftime('%s', date) == strftime('%s', @date)";
                using (var cmd = new SQLiteCommand(query2, conn))
                {
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);
                    long total = 0;
                    Object objectTotal = cmd.ExecuteScalar();
                    if (objectTotal != null)
                    {
                        total = (long)objectTotal;
                    }
                    else
                    {
                        total = initializePettyCashResult(dateTimePicker1.Value);
                    }
                    insertpurchasetotalText.Text = "Rp. " + total.ToString("N");
                }
                conn.Close();
            }
        }

        private void resetInput()
        {
            textBox1.Text = textBox2.Text = "";
            numericUpDown1.Value = 0;
            typecashRadio.Checked = true;
        }

        public PettyCashInsertForm()
        {
            InitializeComponent();
            initializeData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String txt = insertpurchasetotalText.Text;
            long total = Convert.ToInt64(Convert.ToDouble(txt.Remove(0, 4)));
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT * FROM PettyCashResult WHERE strftime('%s', date) >= strftime('%s', @date) AND total + @amount < 0";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@amount", typecashRadio.Checked ? numericUpDown1.Value : -numericUpDown1.Value);
                    if (cmd.ExecuteScalar() != null)
                    {
                        MessageBox.Show("Transaksi Invalid (Credit melebihi batas Debit");
                        return;
                    }
                }
                String query2 = "INSERT INTO PettyCash (date, description, pic, status, amount) VALUES (@date, @description, @pic, @status, @amount)";
                using (var cmd = new SQLiteCommand(query2, conn))
                {
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@description", textBox1.Text);
                    cmd.Parameters.AddWithValue("@pic", textBox2.Text);
                    cmd.Parameters.AddWithValue("@status", typecashRadio.Checked ? "DEBIT" : "CREDIT");
                    cmd.Parameters.AddWithValue("@amount", numericUpDown1.Value);
                    cmd.ExecuteNonQuery();
                }
                String query3 = "UPDATE PettyCashResult SET total = total + @amount WHERE strftime('%s', date) >= strftime('%s', @date)";
                using (var cmd = new SQLiteCommand(query3, conn))
                {
                    cmd.Parameters.AddWithValue("@amount", typecashRadio.Checked ? numericUpDown1.Value : -numericUpDown1.Value);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            MessageBox.Show("Transaksi Berhasil Dimasukkan");
            resetInput();
            initializeData();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            initializeData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetInput();
        }
    }
}
