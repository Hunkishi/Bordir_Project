using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BordiProject
{
    public partial class PurchaseOrderHistoryForm : Form
    {

        private void resetHistory()
        {
            historyspesificPOGroup.Enabled = false;
            historypurchaseDataGrid.Rows.Clear();
            historypurchaseDataGrid.Columns.Clear();
            historyspesificsupplierText.Text = historyspesificsrangeText.Text = "";
            historyspesifictypecreditRadio.Checked = true;
            historyspesificsdateDateTime.Value = DateTime.Today;
            historypurchasetotalText.Text = "Rp. 0.00";
            richTextBox1.Text = "";
            historyspesifictypecreditRadio.Checked = false;
            historyspesifictypecashRadio.Checked = false;
            groupBox6.Enabled = false;
        }

        private void initComboBox()
        {
            GlobalVariable.comboBoxLoadItem(ref historynumberPOCombo, "purchaseID", "Purchase");
        }

        public PurchaseOrderHistoryForm()
        {
            InitializeComponent();
            initComboBox();
            GlobalVariable.comboBoxLoadItem(ref comboBox1, "nameCustomer", "Customer WHERE supplier = 'YES'");
        }

        private void historysearchbynumberPOButton_Click(object sender, EventArgs e)
        {
            resetHistory();
            if (historynumberPOCombo.Text == "")
            {
                MessageBox.Show("Nomor PO tidak boleh kosong");
                return;
            }
            String numberPO = historynumberPOCombo.Text;
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
            //        List<String> columns = new List<String>() { "No.", "Keterangan", "QTY", "Satuan", "Harga Satuan", "Jumlah" };
            //        foreach (var column in columns)
            //        {
            //            historypurchaseDataGrid.Columns.Add(column, column);
            //        }
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                List<String> temp = new List<String>() { };
            //                temp.Add((historypurchaseDataGrid.RowCount + 1).ToString());
            //                temp.Add(reader["nameStock"].ToString());
            //                temp.Add(reader["quantity"].ToString());
            //                temp.Add(reader["unit"].ToString());
            //                temp.Add("Rp. " + Convert.ToInt64(reader["price"]).ToString("N"));
            //                temp.Add("Rp. " + Convert.ToInt64(reader["Total"]).ToString("N"));
            //                Total += Convert.ToInt64(reader["Total"]);
            //                historypurchaseDataGrid.Rows.Add(temp.ToArray());
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
            //                historyspesificsupplierText.Text = reader["nameCustomer"].ToString();
            //                historyspesificsdateDateTime.Value = Convert.ToDateTime(reader["date"]);
            //                historyspesificsrangeText.Text = reader["rangeTime"].ToString();
            //                if (reader["type"].ToString() == "CASH")
            //                    historyspesifictypecashRadio.Checked = true;
            //                else
            //                    historyspesifictypecreditRadio.Checked = true;
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
                    List<String> columns = new List<String>() { "No.", "Keterangan", "QTY", "Satuan", "Harga Satuan", "Jumlah" };
                    foreach (var column in columns)
                    {
                        historypurchaseDataGrid.Columns.Add(column, column);
                    }
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            List<String> temp = new List<String>() { };
                            temp.Add((historypurchaseDataGrid.RowCount + 1).ToString());
                            temp.Add(reader["nameStock"].ToString());
                            temp.Add(reader["quantity"].ToString());
                            temp.Add(reader["unit"].ToString());
                            temp.Add("Rp. " + Convert.ToInt64(reader["price"]).ToString("N"));
                            temp.Add("Rp. " + Convert.ToInt64(reader["Total"]).ToString("N"));
                            Total += Convert.ToInt64(reader["Total"]);
                            historypurchaseDataGrid.Rows.Add(temp.ToArray());
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
                            historyspesificsupplierText.Text = reader["nameCustomer"].ToString();
                            historyspesificsdateDateTime.Value = Convert.ToDateTime(reader["date"]);
                            historyspesificsrangeText.Text = reader["rangeTime"].ToString();
                            if (reader["type"].ToString() == "CASH")
                                historyspesifictypecashRadio.Checked = true;
                            else
                                historyspesifictypecreditRadio.Checked = true;
                        }
                        reader.Close();
                    }
                }
                conn.Close();
            }
            historypurchasetotalText.Text = "Rp. " + Total.ToString("N");
            historyspesificPOGroup.Enabled = true;
            groupBox6.Enabled = true;
        }

        private void historybydateButton_Click(object sender, EventArgs e)
        {
            resetHistory();
            List<String> columns = new List<String>() { "Nomor PO", "Tanggal", "Jenis Pembayaran", "Supplier", "Jangka Waktu", "Jumlah Jenis Pembelian","Total Harga Pembelian" };
            if (checkBox2.Checked)
                columns.RemoveAt(3);
            if (checkBox3.Checked)
                columns.RemoveAt(2);
            foreach (var column in columns)
            {
                historypurchaseDataGrid.Columns.Add(column, column);
            }
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    String query = @"SELECT purchaseID, date, type, nameCustomer, rangeTime 
            //        FROM Purchase[P], Customer[C] WHERE C.customerID = P.customerID ";
            //    StringBuilder querytemp = new StringBuilder(query);
            //    if (checkBox1.Checked)
            //    {
            //        querytemp.Append("AND date >= @datemin AND date <= @datemax ");
            //    }
            //    if (checkBox2.Checked)
            //    {
            //        querytemp.Append("AND nameCustomer = @nameCustomer ");
            //    }
            //    if (checkBox3.Checked)
            //    {
            //        querytemp.Append("AND type = @type ");
            //    }
            //    query = querytemp.ToString();
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        conn.Open();
            //        if (checkBox1.Checked)
            //        {
            //            DateTime dateonly = historybydatefromDateTime.Value;
            //            cmd.Parameters.AddWithValue("@datemin", dateonly.Date);
            //            dateonly = historybydateuntilDateTime.Value;
            //            cmd.Parameters.AddWithValue("@datemax", dateonly.Date);
            //        }
            //        if (checkBox2.Checked)
            //        {
            //            cmd.Parameters.AddWithValue("@nameCustomer", comboBox1.Text);
            //        }
            //        if (checkBox3.Checked)
            //        {
            //            cmd.Parameters.AddWithValue("@type", radioButton1.Checked?"CREDIT":"CASH");
            //        }
            //        using (var reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                List<String> temp = new List<String>() { };
            //                temp.Add(reader["purchaseID"].ToString());
            //                temp.Add(Convert.ToDateTime(reader["date"]).ToString("dd-MMM-yyyy"));
            //                if (!checkBox3.Checked)
            //                    temp.Add(reader["type"].ToString());
            //                if (!checkBox2.Checked)
            //                    temp.Add(reader["nameCustomer"].ToString());
            //                temp.Add(reader["rangeTime"].ToString());
            //                using (var conn2 = new SqlConnection(GlobalVariable.builder))
            //                {
            //                    conn2.Open();
            //                    String query2 = "SELECT COALESCE(COUNT(*),0) FROM PurchaseList WHERE purchaseID = @purchaseID;";
            //                    using (var cmd2 = new SqlCommand(query2, conn2))
            //                    {
            //                        cmd2.Parameters.AddWithValue("@purchaseID", temp[0]);
            //                        temp.Add(cmd2.ExecuteScalar().ToString());
            //                    }
            //                    query2 = "SELECT SUM(quantity*price) FROM PurchaseList WHERE purchaseID = @purchaseID;";
            //                    using (var cmd2 = new SqlCommand(query2, conn2))
            //                    {
            //                        cmd2.Parameters.AddWithValue("@purchaseID",temp[0]);
            //                        temp.Add("Rp. " + Convert.ToInt64(cmd2.ExecuteScalar()).ToString("N"));
            //                    }
            //                    conn2.Close();
            //                }

            //                historypurchaseDataGrid.Rows.Add(temp.ToArray());
            //            }
            //            reader.Close();
            //        }
            //        conn.Close();
            //    }
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                String query = @"SELECT purchaseID, date, type, nameCustomer, rangeTime 
                    FROM Purchase[P], Customer[C] WHERE C.customerID = P.customerID ";
                StringBuilder querytemp = new StringBuilder(query);
                if (checkBox1.Checked)
                {
                    querytemp.Append(@"AND strftime('%s', date) BETWEEN strftime('%s', @datemin) AND strftime('%s', @datemax) ");
                }
                if (checkBox2.Checked)
                {
                    querytemp.Append("AND nameCustomer = @nameCustomer ");
                }
                if (checkBox3.Checked)
                {
                    querytemp.Append("AND type = @type ");
                }
                query = querytemp.ToString();
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    conn.Open();
                    if (checkBox1.Checked)
                    {
                        DateTime dateonly = historybydatefromDateTime.Value;
                        cmd.Parameters.AddWithValue("@datemin", dateonly.Date);
                        dateonly = historybydateuntilDateTime.Value;
                        cmd.Parameters.AddWithValue("@datemax", dateonly.Date);
                    }
                    if (checkBox2.Checked)
                    {
                        cmd.Parameters.AddWithValue("@nameCustomer", comboBox1.Text);
                    }
                    if (checkBox3.Checked)
                    {
                        cmd.Parameters.AddWithValue("@type", radioButton1.Checked ? "CREDIT" : "CASH");
                    }
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            List<String> temp = new List<String>() { };
                            temp.Add(reader["purchaseID"].ToString());
                            temp.Add(Convert.ToDateTime(reader["date"]).ToString("dd-MMM-yyyy"));
                            if (!checkBox3.Checked)
                                temp.Add(reader["type"].ToString());
                            if (!checkBox2.Checked)
                                temp.Add(reader["nameCustomer"].ToString());
                            temp.Add(reader["rangeTime"].ToString());
                            using (var conn2 = new SQLiteConnection(GlobalVariable.builder))
                            {
                                conn2.Open();
                                String query2 = "SELECT COALESCE(COUNT(*),0) FROM PurchaseList WHERE purchaseID = @purchaseID;";
                                using (var cmd2 = new SQLiteCommand(query2, conn2))
                                {
                                    cmd2.Parameters.AddWithValue("@purchaseID", temp[0]);
                                    temp.Add(cmd2.ExecuteScalar().ToString());
                                }
                                query2 = "SELECT SUM(quantity*price) FROM PurchaseList WHERE purchaseID = @purchaseID;";
                                using (var cmd2 = new SQLiteCommand(query2, conn2))
                                {
                                    cmd2.Parameters.AddWithValue("@purchaseID", temp[0]);
                                    temp.Add("Rp. " + Convert.ToInt64(cmd2.ExecuteScalar()).ToString("N"));
                                }
                                conn2.Close();
                            }

                            historypurchaseDataGrid.Rows.Add(temp.ToArray());
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
        }

        private void historybydatefromDateTime_ValueChanged(object sender, EventArgs e)
        {
            historypurchaseDataGrid.Rows.Clear();
            historypurchaseDataGrid.Columns.Clear();
            GlobalVariable.balanceTime(ref historybydatefromDateTime, ref historybydateuntilDateTime, false);
        }

        private void historybydateuntilDateTime_ValueChanged(object sender, EventArgs e)
        {
            historypurchaseDataGrid.Rows.Clear();
            historypurchaseDataGrid.Columns.Clear();
            GlobalVariable.balanceTime(ref historybydatefromDateTime, ref historybydateuntilDateTime, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Filter = "Excel Files | *.xlsx; *.xls; *.xlsm";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();


                    // creating new WorkBook within Excel application
                    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);


                    // creating new Excelsheet in workbook
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

                    // get the reference of first sheet. By default its name is Sheet1.
                    // store its reference to worksheet
                    worksheet = workbook.Sheets["Sheet1"];
                    worksheet = workbook.ActiveSheet;

                    // changing the name of active sheet
                    worksheet.Name = "Riwayat Transaksi PO";


                    // storing header part in Excel
                    for (int i = 1; i < historypurchaseDataGrid.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = historypurchaseDataGrid.Columns[i - 1].HeaderText;
                        worksheet.Cells[1, i].EntireRow.Font.Bold = true;
                    }


                    // storing Each row and column value to excel sheet
                    for (int i = 0; i < historypurchaseDataGrid.Rows.Count; i++)
                    {
                        for (int j = 0; j < historypurchaseDataGrid.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = historypurchaseDataGrid.Rows[i].Cells[j].Value.ToString();
                        }
                    }


                    // save the application
                    workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                    // Exit from the application
                    app.Quit();
                    Console.WriteLine(save.FileName);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            //initialize print dialog button
            ToolStripSplitButton zoomButton = ((ToolStrip)printPreviewDialog1.Controls[1]).Items[1] as ToolStripSplitButton;
            zoomButton.DropDownItems[4].PerformClick();
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            printPreviewDialog1.MouseWheel += this.PageScroll;
            //Insert Document
            printPreviewDialog1.Document = printDocument1;
            //Landscape
            //printDocument1.DefaultPageSettings.Landscape = true;
            //Print Button reconstruct
            ToolStripButton b = new ToolStripButton();
            b.ImageIndex = ((ToolStripButton)((ToolStrip)printPreviewDialog1.Controls[1]).Items[0]).ImageIndex;
            ((ToolStrip)printPreviewDialog1.Controls[1]).Items.Remove(((ToolStripButton)((ToolStrip)printPreviewDialog1.Controls[1]).Items[0]));
            b.Visible = true;
            ((ToolStrip)printPreviewDialog1.Controls[1]).Items.Insert(0, b);
            ((ToolStripButton)((ToolStrip)printPreviewDialog1.Controls[1]).Items[0]).Click += printPreview_PrintClick;
            printPreviewDialog1.ShowDialog();
        }

        private void PageScroll(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                for (int i = 0; i < 3; i++) SendKeys.Send("{UP}");
            else
                for (int i = 0; i < 3; i++) SendKeys.Send("{DOWN}");
        }

        private void printPreview_PrintClick(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            printDialog1.UseEXDialog = true;
            if (DialogResult.OK == printDialog1.ShowDialog())
            {
                printDocument1.DocumentName = "Surat Jalan";
                printDocument1.Print();
            }
        }

        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in historypurchaseDataGrid.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                //Set the left margin
                int iLeftMargin = e.MarginBounds.Left;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in historypurchaseDataGrid.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        // Save width and height of headres
                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }
                //Loop till all the grid rows not get printed
                while (iRow <= historypurchaseDataGrid.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = historypurchaseDataGrid.Rows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;
                    //Check whether the current page settings allo more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            if (!historyspesificPOGroup.Enabled)
                            {
                                //Draw Header
                                String text = "PO Summary";
                                if (checkBox2.Checked)
                                    text += " "+comboBox1.Text;
                                e.Graphics.DrawString(text, new Font(historypurchaseDataGrid.Font, FontStyle.Bold),
                                        Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                        e.Graphics.MeasureString(text, new Font(historypurchaseDataGrid.Font,
                                        FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                                if (checkBox3.Checked)
                                {
                                    String payment = (radioButton1.Checked)?"CREDIT":"CASH";
                                    String text1 = "Jenis Pembayaran : " + payment;
                                    //Draw Payment
                                    e.Graphics.DrawString(text1, new Font(historypurchaseDataGrid.Font, FontStyle.Bold),
                                            Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                            e.Graphics.MeasureString(text1, new Font(historypurchaseDataGrid.Font,
                                            FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                            e.Graphics.MeasureString(text, new Font(new Font(historypurchaseDataGrid.Font,
                                            FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);
                 
                                }
                            }

                            iTopMargin = e.MarginBounds.Top;

                            if (bFirstPage && historyspesificPOGroup.Enabled)
                            {
                                String text = richTextBox1.Text;
                                e.Graphics.DrawString(text, new Font(historypurchaseDataGrid.Font.FontFamily, 24, FontStyle.Bold),
                                    Brushes.Black, new Point(e.MarginBounds.Left, e.MarginBounds.Top));

                                List<String> Keys = new List<String>() { "Kepada", "No. PO", "Tanggal", "Tempo", "Total" };
                                List<String> Values = new List<String>() { historyspesificsupplierText.Text, historynumberPOCombo.Text
                                    , historyspesificsdateDateTime.Value.ToString("dd-MMM-yyyy"), historyspesificsrangeText.Text
                                    , historypurchasetotalText.Text};
                                //Draw Perusahaan
                                for (int i = 0; i < Keys.Count; i++)
                                {
                                    text = Keys[i];
                                    //Draw Date
                                    e.Graphics.DrawString(text, new Font(historypurchaseDataGrid.Font, FontStyle.Bold),
                                        Brushes.Black, new RectangleF(new Point(e.MarginBounds.Left + 465, iTopMargin),
                                        TextRenderer.MeasureText(text, new Font(historypurchaseDataGrid.Font, FontStyle.Bold))), strFormat);
                                    text = ": " + Values[i];
                                    e.Graphics.DrawString(text, new Font(historypurchaseDataGrid.Font, FontStyle.Bold),
                                        Brushes.Black, new RectangleF(new Point(e.MarginBounds.Left + 520, iTopMargin),
                                        TextRenderer.MeasureText(text, new Font(historypurchaseDataGrid.Font, FontStyle.Bold))), strFormat);
                                    iTopMargin += iCellHeight;
                                }
                                iTopMargin += iCellHeight;
                            }

                            //Draw Columns
                            foreach (DataGridViewColumn GridCol in historypurchaseDataGrid.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;
                        //Draw Columns Contents                
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }
                            //Drawing Cells Borders 
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;

                    //Tanda Tangan Pembuatan dan Persetujuan
                    if (iRow > historypurchaseDataGrid.Rows.Count - 1 && historyspesificPOGroup.Enabled)
                    {
                        if (iTopMargin + 6 * iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                        {
                            bNewPage = true;
                            bFirstPage = false;
                            bMorePagesToPrint = true;
                        }
                        else
                        {
                            iTopMargin += 2 * iCellHeight;
                            String text = "Pembuat";
                            e.Graphics.DrawString(text, new Font("Times New Roman", 10, FontStyle.Bold),
                                Brushes.Black, new Point(e.MarginBounds.Left + 170, iTopMargin));
                            text = "_____________";
                            e.Graphics.DrawString(text, new Font("Times New Roman", 10, FontStyle.Bold),
                                Brushes.Black, new Point(e.MarginBounds.Left + 153, iTopMargin + 3 * iCellHeight));
                            text = "Disetujui";
                            e.Graphics.DrawString(text, new Font("Times New Roman", 10, FontStyle.Bold),
                                Brushes.Black, new Point(e.MarginBounds.Left + 410, iTopMargin));
                            text = "_____________";
                            e.Graphics.DrawString(text, new Font("Times New Roman", 10, FontStyle.Bold),
                                Brushes.Black, new Point(e.MarginBounds.Left + 393, iTopMargin + 3 * iCellHeight));

                        }
                    }
                }


                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Enabled = checkBox3.Checked;
            resetHistory();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = checkBox2.Checked;
            resetHistory();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            historybydateGroup.Enabled = checkBox1.Checked;
            resetHistory();
        }

        private void historynumberPOCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetHistory();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetHistory();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            resetHistory();
        }

        private void historynumberPOCombo_TextUpdate(object sender, EventArgs e)
        {
            resetHistory();
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            resetHistory();
        }
    }
}
