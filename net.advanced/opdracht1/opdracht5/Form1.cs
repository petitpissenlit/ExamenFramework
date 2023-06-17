namespace opdracht5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double convertInF = Convert.ToDouble(textBox1.Text) * 9 /5 +32;
            textBox1.Text = convertInF.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double convertInC = (Convert.ToDouble(textBox2.Text) - 32) * 5 / 9;
            textBox2.Text = convertInC.ToString();
        }
    }
}