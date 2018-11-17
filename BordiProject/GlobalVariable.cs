using System;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;

namespace BordiProject
{
    class GlobalVariable
    {
        public static int loginUserId;
        public static String loginUsername;
        //DEPLOY
        public static String builder;
        //COORDINATE CHECKGROUPBOX
        //chk.Location = new Point{grp.top+10, grp.left};
        //REAL DEBUG
        //public static String builder = @"Data Source=(LocalDB)\MSSQLLocalDB;
        //                    AttachDbFilename=D:\Project\Visual Studio 2015\Projects\BordiProject\BordiProject\bordirDatabase.mdf;
        //                    Integrated Security=True";

        //public static void comboBoxLoadItem(ref ComboBox x, String columndb, String tabledb)
        //{
        //    x.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //    x.AutoCompleteSource = AutoCompleteSource.ListItems;
        //    x.SelectedIndex = -1;
        //    x.Items.Clear();
        //    using (var conn = new SqlConnection(builder))
        //    {
        //        conn.Open();
        //        String query = "SELECT " + columndb + " FROM " + tabledb + ";";
        //        using (var cmd = new SqlCommand(query, conn))
        //        {
        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    if (!x.Items.Contains(reader[columndb].ToString()))
        //                        x.Items.Add(reader[columndb].ToString());
        //                }
        //                reader.Close();
        //            }
        //        }
        //        conn.Close();
        //    }
        //    if (x.Items.Count > 0)
        //    {
        //        x.SelectedIndex = 0;
        //        x.Enabled = true;
        //    }
        //    else
        //        x.Enabled = false;
        //}

        public static void comboBoxLoadItem(ref ComboBox x, String columndb, String tabledb)
        {
            x.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            x.AutoCompleteSource = AutoCompleteSource.ListItems;
            x.SelectedIndex = -1;
            x.Items.Clear();
            using (var conn = new SQLiteConnection(builder))
            {
                conn.Open();
                String query = "SELECT " + columndb + " FROM " + tabledb + ";";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!x.Items.Contains(reader[columndb].ToString()))
                                x.Items.Add(reader[columndb].ToString());
                        }
                        reader.Close();
                    }
                }
                conn.Close();
            }
            if (x.Items.Count > 0) {
                x.SelectedIndex = 0;
                x.Enabled = true;
            }
            else
                x.Enabled = false;
        }

        public static void balanceTime(ref DateTimePicker mini, ref DateTimePicker maks, bool priority)
        {
            //priority false = maks must change, priority true = mini must change
            if (mini.Value > maks.Value)
            {
                if (priority)
                    mini.Value = maks.Value;
                else
                    maks.Value = mini.Value; 
            }
            return;
        }

        public static string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            return Convert.ToBase64String(hashBytes);
        }

    }
}
