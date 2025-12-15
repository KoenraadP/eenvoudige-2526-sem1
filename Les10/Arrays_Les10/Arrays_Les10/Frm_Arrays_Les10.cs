using System;
using System.Windows.Forms;

namespace Arrays_Les10
{
    public partial class Frm_Arrays_Les10 : Form
    {
        // array klaarzetten voor 10 int getallen
        // global omdat de array beschikbaar moet zijn voor alle buttons
        int[] randomNumbers;

        public Frm_Arrays_Les10()
        {
            InitializeComponent();
        }

        // methode om tien random int cijfers te maken
        // en op te slaan in een array
        private int[] RandomArray(int min, int max, int amount)
        {
            // array aanmaken met gevraagde aantal plaatsen (amount)
            int[] newArray = new int[amount];

            // random number generator klaar zetten
            Random rnd = new Random();

            // de tien plaatsen in de array invullen
            // met telkens een nieuw random cijfer van min t/m max
            for (int i = 0; i < newArray.Length; i++)
            {
                // cijfer maken
                int newNumber = rnd.Next(min, max + 1);
                // cijfer toevoegen aan array volgens index i
                newArray[i] = newNumber;
            }

            return newArray;
        }

        // methode die alle items uit een array
        // toevoegt aan een listbox
        private void UpdateListbox(Array array, ListBox listbox)
        {
            // listbox eerst leegmaken zodat eventuele oude cijfers niet blijven staan
            listbox.Items.Clear();

            // alle 'items' in de array tonen in de listbox
            foreach (var item in array)
            {
                listbox.Items.Add(item);
            }
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            // knop 2 inschakelen
            btnSort.Enabled = true;

            // array opvullen via methode
            randomNumbers = RandomArray(100, 1000, 20);

            // alle cijfers tonen in eerste listbox
            UpdateListbox(randomNumbers, lbxRandom);
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            // knop 3 inschakelen
            btnFirst3.Enabled = true;

            // array sorteren van klein naar groot
            Array.Sort(randomNumbers);
            // opnieuw alle items tonen in listbox, deze keer gesorteerd
            UpdateListbox(randomNumbers, lbxSorted);
        }

        private void BtnFirst3_Click(object sender, EventArgs e)
        {
            // eerste drie items uit array tonen in derde listbox
            for (int i = 0; i < 3; i++)
            {
                lbxFirst3.Items.Add(randomNumbers[i]);
            }
        }
        private void Frm_Arrays_Les10_Load(object sender, EventArgs e)
        {
            // knoppen 2 en 3 uitschakelen
            btnSort.Enabled = false;
            btnFirst3.Enabled = false;
        }
    }
}
