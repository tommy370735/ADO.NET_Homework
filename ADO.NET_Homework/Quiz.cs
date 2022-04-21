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
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();

            LoadTreeView();
            LoadTreeView2();
        }

        private void LoadTreeView2()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "Select distinct City from Customers";
                    command.Connection = conn;
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void LoadTreeView()
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "Select distinct Country, City, Count(*) as 'countNb' from Customers group by Country,City order by Country ";
                    command.Connection = conn;
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    string country = "";
                    TreeNode treeNode = null;
                    int count = 0;
                    while (dataReader.Read())
                    {
                        if(country != dataReader["Country"].ToString())
                        {
                            treeNode = this.treeView1.Nodes.Add($"{ dataReader["Country"] }");
                            country = dataReader["Country"].ToString();
                            count = 0;
                        }
                        treeNode.Nodes.Add(dataReader["City"].ToString());
                        count += (int)dataReader["countNb"];
                        treeNode.Text = $"{country}({count})";

                    }
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView tre = sender as TreeView;
            this.customersTableAdapter1.FillByCity(this.nwDataSet1.Customers, tre.SelectedNode.Text);
            this.dataGridView1.DataSource = this.nwDataSet1.Customers;
            if (dataGridView1.Rows.Count-1 ==0)
            {
                this.textBox1.Text = "請點選國家內的城市。";
            }
            else if (dataGridView1.Rows.Count-1 > 0)
            {
                this.textBox1.Text = $"城市：{tre.SelectedNode.Text} 內共計有 {this.dataGridView1.Rows.Count - 1} 位顧客。";
            }

        }
    }
}
