using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_Homework
{
    public partial class 作業四 : Form
    {
        public 作業四()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(nwDataSet1.Products);
            this.dataGridView1.DataSource = (nwDataSet1.Products);
            this.categoriesTableAdapter1.Fill(nwDataSet1.Categories);
            this.dataGridView2.DataSource = (nwDataSet1.Categories);
            this.customersTableAdapter1.Fill(nwDataSet1.Customers);
            this.dataGridView3.DataSource = (nwDataSet1.Customers);

            this.listBox1.Items.Clear();

            for(int i = 0; i < nwDataSet1.Tables.Count; i++)
            {
                DataTable table = this.nwDataSet1.Tables[i];
                this.listBox1.Items.Add(table.TableName);

                string s = "";
                for(int colum =0; colum < table.Columns.Count; colum++)
                {
                    s += $"{ table.Columns[colum].ColumnName,-40 }";
                }
                this.listBox1.Items.Add(s);

                this.listBox1.Items.Add("==============================================================================================================================================================================================================================================================");
                
                
                for (int row = 0; row < table.Rows.Count; row++)
                {
                    string x = "";
                    for(int line = 0; line < table.Columns.Count; line++)
                    {
                        x += $"{table.Rows[row][line],-40}";
                    }
                    this.listBox1.Items.Add(x);
                }


                this.listBox1.Items.Add("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel1Collapsed = !this.splitContainer2.Panel1Collapsed;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2Collapsed = !this.splitContainer2.Panel2Collapsed;
        }
    }
}
