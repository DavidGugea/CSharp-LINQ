using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string[] strArray =
        {
            "Müller",
            "Meier",
            "Kurze",
            "Scheider",
            "Merkel",
            "Krause",
            "Baumann",
            "Hofmann"
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(string item in strArray)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IEnumerable<string> result = from str in strArray
                                         where str.Length > 5
                                         orderby str ascending
                                         select str;
            listBox1.DataSource = result.ToArray();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IEnumerable<string> result = strArray.Where(str => str.Length > 5).OrderBy(str => str);
            listBox1.DataSource = result.ToArray();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IEnumerable<string> result = from str in strArray.AsParallel()
                                         where str.Length > 5
                                         orderby str ascending
                                         select str;
            listBox1.DataSource = result.ToArray();
        }
    }
}
