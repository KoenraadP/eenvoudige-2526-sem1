using System;
using System.Drawing;
using System.Windows.Forms;

namespace Negative
{
    public partial class frmNegative : Form
    {
        public frmNegative()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // controleren of één of beide cijfers kleiner zijn dan 0
            // zoja --> boodschap "Negative" in label
            // zo nee --> boodschap "Positive" in label

            double nr1 = Convert.ToDouble(txtNr1.Text);
            double nr2 = Convert.ToDouble(txtNr2.Text);

            if (nr1 < 0 || nr2 < 0)
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Negative";
            }
            else
            {
                lblResult.ForeColor = Color.Green;
                lblResult.Text = "Positive";
            }
        }

        // load event --> wordt uitgevoerd bij 'inladen' van programma
        private void FrmNegative_Load(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }
    }
}
