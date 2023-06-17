namespace opdracht1
{
    public partial class type1 : Form
    {
        public type1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            String text = $"hello {Environment.UserName}. het is nu {DateTime.Now.ToShortTimeString()} op {DateTime.Now.ToShortTimeString}";
            lab1.Text = text;
        }


    }
}