using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace BordiProject
{
    public partial class PurchaseOrderInsertForm : Form
    {
        private bool isNumber(String x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < '0' || x[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }

        private void resetInput()
        {
            insertpurchasedescriptionText.Text = insertpurchaseunitText.Text  = "";
            insertpurchasequantityNumeric.Value = insertpurchasepriceunitNumeric.Value = 0;
        }

        public PurchaseOrderInsertForm()
        {
            InitializeComponent();
            GlobalVariable.comboBoxLoadItem(ref comboBox1,"nameCustomer","Customer WHERE supplier = 'YES'");
        }

        private void insertpurchaseButton_Click(object sender, EventArgs e)
        {
            String desc = insertpurchasedescriptionText.Text, unit = insertpurchaseunitText.Text;
            double quantity = (double)insertpurchasequantityNumeric.Value;
            long price = (long) insertpurchasepriceunitNumeric.Value;
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
            temp.Add(Convert.ToString(insertpurchaseDataGrid.Rows.Count+1));
            temp.Add(desc);
            temp.Add(Convert.ToString(quantity));
            temp.Add(unit);
            temp.Add("Rp. " + price.ToString("N"));
            double subtotal = Convert.ToDouble(price) * quantity;
            temp.Add("Rp. " + subtotal.ToString("N"));
            String txt = insertpurchasetotalText.Text;
            long total = Convert.ToInt64(Convert.ToDouble(txt.Remove(0, 4)) + quantity * price);
            insertpurchasetotalText.Text = "Rp. " + total.ToString("N");
            insertpurchaseDataGrid.Rows.Add(temp.ToArray());
            resetInput();
        }

        private void insertpurchaseclearButton_Click(object sender, EventArgs e)
        {
            insertpurchaseDataGrid.Rows.Clear();
            insertpurchasetotalText.Text = "Rp. 0.00";
        }

        private void insertPOButton_Click(object sender, EventArgs e)
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
            //    String query = "SELECT purchaseID FROM Purchase WHERE purchaseID = @purchaseID;";
            //    using (var cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@purchaseID", numberPO);
            //        if (cmd.ExecuteScalar() != null)
            //        {
            //            MessageBox.Show("nomor PO sudah pernah digunakan");
            //            return;
            //        }
            //    }
            //    //Get customerID
            //    query = "SELECT customerID FROM Customer WHERE nameCustomer = @nameCustomer AND supplier = 'YES';";
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
            //    query = "INSERT INTO Purchase (purchaseID,customerID,date,rangeTime,type) VALUES (@purchaseID,@customerID,@date,@rangeTime,@type);";
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
            //        for (int j = 1; j < insertpurchaseDataGrid.Columns.Count-1; j++)
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
                String query = "SELECT purchaseID FROM Purchase WHERE purchaseID = @purchaseID;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@purchaseID", numberPO);
                    if (cmd.ExecuteScalar() != null)
                    {
                        MessageBox.Show("nomor PO sudah pernah digunakan");
                        return;
                    }
                }
                //Get customerID
                query = "SELECT customerID FROM Customer WHERE nameCustomer = @nameCustomer AND supplier = 'YES';";
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
                query = "INSERT INTO Purchase (purchaseID,customerID,date,rangeTime,type) VALUES (@purchaseID,@customerID,@date,@rangeTime,@type);";
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
                        cmd.Parameters.AddWithValue("@quantity", Convert.ToDouble(values[1]));
                        cmd.Parameters.AddWithValue("@unit", values[2]);
                        cmd.Parameters.AddWithValue("@price", Convert.ToInt64(values[3]));
                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
            MessageBox.Show("Data Berhasil Dimasukkan");
        }

        private void insertpurchaseDataGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            long ret = 0;
            for(int i = 0; i < insertpurchaseDataGrid.RowCount; i++)
            {
                insertpurchaseDataGrid[0, i].Value = i + 1;
                String txt = insertpurchaseDataGrid[5,i].Value.ToString();
                long temp = Convert.ToInt64(Convert.ToDouble(txt.Remove(0, 4)));
                ret += temp;
            }
            insertpurchasetotalText.Text = "Rp. " + ret.ToString("N");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetInput();
            insertdateDateTime.Value = DateTime.Today;
            typecreditRadio.Checked = true;
            GlobalVariable.comboBoxLoadItem(ref comboBox1, "nameCustomer", "Customer WHERE supplier = 'YES'");
            insertnumberPOText.Text = insertrangetimeText.Text = "";
            insertpurchaseclearButton_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
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
                foreach (DataGridViewColumn dgvGridCol in insertpurchaseDataGrid.Columns)
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
                    foreach (DataGridViewColumn GridCol in insertpurchaseDataGrid.Columns)
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
                while (iRow <= insertpurchaseDataGrid.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = insertpurchaseDataGrid.Rows[iRow];
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

                            iTopMargin = e.MarginBounds.Top;

                            if (bFirstPage)
                            {
                                String text = richTextBox1.Text;
                                e.Graphics.DrawString(text, new Font(insertpurchaseDataGrid.Font.FontFamily, 24, FontStyle.Bold),
                                    Brushes.Black, new Point(e.MarginBounds.Left, e.MarginBounds.Top));

                                List<String> Keys = new List<String>() { "Kepada", "No. PO", "Tanggal", "Tempo", "Total" };
                                List<String> Values = new List<String>() { comboBox1.Text, insertnumberPOText.Text
                                    , insertdateDateTime.Value.ToString("dd-MMM-yyyy"), insertrangetimeText.Text
                                    , insertpurchasetotalText.Text};
                                //Draw Perusahaan
                                for (int i = 0; i < Keys.Count; i++)
                                {
                                    text = Keys[i];
                                    //Draw Date
                                    e.Graphics.DrawString(text, new Font(insertpurchaseDataGrid.Font, FontStyle.Bold),
                                        Brushes.Black, new RectangleF(new Point(e.MarginBounds.Left + 465, iTopMargin),
                                        TextRenderer.MeasureText(text, new Font(insertpurchaseDataGrid.Font, FontStyle.Bold))), strFormat);
                                    text = ": " + Values[i];
                                    e.Graphics.DrawString(text, new Font(insertpurchaseDataGrid.Font, FontStyle.Bold),
                                        Brushes.Black, new RectangleF(new Point(e.MarginBounds.Left + 520, iTopMargin),
                                        TextRenderer.MeasureText(text, new Font(insertpurchaseDataGrid.Font, FontStyle.Bold))), strFormat);
                                    iTopMargin += iCellHeight;
                                }
                                iTopMargin += iCellHeight;
                            }

                            //Draw Columns
                            foreach (DataGridViewColumn GridCol in insertpurchaseDataGrid.Columns)
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
                    if (iRow > insertpurchaseDataGrid.Rows.Count - 1 && insertpurchaseDataGrid.Enabled)
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
    }
}
