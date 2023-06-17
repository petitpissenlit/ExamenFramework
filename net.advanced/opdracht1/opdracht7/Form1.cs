namespace opdracht7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double som = Convert.ToDouble(textBox1.Text);
            double getal = 0;
            for(int i = 0; i <= som; i++)
            {
                getal += i;
            }
            label2.Text = "€" + getal.ToString();
                
        }
    }
}