namespace les5._1
{
    public partial class Form1 : Form
    {

        public delegate double temperatuurconvertie(double temperatuur);
        public Form1()
        {
            InitializeComponent();
            temperatuurconvertie conversie1 = new temperatuurconvertie(CelsiusToFahrenheit);
            double result = conversie1(15);
            conversie1 = new temperatuurconvertie(CelsiusToKelvin);
            result = conversie1(15);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public double CelsiusToFahrenheit(double celsius)
        {
            return celsius * 1.8 + 32;
        }

        public double FahrenheitToCelsius(double fahrenheit)
        {
            return fahrenheit - 32 /1.8;
        }
        public double CelsiusToKelvin(double celsius)
        {
            return celsius + 253;
        }
    }
}