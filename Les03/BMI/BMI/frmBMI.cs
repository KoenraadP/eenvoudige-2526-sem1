using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class frmBMI : Form
    {
        public frmBMI()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // getallen uit de vakjes halen en opslaan
            double weight = Convert.ToDouble(txtWeight.Text);
            double height = Convert.ToDouble(txtHeight.Text);
            // berekening doen en resultaat opslaan
            // berekening = weight / (height * height)
            double bmi = weight / (height * height);
            // resultaat afronden tot op 2 cijfers na de komma
            bmi = Math.Round(bmi, 2);
            // resultaat in onderste txtbox plaatsen
            txtResult.Text = bmi.ToString();
        }
    }
}
