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

        #endregion

        #region events

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ReadNumbers();
            double result = Calculate(number1, number2, "+");
            txtResult.Text = result.ToString();
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            ReadNumbers();
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            ReadNumbers();
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            ReadNumbers();
        }

        #endregion
    }
}
