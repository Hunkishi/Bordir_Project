using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BordiProject
{
    public partial class ReceiptHistoryForm : Form
    {
        private void resetHistory()
        {
            groupBox1.Enabled = false;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            textBox1.Text = "";
            textBox2.Text = "Rp. 0.00";
            dateTimePicker1.Value = DateTime.Today;
        }

        private void initComboBox()
        {
            GlobalVariable.comboBoxLoadItem(ref comboBox1, "receiptID", "Receipt");
            GlobalVariable.comboBoxLoadItem(ref comboBox2, "nameCustomer", "Customer WHERE customer = 'YES'");
        }

        public ReceiptHistoryForm()
        {
            InitializeComponent();
            initComboBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resetHistory();
            List<String> columns = new List<String>() { "No. Tanda Terima", "Perusahaan", "Tanggal", "PPN", "PPH", "Total"};
            foreach (var column in columns)
            {
                dataGridView2.Columns.Add(column, column);
            }
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    String query = @"SELECT receiptID, nameCustomer, date, ppn, pph FROM Receipt[R], Customer[C] 
            //            WHERE R.customerID = C.customerID ";
            //    StringBuilder querytemp = new StringBuilder(query);
            //    if (checkBox7.Checked)
            //    {
            //        dataGridView2.Columns.RemoveAt(4);
            //        dataGridView2.Columns.RemoveAt(3);
            //        if (!checkBox3.Checked)
            //            querytemp.Append("AND ppn != 1 ");
            //        if (!checkBox4.Checked)
            //            querytemp.Append("AND pph != 1 ");
            //    }
            //    if (checkBox5.Checked)
            //    {
            //        dataGridView2.Columns.RemoveAt(1);
            //        querytemp.Append("AND C.nameCustomer = @nameCustomer ");
            //    }
            //    if (checkBox6.Checked)
            //    {
            //        querytemp.Append("AND date >= @datemin AND date <= @datemax ");
            //    }
            //    query = querytemp.ToString();
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        conn.Open();
            //        if (checkBox5.Checked)
            //        {
            //            cmd.Parameters.AddWithValue("@nameCustomer", comboBox2.Text);
            //        }
            //        if (checkBox6.Checked)
            //        {
            //            DateTime dateonly = dateTimePicker5.Value;
            //            cmd.Parameters.AddWithValue("@datemin", dateonly.Date);
            //            dateonly = dateTimePicker4.Value;
            //            cmd.Parameters.AddWithValue("@datemax", dateonly.Date);
            //        }
            //        using (var reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                List<String> temp = new List<String>() { };
            //                temp.Add(reader["receiptID"].ToString());
            //                int receiptID = Convert.ToInt32(reader["receiptID"]);
            //                if (!checkBox5.Checked)
            //                    temp.Add(reader["nameCustomer"].ToString());
            //                temp.Add(Convert.ToDateTime(reader["date"]).ToString("dd-MMM-yyyy"));
            //                if (!checkBox7.Checked)
            //                {
            //                    if (Convert.ToBoolean(reader["ppn"]))
            //                        temp.Add("YA");
            //                    else
            //                        temp.Add("TIDAK");
            //                    if (Convert.ToBoolean(reader["pph"]))
            //                        temp.Add("YA");
            //                    else
            //                        temp.Add("TIDAK");
            //                }
            //                long total = 0;
            //                using (var conn2 = new SqlConnection(GlobalVariable.builder))
            //                {
            //                    conn2.Open();
            //                    String query2 = @"SELECT SUM(price*quantity) FROM ReceiptInvoice[RI], InvoiceList[IL] 
            //                                    WHERE receiptID = @receiptID AND RI.invoicesID = IL.invoicesID;";
            //                    using (var cmd2 = new SqlCommand(query2, conn2))
            //                    {
            //                        cmd2.Parameters.AddWithValue("@receiptID", receiptID);
            //                        total = Convert.ToInt64(cmd2.ExecuteScalar());
            //                    }
            //                    conn2.Close();
            //                }
            //                long BeforeTax = total;
            //                if (Convert.ToBoolean(reader["ppn"]))
            //                    total += BeforeTax/10;
            //                if (Convert.ToBoolean(reader["pph"]))
            //                    total -= BeforeTax/50;
            //                temp.Add("Rp. " + total.ToString("N"));
            //                dataGridView2.Rows.Add(temp.ToArray());
            //            }
            //            reader.Close();
            //        }
            //        conn.Close();
            //    }
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                String query = @"SELECT receiptID, nameCustomer, date, ppn, pph FROM Receipt[R], Customer[C] 
                        WHERE R.customerID = C.customerID ";
                StringBuilder querytemp = new StringBuilder(query);
                if (checkBox7.Checked)
                {
                    dataGridView2.Columns.RemoveAt(4);
                    dataGridView2.Columns.RemoveAt(3);
                    if (!checkBox3.Checked)
                        querytemp.Append("AND ppn != 1 ");
                    if (!checkBox4.Checked)
                        querytemp.Append("AND pph != 1 ");
                }
                if (checkBox5.Checked)
                {
                    dataGridView2.Columns.RemoveAt(1);
                    querytemp.Append("AND C.nameCustomer = @nameCustomer ");
                }
                if (checkBox6.Checked)
                {
                    querytemp.Append(@"AND strftime('%s', date) BETWEEN strftime('%s', @datemin) AND strftime('%s', @datemax) ");
                }
                query = querytemp.ToString();
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    conn.Open();
                    if (checkBox5.Checked)
                    {
                        cmd.Parameters.AddWithValue("@nameCustomer", comboBox2.Text);
                    }
                    if (checkBox6.Checked)
                    {
                        DateTime dateonly = dateTimePicker5.Value;
                        cmd.Parameters.AddWithValue("@datemin", dateonly.Date);
                        dateonly = dateTimePicker4.Value;
                        cmd.Parameters.AddWithValue("@datemax", dateonly.Date);
                    }
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            List<String> temp = new List<String>() { };
                            temp.Add(reader["receiptID"].ToString());
                            int receiptID = Convert.ToInt32(reader["receiptID"]);
                            if (!checkBox5.Checked)
                                temp.Add(reader["nameCustomer"].ToString());
                            temp.Add(Convert.ToDateTime(reader["date"]).ToString("dd-MMM-yyyy"));
                            if (!checkBox7.Checked)
                            {
                                if (Convert.ToBoolean(reader["ppn"]))
                                    temp.Add("YA");
                                else
                                    temp.Add("TIDAK");
                                if (Convert.ToBoolean(reader["pph"]))
                                    temp.Add("YA");
                                else
                                    temp.Add("TIDAK");
                            }
                            long total = 0;
                            using (var conn2 = new SQLiteConnection(GlobalVariable.builder))
                            {
                                conn2.Open();
                                String query2 = @"SELECT SUM(price*quantity) FROM ReceiptInvoice[RI], InvoiceList[IL] 
                                                WHERE receiptID = @receiptID AND RI.invoicesID = IL.invoicesID;";
                                using (var cmd2 = new SQLiteCommand(query2, conn2))
                                {
                                    cmd2.Parameters.AddWithValue("@receiptID", receiptID);
                                    total = Convert.ToInt64(cmd2.ExecuteScalar());
                                }
                                conn2.Close();
                            }
                            long BeforeTax = total;
                            if (Convert.ToBoolean(reader["ppn"]))
                                total += BeforeTax / 10;
                            if (Convert.ToBoolean(reader["pph"]))
                                total -= BeforeTax / 50;
                            temp.Add("Rp. " + total.ToString("N"));
                            dataGridView2.Rows.Add(temp.ToArray());
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resetHistory();
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Nomor tanda terima tidak boleh kosong");
                return;
            }
            if (!Regex.IsMatch(comboBox1.Text, @"^\d+$"))
            {
                MessageBox.Show("Format nomor tanda terima jalan salah");
                return;
            }
            int receiptID = Convert.ToInt32(comboBox1.Text);
            long Total = 0;
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = @"SELECT nameCustomer, date, pph, ppn FROM Receipt[R], Customer[C] 
                    WHERE C.customerID = R.customerID AND receiptID = @receiptID;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@receiptID", receiptID);
                    if (cmd.ExecuteScalar() == null)
                    {
                        MessageBox.Show("Nomor tanda terima tidak ditemukan");
                        return;
                    }
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            checkBox1.Checked = Convert.ToBoolean(reader["ppn"]);
                            checkBox2.Checked = Convert.ToBoolean(reader["pph"]);
                            textBox1.Text = reader["nameCustomer"].ToString();
                            dateTimePicker1.Value = Convert.ToDateTime(reader["date"]);
                        }
                        reader.Close();
                    }
                }
                query = @"SELECT date, RI.invoicesID, description FROM ReceiptInvoice[RI], Invoice[I] 
                    WHERE RI.invoicesID = I.invoicesID AND receiptID = @receiptID;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@receiptID", receiptID);
                    List<String> columns = new List<String>() { "No. ", "Tanggal", "No. Nota", "Jumlah", "Keterangan" };
                    foreach (var column in columns)
                    {
                        dataGridView2.Columns.Add(column, column);
                    }
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            List<String> temp = new List<String>() { };
                            temp.Add((dataGridView2.RowCount + 1).ToString());
                            temp.Add(Convert.ToDateTime(reader["date"]).ToString("dd-MMM-yyyy"));
                            temp.Add(reader["invoicesID"].ToString());
                            String query2 = "SELECT SUM(price*quantity) FROM InvoiceList WHERE invoicesID = @invoicesID;";
                            using(var conn2 = new SQLiteConnection(GlobalVariable.builder))
                            {
                                conn2.Open();
                                using (var cmd2 = new SQLiteCommand(query2, conn2))
                                {
                                    cmd2.Parameters.AddWithValue("@invoicesID", Convert.ToInt32(reader["invoicesID"].ToString()));
                                    temp.Add("Rp. " + Convert.ToInt64(cmd2.ExecuteScalar()).ToString("N"));
                                    Total += Convert.ToInt64(cmd2.ExecuteScalar());
                                }
                                conn2.Close();
                            }
                            temp.Add(reader["description"].ToString());
                            dataGridView2.Rows.Add(temp.ToArray());
                        }
                        reader.Close();
                    }
                }
                conn.Close();
            }
            long BeforeTax = Total;
            if (checkBox1.Checked)
                Total += BeforeTax / 10;
            if (checkBox2.Checked)
                Total -= BeforeTax / 50;
            textBox2.Text = "Rp. " + Total.ToString("N");
            groupBox1.Enabled = true;
        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {
            GlobalVariable.balanceTime(ref dateTimePicker5, ref dateTimePicker4, false);
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            GlobalVariable.balanceTime(ref dateTimePicker5, ref dateTimePicker4, true);
        }

        private void button3_Click(object sender, EventArgs e)
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
                foreach (DataGridViewColumn dgvGridCol in dataGridView2.Columns)
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
                    foreach (DataGridViewColumn GridCol in dataGridView2.Columns)
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
                while (iRow <= dataGridView2.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dataGridView2.Rows[iRow];
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
                            e.Graphics.DrawString("Receipt Summary", new Font(dataGridView2.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Receipt Summary", new Font(dataGridView2.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate, new Font(dataGridView2.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(dataGridView2.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Receipt Summary", new Font(new Font(dataGridView2.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dataGridView2.Columns)
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
                    worksheet.Name = "Riwayat Tanda Terima";


                    // storing header part in Excel
                    for (int i = 1; i < dataGridView2.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;
                        worksheet.Cells[1, i].EntireRow.Font.Bold = true;
                    }


                    // storing Each row and column value to excel sheet
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView2.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
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
    }
}
