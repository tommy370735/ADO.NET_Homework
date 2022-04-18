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
    public partial class Homework_6_2 : Form
    {
        public Homework_6_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.photoPictureBox.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Cancle");
            }
        }


        private void newPhotoTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.newPhotoTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelDataSet);

        }

        private void Homework_6_2_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'travelDataSet.NewPhotoTable' 資料表。您可以視需要進行移動或移除。
            this.newPhotoTableTableAdapter.Fill(this.travelDataSet.NewPhotoTable);

        }
    }
}
