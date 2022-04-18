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
    public partial class Homework07 : Form
    {
        public Homework07()
        {
            InitializeComponent();

            LoadData();

            GetListView();

        }

        private void LoadData()
        {
            this.comboBox1.Items.Add("All Contries");
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand command = new SqlCommand("Select distinct Country from Customers", conn);
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    
                    while (dataReader.Read())
                    {
                        this.comboBox1.Items.Add(dataReader["Country"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetListView()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("Select * from Customers", conn);
                    SqlDataReader dataReader = command.ExecuteReader();
                    DataTable table = dataReader.GetSchemaTable();

                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        this.listView1.Columns.Add(table.Rows[i][0].ToString());
                    }
                    this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    this.comboBox1.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand command = new SqlCommand();

                    if(comboBox1.SelectedItem.ToString()== "All Contries")
                    {
                        command.CommandText = $"Select * from Customers";
                    }
                    else
                    {
                        command.CommandText = $"Select * from Customers where Country = '{this.comboBox1.Text}'";
                    }

                                   
                    command.Connection = conn;
                    conn.Open();
                    SqlDataReader dataReader =  command.ExecuteReader();
                    this.listView1.Items.Clear();

                    Random r = new Random();


                    while (dataReader.Read())
                    {
                        ListViewItem lvl = this.listView1.Items.Add(dataReader[0].ToString());
                        lvl.ImageIndex = r.Next(0, this.ImageList1.Images.Count);

                        if(lvl.Index%2 == 0)
                        {
                            lvl.BackColor = Color.Chocolate;
                        }
                        else
                        {
                            lvl.BackColor = Color.Lavender;
                        }
                        for(int i = 1; i < dataReader.FieldCount; i++)
                        {
                            if (dataReader.IsDBNull(i))
                            {
                                lvl.SubItems.Add("空值");
                            }
                            else
                            {
                                lvl.SubItems.Add(dataReader[i].ToString());
                            }
                                   
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.LargeIcon;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.SmallIcon;
        }

        private void detailsViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.Details;
        }
    }
}
