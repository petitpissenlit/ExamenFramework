namespace les._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "oei";
            button1.BackColor = Color.Yellow;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button1.Text = "de text is gewijzigd";
        }
    }
}