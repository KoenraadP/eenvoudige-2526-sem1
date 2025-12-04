using System;
using System.Windows.Forms;

namespace opdracht_selectie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // methode om te controleren of een string
        // kan omgezet worden naar een double
        private bool IsDouble(string s)
        {
            try
            {
                Convert.ToDouble(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // methode om te controleren of een specifiek (double) cijfer
        // binnen een bereik valt, bijvoorbeeld tussen 0 en 100 ligt
        private bool InRange(int min, int max, double number)
        {
            if (number < min || number > max)
            {
                return false;
            }

            return true;
        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";

            string input = txtInput.Text;

            // controleren of de invoer wel degelijk een double kan zijn
            if (IsDouble(input))
            {
                // converteren naar double
                double number = Convert.ToDouble(input);
                // controleren of cijfer binnen bereik valt
                if (InRange(0, 100, number))
                {
                    // melding als alle validatie gelukt is
                    lblOutput.Text = "Alles OK!";
                }
                else
                {
                    // foutmelding als cijfer niet binnen bereik valt
                    lblOutput.Text = "Cijfer moet groter dan 0 en niet groter dan 100 zijn.";
                }
            }
            else
            {
                // foutmelding als de input geen double is
                lblOutput.Text = "Geen cijfer ingevoerd!";
            }
        }
    }
}
