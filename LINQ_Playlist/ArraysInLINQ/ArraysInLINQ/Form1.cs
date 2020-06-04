using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysInLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = Enumerable.Repeat(-1, 10).ToArray();
            listBox1.DataSource = a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] b = Enumerable.Range(0, 10).ToArray();
            listBox2.DataSource = b;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] c = Enumerable.Range(0, 10).Select(i => 100 + 10 * i).ToArray();
            listBox3.DataSource = c;
        }
    }
}
