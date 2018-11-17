using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BordiProject
{
    public partial class ProductionHistoryForm : Form
    {
        private void resetHistory()
        {
            productionnumberText.Text = textBox1.Text = textText.Text = positionText.Text = "";
            dateDateTime.Value = startDatetime.Value = DateTime.Today;
            startDatetime.Text = textBox2.Text = textBox3.Text = machinenumberText.Text = "";
            noRadio.Checked = barudanRadio.Checked = true;
            descriptionRich.Text = "";
            dataGridView1.Rows.Clear();
            pictureBox1.Image = Properties.Resources.noimagefound;
        }

        public ProductionHistoryForm()
        {
            InitializeComponent();
            GlobalVariable.comboBoxLoadItem(ref comboBox1, "productionID", "Production");
            startDatetime.Format = DateTimePickerFormat.Custom;
            startDatetime.CustomFormat = "dddd, dd MMMM yyyy, HH:MM tt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetHistory();
            //using (SqlConnection conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = @"SELECT productionID, nameCustomer, nameProduction, position, date, nameMachine, machineID,
            //                    quantity, style, stitch, pattern, startDateTime, image, description FROM Production[P], CUstomer[C] 
            //                    WHERE productionID = @productionID AND P.customerID = C.customerID";
            //    using (SqlCommand cmd = new SqlCommand(query,conn))
            //    {
            //        cmd.Parameters.AddWithValue("@productionID", comboBox1.Text);
            //        if (cmd.ExecuteScalar() == null)
            //        {
            //            MessageBox.Show("Nomor Produksi Tidak Ditemukan");
            //            return;
            //        }
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                productionnumberText.Text = reader["productionID"].ToString();
            //                textBox1.Text = reader["nameCustomer"].ToString();
            //                textText.Text = reader["nameProduction"].ToString();
            //                positionText.Text = reader["position"].ToString();
            //                dateDateTime.Value = Convert.ToDateTime(reader["date"].ToString()).Date;
            //                styleText.Text = reader["style"].ToString();
            //                textBox2.Text = reader["stitch"].ToString();
            //                textBox3.Text = reader["quantity"].ToString();
            //                machinenumberText.Text = reader["machineID"].ToString();
            //                if (reader["nameMachine"].ToString() == "TAJIMA")
            //                    tajimaRadio.Checked = true;
            //                if (reader["nameMachine"].ToString() == "SWF")
            //                    swfRadio.Checked = true;
            //                if (reader["pattern"].ToString() == "YES")
            //                    yesRadio.Checked = true;
            //                descriptionRich.Text = reader["description"].ToString();
            //                startDatetime.Value = Convert.ToDateTime(reader["startDateTime"]);
            //                try
            //                {
            //                    pictureBox1.Image = Image.FromStream(new MemoryStream((Byte[])(reader["image"])));
            //                }
            //                catch
            //                {
            //                    pictureBox1.Image = Properties.Resources.noimagefound;
            //                }
            //            }
            //        }
            //    }
            //    query = @"SELECT colorID, nameColor FROM Production[P], ProductionColor[PC]
            //                WHERE P.productionID = PC.productionID AND P.productionID = @productionID";
            //    List<int> colorID = new List<int>();
            //    List<String> nameColor = new List<String>();
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@productionID", comboBox1.Text);
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                colorID.Add(Convert.ToInt32(reader["colorID"]));
            //                nameColor.Add(reader["nameColor"].ToString());
            //            }
            //        }
            //    }
            //    query = @"SELECT numberColor FROM ProductionColor[PC],ProductionColorList[PCL]
            //            WHERE PC.colorID = PCL.colorID AND PC.colorID = @colorID";
            //    for (int i = 0; i < colorID.Count; i++)
            //    {
            //        List<String> temp = new List<String>() { nameColor[i] };
            //        using (SqlCommand cmd = new SqlCommand(query, conn))
            //        {
            //            cmd.Parameters.AddWithValue("@colorID", colorID[i]);
            //            using (SqlDataReader reader = cmd.ExecuteReader())
            //            {
            //                while (reader.Read())
            //                {
            //                    temp.Add(reader["numberColor"].ToString());
            //                }
            //            }
            //        }
            //        while (temp.Count < 9)
            //            temp.Add("");
            //        dataGridView1.Rows.Add(temp.ToArray());
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = @"SELECT productionID, nameCustomer, nameProduction, position, date, nameMachine, machineID,
                                quantity, style, stitch, pattern, startDateTime, image, description FROM Production[P], CUstomer[C] 
                                WHERE productionID = @productionID AND P.customerID = C.customerID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@productionID", comboBox1.Text);
                    if (cmd.ExecuteScalar() == null)
                    {
                        MessageBox.Show("Nomor Produksi Tidak Ditemukan");
                        return;
                    }
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productionnumberText.Text = reader["productionID"].ToString();
                            textBox1.Text = reader["nameCustomer"].ToString();
                            textText.Text = reader["nameProduction"].ToString();
                            positionText.Text = reader["position"].ToString();
                            dateDateTime.Value = Convert.ToDateTime(reader["date"].ToString()).Date;
                            styleText.Text = reader["style"].ToString();
                            textBox2.Text = reader["stitch"].ToString();
                            textBox3.Text = reader["quantity"].ToString();
                            machinenumberText.Text = reader["machineID"].ToString();
                            if (reader["nameMachine"].ToString() == "TAJIMA")
                                tajimaRadio.Checked = true;
                            if (reader["nameMachine"].ToString() == "SWF")
                                swfRadio.Checked = true;
                            if (reader["pattern"].ToString() == "YES")
                                yesRadio.Checked = true;
                            descriptionRich.Text = reader["description"].ToString();
                            startDatetime.Value = Convert.ToDateTime(reader["startDateTime"]);
                            try
                            {
                                pictureBox1.Image = Image.FromStream(new MemoryStream((Byte[])(reader["image"])));
                            }
                            catch
                            {
                                pictureBox1.Image = Properties.Resources.noimagefound;
                            }
                        }
                    }
                }
                query = @"SELECT colorID, nameColor FROM Production[P], ProductionColor[PC]
                            WHERE P.productionID = PC.productionID AND P.productionID = @productionID";
                List<int> colorID = new List<int>();
                List<String> nameColor = new List<String>();
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@productionID", comboBox1.Text);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            colorID.Add(Convert.ToInt32(reader["colorID"]));
                            nameColor.Add(reader["nameColor"].ToString());
                        }
                    }
                }
                query = @"SELECT numberColor FROM ProductionColor[PC],ProductionColorList[PCL]
                        WHERE PC.colorID = PCL.colorID AND PC.colorID = @colorID";
                for (int i = 0; i < colorID.Count; i++)
                {
                    List<String> temp = new List<String>() { nameColor[i] };
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@colorID", colorID[i]);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                temp.Add(reader["numberColor"].ToString());
                            }
                        }
                    }
                    while (temp.Count < 9)
                        temp.Add("");
                    dataGridView1.Rows.Add(temp.ToArray());
                }
                conn.Close();
            }
        }
    }
}
