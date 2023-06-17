namespace les7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 childform = new Form2();
            childform.MdiParent = this;
            childform.StartPosition
            
        }
    }
}