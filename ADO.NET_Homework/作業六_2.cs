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
    public partial class Homework_6_2 : Form
    {
        public Homework_6_2()
        {
            InitializeComponent();
            startsetting();
            this.photoPictureBox.AllowDrop = true;
            this.photoPictureBox.DragEnter += PhotoPictureBox_DragEnter;
            this.photoPictureBox.DragDrop += PhotoPictureBox_DragDrop;

            this.cityTableAdapter1.Fill(this.travelDataSet.City);
            this.bindingSource1.DataSource = this.travelDataSet.City;
            this.dataGridView1.DataSource = this.bindingSource1;

        }

        private void PhotoPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.photoPictureBox.Image = Image.FromFile(files[0]);
            descriptionTextBox.Clear();
            descriptionTextBox.Focus();
        }

        private void PhotoPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void startsetting()
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(Settings.Default.TravelDBConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "Select distinct CityName from City ";
                    command.Connection = conn;

                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        this.cityNameComboBox.Items.Add(dataReader["CityName"]);
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
            this.openFileDialog1.Filter = "(*.jpg) | *.jpg | (*.bmp) | *.bmp | All files (*.*)|*.*";
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.photoPictureBox.Image = Image.FromFile(this.openFileDialog1.FileName);
                descriptionTextBox.Clear();
                descriptionTextBox.Focus();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.TravelDBConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"Insert into NewPhotoTable (CityName,Description,Photo) values (@City, @Desc,@Photo)";
                    command.Connection = conn;
                    byte[] bytes;
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.photoPictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    bytes = ms.GetBuffer();

                    command.Parameters.Add("@City",SqlDbType.NVarChar,50).Value =this.cityNameComboBox.SelectedItem.ToString();
                    command.Parameters.Add("@Desc",SqlDbType.Text).Value=this.descriptionTextBox.Text;
                    command.Parameters.Add("@Photo", SqlDbType.Image).Value=bytes;

                    conn.Open();
                    command.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.newPhotoTableTableAdapter.Fill(this.travelDataSet.NewPhotoTable);
            this.newPhotoTableBindingSource.DataSource = this.travelDataSet.NewPhotoTable;
            this.newPhotoTableDataGridView.DataSource = this.newPhotoTableBindingSource;
            this.newPhotoTableBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveLast();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            this.label1.Text = $"{this.bindingSource1.Position + 1} / {this.bindingSource1.Count}";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.TravelDBConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"Insert into City (CityName) values (@CityName)";
                    command.Connection = conn;

                    System.IO.MemoryStream ms = new System.IO.MemoryStream();

                    command.Parameters.Add("@CityName", SqlDbType.NVarChar, 50).Value = this.textBox1.Text;

                    conn.Open();
                    command.ExecuteNonQuery();
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.cityTableAdapter1.Fill(this.travelDataSet.City);
            this.bindingSource1.DataSource = this.travelDataSet.City;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingSource1.MoveLast();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            作業六_1 H6 = new 作業六_1();
            H6.Show();
            this.Close();
        }
    }
    }

