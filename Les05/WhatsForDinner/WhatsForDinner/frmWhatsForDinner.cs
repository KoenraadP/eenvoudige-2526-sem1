using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsForDinner
{
    public partial class frmWhatsForDinner : Form
    {
        public frmWhatsForDinner()
        {
            InitializeComponent();
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // gekozen dag opslaan in variabele
            string chosenDay = dateTimePicker.Value.DayOfWeek.ToString();

            // op basis van gekozen dag, gerecht instellen met methode
            string chosenFood = GetFood(chosenDay);
            txtDinner.Text = "Vandaag eten we " + chosenFood;
        }

        // methode die als invoer/parameter een dag krijgt
        // en als uitvoer een 'gerecht' 
        private string GetFood(string day)
        {
            // variabele voor uitvoer
            string food = "frieten van de frituur";

            switch (day)
            {
                case "Monday":
                    food = "spaghetti";
                    break;
                case "Tuesday":
                    food = "worst";
                    break;
                case "Wednesday":
                    food = "vis";
                    break;
                case "Thursday":
                    food = "biefstuk";
                    break;
                case "Friday":
                    food = "pizza";
                    break;
                case "Saturday":
                    food = "kip";
                    break;
                case "Sunday":
                    food = "spek";
                    break;
            }

            // return voorzien
            return food;
        }
    }
}
