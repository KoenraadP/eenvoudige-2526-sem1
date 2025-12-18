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

        // methode om invoer uit txtItem
        // toe te voegen aan list en listbox te updaten
        private void AddItem()
        {
            // invoer uit txtItem toevoegen aan list
            orderItems.Add(txtItem.Text);
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
    }
}
