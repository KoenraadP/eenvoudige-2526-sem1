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

namespace Arrays01
{
    public partial class FrmArrays : Form
    {
        public FrmArrays()
        {
            InitializeComponent();
        }

        private void BtnNumbers_Click(object sender, EventArgs e)
        {
            // array aanmaken met daarin vijf cijfers
            int[] numbers = { 20, 300, 15, 18, 20 };

            // toon het derde cijfer in output
            // Debug.WriteLine(numbers[2]);

            // handmatig een per een aan listbox toevoegen
            //lbxData.Items.Add(numbers[0]);
            //lbxData.Items.Add(numbers[1]);
            //lbxData.Items.Add(numbers[2]);

            // met for loop
            // de .Length is altijd het aantal elementen
            // in de array, dus is altijd 1 hoger dan de laatste index
            for (int i = 0; i < numbers.Length; i++)
            {
                // huidig element op huidige index 
                // toevoegen aan listbox
                lbxData.Items.Add(numbers[i]);
            }
        }
    }
}
