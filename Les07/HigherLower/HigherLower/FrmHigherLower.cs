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

namespace HigherLower
{
    public partial class FrmHigherLower : Form
    {
        // globale variabelen
        int randomNumber;
        int attempts;

        public FrmHigherLower()
        {
            InitializeComponent();
        }

        // methode die controleert of het ingevoerde cijfer
        // correct is of niet en dan ook een passende tekst maakt hiervoor
        private string GuessFeedback(int guessedNumber)
        {
            // variabele die uiteindelijk als return zal dienen
            string output = "";

            if (guessedNumber == randomNumber)
            {
                output = "Proficiat, je hebt goed geraden, het cijfer was inderdaad "
                            + randomNumber;
            }

            return output;
        }

        // Load wordt uitgevoerd bij starten van programma
        private void FrmHigherLower_Load(object sender, EventArgs e)
        {
            // attempts starten op 0
            attempts = 0;
            // een Random variabele maken 
            // om te kunnen een random cijfer genereren
            Random rng = new Random();
            // random cijfer kiezen vanaf 1 tot en met 5
            // let op: tweede parameter is de bovengrens maar is EXCLUSIEF dit cijfer
            randomNumber = rng.Next(1,6);
            // random cijfer tonen in output venster
            Debug.WriteLine(randomNumber.ToString());
        }

        private void BtnGuess_Click(object sender, EventArgs e)
        {
            // attempts verhogen met 1
            attempts++;
            // uitlezen wat er in textbox staat
            string input = txtGuess.Text;
            // omzetten naar int
            int guessedNumber = Convert.ToInt32(input);
            // gok controleren en resultaat in variabele opslaan
            string result = GuessFeedback(guessedNumber);
            // resultaat tonen in messagebox
            MessageBox.Show(result);

            // als we intussen drie pogingen gedaan hebben, sluit dan het programma af
            if (attempts == 3)
            {
                Close();
            }
        }
    }
}
