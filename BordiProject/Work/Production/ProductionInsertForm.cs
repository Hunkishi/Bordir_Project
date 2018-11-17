using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BordiProject
{
    public partial class ProductionInsertForm : Form
    {
        private void initComp()
        {
            dataGridView1.Rows.Clear();
        }

        public ProductionInsertForm()
        {
            InitializeComponent();
            startDatetime.Format = DateTimePickerFormat.Custom;
            startDatetime.CustomFormat = "dddd, dd MMMM yyyy, HH:MM tt";
            GlobalVariable.comboBoxLoadItem(ref costumerCombo, "nameCustomer", "Customer WHERE customer = 'YES'");
            initComp();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            productionnumberText.Text = styleText.Text = textText.Text = positionText.Text = machinenumberText.Text = 
                descriptionRich.Text = "";
            GlobalVariable.comboBoxLoadItem(ref costumerCombo, "nameCustomer", "Customer WHERE customer = 'YES'");
            noRadio.Checked = true;
            barudanRadio.Checked = true;
            stitchNumeric.Value = quantityNumeric.Value = 1;
            //reset image
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
            pictureBox1.InitialImage = null;
            dataGridView1.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Warna bahan tidak boleh kosong");
                return;
            }
            //input Date
            DateTime Date = dateDateTime.Value;
            //input Start Date
            DateTime StartDate = startDatetime.Value;
            //input Number
            if (productionnumberText.Text == "")
            {
                MessageBox.Show("No. SPK wajib untuk diisi");
                return;
            }
            String Number = productionnumberText.Text + "/PKG/" + Date.ToString("MM/yyyy");
            //input Costumer
            if (costumerCombo.Text == "")
            {
                MessageBox.Show("Nama perusahaan wajib untuk dipilih");
                return;
            }
            String Costumer = costumerCombo.Text;
            //input Gambar/Tulisan
            if (textText.Text == "")
            {
                MessageBox.Show("Tulisan/Gambar wajib untuk diisi");
                return;
            }
            String Text = textText.Text;
            //input Position
            if (positionText.Text == "")
            {
                MessageBox.Show("Posisi wajib untuk diisi");
                return;
            }
            String Position = positionText.Text;
            //input Style
            if (styleText.Text == "")
            {
                MessageBox.Show("Style wajib untuk diisi");
                return;
            }
            String Style = styleText.Text;
            //input Stitch
            int Stitch = (int)stitchNumeric.Value;
            //input Quantity
            int Quantity = (int)quantityNumeric.Value;
            //input Pola
            String Pola;
            if (yesRadio.Checked)
                Pola = "YES";
            else
                Pola = "NO";
            //input Machine
            String Machine = "";
            if (barudanRadio.Checked) Machine = "BARUDAN";
            if (tajimaRadio.Checked) Machine = "TAJIMA";
            if (swfRadio.Checked) Machine = "SWF";
            //input MachineNumber
            if (machinenumberText.Text == "")
            {
                MessageBox.Show("Nomor Mesin wajib untuk diisi");
                return;
            }
            if (!Regex.IsMatch(machinenumberText.Text, @"^\d+$"))
            {
                MessageBox.Show("Format Nomor Mesin salah");
                return;
            }
            String MachineNumber = machinenumberText.Text;
            //input Description
            String Description = descriptionRich.Text;
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    //Cek ProductionID
            //    String query = "SELECT * FROM Production WHERE productionID = @productionID;";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@productionID", Number);
            //        if (cmd.ExecuteScalar() != null)
            //        {
            //            MessageBox.Show("Nomor SKP sudah pernah digunakan");
            //            return;
            //        }
            //    }
            //    //Get customerID
            //    query = "SELECT customerID FROM Customer WHERE nameCustomer = @nameCustomer AND customer = 'YES';";
            //    int customerID;
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@nameCustomer", Costumer);
            //        customerID = (int)cmd.ExecuteScalar();
            //    }
            //    //Get ColorList
            //    List<string> nameColor = new List<string>();
            //    List<List<int>> colorList = new List<List<int> >();
            //    for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            //    {
            //        List<int> temp = new List<int>();
            //        if (dataGridView1[0, i].Value == null)
            //        {
            //            MessageBox.Show("Warna Bahan Tidak Boleh Kosong");
            //            return;
            //        }
            //        nameColor.Add(dataGridView1[0, i].Value.ToString());

            //        for (int j = 1; j < dataGridView1.Columns.Count; j++)
            //        {
            //            if (dataGridView1[j,i].Value != null && !Regex.IsMatch(dataGridView1[j,i].Value.ToString(), @"^\d+$"))
            //            {
            //                MessageBox.Show("Format Nomor Benang Salah");
            //                return;
            //            }
            //            if (dataGridView1[j,i].Value != null)
            //               temp.Add(Convert.ToInt32(dataGridView1[j,i].Value.ToString()));
            //        }
            //        if (temp.Count == 0)
            //        {
            //            MessageBox.Show("Nomor Benang wajib diisi minimal 1");
            //            return;
            //        }
            //        colorList.Add(temp);
            //    }
            //    //Masukkan Data
            //    query = "INSERT INTO Production (productionID,customerID,nameProduction,position,date,nameMachine,machineID,quantity,style,stitch,pattern,startDateTime,image,description) " +
            //        "VALUES (@productionID,@customerID,@nameProduction,@position,@date,@nameMachine,@machineID,@quantity,@style,@stitch,@pattern,@startDateTime,@image,@description);";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@productionID", Number);
            //        cmd.Parameters.AddWithValue("@customerID", customerID);
            //        cmd.Parameters.AddWithValue("@nameProduction", Text);
            //        cmd.Parameters.AddWithValue("@position", Position);
            //        cmd.Parameters.AddWithValue("@date", Date);
            //        cmd.Parameters.AddWithValue("@nameMachine", Machine);
            //        cmd.Parameters.AddWithValue("@machineID", MachineNumber);
            //        cmd.Parameters.AddWithValue("@quantity", Quantity);
            //        cmd.Parameters.AddWithValue("@style", Style);
            //        cmd.Parameters.AddWithValue("@stitch", Stitch);
            //        cmd.Parameters.AddWithValue("@pattern", Pola);
            //        cmd.Parameters.AddWithValue("@startDateTime", startDatetime.Value);
            //        String newImageLocation = AppDomain.CurrentDomain.BaseDirectory + "\\temp.jpeg";
            //        byte[] img = null;
            //        if (pictureBox1 != null && pictureBox1.Image != null)
            //        {

            //            pictureBox1.Image.Save(newImageLocation, System.Drawing.Imaging.ImageFormat.Jpeg);
            //            using (FileStream stream = new FileStream(newImageLocation, FileMode.Open, FileAccess.Read))
            //            {
            //                BinaryReader reader = new BinaryReader(stream);
            //                img = reader.ReadBytes((int)stream.Length);
            //                cmd.Parameters.Add("@image", SqlDbType.Image, img.Length).Value = img;
            //            }
            //        }
            //        else
            //            cmd.Parameters.AddWithValue("@image", new Byte[0]);
            //        cmd.Parameters.AddWithValue("@description", Description);
            //        cmd.ExecuteNonQuery();
            //        if (pictureBox1 != null && pictureBox1.Image != null)
            //            File.Delete(newImageLocation);
            //    }
            //    //Masukkan List Warna 
            //    query = "INSERT INTO ProductionColor (productionID, colorID, nameColor) VALUES (@productionID, @colorID, @nameColor);";
            //    for (int i = 0; i < nameColor.Count; i++)
            //    {
            //        //Get colorID
            //        String query2 = "SELECT COALESCE(MAX(colorID),0) FROM ProductionColor;";
            //        int colorID;
            //        using (var cmd = new SqlCommand(query2, conn))
            //        {
            //            colorID = ((int)cmd.ExecuteScalar()) + 1;
            //        }
            //        using (var cmd = new SqlCommand(query, conn))
            //        {
            //            cmd.Parameters.AddWithValue("@productionID", Number);
            //            cmd.Parameters.AddWithValue("@colorID", colorID);
            //            cmd.Parameters.AddWithValue("@nameColor", nameColor[i]);
            //            cmd.ExecuteNonQuery();
            //        }
            //        for (int j = 0; j < colorList[i].Count; j++)
            //        {
            //            query2 = "INSERT INTO ProductionColorList (colorID, numberColor) VALUES (@colorID, @numberColor);";
            //            using (var cmd = new SqlCommand(query2, conn))
            //            {
            //                cmd.Parameters.AddWithValue("@colorID", colorID);
            //                cmd.Parameters.AddWithValue("@numberColor", colorList[i][j]);
            //                cmd.ExecuteNonQuery();
            //            }
            //        }
            //    }
            //    //DEBUG IMAGE
            //    //query = "SELECT image FROM Production WHERE productionID = @productionID";
            //    //using (var cmd = new SqlCommand(query, conn))
            //    //{
            //    //    cmd.Parameters.AddWithValue("@productionID", Number);
            //    //    using (SqlDataReader reader = cmd.ExecuteReader())
            //    //    {
            //    //        while (reader.Read())
            //    //        {
            //    //            try
            //    //            {
            //    //                pictureBox1.Image = Image.FromStream(new MemoryStream((Byte[])(reader["image"])));
            //    //            }
            //    //            catch
            //    //            {
            //    //                pictureBox1.Image = Properties.Resources.noimagefound;
            //    //            }
            //    //        }
            //    //        reader.Close();
            //    //    }
            //    //}
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                //Cek ProductionID
                String query = "SELECT * FROM Production WHERE productionID = @productionID;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@productionID", Number);
                    if (cmd.ExecuteScalar() != null)
                    {
                        MessageBox.Show("Nomor SKP sudah pernah digunakan");
                        return;
                    }
                }
                //Get customerID
                query = "SELECT customerID FROM Customer WHERE nameCustomer = @nameCustomer AND customer = 'YES';";
                int customerID;
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nameCustomer", Costumer);
                    customerID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                //Get ColorList
                List<string> nameColor = new List<string>();
                List<List<int>> colorList = new List<List<int>>();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    List<int> temp = new List<int>();
                    if (dataGridView1[0, i].Value == null)
                    {
                        MessageBox.Show("Warna Bahan Tidak Boleh Kosong");
                        return;
                    }
                    nameColor.Add(dataGridView1[0, i].Value.ToString());

                    for (int j = 1; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1[j, i].Value != null && !Regex.IsMatch(dataGridView1[j, i].Value.ToString(), @"^\d+$"))
                        {
                            MessageBox.Show("Format Nomor Benang Salah");
                            return;
                        }
                        if (dataGridView1[j, i].Value != null)
                            temp.Add(Convert.ToInt32(dataGridView1[j, i].Value.ToString()));
                    }
                    if (temp.Count == 0)
                    {
                        MessageBox.Show("Nomor Benang wajib diisi minimal 1");
                        return;
                    }
                    colorList.Add(temp);
                }
                //Masukkan Data
                query = "INSERT INTO Production (productionID,customerID,nameProduction,position,date,nameMachine,machineID,quantity,style,stitch,pattern,startDateTime,image,description) " +
                    "VALUES (@productionID,@customerID,@nameProduction,@position,@date,@nameMachine,@machineID,@quantity,@style,@stitch,@pattern,@startDateTime,@image,@description);";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@productionID", Number);
                    cmd.Parameters.AddWithValue("@customerID", customerID);
                    cmd.Parameters.AddWithValue("@nameProduction", Text);
                    cmd.Parameters.AddWithValue("@position", Position);
                    cmd.Parameters.AddWithValue("@date", Date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@nameMachine", Machine);
                    cmd.Parameters.AddWithValue("@machineID", MachineNumber);
                    cmd.Parameters.AddWithValue("@quantity", Quantity);
                    cmd.Parameters.AddWithValue("@style", Style);
                    cmd.Parameters.AddWithValue("@stitch", Stitch);
                    cmd.Parameters.AddWithValue("@pattern", Pola);
                    cmd.Parameters.AddWithValue("@startDateTime", startDatetime.Value);
                    String newImageLocation = AppDomain.CurrentDomain.BaseDirectory + "\\temp.jpeg";
                    byte[] img = null;
                    if (pictureBox1 != null && pictureBox1.Image != null)
                    {

                        pictureBox1.Image.Save(newImageLocation, System.Drawing.Imaging.ImageFormat.Jpeg);
                        using (FileStream stream = new FileStream(newImageLocation, FileMode.Open, FileAccess.Read))
                        {
                            BinaryReader reader = new BinaryReader(stream);
                            img = reader.ReadBytes((int)stream.Length);
                            cmd.Parameters.Add("@image", DbType.Binary, img.Length).Value = img;
                        }
                    }
                    else
                        cmd.Parameters.AddWithValue("@image", new Byte[0]);
                    cmd.Parameters.AddWithValue("@description", Description);
                    cmd.ExecuteNonQuery();
                    if (pictureBox1 != null && pictureBox1.Image != null)
                        File.Delete(newImageLocation);
                }
                //Masukkan List Warna 
                query = "INSERT INTO ProductionColor (productionID, colorID, nameColor) VALUES (@productionID, @colorID, @nameColor);";
                for (int i = 0; i < nameColor.Count; i++)
                {
                    //Get colorID
                    String query2 = "SELECT COALESCE(MAX(colorID),0) FROM ProductionColor;";
                    int colorID;
                    using (var cmd = new SQLiteCommand(query2, conn))
                    {
                        colorID = (Convert.ToInt32(cmd.ExecuteScalar())) + 1;
                    }
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productionID", Number);
                        cmd.Parameters.AddWithValue("@colorID", colorID);
                        cmd.Parameters.AddWithValue("@nameColor", nameColor[i]);
                        cmd.ExecuteNonQuery();
                    }
                    for (int j = 0; j < colorList[i].Count; j++)
                    {
                        query2 = "INSERT INTO ProductionColorList (colorID, numberColor) VALUES (@colorID, @numberColor);";
                        using (var cmd = new SQLiteCommand(query2, conn))
                        {
                            cmd.Parameters.AddWithValue("@colorID", colorID);
                            cmd.Parameters.AddWithValue("@numberColor", colorList[i][j]);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                //DEBUG IMAGE
                query = "SELECT image FROM Production WHERE productionID = @productionID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@productionID", Number);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                pictureBox1.Image = Image.FromStream(new MemoryStream((Byte[])(reader["image"])));
                            }
                            catch
                            {
                                pictureBox1.Image = Properties.Resources.noimagefound;
                            }
                        }
                        reader.Close();
                    }
                }
                conn.Close();
            }
            MessageBox.Show("Data Berhasil Dimasukkan");
            initComp();
            resetButton_Click(sender,e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Load(open.FileName);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
