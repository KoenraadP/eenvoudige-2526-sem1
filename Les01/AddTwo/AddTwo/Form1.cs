using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // eerst error label weer onzichtbaar maken
            lblError.Visible = false;

            try
            {
                // cijfers uit de textboxes inlezen
                // en opslaan in variabelen
                int iNumber1 = Convert.ToInt32(txtNumber1.Text);
                int iNumber2 = Convert.ToInt32(txtNumber2.Text);

                // cijfers optellen en opslaan in derde variabele
                int iResult = iNumber1 + iNumber2;

                // resultaat tonen in derde textbox
                // hierbij moeten we opnieuw converteren naar string
                txtResult.Text = iResult.ToString();

                // in één lijn :)
                //txtResult.Text = 
                //        (Convert.ToInt32(txtNumber1.Text) 
                //        + Convert.ToInt32(txtNumber2.Text)).ToString();
            }
            catch 
            {
                // foutmelding als er iets mislukt is bij het uitvoeren van de try code
                // txtResult.Text = "Oei, er is iets fout gelopen!";
                // MessageBox --> soort pop-up, vergelijkbaar met alert in JavaScript
                // MessageBox.Show("Oei, er is iets fout gelopen!");
                // label zichtbaar maken
                lblError.Visible = true;
            }

        }
    }
}
