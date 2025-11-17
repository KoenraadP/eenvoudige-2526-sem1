using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace les02_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            // try => probeer deze code
            // loopt het fout, ga dan over naar het 'catch' blokje
            try
            {
                // variabelen om cijfers uit textboxes op te slaan
                int number1 = Convert.ToInt32(txtNr1.Text);
                int number2 = Convert.ToInt32(txtNr2.Text);

                // variabele voor resultaat en berekening doen
                int result = number1 / number2;

                // resultaat tonen in derde textbox
                // altijd weer omzetten naar string voor 
                // plaatsen in textbox (tenzij het al string was)
                txtResult.Text = result.ToString();
            }
            catch
            {
                // deze code wordt enkel uitgevoerd
                // als er iets fout gelopen is in het 'try' blokje
                MessageBox.Show("Oei, er is iets fout gelopen");
            }
        }
    }
}
