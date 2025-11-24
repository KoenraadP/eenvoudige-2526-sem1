using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace distance
{
    public partial class frmDistance : Form
    {

        #region globals

        double avgSpeed;
        double duration;

        #endregion

        public frmDistance()
        {
            InitializeComponent();
        }

        #region methods

        // eerste methode: 2 textboxes lezen
        // en inhoud omzetten naar double waarden
        // deze dan ook opslaan in globale variabelen
        private void ReadInputs(TextBox box1, TextBox box2)
        {
            avgSpeed = Convert.ToDouble(box1.Text);
            duration = Convert.ToDouble(box2.Text);
        }

        // methode om de twee cijfers met elkaar te vermenigvuldigen
        // resultaat is opnieuw hetzelfde type als de invoer cijfers
        // in dit geval dus 'double'
        private double CalculateDistance(double speed, double timeInMinutes)
        {
            double result = (speed/60) * timeInMinutes;
            return result;
        }

        // methode die een uitvoer 'zin' maakt met het antwoord hierin
        private string Output(double distanceDriven)
        {
            string output = "Na " + duration + " minuten rijden "
                            + "aan een gemiddelde snelheid van " + avgSpeed
                            + " km per uur heb je " + distanceDriven
                            + " km gereden.";
            return output;
        }

        #endregion

        private void BtnDistance_Click(object sender, EventArgs e)
        {
            // gemaakte methodes aanroepen
            ReadInputs(txtAvgSpeed, txtDuration);
            double distance = CalculateDistance(avgSpeed, duration);
            distance = Math.Round(distance, 2);
            txtOutput.Text = Output(distance);
        }
    }
}
