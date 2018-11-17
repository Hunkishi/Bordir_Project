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
    public partial class SupplyChangeForm : Form
    {
        int editID, editStockID, editQuantity;
        String editType, editDesc, editItemName, editKodeName;
        DateTime editDate;

        int searchedStockID;

        private void resetChange()
        {
            updatedateDateTime.Value = DateTime.Today;
            updateinRadio.Checked = true;
            updatequantityNumeric.Value = 0;
            updatedescriptionRichBox.Text = "";
            updateGroup.Enabled = false;
        }

        private void initComboBox()
        {
            GlobalVariable.comboBoxLoadItem(ref updateitemCombo, "nameStock", "Stock");
            GlobalVariable.comboBoxLoadItem(ref comboBox4, "nameStock", "Stock");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //using (SqlConnection conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    searchedStockID = 0;
            //    String query = "SELECT stockID FROM Stock WHERE nameStock = @nameStock AND kodeStock = @kodeStock;";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@nameStock", comboBox4.Text);
            //        cmd.Parameters.AddWithValue("@kodeStock", comboBox5.Text);
            //        if (cmd.ExecuteScalar() == null)
            //        {
            //            MessageBox.Show("Tidak terdapat Stock ID tersebut");
            //            return;
            //        }
            //        searchedStockID = Convert.ToInt32(cmd.ExecuteScalar());
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                searchedStockID = 0;
                String query = "SELECT stockID FROM Stock WHERE nameStock = @nameStock AND kodeStock = @kodeStock;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nameStock", comboBox4.Text);
                    cmd.Parameters.AddWithValue("@kodeStock", comboBox5.Text);
                    if (cmd.ExecuteScalar() == null)
                    {
                        MessageBox.Show("Tidak terdapat Stock ID tersebut");
                        return;
                    }
                    searchedStockID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                conn.Close();
            }
            textBox1.Text = comboBox4.Text;
            textBox2.Text = comboBox5.Text;
            groupBox3.Enabled = true;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox5.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox5.Items.Clear();
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT kodeStock FROM Stock WHERE nameStock = @nameStock;";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@nameStock", comboBox4.Text);
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                if (!comboBox5.Items.Contains(reader["kodeStock"].ToString()))
            //                    comboBox5.Items.Add(reader["kodeStock"].ToString());
            //            }
            //            reader.Close();
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT kodeStock FROM Stock WHERE nameStock = @nameStock;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nameStock", comboBox4.Text);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!comboBox5.Items.Contains(reader["kodeStock"].ToString()))
                                comboBox5.Items.Add(reader["kodeStock"].ToString());
                        }
                        reader.Close();
                    }
                }
                conn.Close();
            }
            if (comboBox5.Items.Count > 0)
            {
                comboBox5.SelectedIndex = 0;
                comboBox5.Enabled = true;
            }
            else
            {
                comboBox5.Text = "";
                comboBox5.Enabled = false;
            }
            groupBox3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = @"UPDATE Stock SET nameStock = @nameStock, kodeStock = @kodeStock 
                            WHERE stockID = @stockID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@stockID", searchedStockID);
                    cmd.Parameters.AddWithValue("@nameStock", textBox1.Text);
                    cmd.Parameters.AddWithValue("@kodeStock", textBox2.Text);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            MessageBox.Show("Barang berhasil diubah");
            groupBox3.Enabled = false;
            textBox1.Text = textBox2.Text = "";
            initComboBox();
            resetChange();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //using (SqlConnection conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "DELETE FROM StockTransaction WHERE stockID = @stockID";
            //    using (SqlCommand cmd = new SqlCommand(query,conn))
            //    {
            //        cmd.Parameters.AddWithValue("@stockID",searchedStockID);
            //        cmd.ExecuteNonQuery();
            //    }
            //    query = "DELETE FROM Stock WHERE stockID = @stockID";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@stockID", searchedStockID);
            //        cmd.ExecuteNonQuery();
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "DELETE FROM StockTransaction WHERE stockID = @stockID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@stockID", searchedStockID);
                    cmd.ExecuteNonQuery();
                }
                query = "DELETE FROM Stock WHERE stockID = @stockID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@stockID", searchedStockID);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            MessageBox.Show("Barang berhasil dihapus");
            groupBox3.Enabled = false;
            textBox1.Text = textBox2.Text = "";
            initComboBox();
            resetChange();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox3.Enabled = false;
        }

        private void updateitemCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox3.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox3.Items.Clear();
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT kodeStock FROM Stock WHERE nameStock = @nameStock;";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@nameStock", updateitemCombo.Text);
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                if (!comboBox3.Items.Contains(reader["kodeStock"].ToString()))
            //                    comboBox3.Items.Add(reader["kodeStock"].ToString());
            //            }
            //            reader.Close();
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT kodeStock FROM Stock WHERE nameStock = @nameStock;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nameStock", updateitemCombo.Text);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!comboBox3.Items.Contains(reader["kodeStock"].ToString()))
                                comboBox3.Items.Add(reader["kodeStock"].ToString());
                        }
                        reader.Close();
                    }
                }
                conn.Close();
            }
            if (comboBox3.Items.Count > 0)
            {
                comboBox3.SelectedIndex = 0;
                comboBox3.Enabled = true;
            }
            else
            {
                comboBox3.Text = "";
                comboBox3.Enabled = false;
            }
        }

        public SupplyChangeForm()
        {
            InitializeComponent();
            initComboBox();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            updatedateDateTime.Value = editDate;
            updateitemCombo.Text = editItemName;
            if (editType == "IN")
                updateinRadio.Checked = true;
            else
                updateoutRadio.Checked = true;
            updatequantityNumeric.Value = Math.Abs(editQuantity);
            updatedescriptionRichBox.Text = editDesc;
        }


        private void editidtransactionButton_Click(object sender, EventArgs e)
        {
            resetChange();
            try
            {
                editID = Convert.ToInt32(editidtransactionText.Text);
            }
            catch
            {
                MessageBox.Show("Tolong masukkan format ID berupa angka");
                return;
            }
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    updateGroup.Enabled = false;
            //    conn.Open();
            //    String query = "SELECT * FROM StockTransaction WHERE stockTransactionID = @stockTransactionID;";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@stockTransactionID", editID);
            //        if (cmd.ExecuteScalar() == null || (int)cmd.ExecuteScalar() == 0)
            //        {
            //            MessageBox.Show("ID Transaksi tidak ditemukan");
            //            return;
            //        }
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                updatequantityNumeric.Value = editQuantity = Math.Abs(Convert.ToInt32(reader["quantity"]));
            //                updatedescriptionRichBox.Text = editDesc = Convert.ToString(reader["description"]);
            //                updatedateDateTime.Value = editDate = Convert.ToDateTime(reader["date"]);
            //                editType = Convert.ToString(reader["status"]);
            //                if (editType == "IN")
            //                {
            //                    updateinRadio.Checked = true;
            //                    editQuantity *= -1;
            //                }
            //                else
            //                    updateoutRadio.Checked = true;
            //                editStockID = Convert.ToInt32(reader["stockID"]);
            //            }
            //            reader.Close();
            //        }
            //    }
            //    query = "SELECT nameStock FROM Stock WHERE stockID = @stockID;";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@stockID", editStockID);
            //        updateitemCombo.Text = editItemName = Convert.ToString(cmd.ExecuteScalar());
            //    }
            //    query = "SELECT kodeStock FROM Stock WHERE stockID = @stockID;";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@stockID", editStockID);
            //        comboBox3.Text = editKodeName = Convert.ToString(cmd.ExecuteScalar());
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                updateGroup.Enabled = false;
                conn.Open();
                String query = "SELECT * FROM StockTransaction WHERE stockTransactionID = @stockTransactionID;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@stockTransactionID", editID);
                    if (cmd.ExecuteScalar() == null)
                    {
                        MessageBox.Show("ID Transaksi tidak ditemukan");
                        return;
                    }
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            updatequantityNumeric.Value = editQuantity = Math.Abs(Convert.ToInt32(reader["quantity"]));
                            updatedescriptionRichBox.Text = editDesc = Convert.ToString(reader["description"]);
                            updatedateDateTime.Value = editDate = Convert.ToDateTime(reader["date"]);
                            editType = Convert.ToString(reader["status"]);
                            if (editType == "IN")
                            {
                                updateinRadio.Checked = true;
                                editQuantity *= -1;
                            }
                            else
                                updateoutRadio.Checked = true;
                            editStockID = Convert.ToInt32(reader["stockID"]);
                        }
                        reader.Close();
                    }
                }
                query = "SELECT nameStock FROM Stock WHERE stockID = @stockID;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@stockID", editStockID);
                    updateitemCombo.Text = editItemName = Convert.ToString(cmd.ExecuteScalar());
                }
                query = "SELECT kodeStock FROM Stock WHERE stockID = @stockID;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@stockID", editStockID);
                    comboBox3.Text = editKodeName = Convert.ToString(cmd.ExecuteScalar());
                }
                conn.Close();
            }
            updateGroup.Enabled = true;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //using (SqlConnection conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    int newStockID = 0, newQuantity = (int)updatequantityNumeric.Value, prevQuantity;
            //    String query = "SELECT stockID FROM Stock WHERE nameStock = @nameStock AND kodeStock = @kodeStock;";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@nameStock", updateitemCombo.Text);
            //        cmd.Parameters.AddWithValue("@kodeStock", comboBox3.Text);
            //        if (cmd.ExecuteScalar() == null)
            //        {
            //            MessageBox.Show("Tidak terdapat Stock ID tersebut");
            //            return;
            //        }
            //        newStockID = Convert.ToInt32(cmd.ExecuteScalar());
            //    }

            //    query = "UPDATE Stock SET quantity = @quantity WHERE stockID = @stockID;";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        String query2 = "SELECT quantity FROM Stock WHERE stockID = @stockID;";
            //        using (SqlCommand cmd2 = new SqlCommand(query2, conn))
            //        {
            //            cmd2.Parameters.AddWithValue("@stockID", newStockID);
            //            prevQuantity = Convert.ToInt32(cmd2.ExecuteScalar());
            //        }
            //        prevQuantity += editQuantity;
            //        if (updateoutRadio.Checked)
            //            newQuantity *= -1;
            //        if (prevQuantity + newQuantity < 0)
            //        {
            //            MessageBox.Show("Pengubahan Quantity tidak valid ( Jumlah stock pengurangan terlalu besar )");
            //            return;
            //        }
            //        cmd.Parameters.AddWithValue("@quantity", prevQuantity + newQuantity);
            //        cmd.Parameters.AddWithValue("@stockID", newStockID);
            //        cmd.ExecuteNonQuery();
            //    }
            //    query = @"UPDATE StockTransaction SET stockID = @stockID, status = @status, 
            //        quantity = @quantity , description = @description ,date = @date 
            //        WHERE stockTransactionID = @stockTransactionID";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@stockID", newStockID);
            //        if (updateinRadio.Checked)
            //            cmd.Parameters.AddWithValue("@status", "IN");
            //        else
            //            cmd.Parameters.AddWithValue("@status", "OUT");
            //        cmd.Parameters.AddWithValue("@quantity", Math.Abs(newQuantity));
            //        cmd.Parameters.AddWithValue("@description", updatedescriptionRichBox.Text);
            //        cmd.Parameters.AddWithValue("@date", updatedateDateTime.Value);
            //        cmd.Parameters.AddWithValue("@stockTransactionID", editID);
            //        cmd.ExecuteNonQuery();
            //    }
            //    query = "UPDATE Stock SET quantity = @quantity WHERE stockID = @stockID;";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        String query2 = "SELECT quantity FROM Stock WHERE stockID = @stockID;";
            //        using (SqlCommand cmd2 = new SqlCommand(query2, conn))
            //        {
            //            cmd2.Parameters.AddWithValue("@stockID", editStockID);
            //            prevQuantity = Convert.ToInt32(cmd2.ExecuteScalar());
            //        }
            //        cmd.Parameters.AddWithValue("@quantity", prevQuantity + editQuantity);
            //        cmd.Parameters.AddWithValue("@stockID", editStockID);
            //        cmd.ExecuteNonQuery();
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                int newStockID = 0, newQuantity = (int)updatequantityNumeric.Value, prevQuantity;
                String query = "SELECT stockID FROM Stock WHERE nameStock = @nameStock AND kodeStock = @kodeStock;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nameStock", updateitemCombo.Text);
                    cmd.Parameters.AddWithValue("@kodeStock", comboBox3.Text);
                    if (cmd.ExecuteScalar() == null)
                    {
                        MessageBox.Show("Tidak terdapat Stock ID tersebut");
                        return;
                    }
                    newStockID = Convert.ToInt32(cmd.ExecuteScalar());
                }

                query = "UPDATE Stock SET quantity = @quantity WHERE stockID = @stockID;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    String query2 = "SELECT quantity FROM Stock WHERE stockID = @stockID;";
                    using (var cmd2 = new SQLiteCommand(query2, conn))
                    {
                        cmd2.Parameters.AddWithValue("@stockID", newStockID);
                        prevQuantity = Convert.ToInt32(cmd2.ExecuteScalar());
                    }
                    prevQuantity += editQuantity;
                    if (updateoutRadio.Checked)
                        newQuantity *= -1;
                    if (prevQuantity + newQuantity < 0)
                    {
                        MessageBox.Show("Pengubahan Quantity tidak valid ( Jumlah stock pengurangan terlalu besar )");
                        return;
                    }
                    cmd.Parameters.AddWithValue("@quantity", prevQuantity + newQuantity);
                    cmd.Parameters.AddWithValue("@stockID", newStockID);
                    cmd.ExecuteNonQuery();
                }
                query = @"UPDATE StockTransaction SET stockID = @stockID, status = @status, 
                    quantity = @quantity , description = @description ,date = @date 
                    WHERE stockTransactionID = @stockTransactionID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@stockID", newStockID);
                    if (updateinRadio.Checked)
                        cmd.Parameters.AddWithValue("@status", "IN");
                    else
                        cmd.Parameters.AddWithValue("@status", "OUT");
                    cmd.Parameters.AddWithValue("@quantity", Math.Abs(newQuantity));
                    cmd.Parameters.AddWithValue("@description", updatedescriptionRichBox.Text);
                    cmd.Parameters.AddWithValue("@date", updatedateDateTime.Value);
                    cmd.Parameters.AddWithValue("@stockTransactionID", editID);
                    cmd.ExecuteNonQuery();
                }
                query = "UPDATE Stock SET quantity = @quantity WHERE stockID = @stockID;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    String query2 = "SELECT quantity FROM Stock WHERE stockID = @stockID;";
                    using (var cmd2 = new SQLiteCommand(query2, conn))
                    {
                        cmd2.Parameters.AddWithValue("@stockID", editStockID);
                        prevQuantity = Convert.ToInt32(cmd2.ExecuteScalar());
                    }
                    cmd.Parameters.AddWithValue("@quantity", prevQuantity + editQuantity);
                    cmd.Parameters.AddWithValue("@stockID", editStockID);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            MessageBox.Show("Pengubahan telah berhasil");
        }
    }
}
