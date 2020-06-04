using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyntaxDifferences
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public IEnumerable<int> numbers = new List<int>() { 5, -4, 18, 26, 0, 19, 16, 2, -1, 0, 9, -5, 8, 15, 19 };

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach(int number in numbers)
            {
                ListBox_Numbers.Items.Add(number);
            }
        }

        private void QueryExpressionSyntax_Button_Click(object sender, EventArgs e)
        {
            IEnumerable<int> result = from number in numbers
                                      where number > 10
                                      orderby number ascending
                                      select number;

            ListBox_Numbers.DataSource = result.ToArray();
        }

        private void ExtensionMethodSyntax_Button_Click(object sender, EventArgs e)
        {
            IEnumerable<int> result = numbers.Where(number => number > 10).OrderBy(number => number).Select(number => number);
            ListBox_Numbers.DataSource = result.ToArray();
        }

        private void GemischteSyntax_Click(object sender, EventArgs e)
        {
            IEnumerable<int> result = (from number in numbers
                                       where number > 10
                                       select number).OrderBy(number => number);
            ListBox_Numbers.DataSource = result.ToArray();
        }
    }
}