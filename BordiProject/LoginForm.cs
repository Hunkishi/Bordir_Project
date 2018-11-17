using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BordiProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //if (Properties.Settings.Default["DatabaseDirectory"].ToString() != "|DataDirectory|bordirDatabase.mdf")
            //{
            //    radioButton2.Checked = true;
            //    textBox1.Text = Properties.Settings.Default["DatabaseDirectory"].ToString();
            //}
            //else
            //{
            //    textBox1.Text = AppDomain.CurrentDomain.BaseDirectory + "bordirDatabase.mdf";
            //}
            //Check database valid
            try
            {
                using (var conn = new SQLiteConnection(@"Data Source=" + Properties.Settings.Default["DatabaseDirectory2"].ToString() + "; Version = 3"))
                {
                    conn.Open();
                    conn.Close();
                }
            }
            catch
            {
                Properties.Settings.Default["DatabaseDirectory2"] = "|DataDirectory|bordirDatabase.sqlite3";
            }
            if (Properties.Settings.Default["DatabaseDirectory2"].ToString() != "|DataDirectory|bordirDatabase.sqlite3")
            {
                radioButton2.Checked = true;
                textBox1.Text = Properties.Settings.Default["DatabaseDirectory2"].ToString();
            }
            else
            {
                textBox1.Text = AppDomain.CurrentDomain.BaseDirectory + "bordirDatabase.sqlite3";
                //Check Network?
                if (textBox1.Text.StartsWith("\\\\"))
                    textBox1.Text = "\\\\" + textBox1.Text;
            }
        }

        public void openForm(Form x)
        {
            this.Hide();
            x.ShowDialog();
            this.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            ////if (radioButton2.Checked)
            ////{
            ////    GlobalVariable.builder = @"Data Source=(LocalDB)\MSSQLLocalDB;
            ////                AttachDbFilename=" + textBox1.Text+ @";
            ////                Integrated Security=True";
            ////} else
            ////{
            ////    GlobalVariable.builder = @"Data Source=(LocalDB)\MSSQLLocalDB;
            ////                AttachDbFilename=|DataDirectory|bordirDatabase.mdf;
            ////                ;Integrated Security=True";
            ////}
            ////String username = usernameText.Text, password = passwordText.Text;
            ////bool success = false;
            ////using (var conn = new SqlConnection(GlobalVariable.builder))
            ////{
            ////    conn.Open();
            ////    String query = "SELECT * FROM UserData WHERE username = @username AND PWDCOMPARE(@password,password) = 1;";
            ////    using (var cmd = new SqlCommand(query, conn))
            ////    {
            ////        cmd.Parameters.AddWithValue("@username",username);
            ////        cmd.Parameters.AddWithValue("@password", password);
            ////        using (SqlDataReader reader = cmd.ExecuteReader())
            ////            while (reader.Read())
            ////            {
            ////                GlobalVariable.loginUserId = Convert.ToInt32(reader["userID"]);
            ////                GlobalVariable.loginUsername = reader["username"].ToString();
            ////                success = true;
            ////            }
            ////    }
            ////    conn.Close();
            ////}
            ////if (success)
            ////{
            ////    if (radioButton2.Checked)
            ////        Properties.Settings.Default["DatabaseDirectory"] = textBox1.Text;
            ////    else
            ////        Properties.Settings.Default["DatabaseDirectory"] = "|DataDirectory|bordirDatabase.mdf";
            ////    Properties.Settings.Default.Save();  
            ////    openForm(new MenuForm());
            ////}
            ////else
            ////    MessageBox.Show("Login Failed");
            if (radioButton2.Checked)
            {
                GlobalVariable.builder = @"Data Source="+textBox1.Text+"; Version = 3";
            } else {
                GlobalVariable.builder = @"Data Source=|DataDirectory|bordirDatabase.sqlite3; Version = 3;";
            }
            ////string mdfbuilder = @"Data Source=(LocalDB)\MSSQLLocalDB;
            ////            AttachDbFilename=D:\BORDIRDATABASE.MDF;
            ////            Integrated Security=True";
            ////using (var conn = new SqlConnection(mdfbuilder))
            ////{
            ////    conn.Open();
            ////    String query = "SELECT * FROM Customer";
            ////    using (var cmd = new SqlCommand(query, conn))
            ////    {
            ////        using (var reader = cmd.ExecuteReader())
            ////        {
            ////            while (reader.Read())
            ////            {
            ////                int customerID = Convert.ToInt32(reader["customerID"]);
            ////                String nameCustomer = reader["nameCustomer"].ToString();
            ////                String address = reader["address"].ToString();
            ////                String fax = reader["fax"].ToString();
            ////                String isCustomer = reader["customer"].ToString();
            ////                String isSupplier = reader["supplier"].ToString();
            ////                using (var conn2 = new SQLiteConnection(GlobalVariable.builder))
            ////                {
            ////                    conn2.Open();
            ////                    //masukkan data
            ////                    String query2 = "INSERT INTO Customer (customerID,nameCustomer,address,fax,customer,supplier) VALUES (@customerID,@nameCustomer,@address,@fax,@customer,@supplier);";
            ////                    using (var cmd2 = new SQLiteCommand(query2, conn2))
            ////                    {
            ////                        cmd2.Parameters.AddWithValue("@customerID", customerID);
            ////                        cmd2.Parameters.AddWithValue("@nameCustomer", nameCustomer);
            ////                        cmd2.Parameters.AddWithValue("@address", address);
            ////                        cmd2.Parameters.AddWithValue("@fax", fax);
            ////                        cmd2.Parameters.AddWithValue("@customer", isCustomer);
            ////                        cmd2.Parameters.AddWithValue("@supplier", isSupplier);
            ////                        cmd2.ExecuteNonQuery();
            ////                    }
            ////                    conn2.Close();
            ////                }
            ////            }
            ////        }
            ////    }
            ////    query = "SELECT * FROM CustomerContactPerson";
            ////    using (var cmd = new SqlCommand(query, conn))
            ////    {
            ////        using (var reader = cmd.ExecuteReader())
            ////        {
            ////            while (reader.Read())
            ////            {
            ////                int customerID = Convert.ToInt32(reader["customerID"]);
            ////                String name = reader["name"].ToString();
            ////                String hp = reader["hp"].ToString();
            ////                String ext = reader["ext"].ToString();
            ////                using (var conn2 = new SQLiteConnection(GlobalVariable.builder))
            ////                {
            ////                    conn2.Open();
            ////                    //masukkan data
            ////                    String query2 = "INSERT INTO CustomerContactPerson (customerID,name,hp,ext) VALUES (@customerID,@name,@hp,@ext);";
            ////                    using (var cmd2 = new SQLiteCommand(query2, conn2))
            ////                    {
            ////                        cmd2.Parameters.AddWithValue("@customerID", customerID);
            ////                        cmd2.Parameters.AddWithValue("@name", name);
            ////                        cmd2.Parameters.AddWithValue("@hp", hp);
            ////                        cmd2.Parameters.AddWithValue("@ext", ext);
            ////                        cmd2.ExecuteNonQuery();
            ////                    }
            ////                    conn2.Close();
            ////                }
            ////            }
            ////        }
            ////    }
            ////    query = "SELECT * FROM CustomerTelephone";
            ////    using (var cmd = new SqlCommand(query, conn))
            ////    {
            ////        using (var reader = cmd.ExecuteReader())
            ////        {
            ////            while (reader.Read())
            ////            {
            ////                int customerID = Convert.ToInt32(reader["customerID"]);
            ////                String telephone = reader["telephone"].ToString();
            ////                using (var conn2 = new SQLiteConnection(GlobalVariable.builder))
            ////                {
            ////                    conn2.Open();
            ////                    //masukkan data
            ////                    String query2 = "INSERT INTO CustomerTelephone (customerID,telephone) VALUES (@customerID,@telephone);";
            ////                    using (var cmd2 = new SQLiteCommand(query2, conn2))
            ////                    {
            ////                        cmd2.Parameters.AddWithValue("@customerID", customerID);
            ////                        cmd2.Parameters.AddWithValue("@telephone", telephone);
            ////                        cmd2.ExecuteNonQuery();
            ////                    }
            ////                    conn2.Close();
            ////                }
            ////            }
            ////        }
            ////    }
            ////    conn.Close();
            ////}
            String username = usernameText.Text, password = passwordText.Text;
            bool success = false;
            using (SQLiteConnection conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT * FROM UserData WHERE username = @username AND password = @password;";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                { 
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", GlobalVariable.Hash(password));
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GlobalVariable.loginUserId = Convert.ToInt32(reader["userID"]);
                            GlobalVariable.loginUsername = reader["username"].ToString();
                            success = true;
                        }
                    }
                }
                conn.Close();
            }
            if (success)
            {
                if (radioButton2.Checked)
                    Properties.Settings.Default["DatabaseDirectory2"] = textBox1.Text;
                else
                    Properties.Settings.Default["DatabaseDirectory2"] = "|DataDirectory|bordirDatabase.sqlite3";
                Properties.Settings.Default.Save();
                openForm(new MenuForm());
                passwordText.Text = "";
            }
            else
                MessageBox.Show("Login Failed");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = button1.Enabled = radioButton2.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////using (OpenFileDialog open = new OpenFileDialog())
            ////{
            ////    open.Filter = " SQL Server databases | *.mdf;";
            ////    if (open.ShowDialog() == DialogResult.OK)
            ////    {
            ////        textBox1.Text = open.FileName;
            ////    }
            ////}
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "SQLite database files | *.db; *.sqlite; *.sqlite3; *.db3";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = open.FileName;
                    //Check Network?
                    if (textBox1.Text.StartsWith("\\\\"))
                        textBox1.Text = "\\\\" + textBox1.Text;
                }
            }
        }
        
        private void usernameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(sender, e);
            }
        }

        private void passwordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(sender, e);
            }
        }
    }
}
