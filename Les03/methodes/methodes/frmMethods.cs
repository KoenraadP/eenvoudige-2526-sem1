using System;
using System.Windows.Forms;

namespace methodes
{
    public partial class frmMethods : Form
    {
        public frmMethods()
        {
            InitializeComponent();
        }

        // hieronder staan 4 verschillende methodes die allemaal kunnen gebruikt worden
        // binnen deze app om twee cijfers op te tellen 
        // de code om dan de methodes te gebruiken bij de knoppen staat er telkens ook bij 

        // methode 1: void methode zonder parameters
        private void Add1()
        {
            // cijfers ophalen uit de textboxes en omzetten
            decimal d1 = Convert.ToDecimal(txtNumber1.Text);
            decimal d2 = Convert.ToDecimal(txtNumber2.Text);

            // optellen en resultaat opslaan
            decimal dResult = d1 + d2;

            // resultaat in onderste textbox plaatsen
            txtResult.Text = dResult.ToString();
        }

        // Add1 methode wordt hieronder gebruikt bij de eerste button

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            // geen parameters en geen return, de methode kan hier dus gewoon gezet worden zonder extra code
            // alle code zit al in de methode zelf
            // deze methode kan je niet overzetten naar een andere app tenzij je in die andere app
            // exact hetzelfde soort formulier met dezelfde namen opbouwt
            Add1();
        }

        // methode 2: void methode met parameters
        private void Add2(decimal d1, decimal d2)
        {
            // optellen en resultaat opslaan
            decimal dResult = d1 + d2;

            // resultaat in onderste textbox plaatsen
            txtResult.Text = dResult.ToString();
        }

        // Add2 methode wordt hieronder gebruikt bij de tweede button

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            // deze keer moet ik de parameters invullen tussen haakjes want ik heb parameters voorzien bij de methode
            // ik moet wel binnen de haakjes ook de conversie doen want ik heb gezegd dat ik als parameters 'decimal' waarden gebruik
            // deze methode kan al iets makkelijker overgezet worden, enkel de txtResult kan voor problemen zorgen in de methode
            Add2(Convert.ToDecimal(txtNumber1.Text),Convert.ToDecimal(txtNumber2.Text));
        }

        // methode 3: return methode zonder parameters
        private decimal Add3()
        {
            // cijfers ophalen uit de textboxes en omzetten
            decimal d1 = Convert.ToDecimal(txtNumber1.Text);
            decimal d2 = Convert.ToDecimal(txtNumber2.Text);

            // optellen en resultaat opslaan
            decimal dResult = d1 + d2;

            // resultaat terug sturen uit de methode als 'uitkomst' van de methode (return)
            return dResult;
        }

        // Add3 methode wordt hieronder gebruikt bij de derde button

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            // hier moet ik enkel nog vermelden wat er moet gebeuren met de 'uitkomst' van de methode
            // moet ook omgezet worden naar string want de uitkomst van de methode is een decimal
            // opnieuw minder bruikbaar om over te zetten naar een andere app omdat de nieuwe app dan ook een txtNumber1 en txtNumber2 nodig heeft
            txtResult.Text = Add3().ToString();
        }

        // methode 4: return methode met parameters
        private decimal Add4(decimal d1, decimal d2)
        {
            // optellen en resultaat opslaan
            decimal dResult = d1 + d2;

            // resultaat terug sturen uit de methode als 'uitkomst' van de methode (return)
            return dResult;
        }

        // Add4 methode wordt hieronder gebruikt bij de vierde button

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            // het gebruik van methode 4 is wel iets complexer omdat er nog verschillende zaken moeten gebeuren
            // 1) vermelden waar de uitkomst moet komen (in txtResult)
            // 2) conversie van de textbox waarden naar decimal om op te tellen
            // 3) uiteindelijk ook weer naar string omzetten om in de textbox te krijgen
            // deze methode is echter het meest makkelijk te hergebruiken in een andere app omdat er in de methode zelf nog geen namen van controls (textboxes, buttons, ...) staan
            txtResult.Text = Add4(Convert.ToDecimal(txtNumber1.Text), Convert.ToDecimal(txtNumber2.Text)).ToString();
        }
    }
}
