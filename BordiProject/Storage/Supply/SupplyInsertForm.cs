using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BordiProject
{
    public partial class SupplyInsertForm : Form
    {
        
        private void initComboBox()
        {
            GlobalVariable.comboBoxLoadItem(ref transactionitemnameCombo, "nameStock", "Stock");
        }

        public SupplyInsertForm()
        {
            InitializeComponent();
            initComboBox();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            String nameStock = insertitemText.Text;
            String kodeStock = insertCodeText.Text;
            if (nameStock == "")
            {
                MessageBox.Show("Tolong isi kolom nama barang terlebih dahulu");
                return;
            }
            if (kodeStock == "")
            {
                MessageBox.Show("Tolong isi kolom kode barang terlebih dahulu");
                return;
            }
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT nameStock FROM Stock WHERE nameStock = @nameStock AND kodeStock = @kodeStock;";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@kodeStock", kodeStock);
            //        cmd.Parameters.AddWithValue("@nameStock", nameStock);
            //        if (cmd.ExecuteScalar() != null)
            //        {
            //            MessageBox.Show("Nama barang sudah pernah ditambahkan");
            //            return;
            //        }
            //    }
            //    query = "SELECT COALESCE(MAX(stockID),0) FROM Stock;";
            //    int id;
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        id = ((int)cmd.ExecuteScalar()) + 1;
            //    }
            //    query = "INSERT INTO Stock (stockID, nameStock, quantity, kodeStock) VALUES (@stockID, @nameStock, @quantity, @kodeStock)";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.CommandType = CommandType.Text;
            //        cmd.Parameters.AddWithValue("@stockID", id);
            //        cmd.Parameters.AddWithValue("@nameStock", nameStock);
            //        cmd.Parameters.AddWithValue("@quantity", 0);
            //        cmd.Parameters.AddWithValue("@kodeStock", kodeStock);
            //        cmd.ExecuteNonQuery();
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT nameStock FROM Stock WHERE nameStock = @nameStock AND kodeStock = @kodeStock;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kodeStock", kodeStock);
                    cmd.Parameters.AddWithValue("@nameStock", nameStock);
                    if (cmd.ExecuteScalar() != null)
                    {
                        MessageBox.Show("Nama barang sudah pernah ditambahkan");
                        return;
                    }
                }
                query = "SELECT COALESCE(MAX(stockID),0) FROM Stock;";
                int id;
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    id = (Convert.ToInt32(cmd.ExecuteScalar())) + 1;
                }
                query = "INSERT INTO Stock (stockID, nameStock, quantity, kodeStock) VALUES (@stockID, @nameStock, @quantity, @kodeStock)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@stockID", id);
                    cmd.Parameters.AddWithValue("@nameStock", nameStock);
                    cmd.Parameters.AddWithValue("@quantity", 0);
                    cmd.Parameters.AddWithValue("@kodeStock", kodeStock);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            MessageBox.Show("Barang telah ditambahkan");
            initComboBox();
        }

        private void transactionitemnameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            transactionitemkodeCombo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            transactionitemkodeCombo.AutoCompleteSource = AutoCompleteSource.ListItems;
            transactionitemkodeCombo.Items.Clear();
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT kodeStock FROM Stock WHERE nameStock = @nameStock;";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@nameStock", transactionitemnameCombo.Text);
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                if (!transactionitemkodeCombo.Items.Contains(reader["kodeStock"].ToString()))
            //                    transactionitemkodeCombo.Items.Add(reader["kodeStock"].ToString());
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
                    cmd.Parameters.AddWithValue("@nameStock", transactionitemnameCombo.Text);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!transactionitemkodeCombo.Items.Contains(reader["kodeStock"].ToString()))
                                transactionitemkodeCombo.Items.Add(reader["kodeStock"].ToString());
                        }
                        reader.Close();
                    }
                }
                conn.Close();
            }
            if (transactionitemkodeCombo.Items.Count > 0)
            {
                transactionitemkodeCombo.SelectedIndex = 0;
                transactionitemkodeCombo.Enabled = true;
            }
            else {
                transactionitemkodeCombo.Text = "";
                transactionitemkodeCombo.Enabled = false;
            }
        }

        private void transactionButton_Click(object sender, EventArgs e)
        {
            DateTime date = transactiondateDateTime.Value;
            String nameItem = transactionitemnameCombo.GetItemText(transactionitemnameCombo.SelectedItem), type, desc = transactiondescriptionRichBox.Text;
            String nameKode = transactionitemkodeCombo.GetItemText(transactionitemkodeCombo.SelectedItem);
            int quantity = (int)transactionquantityNumeric.Value, stockID = 0, quantityBefore = 0;
            if (transactioninRadio.Checked)
                type = "IN";
            else {
                type = "OUT";
                quantity *= -1;
            }
            Console.WriteLine(nameItem);
            //using (SqlConnection conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT COUNT(*) FROM Stock WHERE nameStock = @namaItem;";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@namaItem", nameItem);
            //        if (cmd.ExecuteScalar() == null || (int) cmd.ExecuteScalar() == 0)
            //        {
            //            MessageBox.Show("Nama Barang tidak terdapat pada database!");
            //            return;
            //        }
            //    }
            //    query = "SELECT stockID, quantity FROM Stock WHERE nameStock = @nameItem AND kodeStock = @nameKode;";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@nameItem", nameItem);
            //        cmd.Parameters.AddWithValue("@nameKode", nameKode);
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                quantityBefore = Convert.ToInt32(reader["quantity"].ToString());
            //                stockID = Convert.ToInt32(reader["stockID"].ToString());
            //            }
            //            reader.Close();
            //        }
            //        if (quantityBefore + quantity < 0)
            //        {
            //            MessageBox.Show("Jumlah pengeluaran/pemasukan tidak sesuai dengan database");
            //            return;
            //        }
            //    }
            //    query = "UPDATE Stock SET quantity = @quantity WHERE stockID = @stockID;";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@quantity", (quantityBefore + quantity));
            //        cmd.Parameters.AddWithValue("@stockID", stockID);
            //        cmd.ExecuteNonQuery();
            //    }
            //    query = "SELECT COALESCE(MAX(stockTransactionID),0) FROM StockTransaction;";
            //    int transactionId;
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        transactionId = (int) cmd.ExecuteScalar() + 1;
            //    }
            //    query = "INSERT StockTransaction (stockTransactionID,stockID,quantity,status,description,date) VALUES (@stockTransactionID,@stockID,@quantity,@status,@description,@date)";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@stockTransactionID", transactionId);
            //        cmd.Parameters.AddWithValue("@stockID", stockID);
            //        cmd.Parameters.AddWithValue("@quantity", quantity);
            //        cmd.Parameters.AddWithValue("@status", type);
            //        cmd.Parameters.AddWithValue("@description", desc);
            //        cmd.Parameters.AddWithValue("@date", date);
            //        cmd.ExecuteNonQuery();
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT COUNT(*) FROM Stock WHERE nameStock = @namaItem;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@namaItem", nameItem);
                    if (cmd.ExecuteScalar() == null)
                    {
                        MessageBox.Show("Nama Barang tidak terdapat pada database!");
                        return;
                    }
                }
                query = "SELECT stockID, quantity FROM Stock WHERE nameStock = @nameItem AND kodeStock = @nameKode;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nameItem", nameItem);
                    cmd.Parameters.AddWithValue("@nameKode", nameKode);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            quantityBefore = Convert.ToInt32(reader["quantity"].ToString());
                            stockID = Convert.ToInt32(reader["stockID"].ToString());
                        }
                        reader.Close();
                    }
                    if (quantityBefore + quantity < 0)
                    {
                        MessageBox.Show("Jumlah pengeluaran/pemasukan tidak sesuai dengan database");
                        return;
                    }
                }
                query = "UPDATE Stock SET quantity = @quantity WHERE stockID = @stockID;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@quantity", (quantityBefore + quantity));
                    cmd.Parameters.AddWithValue("@stockID", stockID);
                    cmd.ExecuteNonQuery();
                }
                query = "SELECT COALESCE(MAX(stockTransactionID),0) FROM StockTransaction;";
                int transactionId;
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    transactionId = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                }
                query = "INSERT INTO StockTransaction (stockTransactionID,stockID,quantity,status,description,date) VALUES (@stockTransactionID,@stockID,@quantity,@status,@description,@date)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@stockTransactionID", transactionId);
                    cmd.Parameters.AddWithValue("@stockID", stockID);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@status", type);
                    cmd.Parameters.AddWithValue("@description", desc);
                    cmd.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            MessageBox.Show("Transaksi Barang Berhasil!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            transactiondateDateTime.Value = DateTime.Today;
            transactioninRadio.Checked = true;
            transactionquantityNumeric.Value = 1;
            transactiondescriptionRichBox.Text = "";
        }
    }
}
