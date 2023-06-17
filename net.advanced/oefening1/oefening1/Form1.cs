namespace oefening1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                tbresult.Text = (bool.Parse(tb1.Text)).ToString();
            }
            catch
            {
                if(tb1.Text.Equals("0"))
                {
                    tbresult.Text = false.ToString();
                }
                else if (tb1.Text == "1")
                {
                    tbresult.Text = true.ToString();
                }else
                {
                    tbresult.Text = "onbekend";
                }
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonkleinerdan_Click(object sender, EventArgs e)
        {
            try
            {
                tbresult.Text = (decimal.Parse(tb1.Text) < decimal.Parse(tb2.Text)).ToString();

            }
            catch
            {
                tbresult.Text = "!!! cijfers !!!";
                tbresult.ForeColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int van = 1;
                int tot = int.Parse(tb1.Text);

                int som = 0;

                while (van <= tot)
                {
                    som += van;
                    van++;
                }
                tbresult.Text = som.ToString();
            }
            catch
            {
                tbresult.Text = "!!! Interger Value in Operator !!!";
            }
        }

    
    }
}










