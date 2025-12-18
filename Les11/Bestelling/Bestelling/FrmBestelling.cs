using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bestelling
{
    public partial class FrmBestelling : Form
    {
        // globale list aanmaken
        List<string> orderItems = new List<string>();

        public FrmBestelling()
        {
            InitializeComponent();
        }

        #region methods

        // methode om invoer uit txtItem
        // toe te voegen aan list en listbox te updaten
        private void AddItem()
        {
            // invoer string in correcte formaat zetten
            string input = Capitalise(txtItem.Text);
            // invoer uit txtItem toevoegen aan list
            orderItems.Add(input);
            // updateorder methode uitvoeren om in listbox te tonen
            UpdateOrder();
        }

        // methode om listbox te updaten
        private void UpdateOrder()
        {
            // listbox eerst weer leegmaken voor de update
            lbxOrder.Items.Clear();

            // met foreach alle items uit list tonen in listbox
            foreach (var item in orderItems)
            {
                lbxOrder.Items.Add(item);
            }
        }

        // methode om alle geselecteerde items uit de list te verwijderen
        // en ook de listbox te updaten
        private  void DeleteItems()
        {
            // alle geselecteerde items uit listbox
            // verwijderen uit list
            foreach (string item in lbxOrder.SelectedItems)
            {
                orderItems.Remove(item);
            }

            // listbox updaten
            UpdateOrder();
        }

        // methode om een string te 'capitalisen'
        // betekent: eerste letter hoofdletter, andere kleine letters
        // en ook spaties voor en na de string wegnemen
        private string Capitalise(string input)
        {
            // spaties wegnemen
            string result = input.Trim();

            // eerste letter ophalen
            char firstLetter = result[0];
            // rest van woord
            string restOfWord = result.Substring(1);

            // aan elkaar plakken in juiste case
            result = char.ToUpper(firstLetter) 
                    + restOfWord.ToLower();

            return result;
        }

        #endregion

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // controleren of textbox niet leeg is
            // als dit OK is --> dan wel code uitvoeren, anders foutboodschap
            if (txtItem.Text != "")
            {
                // add item methode uitvoeren om item toe te voegen
                // aan zowel list als listbox
                AddItem();

                // input vak (txtItem) weer leeg maken voor volgende item
                txtItem.Clear();
            }
            else
            {
                MessageBox.Show("Geen item ingevoerd!", "Fout",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteItems();
        }

        private void FrmBestelling_Load(object sender, EventArgs e)
        {
            // enkele default items al toevoegen aan list
            // en ook tonen in listbox
            orderItems.Add("Koffie");
            orderItems.Add("Koffie");
            orderItems.Add("Koffie");
            orderItems.Add("Thee");
            orderItems.Add("Thee");
            orderItems.Add("Donut");

            UpdateOrder();
        }

        private void BtnSummary_Click(object sender, EventArgs e)
        {
            // string aanmaken om output in te voorzien
            string orderSummary = "";

            // ieder element uit de list (orderItems)
            // in string plaatsen telkens op een nieuwe regel
            // Distinct om ieder soort maar één keer te hebben
            foreach(var item in orderItems.Distinct())
            {
                // opslaan hoe veel keer een item in de
                // volledige list voorkomt
                int amount = orderItems.Count(x => x == item);
                orderSummary += item + " \tx " + amount + "\r\n";
            }

            // string in textbox plaatsen en laatste lege regel verwijderen
            txtSummary.Text = orderSummary.Trim();
        }
    }
}
