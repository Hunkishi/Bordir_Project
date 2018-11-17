using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BordiProject
{
    public partial class DeliveryHistoryForm : Form
    {
        private void initComboBox()
        {
            GlobalVariable.comboBoxLoadItem(ref comboBox2, "orderID", "OrderStatus");
            GlobalVariable.comboBoxLoadItem(ref comboBox1, "nameCustomer", "Customer WHERE customer = 'YES'");
            GlobalVariable.comboBoxLoadItem(ref comboBox3, "nameCustomer", "Customer WHERE customer = 'YES'");
        }

        private void untilDatetime_ValueChanged(object sender, EventArgs e)
        {
            GlobalVariable.balanceTime(ref fromDatetime, ref untilDatetime, true);
        }

        private void fromDatetime_ValueChanged(object sender, EventArgs e)
        {
            GlobalVariable.balanceTime(ref fromDatetime, ref untilDatetime, false);
        }

        private void resetHistory()
        {
            datetime1.Value = DateTime.Today;
            richTextBox1.Text = textBox3.Text = textBox2.Text = "";
            textBox8.Text = "0";
            orderDataGrid.Columns.Clear();
            orderDataGrid.Rows.Clear();
            groupBox9.Enabled = false;
        }

        public DeliveryHistoryForm()
        {
            InitializeComponent();
            initComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
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
                for(int i=0;i<3;i++) SendKeys.Send("{UP}");
            else
                for(int i=0;i<3;i++) SendKeys.Send("{DOWN}");
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

        private void RemoveClickEvent(ToolStripButton b)
        {
            FieldInfo f1 = typeof(Control).GetField("EventClick",
                BindingFlags.Static | BindingFlags.NonPublic);
            object obj = f1.GetValue(b);
            PropertyInfo pi = b.GetType().GetProperty("Events",
                BindingFlags.NonPublic | BindingFlags.Instance);
            EventHandlerList list = (EventHandlerList)pi.GetValue(b, null);
            list.RemoveHandler(obj, list[obj]);
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
                foreach (DataGridViewColumn dgvGridCol in orderDataGrid.Columns)
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
                    foreach (DataGridViewColumn GridCol in orderDataGrid.Columns)
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
                while (iRow <= orderDataGrid.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = orderDataGrid.Rows[iRow];
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
                            //Draw Header
                            e.Graphics.DrawString("Order Summary", new Font(orderDataGrid.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Order Summary", new Font(orderDataGrid.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate, new Font(orderDataGrid.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(orderDataGrid.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Order Summary", new Font(new Font(orderDataGrid.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in orderDataGrid.Columns)
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

        private void button3_Click(object sender, EventArgs e)
        {
            resetHistory();
            String orderID = comboBox2.Text;
            String status;
            if (orderID == "")
            {
                MessageBox.Show("Nomor Surat Jalan tidak boleh kosong");
                return;
            }
            if (radioButton1.Checked && !Regex.IsMatch(orderID, @"^\d+$"))
            {
                MessageBox.Show("Format nomor surat jalan salah");
                return;
            }
            if (radioButton2.Checked)
                status = "MASUK";
            else
                status = "KELUAR";
            long Total = 0;
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = @"SELECT nameItem, quantity, unit FROM OrderItem WHERE orderID = @orderID AND status = @status;";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@orderID", orderID);
            //        cmd.Parameters.AddWithValue("@status", status);
            //        if (cmd.ExecuteScalar() == null)
            //        {
            //            MessageBox.Show("Nomor Surat Jalan tidak ditemukan");
            //            return;
            //        }
            //        List<String> columns = new List<String>() { "No.", "Nama Barang", "QTY", "Satuan"};
            //        foreach (var column in columns)
            //        {
            //            orderDataGrid.Columns.Add(column, column);
            //        }
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                List<String> temp = new List<String>() { };
            //                temp.Add((orderDataGrid.RowCount + 1).ToString());
            //                temp.Add(reader["nameItem"].ToString());
            //                temp.Add(reader["quantity"].ToString());
            //                temp.Add(reader["unit"].ToString());
            //                Total += Convert.ToInt32(reader["quantity"]);
            //                orderDataGrid.Rows.Add(temp.ToArray());
            //            }
            //            reader.Close();
            //        }
            //    }
            //    query = @"SELECT nameCustomer AS cmtNameCustomer, buyerNameCustomer, style, date, description FROM 
            //            (SELECT cmtCustomerID, nameCustomer AS buyerNameCustomer, style, date, description FROM OrderStatus[OS]
            //            , Customer[C] WHERE C.customerID = OS.buyerCustomerID AND orderID = @orderID AND status = @status) AS OS2, Customer[C] 
            //            WHERE C.customerID = OS2.cmtCustomerID";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@orderID", orderID);
            //        cmd.Parameters.AddWithValue("@status", status);
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                textBox3.Text = reader["buyerNameCustomer"].ToString();
            //                textBox4.Text = reader["cmtNameCustomer"].ToString();
            //                datetime1.Value = Convert.ToDateTime(reader["date"]);
            //                textBox2.Text = reader["style"].ToString();
            //                richTextBox1.Text = reader["description"].ToString();
            //            }
            //            reader.Close();
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = @"SELECT nameItem, quantity, unit FROM OrderItem WHERE orderID = @orderID AND status = @status;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@orderID", orderID);
                    cmd.Parameters.AddWithValue("@status", status);
                    if (cmd.ExecuteScalar() == null)
                    {
                        MessageBox.Show("Nomor Surat Jalan tidak ditemukan");
                        return;
                    }
                    List<String> columns = new List<String>() { "No.", "Nama Barang", "QTY", "Satuan" };
                    foreach (var column in columns)
                    {
                        orderDataGrid.Columns.Add(column, column);
                    }
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            List<String> temp = new List<String>() { };
                            temp.Add((orderDataGrid.RowCount + 1).ToString());
                            temp.Add(reader["nameItem"].ToString());
                            temp.Add(reader["quantity"].ToString());
                            temp.Add(reader["unit"].ToString());
                            Total += Convert.ToInt32(reader["quantity"]);
                            orderDataGrid.Rows.Add(temp.ToArray());
                        }
                        reader.Close();
                    }
                }
                query = @"SELECT nameCustomer AS cmtNameCustomer, buyerNameCustomer, style, date, description FROM 
                        (SELECT cmtCustomerID, nameCustomer AS buyerNameCustomer, style, date, description FROM OrderStatus[OS]
                        , Customer[C] WHERE C.customerID = OS.buyerCustomerID AND orderID = @orderID AND status = @status) AS OS2, Customer[C] 
                        WHERE C.customerID = OS2.cmtCustomerID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@orderID", orderID);
                    cmd.Parameters.AddWithValue("@status", status);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            textBox3.Text = reader["buyerNameCustomer"].ToString();
                            textBox4.Text = reader["cmtNameCustomer"].ToString();
                            datetime1.Value = Convert.ToDateTime(reader["date"]);
                            textBox2.Text = reader["style"].ToString();
                            richTextBox1.Text = reader["description"].ToString();
                        }
                        reader.Close();
                    }
                }
                conn.Close();
            }
            textBox8.Text = Total.ToString();
            groupBox9.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog save = new SaveFileDialog())
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
                    worksheet.Name = "Riwayat Transaksi Surat Jalan";


                    // storing header part in Excel
                    for (int i = 1; i < orderDataGrid.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = orderDataGrid.Columns[i - 1].HeaderText;
                        worksheet.Cells[1, i].EntireRow.Font.Bold = true;
                    }
                    

                    // storing Each row and column value to excel sheet
                    for (int i = 0; i < orderDataGrid.Rows.Count; i++)
                    {
                        for (int j = 0; j < orderDataGrid.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = orderDataGrid.Rows[i].Cells[j].Value.ToString();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            searchGroup.Enabled = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Enabled = checkBox2.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Enabled = checkBox5.Checked;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            groupBox7.Enabled = checkBox6.Checked;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resetHistory();
            List<String> columns = new List<String>() { "Nomor Surat Jalan", "Status", "Style", "Tanggal", "Buyer", "CMT", "Total Barang" };
            foreach (var column in columns)
            {
                orderDataGrid.Columns.Add(column, column);
            }
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    String query = @"SELECT orderID, status, style, buyerNameCustomer, nameCustomer AS cmtNameCustomer, date, total FROM
            //        (SELECT OS.orderID, OS.status, date, OS.style, nameCustomer AS buyerNameCustomer, OS.cmtCustomerID, SUM(quantity) AS total 
            //        FROM OrderStatus[OS], Customer[C], OrderItem[OI] WHERE C.customerID = OS.buyerCustomerID 
            //        AND OS.orderID = OI.orderID AND OS.status = OI.status
            //        AND OS.buyerCustomerID = OI.buyerCustomerID AND OS.cmtCustomerID = OI.cmtCustomerID 
            //        GROUP BY OS.orderID, OS.status, date, OS.style,nameCustomer ,OS.cmtCustomerID) 
            //        AS OSS, Customer[C] WHERE OSS.cmtCustomerID = C.customerID ";
            //    StringBuilder querytemp = new StringBuilder(query);
            //    if (checkBox1.Checked)
            //    {
            //        querytemp.Append(@"AND OSS.date >= @datemin ");
            //        querytemp.Append(@"AND OSS.date <= @datemax ");
            //    }
            //    if (checkBox2.Checked)
            //    {
            //        querytemp.Append(@"AND OSS.buyerNameCustomer = @buyerNameCustomer ");
            //    }
            //    if (checkBox6.Checked)
            //    {
            //        querytemp.Append(@"AND C.nameCustomer = @cmtNameCustomer ");
            //    }
            //    if (!checkBox3.Checked)
            //    {
            //        querytemp.Append(@"AND OSS.status != 'MASUK' ");
            //    }
            //    if (!checkBox4.Checked)
            //    {
            //        querytemp.Append(@"AND OSS.status != 'KELUAR' ");
            //    }
            //    if (checkBox5.Checked)
            //    {
            //        querytemp.Append(@"AND OSS.style = @style ");
            //    }
            //    query = querytemp.ToString();
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        conn.Open();
            //        if (checkBox1.Checked)
            //        {
            //            DateTime dateonly = fromDatetime.Value;
            //            cmd.Parameters.AddWithValue("@datemin", dateonly.Date);
            //            dateonly = untilDatetime.Value;
            //            cmd.Parameters.AddWithValue("@datemax", dateonly.Date);
            //        }
            //        if (checkBox2.Checked)
            //        {
            //            cmd.Parameters.AddWithValue("@buyerNameCustomer", comboBox1.Text);
            //        }
            //        if (checkBox6.Checked)
            //        {
            //            cmd.Parameters.AddWithValue("@cmtNameCustomer", comboBox3.Text);
            //        }
            //        if (checkBox5.Checked)
            //        {
            //            cmd.Parameters.AddWithValue("@style", textBox1.Text);
            //        }
            //        using (var reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                List<String> temp = new List<String>() { };
            //                temp.Add(reader["orderID"].ToString());
            //                temp.Add(reader["status"].ToString());
            //                temp.Add(reader["style"].ToString());
            //                temp.Add(Convert.ToDateTime(reader["date"]).ToString("dd-MMM-yyyy"));
            //                temp.Add(reader["buyerNameCustomer"].ToString());
            //                temp.Add(reader["cmtNameCustomer"].ToString());
            //                temp.Add(reader["total"].ToString());
            //                orderDataGrid.Rows.Add(temp.ToArray());
            //            }
            //            reader.Close();
            //        }
            //        conn.Close();
            //    }
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                String query = @"SELECT orderID, status, style, buyerNameCustomer, nameCustomer AS cmtNameCustomer, date, total FROM
                    (SELECT OS.orderID, OS.status, date, OS.style, nameCustomer AS buyerNameCustomer, OS.cmtCustomerID, SUM(quantity) AS total 
                    FROM OrderStatus[OS], Customer[C], OrderItem[OI] WHERE C.customerID = OS.buyerCustomerID 
                    AND OS.orderID = OI.orderID AND OS.status = OI.status
                    AND OS.buyerCustomerID = OI.buyerCustomerID AND OS.cmtCustomerID = OI.cmtCustomerID 
                    GROUP BY OS.orderID, OS.status, date, OS.style,nameCustomer ,OS.cmtCustomerID) 
                    AS OSS, Customer[C] WHERE OSS.cmtCustomerID = C.customerID ";
                StringBuilder querytemp = new StringBuilder(query);
                if (checkBox1.Checked)
                {
                    querytemp.Append(@"AND strftime('%s', OSS.date) BETWEEN strftime('%s', @datemin) AND strftime('%s', @datemax) ");
                }
                if (checkBox2.Checked)
                {
                    querytemp.Append(@"AND OSS.buyerNameCustomer = @buyerNameCustomer ");
                }
                if (checkBox6.Checked)
                {
                    querytemp.Append(@"AND C.nameCustomer = @cmtNameCustomer ");
                }
                if (!checkBox3.Checked)
                {
                    querytemp.Append(@"AND OSS.status != 'MASUK' ");
                }
                if (!checkBox4.Checked)
                {
                    querytemp.Append(@"AND OSS.status != 'KELUAR' ");
                }
                if (checkBox5.Checked)
                {
                    querytemp.Append(@"AND OSS.style = @style ");
                }
                query = querytemp.ToString();
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    conn.Open();
                    if (checkBox1.Checked)
                    {
                        DateTime dateonly = fromDatetime.Value;
                        cmd.Parameters.AddWithValue("@datemin", dateonly.Date);
                        dateonly = untilDatetime.Value;
                        cmd.Parameters.AddWithValue("@datemax", dateonly.Date);
                    }
                    if (checkBox2.Checked)
                    {
                        cmd.Parameters.AddWithValue("@buyerNameCustomer", comboBox1.Text);
                    }
                    if (checkBox6.Checked)
                    {
                        cmd.Parameters.AddWithValue("@cmtNameCustomer", comboBox3.Text);
                    }
                    if (checkBox5.Checked)
                    {
                        cmd.Parameters.AddWithValue("@style", textBox1.Text);
                    }
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            List<String> temp = new List<String>() { };
                            temp.Add(reader["orderID"].ToString());
                            temp.Add(reader["status"].ToString());
                            temp.Add(reader["style"].ToString());
                            temp.Add(Convert.ToDateTime(reader["date"]).ToString("dd-MMM-yyyy"));
                            temp.Add(reader["buyerNameCustomer"].ToString());
                            temp.Add(reader["cmtNameCustomer"].ToString());
                            temp.Add(reader["total"].ToString());
                            orderDataGrid.Rows.Add(temp.ToArray());
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
        }

    }
}
