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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BordiProject
{
    public partial class SupplyHistoryForm : Form
    {
        private String generateTypeCond()
        {
            StringBuilder temp = new StringBuilder();
            if (!typeinCheckBox.Checked)
            {
                temp.Append(" AND ST.status != \'IN\'");
            }
            if (!typeoutCheckBox.Checked)
            {
                temp.Append(" AND ST.status != \'OUT\'");
            }
            return temp.ToString();
        }

        private void initComboBox()
        {
            GlobalVariable.comboBoxLoadItem(ref comboBox1, "nameStock", "Stock");
            GlobalVariable.comboBoxLoadItem(ref bynameitemnameComboBox, "kodeStock", "Stock");
            GlobalVariable.comboBoxLoadItem(ref stockbynameitemnameComboBox, "kodeStock", "Stock");
            GlobalVariable.comboBoxLoadItem(ref comboBox2, "nameStock", "Stock");
        }

        public SupplyHistoryForm()
        {
            InitializeComponent();
            initComboBox();
        }

        private void displayallButton_Click(object sender, EventArgs e)
        {
            List<String> temp = new List<String>();
            transactionhistoryDataGrid.Columns.Clear();
            transactionhistoryDataGrid.Rows.Clear();
            //using (SqlConnection conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT * FROM Stock";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        List<String> cols = new List<String>() { "Nama Stock", "Kode Stock" ,"Jumlah Stock" };
            //        foreach (var col in cols)
            //        {
            //            transactionhistoryDataGrid.Columns.Add(col, col);
            //        }
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                temp.Clear();
            //                temp.Add(reader["nameStock"].ToString());
            //                temp.Add(reader["kodeStock"].ToString());
            //                temp.Add(reader["quantity"].ToString());
            //                transactionhistoryDataGrid.Rows.Add(temp.ToArray());
            //            }
            //            reader.Close();
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT * FROM Stock";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    List<String> cols = new List<String>() { "Nama Stock", "Kode Stock", "Jumlah Stock" };
                    foreach (var col in cols)
                    {
                        transactionhistoryDataGrid.Columns.Add(col, col);
                    }
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            temp.Clear();
                            temp.Add(reader["nameStock"].ToString());
                            temp.Add(reader["kodeStock"].ToString());
                            temp.Add(reader["quantity"].ToString());
                            transactionhistoryDataGrid.Rows.Add(temp.ToArray());
                        }
                        reader.Close();
                    }
                }
                conn.Close();
            }
        }

        private void bydatefromDateTime_ValueChanged(object sender, EventArgs e)
        {
            GlobalVariable.balanceTime(ref bydatefromDateTime, ref bydateuntilDateTime, false);
        }

        private void bydateuntilDateTime_ValueChanged(object sender, EventArgs e)
        {
            GlobalVariable.balanceTime(ref bydatefromDateTime, ref bydateuntilDateTime, true);
        }

        private void stockbynameitemnameButton_Click(object sender, EventArgs e)
        {
            List<String> temp = new List<String>();
            transactionhistoryDataGrid.Columns.Clear();
            transactionhistoryDataGrid.Rows.Clear();
            //using (SqlConnection conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT * FROM Stock WHERE 1 = 1 ";
            //    StringBuilder querytemp = new StringBuilder(query);
            //    if (checkBox4.Checked)
            //    {
            //        querytemp.Append("AND kodeStock = @kodeStock ");
            //    }
            //    if (checkBox5.Checked)
            //    {
            //        querytemp.Append("AND nameStock = @nameStock ");
            //    }
            //    query = querytemp.ToString();
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        List<String> cols = new List<String>() { "Nama Stock", "Kode Stock", "Jumlah Stock" };
            //        if (checkBox4.Checked)
            //        {
            //            cols.RemoveAt(1);
            //            cmd.Parameters.AddWithValue("@kodeStock", stockbynameitemnameComboBox.Text);
            //        }
            //        if (checkBox5.Checked)
            //        {
            //            cols.RemoveAt(0);
            //            cmd.Parameters.AddWithValue("@nameStock", comboBox2.Text);
            //        }
            //        foreach (var col in cols)
            //        {
            //            transactionhistoryDataGrid.Columns.Add(col, col);
            //        }
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                temp.Clear();
            //                if (!checkBox5.Checked)
            //                    temp.Add(reader["nameStock"].ToString());
            //                if (!checkBox4.Checked)
            //                    temp.Add(reader["kodeStock"].ToString());
            //                temp.Add(reader["quantity"].ToString());
            //                transactionhistoryDataGrid.Rows.Add(temp.ToArray());
            //            }
            //            reader.Close();
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT * FROM Stock WHERE 1 = 1 ";
                StringBuilder querytemp = new StringBuilder(query);
                if (checkBox4.Checked)
                {
                    querytemp.Append("AND kodeStock = @kodeStock ");
                }
                if (checkBox5.Checked)
                {
                    querytemp.Append("AND nameStock = @nameStock ");
                }
                query = querytemp.ToString();
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    List<String> cols = new List<String>() { "Nama Stock", "Kode Stock", "Jumlah Stock" };
                    if (checkBox4.Checked)
                    {
                        cols.RemoveAt(1);
                        cmd.Parameters.AddWithValue("@kodeStock", stockbynameitemnameComboBox.Text);
                    }
                    if (checkBox5.Checked)
                    {
                        cols.RemoveAt(0);
                        cmd.Parameters.AddWithValue("@nameStock", comboBox2.Text);
                    }
                    foreach (var col in cols)
                    {
                        transactionhistoryDataGrid.Columns.Add(col, col);
                    }
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            temp.Clear();
                            if (!checkBox5.Checked)
                                temp.Add(reader["nameStock"].ToString());
                            if (!checkBox4.Checked)
                                temp.Add(reader["kodeStock"].ToString());
                            temp.Add(reader["quantity"].ToString());
                            transactionhistoryDataGrid.Rows.Add(temp.ToArray());
                        }
                        reader.Close();
                    }
                }
                conn.Close();
            }
        }

        private void transactionhistorysearchButton_Click(object sender, EventArgs e)
        {
            List<String> temp = new List<String>();
            transactionhistoryDataGrid.Columns.Clear();
            transactionhistoryDataGrid.Rows.Clear();
            //using (SqlConnection conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = @"SELECT ST.stockTransactionID, S.nameStock, S.kodeStock, ST.quantity, ST.status, ST.description, ST.date 
            //        FROM StockTransaction[ST], Stock[S] WHERE ST.stockID = S.stockID ";
            //    StringBuilder querytemp = new StringBuilder(query);
            //    if (checkBox1.Checked)
            //    {
            //        querytemp.Append("AND ST.date >= @datemin AND ST.date <= @datemax ");
            //    }
            //    if (!typeinCheckBox.Checked)
            //    {
            //        querytemp.Append("AND ST.status != 'IN' ");
            //    }
            //    if (!typeoutCheckBox.Checked)
            //    {
            //        querytemp.Append("AND ST.status != 'OUT' ");
            //    }
            //    if (checkBox2.Checked)
            //    {
            //        querytemp.Append("AND S.nameStock = @nameStock ");
            //    }
            //    if (checkBox3.Checked)
            //    {
            //        querytemp.Append("AND S.kodeStock = @kodeStock ");
            //    }
            //    query = querytemp.ToString();
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        List<String> cols = new List<String>() { "ID Transaksi Stock", "Nama Stock", "Kode Stock", "Jumlah Stock Transaksi", "Jenis", "Deskripsi", "Tanggal Transaksi" };
            //        if (checkBox1.Checked)
            //        {
            //            DateTime dateonly = bydatefromDateTime.Value;
            //            cmd.Parameters.AddWithValue("@datemin", dateonly.Date);
            //            dateonly = bydateuntilDateTime.Value;
            //            cmd.Parameters.AddWithValue("@datemax", dateonly.Date);
            //        }
            //        if (checkBox3.Checked)
            //        {
            //            cols.RemoveAt(2);
            //            cmd.Parameters.AddWithValue("@kodeStock", bynameitemnameComboBox.Text);
            //        }
            //        if (checkBox2.Checked)
            //        {
            //            cols.RemoveAt(1);
            //            cmd.Parameters.AddWithValue("@nameStock", comboBox1.Text);
            //        }
            //        foreach (var col in cols)
            //        {
            //            transactionhistoryDataGrid.Columns.Add(col, col);
            //        }
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                temp.Clear();
            //                temp.Add(reader["stockTransactionID"].ToString());
            //                if (!checkBox2.Checked) temp.Add(reader["nameStock"].ToString());
            //                if (!checkBox3.Checked) temp.Add(reader["kodeStock"].ToString());
            //                temp.Add(reader["quantity"].ToString());
            //                if (reader["status"].ToString() == "IN")
            //                    temp.Add("MASUK");
            //                else
            //                    temp.Add("KELUAR");
            //                temp.Add(reader["description"].ToString());
            //                DateTime tempDate = Convert.ToDateTime(reader["date"]);
            //                temp.Add(tempDate.ToString("dd-MMM-yyyy"));
            //                transactionhistoryDataGrid.Rows.Add(temp.ToArray());
            //            }
            //            reader.Close();
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = @"SELECT ST.stockTransactionID, S.nameStock, S.kodeStock, ST.quantity, ST.status, ST.description, ST.date 
                    FROM StockTransaction[ST], Stock[S] WHERE ST.stockID = S.stockID ";
                StringBuilder querytemp = new StringBuilder(query);
                if (checkBox1.Checked)
                {
                    querytemp.Append(@"AND strftime('%s', ST.date) BETWEEN strftime('%s', @datemin) AND strftime('%s', @datemax) ");
                }
                if (!typeinCheckBox.Checked)
                {
                    querytemp.Append("AND ST.status != 'IN' ");
                }
                if (!typeoutCheckBox.Checked)
                {
                    querytemp.Append("AND ST.status != 'OUT' ");
                }
                if (checkBox2.Checked)
                {
                    querytemp.Append("AND S.nameStock = @nameStock ");
                }
                if (checkBox3.Checked)
                {
                    querytemp.Append("AND S.kodeStock = @kodeStock ");
                }
                query = querytemp.ToString();
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    List<String> cols = new List<String>() { "ID Transaksi Stock", "Nama Stock", "Kode Stock", "Jumlah Stock Transaksi", "Jenis", "Deskripsi", "Tanggal Transaksi" };
                    if (checkBox1.Checked)
                    {
                        DateTime dateonly = bydatefromDateTime.Value;
                        cmd.Parameters.AddWithValue("@datemin", dateonly.Date);
                        dateonly = bydateuntilDateTime.Value;
                        cmd.Parameters.AddWithValue("@datemax", dateonly.Date);
                    }
                    if (checkBox3.Checked)
                    {
                        cols.RemoveAt(2);
                        cmd.Parameters.AddWithValue("@kodeStock", bynameitemnameComboBox.Text);
                    }
                    if (checkBox2.Checked)
                    {
                        cols.RemoveAt(1);
                        cmd.Parameters.AddWithValue("@nameStock", comboBox1.Text);
                    }
                    foreach (var col in cols)
                    {
                        transactionhistoryDataGrid.Columns.Add(col, col);
                    }
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            temp.Clear();
                            temp.Add(reader["stockTransactionID"].ToString());
                            if (!checkBox2.Checked) temp.Add(reader["nameStock"].ToString());
                            if (!checkBox3.Checked) temp.Add(reader["kodeStock"].ToString());
                            temp.Add(reader["quantity"].ToString());
                            if (reader["status"].ToString() == "IN")
                                temp.Add("MASUK");
                            else
                                temp.Add("KELUAR");
                            temp.Add(reader["description"].ToString());
                            DateTime tempDate = Convert.ToDateTime(reader["date"]);
                            temp.Add(tempDate.ToString("dd-MMM-yyyy"));
                            transactionhistoryDataGrid.Rows.Add(temp.ToArray());
                        }
                        reader.Close();
                    }
                }
                conn.Close();
            }
        }

        private void transactionhistoryprintButton_Click(object sender, EventArgs e)
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
                foreach (DataGridViewColumn dgvGridCol in transactionhistoryDataGrid.Columns)
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
                    foreach (DataGridViewColumn GridCol in transactionhistoryDataGrid.Columns)
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
                while (iRow <= transactionhistoryDataGrid.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = transactionhistoryDataGrid.Rows[iRow];
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
                            e.Graphics.DrawString("Stock Summary", new Font(transactionhistoryDataGrid.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Stock Summary", new Font(transactionhistoryDataGrid.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate, new Font(transactionhistoryDataGrid.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(transactionhistoryDataGrid.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Stock Summary", new Font(new Font(transactionhistoryDataGrid.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in transactionhistoryDataGrid.Columns)
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

        private void button2_Click(object sender, EventArgs e)
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
                    worksheet.Name = "Riwayat Stok";


                    // storing header part in Excel
                    for (int i = 1; i < transactionhistoryDataGrid.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = transactionhistoryDataGrid.Columns[i - 1].HeaderText;
                        worksheet.Cells[1, i].EntireRow.Font.Bold = true;
                    }


                    // storing Each row and column value to excel sheet
                    for (int i = 0; i < transactionhistoryDataGrid.Rows.Count; i++)
                    {
                        for (int j = 0; j < transactionhistoryDataGrid.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = transactionhistoryDataGrid.Rows[i].Cells[j].Value.ToString();
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
            bydateGroup.Enabled = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            bynameGroup.Enabled = checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            stockbynameGroup.Enabled = checkBox4.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Enabled = checkBox5.Checked;
        }
    }
}
