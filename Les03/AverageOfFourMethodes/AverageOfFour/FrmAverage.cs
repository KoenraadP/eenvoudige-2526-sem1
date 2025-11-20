using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageOfFour
{
    public partial class FrmAverage : Form
    {
        // globals om te gebruiken bij de uitwerking van de opdracht
        double dNr1, dNr2, dNr3, dNr4;

        public FrmAverage()
        {
            InitializeComponent();
        }

        // methode om iets te testen :)
        private string VeryLargeNumber()
        {
            int length = 309;
            string largeNumber = new string('9', length);
            return largeNumber;
        }

        // maak de drie methodes waarvoor je hieronder de beschrijvingen vindt
        // koppel daarna deze methodes op een correcte manier aan de knop

        // schrijf een methode die de variabelen dNr1, dNr2, dNr3 en dNr4
        // een waarde toekent: de inhoud van de vier textboxes, omgezet naar
        // double formaat



        // schrijf een methode die het gemiddelde berekent van
        // vier opgegeven double cijfers
        // het gemiddelde moet uit de methode komen als 'uitkomst'



        // schrijf een methode die een tekst zin maakt
        // "Het gemiddelde is ..."
        // op het einde van deze zin wordt een cijfer getoond
        // dit cijfer wordt ingevoerd bij het aanroepen van de methode



    }
}
