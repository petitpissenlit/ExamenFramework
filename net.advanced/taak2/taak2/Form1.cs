namespace taak2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dier koe = new koe(1000);
            dier varken = new varken(250);
            dier slang = new slang(5);

            if (checkBox1.Checked)
            {
                MessageBox.Show(koe.ToString());
            }
            if (checkBox2.Checked)
            {
                MessageBox.Show(slang.ToString());
            }

            if (checkBox3.Checked)
            {
                MessageBox.Show(varken.ToString());
                
            }
        }
    }
    
}