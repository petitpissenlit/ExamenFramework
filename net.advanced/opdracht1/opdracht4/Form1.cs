namespace opdracht4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        private void calculator_Click(object sender, EventArgs e)
        {
            double itm1 = Convert.ToDouble(qty1.Text);
            double itm2 = Convert.ToDouble(qty2.Text);
            double itm3 = Convert.ToDouble(qty3.Text);
            double itm4 = Convert.ToDouble(qty4.Text);

            double peach1 = Convert.ToDouble(P_each1.Text);
            double peach2 = Convert.ToDouble(P_each2.Text);
            double peach3 = Convert.ToDouble(P_each3.Text);
            double peach4 = Convert.ToDouble(P_each4.Text);

            double resultaat1 = itm1 * peach1; 
            double resultaat2 = itm2 * peach2;
            double resultaat3 = itm3 * peach3;
            double resultaat4 = itm4 * peach4;

            Ex_Price1.Text = resultaat1.ToString();
            Ex_Price2.Text = resultaat2.ToString();
            Ex_Price3.Text = resultaat3.ToString();
            Ex_Price4.Text = resultaat4.ToString();

            double sbtot = resultaat1 + resultaat2 + resultaat3 + resultaat4;
            subtot.Text = "€" + sbtot.ToString();

            double btw = Convert.ToDouble(taxrate.Text);
            double Stax = sbtot * btw;

            saletax.Text = "€" + Stax.ToString();

            double shipp = Convert.ToDouble(shipping.Text);
            double grtot = sbtot + Stax + shipp;

            g_tot.Text = "€" + grtot.ToString();

        }

    }
}