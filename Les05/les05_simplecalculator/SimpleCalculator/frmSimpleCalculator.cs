using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class FrmSimpleCalculator : Form
    {
        #region globals

        double number1;
        double number2;

        #endregion

        public FrmSimpleCalculator()
        {
            InitializeComponent();
        }

        #region methodes

        // methode die controleert of een string
        // kan omgezet worden naar een double
        // bool --> true of false
        private bool IsDouble(string s)
        {
            // variabele die op het einde true of false returnt
            bool check = false;
            // conversie 'proberen'
            // als het lukt --> verzetten naar true
            // mislukt --> naar catch overgaan
            try
            {
                Convert.ToDouble(s);
                check = true;
                return check;
            }
            catch
            {
                return check;
            }
        }

        private void ReadNumbers()
        {
            number1 = Convert.ToDouble(txtNumber1.Text);
            number2 = Convert.ToDouble(txtNumber2.Text);
        }

        // methode die alle vier de bewerkingen kan uitvoeren
        // op basis van opgegeven 'operation' (+ - x :)
        private double Calculate(double nr1, double nr2, string operation)
        {
            // variabele voor resultaat
            double result = 0;

            // berekening doen op basis van operation
            if (operation == "+")
            {
                result = nr1 + nr2;
            }
            else if (operation == "-")
            {
                result = nr1 - nr2;
            }
            else if (operation == "x")
            {
                result = nr1 * nr2;
            }
            else
            {
                result = nr1 / nr2;
            }

            // op het einde van de methode resultaat als return
            return result;
        }

        // alternatieve Calculate methode met switch ipv if/else
        private double Calculatev2(double nr1, double nr2, string operation)
        {
            // variabele voor resultaat
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = nr1 + nr2;
                    break;
                case "-":
                    result = nr1 - nr2;
                    break;
                case "x":
                    result = nr1 * nr2;
                    break;
                default:
                    result = nr1 / nr2;
                    break;
            }

            return result;
        }

        // methode die alle invoer vakken weer leeg maakt
        // en ook de focus (cursor) op/in het eerste vak zet
        private void ResetInput()
        {
            txtNumber1.Text = "";
            txtNumber2.Text = "";
            txtNumber1.Focus();
        }

        #endregion

        #region events

        // algemene click methode voor de buttons
        private void Btn_Click(object sender, EventArgs e)
        {
            // tekst uit textboxes als string opslaan
            string txt1 = txtNumber1.Text;
            string txt2 = txtNumber2.Text;
            // controleren of txt1 en text2 kunnen
            // omgezet worden naar double, zoja --> verder doen
            if (IsDouble(txt1) == true && IsDouble(txt2) == true)
            {
                ReadNumbers();
                // tekentje op button lezen
                string operation = ((Button)sender).Text;
                double result = Calculate(number1, number2, operation);
                txtResult.Text = result.ToString();
                ResetInput();
            }
            else
            {
                MessageBox.Show("Voer geldige cijfers in!", "Foute invoer",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
    }
}
