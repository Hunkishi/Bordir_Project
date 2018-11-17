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
    public partial class PurchaseOrderChangeForm : Form
    {
        private void resetInput()
        {
            insertpurchasedescriptionText.Text = insertpurchaseunitText.Text = "";
            insertpurchasequantityNumeric.Value = insertpurchasepriceunitNumeric.Value = 0;
        }

        private void resetHistory()
        {
            insertGroup.Enabled = false;
            insertdateDateTime.Value = DateTime.Today;
            typecreditRadio.Checked = true;
            GlobalVariable.comboBoxLoadItem(ref comboBox1, "nameCustomer", "Customer WHERE supplier = 'YES'");
            insertnumberPOText.Text = insertrangetimeText.Text = "";
            insertpurchaseDataGrid.Rows.Clear();
            insertpurchasetotalText.Text = "Rp. 0.00";
            resetInput();
        }

        private void initCombo()
        {
            GlobalVariable.comboBoxLoadItem(ref comboBox2, "purchaseID", "Purchase");
        }

        public PurchaseOrderChangeForm()
        {
            InitializeComponent();
            initCombo();
            resetHistory();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resetHistory();
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Nomor PO tidak boleh kosong");
                return;
            }
            String numberPO = comboBox2.Text;
            long Total = 0;
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT nameStock, quantity, unit, price, quantity*price AS Total FROM PurchaseList" +
            //        " WHERE purchaseID = @purchaseID;";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@purchaseID", numberPO);
            //        if (cmd.ExecuteScalar() == null)
            //        {
            //            MessageBox.Show("Nomor PO tidak ditemukan");
            //            return;
            //        }
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                List<String> temp = new List<String>() { };
            //                temp.Add((insertpurchaseDataGrid.RowCount + 1).ToString());
            //                temp.Add(reader["nameStock"].ToString());
            //                temp.Add(reader["quantity"].ToString());
            //                temp.Add(reader["unit"].ToString());
            //                temp.Add("Rp. " + Convert.ToInt64(reader["price"]).ToString("N"));
            //                temp.Add("Rp. " + Convert.ToInt64(reader["Total"]).ToString("N"));
            //                Total += Convert.ToInt64(reader["Total"]);
            //                insertpurchaseDataGrid.Rows.Add(temp.ToArray());
            //            }
            //            reader.Close();
            //        }
            //    }
            //    query = @"SELECT nameCustomer, date, rangeTime, type FROM Purchase[P], Customer[C] 
            //            WHERE P.customerID = C.customerID AND purchaseID = @purchaseID";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@purchaseID", numberPO);
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                insertnumberPOText.Text = comboBox2.Text;
            //                comboBox1.Text = reader["nameCustomer"].ToString();
            //                insertdateDateTime.Value = Convert.ToDateTime(reader["date"]);
            //                insertrangetimeText.Text = reader["rangeTime"].ToString();
            //                if (reader["type"].ToString() == "CASH")
            //                    typecashRadio.Checked = true;
            //                else
            //                    typecreditRadio.Checked = true;
            //            }
            //            reader.Close();
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT nameStock, quantity, unit, price, quantity*price AS Total FROM PurchaseList" +
                    " WHERE purchaseID = @purchaseID;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@purchaseID", numberPO);
                    if (cmd.ExecuteScalar() == null)
                    {
                        MessageBox.Show("Nomor PO tidak ditemukan");
                        return;
                    }
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            List<String> temp = new List<String>() { };
                            temp.Add((insertpurchaseDataGrid.RowCount + 1).ToString());
                            temp.Add(reader["nameStock"].ToString());
                            temp.Add(reader["quantity"].ToString());
                            temp.Add(reader["unit"].ToString());
                            temp.Add("Rp. " + Convert.ToInt64(reader["price"]).ToString("N"));
                            temp.Add("Rp. " + Convert.ToInt64(reader["Total"]).ToString("N"));
                            Total += Convert.ToInt64(reader["Total"]);
                            insertpurchaseDataGrid.Rows.Add(temp.ToArray());
                        }
                        reader.Close();
                    }
                }
                query = @"SELECT nameCustomer, date, rangeTime, type FROM Purchase[P], Customer[C] 
                        WHERE P.customerID = C.customerID AND purchaseID = @purchaseID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@purchaseID", numberPO);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            insertnumberPOText.Text = comboBox2.Text;
                            comboBox1.Text = reader["nameCustomer"].ToString();
                            insertdateDateTime.Value = Convert.ToDateTime(reader["date"]);
                            insertrangetimeText.Text = reader["rangeTime"].ToString();
                            if (reader["type"].ToString() == "CASH")
                                typecashRadio.Checked = true;
                            else
                                typecreditRadio.Checked = true;
                        }
                        reader.Close();
                    }
                }
                conn.Close();
            }
            insertpurchasetotalText.Text = "Rp. " + Total.ToString("N");
            insertGroup.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            insertpurchaseDataGrid.Rows.Clear();
            insertpurchasetotalText.Text = "Rp. 0.00";
        }

        private void insertpurchaseButton_Click(object sender, EventArgs e)
        {
            String desc = insertpurchasedescriptionText.Text, unit = insertpurchaseunitText.Text;
            int quantity = (int)insertpurchasequantityNumeric.Value;
            long price = (long)insertpurchasepriceunitNumeric.Value;
            if (desc.Length <= 0)
            {
                MessageBox.Show("Kolom keterangan tidak boleh kosong");
                return;
            }
            if (quantity <= 0)
            {
                MessageBox.Show("Nilai quantity tidak boleh lebih kecil sama dengan 0");
                return;
            }
            if (unit.Length <= 0)
            {
                MessageBox.Show("Kolom satuan tidak boleh kosong");
                return;
            }
            if (price <= 0)
            {
                MessageBox.Show("Harga tidak boleh lebih kecil sama dengan 0");
                return;
            }
            List<String> temp = new List<String>() { };
            temp.Add(Convert.ToString(insertpurchaseDataGrid.Rows.Count + 1));
            temp.Add(desc);
            temp.Add(Convert.ToString(quantity));
            temp.Add(unit);
            temp.Add("Rp. " + price.ToString("N"));
            long subtotal = price * quantity;
            temp.Add("Rp. " + subtotal.ToString("N"));
            String txt = insertpurchasetotalText.Text;
            long total = Convert.ToInt64(Convert.ToDouble(txt.Remove(0, 4)));
            total += quantity * price;
            insertpurchasetotalText.Text = "Rp. " + total.ToString("N");
            insertpurchaseDataGrid.Rows.Add(temp.ToArray());
            resetInput();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resetHistory();
            //using (SqlConnection conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "DELETE FROM PurchaseList WHERE purchaseID = @purchaseID";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@purchaseID", comboBox2.Text);
            //        cmd.ExecuteNonQuery();
            //    }
            //    query = "DELETE FROM Purchase WHERE purchaseID = @purchaseID";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@purchaseID", comboBox2.Text);
            //        cmd.ExecuteNonQuery();
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "DELETE FROM PurchaseList WHERE purchaseID = @purchaseID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@purchaseID", comboBox2.Text);
                    cmd.ExecuteNonQuery();
                }
                query = "DELETE FROM Purchase WHERE purchaseID = @purchaseID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@purchaseID", comboBox2.Text);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            GlobalVariable.comboBoxLoadItem(ref comboBox2, "purchaseID", "Purchase");
            MessageBox.Show("Data Berhasil Dihapus");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (insertpurchaseDataGrid.Rows.Count == 0)
            {
                MessageBox.Show("List pembelian tidak boleh kosong");
                return;
            }
            if (insertnumberPOText.Text == "")
            {
                MessageBox.Show("Nomor PO tidak boleh kosong");
                return;
            }
            String numberPO = insertnumberPOText.Text;
            String supplier = comboBox1.Text, range = insertrangetimeText.Text, type = (typecashRadio.Checked) ? "CASH" : "CREDIT";
            DateTime date = insertdateDateTime.Value;
            if (supplier == "")
            {
                MessageBox.Show("Supplier (Kolom kepada) tidak boleh kosong");
                return;
            }
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    //Get customerID
            //    String query = "SELECT customerID FROM Customer WHERE nameCustomer = @nameCustomer AND supplier = 'YES';";
            //    int customerID;
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@nameCustomer", supplier);
            //        if (cmd.ExecuteScalar() == null)
            //        {
            //            MessageBox.Show("customer tidak terdapat pada database");
            //            return;
            //        }
            //        customerID = (int)cmd.ExecuteScalar();
            //    }
            //    //Delete PO List
            //    query = "DELETE FROM PurchaseList WHERE purchaseID = @purchaseID";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@purchaseID", comboBox2.Text);
            //        cmd.ExecuteNonQuery();
            //    }
            //    //Update PO
            //    query = @"UPDATE Purchase SET customerID = @customerID, date = @date,
            //        rangeTime = @rangeTime,type = @type WHERE purchaseID = @purchaseID";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@purchaseID", numberPO);
            //        cmd.Parameters.AddWithValue("@customerID", customerID);
            //        cmd.Parameters.AddWithValue("@date", date);
            //        cmd.Parameters.AddWithValue("@rangeTime", range);
            //        cmd.Parameters.AddWithValue("@type", type);
            //        cmd.ExecuteNonQuery();
            //    }
            //    for (int i = 0; i < insertpurchaseDataGrid.Rows.Count; i++)
            //    {
            //        List<String> values = new List<String>();
            //        for (int j = 1; j < insertpurchaseDataGrid.Columns.Count - 1; j++)
            //        {
            //            String temp = insertpurchaseDataGrid[j, i].Value.ToString();
            //            if (j == 4) temp = Convert.ToInt64(Convert.ToDouble(temp.Remove(0, 4))).ToString();
            //            values.Add(temp);
            //        }
            //        query = "INSERT INTO PurchaseList (purchaseID,nameStock,quantity,unit,price) VALUES (@purchaseID,@nameStock,@quantity,@unit,@price);";
            //        using (var cmd = new SqlCommand(query, conn))
            //        {
            //            cmd.Parameters.AddWithValue("@purchaseID", numberPO);
            //            cmd.Parameters.AddWithValue("@nameStock", values[0]);
            //            cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(values[1]));
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
                //Get customerID
                String query = "SELECT customerID FROM Customer WHERE nameCustomer = @nameCustomer AND supplier = 'YES';";
                int customerID;
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nameCustomer", supplier);
                    if (cmd.ExecuteScalar() == null)
                    {
                        MessageBox.Show("customer tidak terdapat pada database");
                        return;
                    }
                    customerID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                //Delete PO List
                query = "DELETE FROM PurchaseList WHERE purchaseID = @purchaseID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@purchaseID", comboBox2.Text);
                    cmd.ExecuteNonQuery();
                }
                //Update PO
                query = @"UPDATE Purchase SET customerID = @customerID, date = @date,
                    rangeTime = @rangeTime,type = @type WHERE purchaseID = @purchaseID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@purchaseID", numberPO);
                    cmd.Parameters.AddWithValue("@customerID", customerID);
                    cmd.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@rangeTime", range);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.ExecuteNonQuery();
                }
                for (int i = 0; i < insertpurchaseDataGrid.Rows.Count; i++)
                {
                    List<String> values = new List<String>();
                    for (int j = 1; j < insertpurchaseDataGrid.Columns.Count - 1; j++)
                    {
                        String temp = insertpurchaseDataGrid[j, i].Value.ToString();
                        if (j == 4) temp = Convert.ToInt64(Convert.ToDouble(temp.Remove(0, 4))).ToString();
                        values.Add(temp);
                    }
                    query = "INSERT INTO PurchaseList (purchaseID,nameStock,quantity,unit,price) VALUES (@purchaseID,@nameStock,@quantity,@unit,@price);";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@purchaseID", numberPO);
                        cmd.Parameters.AddWithValue("@nameStock", values[0]);
                        cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(values[1]));
                        cmd.Parameters.AddWithValue("@unit", values[2]);
                        cmd.Parameters.AddWithValue("@price", Convert.ToInt64(values[3]));
                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
            MessageBox.Show("Data Berhasil Diubah");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetHistory();
        }
    }
}
