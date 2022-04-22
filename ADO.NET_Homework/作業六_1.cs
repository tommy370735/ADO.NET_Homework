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
    public partial class 作業六_1 : Form
    {
        public 作業六_1()
        {
            InitializeComponent();
            startset();
            this.newPhotoTableTableAdapter1.Fill(this.travelDataSet1.NewPhotoTable);
            this.bindingSource1.DataSource = this.travelDataSet1.NewPhotoTable;

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
                        linklb.Top = 125 + 30 * i;
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
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.TravelDBConnectionString))
                {
                    LinkLabel linkLabel = sender as LinkLabel;
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"Select * from NewPhotoTable where CityName = '{linkLabel.Text}'";//+$"Select PhotoID,Description from NewPhotoTable where CityName = '{linkLabel.Text}'";
                    command.Connection = conn;

                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    this.flowLayoutPanel1.Controls.Clear();
                    while (dataReader.Read())
                    {
                        byte[] bytes = (byte[])dataReader["Photo"];
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                        PictureBox pic = new PictureBox();
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Width = 180;
                        pic.Height = 120;
                        pic.Tag = dataReader["PhotoID"];
                        pic.Image = Image.FromStream(ms);
                        pic.Click += Pic_Click;
                        this.flowLayoutPanel1.Controls.Add(pic);

                    }
                    //dataReader.NextResult();
                    //listBox1.Items.Clear();
                    //listBox2.Items.Clear();
                    //while (dataReader.Read())
                    //{
                    //    listBox1.Items.Add(dataReader[0]);
                    //    listBox2.Items.Add(dataReader[1]);
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.TravelDBConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"Select Description from NewPhotoTable where PhotoID = '{pic.Tag}'";
                    command.Connection = conn;

                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        this.textBox1.Text = dataReader["Description"].ToString();

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            Form f = new Form();
            f.BackgroundImage = ((PictureBox)sender).Image;
            f.BackgroundImageLayout = ImageLayout.Zoom;
            f.Width = 381;
            f.Height = 305;
            f.Text = textBox1.Text;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homework_6_2 H6 = new Homework_6_2();
            H6.Show();
            this.Close();

        }


    }
}
