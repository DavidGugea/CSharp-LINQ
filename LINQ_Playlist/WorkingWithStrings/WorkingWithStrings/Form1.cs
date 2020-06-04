using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingWithStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "XY34/w = abc-12";
            listBox1.Items.Add(s);
            listBox1.Items.Add(String.Empty);

            IEnumerable<char> query1 = from c in s
                                       where Char.IsDigit(c)
                                       select c;

            foreach(char c in query1)
            {
                listBox1.Items.Add(c);
            }

            int count = query1.Count();
            listBox1.Items.Add(string.Format("Anzahl = {0}", count));

            IEnumerable<char> query2 = s.TakeWhile(c => c != '=');
            foreach(char c in query2)
            {
                listBox1.Items.Add(c.ToString());
            }
        }
    }
}
