using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AggregatAbfragen_AggregateFunctions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<double> numbers = new List<double>();

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                listBox1.Items.Add(textBox1.Text);
                numbers.Add(double.Parse(textBox1.Text));
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = numbers.Count().ToString();
            textBox3.Text = numbers.Sum().ToString();
            textBox4.Text = numbers.Average().ToString();
            textBox5.Text = numbers.Max().ToString();
            textBox6.Text = numbers.Min().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            numbers = new List<double>();
        }
    }
}
