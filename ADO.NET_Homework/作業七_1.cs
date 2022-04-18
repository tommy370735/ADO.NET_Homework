using ADO.NET_Homework.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ADO.NET_Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                string MemberName = this.UsernameTextBox.Text;
                string passWord = this.PasswordTextBox.Text;
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "LogOnMyNewMember";
                    command.Connection = conn;
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("MemberName", SqlDbType.NVarChar, 16).Value = MemberName;
                    command.Parameters.Add("Password", SqlDbType.NVarChar, 40).Value = passWord;


                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        MessageBox.Show("成功登入，進入新頁面。");
                        Homework07 H07 = new Homework07();
                        H07.Show();

                    }
                    else
                    {
                        MessageBox.Show("登入失敗，請重新嘗試。");
                        this.UsernameTextBox.Clear();
                        this.PasswordTextBox.Clear();
                        this.UsernameTextBox.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string MemberName = this.UsernameTextBox.Text;
                string passWord = this.PasswordTextBox.Text;
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "InsertMyNewMember";
                    command.Connection = conn;
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("MemberName", SqlDbType.NVarChar, 16).Value = MemberName;
                    command.Parameters.Add("Password", SqlDbType.NVarChar, 40).Value = passWord;

                    conn.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("帳號建立成功，請登入帳戶。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已取消登入。");
            this.UsernameTextBox.Clear();
            this.PasswordTextBox.Clear();
            this.UsernameTextBox.Focus();
        }
    }
}
