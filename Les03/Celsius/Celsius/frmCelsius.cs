using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celsius
{
    public partial class frmCelsius : Form
    {
        public frmCelsius()
        {
            InitializeComponent();
        }

        private void BtnCelsius_Click(object sender, EventArgs e)
        {
            // waarde uit tekstvak voor celsius lezen
            // en omzetten naar een double type
            double celsius = Convert.ToDouble(txtCelsius.Text);
            // variabele voor fahrenheit waarde en berekening
            double fahrenheit = (celsius * 1.8) + 32;
            // resultaat in onderste tekstvak plaatsen
            txtResult.Text = fahrenheit.ToString();
        }

        private void BtnFahrenheit_Click(object sender, EventArgs e)
        {
            // waarde uit tekstvak voor fahrenheit lezen
            // en omzetten naar een double type
            double fahrenheit = Convert.ToDouble(txtFahrenheit.Text);
            // variabele voor celsius waarde en berekening
            // formule: (F - 32) / 1.8
            double celsius = (fahrenheit - 32) / 1.8;
            // afronden tot op 2 cijfers na de komma
            celsius = Math.Round(celsius,2);
            // resultaat in onderste tekstvak plaatsen
            txtResult.Text = celsius.ToString();
        }
    }
}
