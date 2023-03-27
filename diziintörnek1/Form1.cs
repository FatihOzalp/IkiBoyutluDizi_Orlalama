using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziintörnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[3];
        int[,] notlar = new int[3, 4];
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            isimler[index] = textBox5.Text;
            notlar[index, 0] = int.Parse(textBox1.Text);
            notlar[index, 1] = int.Parse(textBox2.Text);
            notlar[index, 2] = int.Parse(textBox3.Text);
            notlar[index, 3] = int.Parse(textBox4.Text);
            index++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double toplam;
            for (int i = 0; i < 3; i++)
            {
                toplam = 0;
                for (int j = 0; j < 4; j++)
                {
                    toplam += notlar[i, j];

                }
                listBox1.Items.Add(isimler[i] + "->" + toplam / 4);
            }
        }
    }
}
