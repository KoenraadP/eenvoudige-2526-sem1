using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AreaCircle
{
    public partial class frmAreaCircle : Form
    {
        public frmAreaCircle()
        {
            InitializeComponent();
        }

        private void BtnArea_Click(object sender, EventArgs e)
        {
            // straal waarde uit tekstvak halen
            // en opslaan in variabele
            string sRadius = txtRadius.Text;
            // waarde omzetten naar een double getal type
            // om er mee te kunnen rekenen
            double dRadius = Convert.ToDouble(sRadius);
            // oppervlakte berekenen en opslaan in variabele
            double area = Math.PI * dRadius * dRadius;
            // alternatief voor dRadius * dRadius: Math.Pow(dRadius, 2);
            // afronden tot op twee cijfers na de komma
            area = Math.Round(area,2);
            // resultaat in onderste tekstvak plaatsen
            txtResult.Text = area.ToString();
        }
    }
}
