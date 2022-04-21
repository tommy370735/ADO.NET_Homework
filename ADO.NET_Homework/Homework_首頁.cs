using ADO.NET作業2_VS複習;
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
    public partial class Homework_首頁 : Form
    {
        public Homework_首頁()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework_03 H003 = new Homework_03();
            H003.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(H003);
            H003.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            作業五 H005 = new 作業五();
            H005.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(H005);
            H005.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            作業四 H004 = new 作業四();
            H004.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(H004);
            H004.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework07 H007 = new Homework07();
            H007.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(H007);
            H007.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            作業六_1 H006 = new 作業六_1();
            H006.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(H006);
            H006.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Homework_01 H001 = new Homework_01();
            H001.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(H001);
            H001.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Quiz H008 = new Quiz();
            H008.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(H008);
            H008.Show();
        }
    }
}
