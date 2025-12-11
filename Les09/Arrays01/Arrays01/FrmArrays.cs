using System;
using System.Windows.Forms;

namespace Arrays01
{
    public partial class FrmArrays : Form
    {
        // nieuwe array declareren
        int[] numbers;
        // nieuwe 'random number generator' aanmaken
        Random rng;

        public FrmArrays()
        {
            InitializeComponent();
        }

        // methode die van een opgegeven array
        // alle elementen in een opgegeven listbox toont
        private void UpdateData(Array array, ListBox listbox)
        {
            // eerst listbox 'resetten' (leeg maken)
            listbox.Items.Clear();

            // met foreach loop
            foreach (var item in array)
            {
                listbox.Items.Add(item);
            }
        }

        // methode die 'amount' aantal random cijfers aanmaakt
        // met als ondergrens 'min' en bovengrens 'max'
        // op het einde van de methode krijg ik een int[] array
        private int[] RandomNumbers(int amount, int min, int max)
        {
            // array klaarzetten met correct aantal 'vakjes'/indexes
            int[] randomArray = new int[amount];

            // for loop die alle momenteel 'lege' plaatsen in de array
            // invult met een random cijfer van 'min' tot en met 'max'
            for (int i = 0; i < amount; i++)
            {
                randomArray[i] = rng.Next(min, max + 1);
            }

            // array als return
            return randomArray;
        }

        private void BtnNumbers_Click(object sender, EventArgs e)
        {
            // numbers array invullen via RandomNumbers methode
            numbers = RandomNumbers(10, 1, 100);
            // UpdateData methode gebruiken
            UpdateData(numbers, lbxData);
        }

        private void FrmArrays_Load(object sender, EventArgs e)
        {
            // random initialiseren
            rng = new Random();            
        }
    }
}
