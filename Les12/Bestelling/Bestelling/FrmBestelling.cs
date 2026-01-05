using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        private void AddItem(string item)
        {
            // invoer string in correcte formaat zetten
            item = Capitalise(item);
            // invoer uit txtItem toevoegen aan list
            orderItems.Add(item);
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
                AddItem(txtItem.Text);

                // input vak (txtItem) weer leeg maken voor volgende item
                txtItem.Clear();
            }
            else
            {
                // geselecteerde item uit cbxMenu toevoegen aan list en listbox
                AddItem(cbxMenu.Text);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteItems();
        }

        private void FrmBestelling_Load(object sender, EventArgs e)
        {
            // vaste array met menu items maken
            string[] menuItems = { "Koffie", "Thee", "Muffin" };
            // alle elementen uit menuItems toevoegen aan cbxMenu
            foreach (var item in menuItems)
            {
                cbxMenu.Items.Add(item);
            }
            // eerste element uit combobox al actief zetten (selecteren)
            cbxMenu.SelectedIndex = 0;
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

        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            // list orderItems leegmaken
            orderItems.Clear();
            // listbox opnieuw opbouwen met huidige inhoud list die nu leeg is
            UpdateOrder();
            // textbox txtSummary leeg maken
            txtSummary.Clear();
            // cursor in txtItem plaatsen
            txtItem.Focus();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            // maak nieuw document om te printen aan in de code
            PrintDocument document = new PrintDocument();
            // pagina om te printen toevoegen aan document
            document.PrintPage += Document_PrintPage;
            // grootte afdrukvoorbeeld aanpassen
            printPreviewDialog.ClientSize = new Size(800,600);
            // document correct instellen voor afdrukvoorbeeld
            printPreviewDialog.Document = document;
            // toon afdrukvoorbeeld
            printPreviewDialog.ShowDialog();
        }

        // methode die printblad opbouwt
        private void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            // lettertype instellen voor tekst die moet geprint worden
            Font printFont = new Font("Arial", 12);
            // linkermarge koppelen aan variabele x
            int x = e.MarginBounds.Left;
            // bovenmarge koppelen aan variabele y
            int y = e.MarginBounds.Top;

            // tekst die moet geprint worden in variabele opslaan
            string textToPrint = "Bestelling: " + "\r\n\r\n" + txtSummary.Text;

            // tekst 'tekenen' op blad
            e.Graphics.DrawString(textToPrint, printFont, Brushes.Black, x, y); 
        }
    }
}
