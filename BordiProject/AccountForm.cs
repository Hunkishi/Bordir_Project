using System;
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
    public partial class AccountForm : Form
    {

        private bool containCharacterOnly(String x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if ((x[i] < 'A' || x[i] > 'Z') && (x[i] < 'a' || x[i] > 'z'))
                {
                    return false;
                }
            }
            return true;
        }

        public AccountForm()
        {
            InitializeComponent();
            //if (GlobalVariable.loginUsername != "admin") groupBox1.Enabled = false;
            changeusernameText.Text = GlobalVariable.loginUsername;
        }

        private void registrasiButton_Click(object sender, EventArgs e)
        {
            String username = registrasiusernameText.Text;
            String password = registrasipasswordText.Text;
            String verifikasi = registrasiverifikasiText.Text;
            if (username.Length < 5 || username.Length > 15)
            {
                MessageBox.Show("Panjang username harus 5 - 15 karakter");
                return;
            }
            if (password.Length < 5 || password.Length > 15)
            {
                MessageBox.Show("Panjang password harus 5 - 15 karakter");
                return;
            }
            if (!containCharacterOnly(username))
            {
                MessageBox.Show("Username hanya boleh terdiri dari huruf alphabet besar/kecil");
                return; 
            }
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    String query = "SELECT * FROM UserData WHERE username = @username";
            //    using (var cmd = new SqlCommand(query,conn))
            //    {
            //        cmd.Parameters.AddWithValue("@username",username);
            //        if (cmd.ExecuteScalar() != null)
            //        {
            //            MessageBox.Show("Username Telah Ada");
            //            return;
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT * FROM UserData WHERE username = @username";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    if (cmd.ExecuteScalar() != null)
                    {
                        MessageBox.Show("Username Telah Ada");
                        return;
                    }
                }
                conn.Close();
            }
            if (password != verifikasi)
            {
                MessageBox.Show("Password dan Verifikasi Password berbeda");
                return;
            }
            //using (var conn = new SqlConnection(GlobalVariable.builder))
            //{
            //    conn.Open();
            //    int maxID;
            //    String query = "SELECT COALESCE(MAX(userID),0) FROM UserData;";
            //    using (SqlCommand cmd = new SqlCommand(query,conn))
            //    {
            //        maxID = (int)cmd.ExecuteScalar();
            //    }
            //    query = "INSERT UserData(userID,username,password) VALUES (@userID,@username,PWDENCRYPT(@password));";
            //    using (SqlCommand cmd = new SqlCommand(query,conn))
            //    {
            //        cmd.Parameters.AddWithValue("@userID", maxID + 1);
            //        cmd.Parameters.AddWithValue("@username", username);
            //        cmd.Parameters.AddWithValue("@password", password);
            //        cmd.ExecuteNonQuery();
            //    }
            //    query = "INSERT UserROle(userID,roleID) VALUES (@userID,@roleID)";
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@userID", maxID + 1);
            //        cmd.Parameters.Add("@roleID", SqlDbType.VarChar);
            //        if (checkBox1.Checked)
            //        {
            //            cmd.Parameters["@roleID"].Value = "PRO1";
            //            cmd.ExecuteNonQuery();
            //        }
            //        if (checkBox2.Checked)
            //        {
            //            cmd.Parameters["@roleID"].Value = "PRO2";
            //            cmd.ExecuteNonQuery();
            //        }
            //        if (checkBox4.Checked)
            //        {
            //            cmd.Parameters["@roleID"].Value = "ORD1";
            //            cmd.ExecuteNonQuery();
            //        }
            //        if (checkBox3.Checked)
            //        {
            //            cmd.Parameters["@roleID"].Value = "ORD2";
            //            cmd.ExecuteNonQuery();
            //        }
            //        if (checkBox6.Checked)
            //        {
            //            cmd.Parameters["@roleID"].Value = "INV1";
            //            cmd.ExecuteNonQuery();
            //        }
            //        if (checkBox5.Checked)
            //        {
            //            cmd.Parameters["@roleID"].Value = "INV2";
            //            cmd.ExecuteNonQuery();
            //        }
            //        if (checkBox8.Checked)
            //        {
            //            cmd.Parameters["@roleID"].Value = "REC1";
            //            cmd.ExecuteNonQuery();
            //        }
            //        if (checkBox7.Checked)
            //        {
            //            cmd.Parameters["@roleID"].Value = "REC2";
            //            cmd.ExecuteNonQuery();
            //        }
            //        if (checkBox10.Checked)
            //        {
            //            cmd.Parameters["@roleID"].Value = "STO1";
            //            cmd.ExecuteNonQuery();
            //        }
            //        if (checkBox9.Checked)
            //        {
            //            cmd.Parameters["@roleID"].Value = "STO2";
            //            cmd.ExecuteNonQuery();
            //        }
            //        if (checkBox12.Checked)
            //        {
            //            cmd.Parameters["@roleID"].Value = "PUR1";
            //            cmd.ExecuteNonQuery();
            //        }
            //        if (checkBox11.Checked)
            //        {
            //            cmd.Parameters["@roleID"].Value = "PUR2";
            //            cmd.ExecuteNonQuery();
            //        }
            //        if (checkBox14.Checked)
            //        {
            //            cmd.Parameters["@roleID"].Value = "CUS1";
            //            cmd.ExecuteNonQuery();
            //        }
            //        if (checkBox13.Checked)
            //        {
            //            cmd.Parameters["@roleID"].Value = "CUS2";
            //            cmd.ExecuteNonQuery();
            //        }
            //        if (checkBox15.Checked)
            //        {
            //            cmd.Parameters["@roleID"].Value = "USR";
            //            cmd.ExecuteNonQuery();
            //        }
            //        if (checkBox16.Checked)
            //        {
            //            cmd.Parameters["@roleID"].Value = "PUR3";
            //            cmd.ExecuteNonQuery();
            //        }
            //        if (checkBox17.Checked)
            //        {
            //            cmd.Parameters["@roleID"].Value = "STO3";
            //            cmd.ExecuteNonQuery();
            //        }
            //        if (checkBox18.Checked)
            //        {
            //            cmd.Parameters["@roleID"].Value = "CUS3";
            //            cmd.ExecuteNonQuery();
            //        }
            //    }
            //    conn.Close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                int maxID;
                String query = "SELECT COALESCE(MAX(userID),0) FROM UserData;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    maxID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                query = "INSERT INTO UserData(userID,username,password) VALUES (@userID,@username,@password);";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", maxID + 1);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", GlobalVariable.Hash(password));
                    cmd.ExecuteNonQuery();
                }
                query = "INSERT INTO UserRole(userID,roleID) VALUES (@userID,@roleID)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", maxID + 1);
                    cmd.Parameters.Add("@roleID", DbType.String);
                    if (checkBox1.Checked)
                    {
                        cmd.Parameters["@roleID"].Value = "PRO1";
                        cmd.ExecuteNonQuery();
                    }
                    if (checkBox2.Checked)
                    {
                        cmd.Parameters["@roleID"].Value = "PRO2";
                        cmd.ExecuteNonQuery();
                    }
                    if (checkBox4.Checked)
                    {
                        cmd.Parameters["@roleID"].Value = "ORD1";
                        cmd.ExecuteNonQuery();
                    }
                    if (checkBox3.Checked)
                    {
                        cmd.Parameters["@roleID"].Value = "ORD2";
                        cmd.ExecuteNonQuery();
                    }
                    if (checkBox6.Checked)
                    {
                        cmd.Parameters["@roleID"].Value = "INV1";
                        cmd.ExecuteNonQuery();
                    }
                    if (checkBox5.Checked)
                    {
                        cmd.Parameters["@roleID"].Value = "INV2";
                        cmd.ExecuteNonQuery();
                    }
                    if (checkBox8.Checked)
                    {
                        cmd.Parameters["@roleID"].Value = "REC1";
                        cmd.ExecuteNonQuery();
                    }
                    if (checkBox7.Checked)
                    {
                        cmd.Parameters["@roleID"].Value = "REC2";
                        cmd.ExecuteNonQuery();
                    }
                    if (checkBox10.Checked)
                    {
                        cmd.Parameters["@roleID"].Value = "STO1";
                        cmd.ExecuteNonQuery();
                    }
                    if (checkBox9.Checked)
                    {
                        cmd.Parameters["@roleID"].Value = "STO2";
                        cmd.ExecuteNonQuery();
                    }
                    if (checkBox12.Checked)
                    {
                        cmd.Parameters["@roleID"].Value = "PUR1";
                        cmd.ExecuteNonQuery();
                    }
                    if (checkBox11.Checked)
                    {
                        cmd.Parameters["@roleID"].Value = "PUR2";
                        cmd.ExecuteNonQuery();
                    }
                    if (checkBox14.Checked)
                    {
                        cmd.Parameters["@roleID"].Value = "CUS1";
                        cmd.ExecuteNonQuery();
                    }
                    if (checkBox13.Checked)
                    {
                        cmd.Parameters["@roleID"].Value = "CUS2";
                        cmd.ExecuteNonQuery();
                    }
                    if (checkBox15.Checked)
                    {
                        cmd.Parameters["@roleID"].Value = "USR";
                        cmd.ExecuteNonQuery();
                    }
                    if (checkBox16.Checked)
                    {
                        cmd.Parameters["@roleID"].Value = "PUR3";
                        cmd.ExecuteNonQuery();
                    }
                    if (checkBox17.Checked)
                    {
                        cmd.Parameters["@roleID"].Value = "STO3";
                        cmd.ExecuteNonQuery();
                    }
                    if (checkBox18.Checked)
                    {
                        cmd.Parameters["@roleID"].Value = "CUS3";
                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
            MessageBox.Show("Akun Berhasil Ditambahkan");

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            String username = changeusernameText.Text;
            String password = changepasswordText.Text;
            String newpassword = changenewpasswordText.Text;
            String verifikasi = changeverifiasiText.Text;
            //using (sqlconnection conn = new sqlconnection(globalvariable.builder))
            //{
            //    conn.open();
            //    string query = "select * from userdata where username = @username and pwdcompare(@password,password) = 1";
            //    using (sqlcommand cmd = new sqlcommand(query, conn))
            //    {
            //        cmd.parameters.addwithvalue("@username", username);
            //        cmd.parameters.addwithvalue("@password", password);
            //        if (cmd.executescalar() == null)
            //        {
            //            messagebox.show("username dengan password tidak sesuai");
            //            return;
            //        }
            //    }
            //    if (newpassword.length < 5 || newpassword.length > 15)
            //    {
            //        conn.close();
            //        messagebox.show("panjang password baru harus 5 - 15 karakter");
            //        return;
            //    }
            //    if (newpassword != verifikasi)
            //    {
            //        conn.close();
            //        messagebox.show("password baru dan verifikasi password berbeda");
            //        return;
            //    }
            //    query = "update userdata set password = pwdencrypt(@password) where username = @username;";
            //    using (sqlcommand cmd = new sqlcommand(query, conn))
            //    {
            //        cmd.parameters.addwithvalue("@username", username);
            //        cmd.parameters.addwithvalue("@password", newpassword);
            //        cmd.executenonquery();
            //    }
            //    conn.close();
            //}
            using (var conn = new SQLiteConnection(GlobalVariable.builder))
            {
                conn.Open();
                String query = "SELECT * FROM UserData WHERE username = @username AND password = @password";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", GlobalVariable.Hash(password));
                    if (cmd.ExecuteScalar() == null)
                    {
                        MessageBox.Show("Username dengan Password tidak sesuai");
                        return;
                    }
                }
                if (newpassword.Length < 5 || newpassword.Length > 15)
                {
                    conn.Close();
                    MessageBox.Show("Panjang password baru harus 5 - 15 karakter");
                    return;
                }
                if (newpassword != verifikasi)
                {
                    conn.Close();
                    MessageBox.Show("Password baru dan Verifikasi Password berbeda");
                    return;
                }
                query = "UPDATE UserData SET password = @password WHERE username = @username;";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", GlobalVariable.Hash(newpassword));
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            MessageBox.Show("Password Akun Berhasil Diubah");
            changepasswordText.Text = changenewpasswordText.Text = changeverifiasiText.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = checkBox2.Checked = true;
            checkBox3.Checked = checkBox4.Checked = true;
            checkBox5.Checked = checkBox6.Checked = true;
            checkBox7.Checked = checkBox8.Checked = true;
            checkBox9.Checked = checkBox10.Checked = checkBox17.Checked = true;
            checkBox11.Checked = checkBox12.Checked = checkBox16.Checked = true;
            checkBox13.Checked = checkBox14.Checked = checkBox18.Checked = true;
            checkBox15.Checked = true; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = checkBox2.Checked = false;
            checkBox3.Checked = checkBox4.Checked = false;
            checkBox5.Checked = checkBox6.Checked = false;
            checkBox7.Checked = checkBox8.Checked = false;
            checkBox9.Checked = checkBox10.Checked = checkBox17.Checked = false;
            checkBox11.Checked = checkBox12.Checked = checkBox16.Checked = false;
            checkBox13.Checked = checkBox14.Checked = checkBox18.Checked = false;
            checkBox15.Checked = false;
        }
    }
}
