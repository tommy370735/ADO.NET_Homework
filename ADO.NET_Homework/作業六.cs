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
    public partial class 作業六 : Form
    {
        public 作業六()
        {
            InitializeComponent();
            startset();

        }

        public void startset()
        {
            //開連接失敗
            SqlConnection conn_伺服器資料庫 = null;

            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\所有資料\ADO.NET\作業整合\28_孫祐庠\ADO.NET_Homework\ADO.NET_Homework\TravelDB.mdf;Integrated Security=True
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(LocalDB)\MSSQLLocalDB";
            builder.AttachDBFilename = Application.StartupPath + @"\TravelDB.mdf";
            builder.IntegratedSecurity = true;

            try
            {
                using (conn_伺服器資料庫 = new SqlConnection(builder.ConnectionString))
                {
                    
                       conn_伺服器資料庫.Open();
                    SqlCommand command = new SqlCommand("Select CityName from City ", conn_伺服器資料庫);
                    SqlDataReader datard = command.ExecuteReader();
                    int i = 0;
                    while (datard.Read())
                    {
                       // for (int i = 0; i < datard.FieldCount; i++)
                      //  {
                            LinkLabel linklb = new LinkLabel();
                            linklb.Text = $"{datard[0].ToString()}";
                            linklb.Left = 30;
                            linklb.Top = 100 + 30 * i;
                            linklb.Tag = i;
                            linklb.Click += Linklb_Click;
                            this.splitContainer1.Panel1.Controls.Add(linklb);
                            i++;
                        //    }
                    }
                }
            }
            catch (Exception ex_異常狀況)
            {
                MessageBox.Show(ex_異常狀況.Message);
            }







        }

        private void Linklb_Click(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Cancle");
            }
        }


    }
}
