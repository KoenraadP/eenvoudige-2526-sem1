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
        public FrmBestelling()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // list voor string items maken
            List<string> orderItems = new List<string>();

            // invoer uit txtItem toevoegen aan list
            orderItems.Add(txtItem.Text);

            // met foreach alle items uit list tonen in listbox
            foreach (var item in orderItems)
            {
                lbxOrder.Items.Add(item);
            }

            // input vak (txtItem) weer leeg maken voor volgende item
            txtItem.Clear();
        }
    }
}
