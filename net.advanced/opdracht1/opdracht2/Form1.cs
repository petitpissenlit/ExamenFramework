namespace opdracht2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int opl1 = 1234 * 54321;
            string string1 = $"1234 * 54321 = {opl1}";
            lab1.Text = string1;

            int opl2 = 22222 * 33333;
            string string2 = $"22222 * 33333 = {opl2}";
            lab2.Text = string2;

            bool opl3 = opl1 < opl2;

            string string3 = $"1234 * 54321 > 22222 * 33333 = {opl3}";
            lab3.Text = string3;
        }
    }
}