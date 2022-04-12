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
    public partial class Homework_03 : Form
    {
        public Homework_03()
        {
            InitializeComponent();
            con_起始設定();
        }

        private void con_起始設定()
        {
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.bindingSource1.DataSource = this.nwDataSet1.Products;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            lblResult.Text = $"結果 {this.bindingSource1.Count} 筆";
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            label2.Text = $"{this.bindingSource1.Position + 1} / {this.bindingSource1.Count}";
            lblResult.Text = $"結果 {this.bindingSource1.Count} 筆";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.bindingSource1.MoveFirst();
            this.bindingSource1.Position = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //this.bindingSource1.MovePrevious();
            this.bindingSource1.Position -= 1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //this.bindingSource1.MoveNext();
            this.bindingSource1.Position += 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveLast();
            this.bindingSource1.Position = bindingSource1.Count - 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal up1 = Convert.ToDecimal(textBox1.Text);
            decimal up2 = Convert.ToDecimal(textBox2.Text);
            this.productsTableAdapter1.FillByUnitPriceBetween(this.nwDataSet1.Products, up1, up2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string PdName = textBox3.Text;
            this.productsTableAdapter1.FillByLIKE(nwDataSet1.Products, '%' + PdName + '%');
        }


    }
}
