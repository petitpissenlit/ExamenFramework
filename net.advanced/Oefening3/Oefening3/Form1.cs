using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsEveritingDigit(String text)
        {
            foreach (char c in text)
            {
                if (!(char.IsDigit(c)))
                {
                    return false;
                }
            }
            return true;
        }
        Stapel<int> integers = new Stapel<int>();
        Stapel<string> strings = new Stapel<string>();
        Stapel<Persoon>personen = new Stapel<Persoon>();

        private void integersToevoegen_Click(object sender, EventArgs e)
        {
            if (IsEveritingDigit(integersInput.Text))
            {
                integers.OpDeStapel(int.Parse(integersInput.Text));

            } else
            {
                MessageBox.Show("enkel integers toegelaten ! ");
                integersInput.Text = null;
            }

            integersInput.Text = null;
        }


        private void verwijderenIntegers_Click(object sender, EventArgs e)
        {
            if(integers.ToString() != string.Empty)
            {
                integers.vanDeStapel();
            } else
            {
                MessageBox.Show(" de stapel is al leeg ! ");
            }
            
        }
        private void LeegmakenIntegers_Click(object sender, EventArgs e)
        {
           
            integers.StapelLeegMaken();
        }

        private void showListIntegers_Click(object sender, EventArgs e)
        {
            label6.Text =  "integers: " +  integers.ToString();
        }
        
    }
}
