namespace opdracht6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void calculator_Click(object sender, EventArgs e)
        {
            double d1 = Convert.ToDouble(textBox1.Text);
            double d2 = Convert.ToDouble(textBox2.Text);
            double d3 = Convert.ToDouble(textBox3.Text);
            double d4 = Convert.ToDouble(textBox4.Text);

            double prijs1 = Convert.ToDouble(P_each1.Text);
            double prijs2 = Convert.ToDouble(P_each2.Text);
            double prijs3 = Convert.ToDouble(P_each3.Text);
            double prijs4 = Convert.ToDouble(P_each4.Text);


            double resultaat1 = d1 * prijs1;
            double resultaat2 = d2 * prijs2;
            double resultaat3 = d3 * prijs3;
            double resultaat4 = d4 * prijs4;


            Ex_Price1.Text = resultaat1.ToString();
            Ex_Price2.Text = resultaat2.ToString();
            Ex_Price3.Text = resultaat3.ToString();
            Ex_Price4.Text = resultaat4.ToString();

            double subtotal = resultaat1 + resultaat2 + resultaat3 + resultaat4;
            subtot.Text = "€" + subtotal.ToString();

            double tva = subtotal * 7 / 100;
            saletax.Text = "€"+  tva.ToString();
            double shippin = 0;

            if (subtotal < 20)
            {
                shippin = 5;
                shipping.Text = "€" + shippin.ToString();
            }
            else if (subtotal < 50 && subtotal > 20)
            {
                shippin = 7.5;
                shipping.Text = "€" + shippin.ToString();
            }
            else if (subtotal < 75 && subtotal > 50)
            {
                shippin = 10;
                shipping.Text = "€" + shippin.ToString();
            }
            else
            {
                shippin = 0;
                shipping.Text = "€" + shippin.ToString();
            }
            double grandtotaal = subtotal + tva + shippin;
            g_tot.Text = "€" + grandtotaal.ToString();






            }
    }
}