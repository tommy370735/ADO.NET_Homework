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
    public partial class 作業五 : Form
    {
        public 作業五()
        {
            InitializeComponent();
            dis_起始設定1();
            dis_起始設定2();
        }

        //awDataSet1.[Production].ProductPhoto

        private void dis_起始設定2()
        {

            this.productPhotoTableAdapter1.Fill(this.awDataSet1.ProductPhoto);
            this.bindingSource1.DataSource = this.awDataSet1.ProductPhoto;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.pictureBox1.DataBindings.Add("Image", this.bindingSource1, "LargePhoto", true);
            //this.comboBox1.DataBindings.Add("SelectedText", this.bindingSource1, "ModifiedDate");
            this.bindingNavigator1.BindingSource = this.bindingSource1;

        }

        private void dis_起始設定1()
        {
            SqlConnection adw_資料庫 = new SqlConnection("Data Source=.;Initial Catalog=AdventureWorks2019;Integrated Security=True");
            SqlDataAdapter adw_轉接頭 = new SqlDataAdapter("Select distinct convert(char(4),[ModifiedDate],102) as 'year' from [Production].[ProductPhoto] group by ModifiedDate ", adw_資料庫);
            DataTable adw_目標數據 = new DataTable();
            adw_轉接頭.Fill(adw_目標數據);

            comboBox1.DataSource = adw_目標數據;

            comboBox1.DisplayMember = "year";
            //                           ↑取得欄位內的值↑
            //DataTable table = this.awDataSet1.Tables[0];
            //string s = "";
            //for (int i = 0; i < adw_目標數據.Tables[0].Rows.Count; i++)
            //{
            //    s = (adw_目標數據.Tables[0].Rows[i]["year"]).ToString();
            //    comboBox1.Items.Add(s);
            //}


        }

        //private int years()
        //{
        //    this.productPhotoTableAdapter1.FillByYYYY(this.awDataSet1.ProductPhoto);
        //    return this.awDataSet1.ProductPhoto.Rows.Count;
        //}



        private void button13_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveFirst();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MovePrevious();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveNext();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveLast();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            label4.Text = $"{this.bindingSource1.Position+1} / {this.bindingSource1.Count}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string d1= dateTimePicker1.Value.ToString();
            //string d2 = dateTimePicker2.Value.ToString();
            this.productPhotoTableAdapter1.FillByDatetime(this.awDataSet1.ProductPhoto, dateTimePicker1.Value, dateTimePicker2.Value);
            this.dataGridView1.DataSource = this.awDataSet1.ProductPhoto;
            dataGridView1.Sort(dataGridView1.Columns["ProductPhotoID"], ListSortDirection.Ascending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["ModifiedDate"], ListSortDirection.Ascending);
        }//                              ↑排序                          ↑列            ↑可用索引(int)或欄位名   ↑列表排序方向   ↑ASC升冪

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.productPhotoTableAdapter1.FillBytime(this.awDataSet1.ProductPhoto,comboBox1.Text );

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.productPhotoTableAdapter1.Fill(this.awDataSet1.ProductPhoto);
            this.dataGridView1.DataSource = this.bindingSource1;
            dataGridView1.Sort(dataGridView1.Columns["ProductPhotoID"], ListSortDirection.Ascending);
        }
    }
}
