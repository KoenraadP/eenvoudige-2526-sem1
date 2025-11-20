using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class FrmSimpleCalculator : Form
    {

        // globale variabelen komen hier
        // deze variabelen kunnen overal gebruikt worden
        // standaard als je geen waarde toekent bij cijfers
        // is deze (meestal) 0
        double number1;
        double number2;

        public FrmSimpleCalculator()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // methode ReadNumbers gebruiken om cijfers uit 
            // tekstvakken te halen en om te zetten
            ReadNumbers();
            double sum = Add(number1, number2);
            txtResult.Text = sum.ToString();
            // kortere versie
            //txtResult.Text = Add(number1, number2).ToString();
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            ReadNumbers();
            double difference = Subtract(number1, number2);
            txtResult.Text = difference.ToString();
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            ReadNumbers();
            double product = Multiply(number1, number2);
            txtResult.Text = product.ToString();
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            ReadNumbers();
            double quotient = Divide(number1, number2);
            txtResult.Text = quotient.ToString();
        }

        // methode om twee cijfers uit textboxes te halen
        // en om te zetten naar double
        private void ReadNumbers()
        {
            number1 = Convert.ToDouble(txtNumber1.Text);
            number2 = Convert.ToDouble(txtNumber2.Text);
        }

        // methode om twee opgegeven double getallen
        // op te tellen en het resultaat hiervan
        // 'terug' te krijgen als return waarde
        private double Add(double d1, double d2)
        {
            // parameters d1 en d2 optellen
            double result = d1 + d2;
            // result als return waarde
            return result;
            // kortere versie
            // return d1 + d2;
        }

        private double Subtract(double d1, double d2)
        {
            double result = d1 - d2;
            return result;
        }

        private double Multiply(double d1, double d2)
        {
            double result = d1 * d2;
            return result;
        }

        private double Divide(double d1, double d2)
        {
            double result = d1 / d2;
            return result;
        }
    }
}
