using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Score
{
    public partial class FrmScore : Form
    {
        public FrmScore()
        {
            InitializeComponent();
        }

        private void BtnAverage_Click(object sender, EventArgs e)
        {
            // try --> checken of er geen grote problemen met invoer zijn
            try
            {
                // getallen uit textboxes halen
                double score1 = Convert.ToDouble(txtScore1.Text);
                double score2 = Convert.ToDouble(txtScore2.Text);
                double score3 = Convert.ToDouble(txtScore3.Text);

                // controleren of getallen binnen het juiste bereik vallen
                // niet kleiner dan 0, niet groter dan 100
                if (score1 < 0 || score1 > 100 ||
                    score2 < 0 || score2 > 100 ||
                    score3 < 0 || score3 > 100)
                {
                    MessageBox.Show("Niet kleiner dan 0 of groter dan 100!");
                }
                else
                {
                    // gemiddelde berekenen
                    double average = (score1 + score2 + score3) / 3;

                    // afronden tot op 2 cijfers, niet vergeten opnieuw op te slaan
                    average = Math.Round(average, 2);

                    // average tonen in txtAverage
                    txtAverage.Text = average.ToString();

                    // variabele voor graad
                    // standaard instellen op leeg
                    string grade = "";

                    if (average >= 88)
                    {
                        grade = "Grootste onderscheiding";
                    }
                    else if (average >= 77)
                    {
                        grade = "Grote onderscheiding";
                    }
                    else if (average >= 68)
                    {
                        grade = "Onderscheiding";
                    }
                    else if (average >= 50)
                    {
                        grade = "Voldoende";
                    }
                    else
                    {
                        grade = "Onvoldoende";
                    }

                    // grade tonen in label
                    lblGrade.Text = grade;
                }

            }
            catch
            {
                MessageBox.Show("Slechte invoer!");
            }
        }
    }
}
