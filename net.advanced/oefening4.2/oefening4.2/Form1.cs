namespace oefening4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tuple<int,Boolean,double> even = returnookdriewaarden(15, 17.34);
            int eenint = even.Item1;
            double eendob = even.Item3;
            bool eenbool = even.Item2;
        }
        Tuple<int, Boolean, double> returnookdriewaarden(int eeninterger, double eendouble)
        {
            return Tuple.Create((int)(eeninterger + eendouble),
                                eeninterger > eendouble,
                                eendouble - eeninterger);
        }
    }
}