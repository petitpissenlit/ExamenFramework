using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oef3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              if (textBox2.Text != "")
            {
                double etd = double.Parse(textBox2.Text) * 1.02;
                textBox1.Text = etd.ToString();
                
            }
            
          else if (textBox3.Text != "")
            {
                double ftd = double.Parse(textBox3.Text) * 0.99;
                textBox1.Text = ftd.ToString();
                

            }
           
           else if (textBox4.Text != "")
            {
                double ptd = double.Parse(textBox4.Text) * 0.88;
                textBox1.Text = ptd.ToString();
                
            }
            

          else if (textBox5.Text != "")
            {
                double rtd = double.Parse(textBox5.Text) * 81.50;
                textBox1.Text = rtd.ToString();
                
            }
            

          else if (textBox6.Text != "")
            {
                double ytd = double.Parse(textBox6.Text) * 144.50;
                textBox1.Text = ytd.ToString();
                
            }
            


            if (textBox1.Text != "")
            {

                USD dollar = new USD(double.Parse(textBox1.Text));
                USD euro = new Euro(double.Parse(textBox1.Text));
                USD pounds = new Pounds(double.Parse(textBox1.Text));
                USD yen = new Yen(double.Parse(textBox1.Text));
                USD franken = new Franken(double.Parse(textBox1.Text));
                USD rupees = new Rupees(double.Parse(textBox1.Text));

                textBox1.Text = dollar.ToString();
                textBox2.Text = euro.ToString();
                textBox3.Text = franken.ToString();
                textBox4.Text = pounds.ToString();
                textBox5.Text = yen.ToString();
                textBox6.Text = rupees.ToString();
                
            }

        }
    }
}
