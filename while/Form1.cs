using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                double toplam = 0;
               for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    toplam += Convert.ToDouble(listBox1.Items[i]);
                }
                label1.Text = "Toplam : " + toplam;
            }
        }

            private void button2_Click(object sender, EventArgs e)
        {
            int say = 1;
            while (say <= 10)
            {
                listBox1.Items.Add(say);
                say++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
