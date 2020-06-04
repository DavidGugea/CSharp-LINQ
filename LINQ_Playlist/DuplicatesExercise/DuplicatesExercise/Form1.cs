using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicatesExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Person> personen = new List<Person>()
        {
            new Person ( "Müller", "Kurt" ),
            new Person ( "Meier", "Timo" ),
            new Person ( "Schenider", "Alois" ),
            new Person ( "Müller", "Kurt" ),
            new Person ( "Schröder", "Thomas" ),
            new Person ( "Müller", "Kurt" ),
            new Person ( "Müller", "Max" ),
            new Person ( "Müller", "Thomas" ),
            new Person ( "Brezner", "Dr." ),
            new Person ( "Doberenz", "Walter" )
        };

        private void button1_Click(object sender, EventArgs e)
        {
            IEnumerable<Person> personen1 = personen.Distinct(new PersonComparer());
            listBox1.Items.Clear();
            foreach(Person item in personen1)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IEnumerable<Person> personen1 = personen.Distinct(new PersonComparer());

            string[] personenNN = (from ps in personen1
                                   select ps.Nachname).ToArray();
            listBox1.Items.Clear();
            foreach(string item in personenNN)
            {
                listBox1.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Person item in personen)
            {
                listBox1.Items.Add(item.ToString());
            }
        }
    }
}
