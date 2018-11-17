using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BordiProject
{
    public partial class InvoicesHistoryForm : Form
    {
        private void resetHistory()
        {
            groupBox3.Enabled = groupBox2.Enabled = false;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView1.Rows.Clear();
            textBox2.Text = "";
            textBox1.Text = "Rp. 0.00";
            dateTimePicker2.Value = DateTime.Today;
        }

        private void initComboBox()
        {
            GlobalVariable.comboBoxLoadItem(ref comboBox3, "invoicesID", "Invoice");
            GlobalVariable.comboBoxLoadItem(ref comboBox1, "nameCustomer", "Customer WHERE customer = 'YES'");
            GlobalVariable.comboBoxLoadItem(ref comboBox2, "nameCustomer", "Customer WHERE customer = 'YES'");
            GlobalVariable.comboBoxLoadItem(ref comboBox4, "orderID", "OrderStatus WHERE status = 'KELUAR'");
        }

        private void untilDatetime_ValueChanged(object sender, EventArgs e)
        {
            GlobalVariable.balanceTime(ref historybydatefromDateTime, ref historybydateuntilDateTime, true);
        }

        private void fromDatetime_ValueChanged(object sender, EventArgs e)
        {
            GlobalVariable.balanceTime(ref historybydatefromDateTime, ref historybydateuntilDateTime, false);
        }

        public InvoicesHistoryForm()
        {
            InitializeComponent();
            initComboBox();
        }

        //private void historybydateButton_Click(object sender, EventArgs e)
        //{
        //    resetHistory();
        //    List<String> columns = new List<String>() { "No. Faktur", "Perusahaan", "Tanggal", "Total Barang"};
        //    foreach (var column in columns)
        //    {
        //        dataGridView2.Columns.Add(column, column);
        //    }
        //    using (var conn = new SqlConnection(GlobalVariable.builder))
        //    {
        //        String query = @"SELECT invoicesID, nameCustomer, date FROM Invoice[I], Customer[C] 
        //            WHERE I.customerID = C.customerID AND date >= @datemin AND date <= @datemax;";
        //        using (var cmd = new SqlCommand(query, conn))
        //        {
        //            conn.Open();
        //            DateTime dateonly = historybydatefromDateTime.Value;
        //            cmd.Parameters.AddWithValue("@datemin", dateonly.Date);
        //            dateonly = historybydateuntilDateTime.Value;
        //            cmd.Parameters.AddWithValue("@datemax", dateonly.Date);
        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    List<String> temp = new List<String>() { };
        //                    temp.Add(reader["invoicesID"].ToString());
        //                    temp.Add(reader["nameCustomer"].ToString());
        //                    temp.Add(Convert.ToDateTime(reader["date"]).ToString("dd-MMM-yyyy"));
        //                    using (var conn2 = new SqlConnection(GlobalVariable.builder))
        //                    {
        //                        conn2.Open();
        //                        String query2 = "SELECT SUM(quantity) FROM InvoiceList WHERE invoicesID = @invoicesID;";
        //                        using (var cmd2 = new SqlCommand(query2, conn2))
        //                        {
        //                            cmd2.Parameters.AddWithValue("@invoicesID", Convert.ToInt32(temp[0]));
        //                            temp.Add(cmd2.ExecuteScalar().ToString());
        //                        }
        //                        conn2.Close();
        //                    }

        //                    dataGridView2.Rows.Add(temp.ToArray());
        //                }
        //                reader.Close();
        //            }
        //            conn.Close();
        //        }
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            resetHistory();
            List<String> columns = new List<String>() { "Nomor Faktur", "Tanggal", "Buyer", "CMT", "Total Harga" };
            foreach (var column in columns)
            {
                dataGridView2.Columns.Add(column, column);
            }
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    String query = @"SELECT I2.invoicesID, date, nameCustomer AS cmtNameCustomer, buyerNameCustomer, Total 
            //                    FROM (SELECT I.invoicesID, date, cmtCustomerID, nameCustomer AS buyerNameCustomer
            //                    , SUM(price*quantity) AS Total FROM Invoice[I], Customer[C], InvoiceList[IL] 
            //                    WHERE C.customerID = I.buyerCustomerID AND I.invoicesID = IL.invoicesID
            //                    GROUP BY I.invoicesID, date, cmtCustomerID, nameCustomer) AS I2, Customer[C] ";
            //    StringBuilder querytemp = new StringBuilder(query);
            //    if (checkBox5.Checked)
            //    {
            //        querytemp.Append(",InvoiceOrderList[IL] ");
            //    }
            //    querytemp.Append("WHERE C.customerID = I2.cmtCustomerID ");
            //    if (checkBox1.Checked)
            //    {
            //        querytemp.Append(@"AND I2.date >= @datemin ");
            //        querytemp.Append(@"AND I2.date <= @datemax ");
            //    }
            //    if (checkBox2.Checked)
            //    {
            //        querytemp.Append(@"AND I2.buyerNameCustomer = @buyerNameCustomer ");
            //    }
            //    if (checkBox3.Checked)
            //    {
            //        querytemp.Append(@"AND C.nameCustomer = @cmtNameCustomer ");
            //    }
            //    if (checkBox5.Checked)
            //    {
            //        querytemp.Append(@"AND IL.invoicesID = I2.invoicesID AND IL.orderID = @orderID ");
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
            //            cmd.Parameters.AddWithValue("@buyerNameCustomer", comboBox1.Text);
            //        }
            //        if (checkBox3.Checked)
            //        {
            //            cmd.Parameters.AddWithValue("@cmtNameCustomer", comboBox2.Text);
            //        }
            //        if (checkBox5.Checked)
            //        {
            //            cmd.Parameters.AddWithValue("@orderID", comboBox4.Text);
            //        }
            //        using (var reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                List<String> temp = new List<String>() { };
            //                temp.Add(reader["invoicesID"].ToString());
            //                temp.Add(Convert.ToDateTime(reader["date"]).ToString("dd-MMM-yyyy"));
            //                temp.Add(reader["buyerNameCustomer"].ToString());
            //                temp.Add(reader["cmtNameCustomer"].ToString());
            //                temp.Add("Rp. " + Convert.ToInt64(reader["total"]).ToString("N"));
            //                dataGridView2.Rows.Add(temp.ToArray());
            //            }
            //            reader.Close();
            //        }
            //        conn.Close();
            //    }
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                String query = @"SELECT I2.invoicesID, date, nameCustomer AS cmtNameCustomer, buyerNameCustomer, Total 
                                FROM (SELECT I.invoicesID, date, cmtCustomerID, nameCustomer AS buyerNameCustomer
                                , SUM(price*quantity) AS Total FROM Invoice[I], Customer[C], InvoiceList[IL] 
                                WHERE C.customerID = I.buyerCustomerID AND I.invoicesID = IL.invoicesID
                                GROUP BY I.invoicesID, date, cmtCustomerID, nameCustomer) AS I2, Customer[C] ";
                StringBuilder querytemp = new StringBuilder(query);
                if (checkBox5.Checked)
                {
                    querytemp.Append(",InvoiceOrderList[IL] ");
                }
                querytemp.Append("WHERE C.customerID = I2.cmtCustomerID ");
                if (checkBox1.Checked)
                {
                    querytemp.Append(@"AND strftime('%s', I2.date) BETWEEN strftime('%s', @datemin) AND strftime('%s', @datemax) ");
                }
                if (checkBox2.Checked)
                {
                    querytemp.Append(@"AND I2.buyerNameCustomer = @buyerNameCustomer ");
                }
                if (checkBox3.Checked)
                {
                    querytemp.Append(@"AND C.nameCustomer = @cmtNameCustomer ");
                }
                if (checkBox5.Checked)
                {
                    querytemp.Append(@"AND IL.invoicesID = I2.invoicesID AND IL.orderID = @orderID ");
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
                        cmd.Parameters.AddWithValue("@buyerNameCustomer", comboBox1.Text);
                    }
                    if (checkBox3.Checked)
                    {
                        cmd.Parameters.AddWithValue("@cmtNameCustomer", comboBox2.Text);
                    }
                    if (checkBox5.Checked)
                    {
                        cmd.Parameters.AddWithValue("@orderID", comboBox4.Text);
                    }
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            List<String> temp = new List<String>() { };
                            temp.Add(reader["invoicesID"].ToString());
                            temp.Add(Convert.ToDateTime(reader["date"]).ToString("dd-MMM-yyyy"));
                            temp.Add(reader["buyerNameCustomer"].ToString());
                            temp.Add(reader["cmtNameCustomer"].ToString());
                            temp.Add("Rp. " + Convert.ToInt64(reader["total"]).ToString("N"));
                            dataGridView2.Rows.Add(temp.ToArray());
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetHistory();
            if (comboBox3.Text == "")
            {
                MessageBox.Show("Nomor faktur tidak boleh kosong");
                return;
            }
            if (!Regex.IsMatch(comboBox3.Text, @"^\d+$"))
            {
                MessageBox.Show("Format nomor faktur salah");
                return;
            }
            int invoicesID = Convert.ToInt32(comboBox3.Text);
            long Total = 0;
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = @"SELECT quantity, nameItem, unit, price, quantity*price AS Total FROM InvoiceList 
            //        WHERE invoicesID = @invoicesID;";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@invoicesID", invoicesID);
            //        if (cmd.ExecuteScalar() == null)
            //        {
            //            MessageBox.Show("Nomor Faktur tidak ditemukan");
            //            return;
            //        }
            //        List<String> columns = new List<String>() { "No. ", "Banyaknya", "Nama Barang", "Satuan", "Harga Satuan", "Jumlah" };
            //        foreach (var column in columns)
            //        {
            //            dataGridView2.Columns.Add(column, column);
            //        }
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                List<String> temp = new List<String>() { };
            //                temp.Add((dataGridView2.RowCount + 1).ToString());
            //                temp.Add(reader["quantity"].ToString());
            //                temp.Add(reader["nameItem"].ToString());
            //                temp.Add(reader["unit"].ToString());
            //                temp.Add("Rp. " + Convert.ToInt64(reader["price"]).ToString("N"));
            //                temp.Add("Rp. " + Convert.ToInt64(reader["Total"]).ToString("N"));
            //                Total += Convert.ToInt64(reader["Total"]);
            //                dataGridView2.Rows.Add(temp.ToArray());
            //            }
            //            reader.Close();
            //        }
            //    }
            //    query = @"SELECT orderID FROM InvoiceOrderList WHERE invoicesID = @invoicesID;";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@invoicesID", invoicesID);
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                List<String> temp = new List<String>() { };
            //                temp.Add(reader["orderID"].ToString());
            //                dataGridView1.Rows.Add(temp.ToArray());
            //            }
            //            reader.Close();
            //        }
            //    }
            //    query = @"SELECT nameCustomer AS cmtNameCustomer, buyerNameCustomer, date FROM 
            //        (SELECT cmtCustomerID, nameCustomer AS buyerNameCustomer, date FROM Invoice[I], Customer[C] 
            //        WHERE I.buyerCustomerID = C.customerID AND invoicesID = @invoicesID) AS I2, Customer[C] 
            //        WHERE C.customerID = I2.cmtCustomerID";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@invoicesID", invoicesID);
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                textBox2.Text = reader["buyerNameCustomer"].ToString();
            //                textBox3.Text = reader["cmtNameCustomer"].ToString();
            //                dateTimePicker2.Value = Convert.ToDateTime(reader["date"]);
            //            }
            //            reader.Close();
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = @"SELECT quantity, nameItem, unit, price, quantity*price AS Total FROM InvoiceList 
                    WHERE invoicesID = @invoicesID;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@invoicesID", invoicesID);
                    if (cmd.ExecuteScalar() == null)
                    {
                        MessageBox.Show("Nomor Faktur tidak ditemukan");
                        return;
                    }
                    List<String> columns = new List<String>() { "No. ", "Banyaknya", "Nama Barang", "Satuan", "Harga Satuan", "Jumlah" };
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
                            temp.Add(reader["quantity"].ToString());
                            temp.Add(reader["nameItem"].ToString());
                            temp.Add(reader["unit"].ToString());
                            temp.Add("Rp. " + Convert.ToInt64(reader["price"]).ToString("N"));
                            temp.Add("Rp. " + Convert.ToInt64(reader["Total"]).ToString("N"));
                            Total += Convert.ToInt64(reader["Total"]);
                            dataGridView2.Rows.Add(temp.ToArray());
                        }
                        reader.Close();
                    }
                }
                query = @"SELECT orderID FROM InvoiceOrderList WHERE invoicesID = @invoicesID;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@invoicesID", invoicesID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            List<String> temp = new List<String>() { };
                            temp.Add(reader["orderID"].ToString());
                            dataGridView1.Rows.Add(temp.ToArray());
                        }
                        reader.Close();
                    }
                }
                query = @"SELECT nameCustomer AS cmtNameCustomer, buyerNameCustomer, date FROM 
                    (SELECT cmtCustomerID, nameCustomer AS buyerNameCustomer, date FROM Invoice[I], Customer[C] 
                    WHERE I.buyerCustomerID = C.customerID AND invoicesID = @invoicesID) AS I2, Customer[C] 
                    WHERE C.customerID = I2.cmtCustomerID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@invoicesID", invoicesID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            textBox2.Text = reader["buyerNameCustomer"].ToString();
                            textBox3.Text = reader["cmtNameCustomer"].ToString();
                            dateTimePicker2.Value = Convert.ToDateTime(reader["date"]);
                        }
                        reader.Close();
                    }
                }
                conn.Close();
            }
            textBox1.Text = "Rp. " + Total.ToString("N");
            groupBox2.Enabled = groupBox3.Enabled = true;
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
                            e.Graphics.DrawString("Invoice Summary", new Font(dataGridView2.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Invoice Summary", new Font(dataGridView2.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate, new Font(dataGridView2.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(dataGridView2.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Invoice Summary", new Font(new Font(dataGridView2.Font,
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

        private void button4_Click(object sender, EventArgs e)
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
                    worksheet.Name = "Riwayat Transaksi Surat Jalan";


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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Enabled = checkBox2.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            historybydateGroup.Enabled = checkBox1.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Enabled = checkBox3.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            groupBox8.Enabled = checkBox5.Checked;
        }
    }
}
