using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSwap_Click(object sender, EventArgs e)
        {
            // eerst de huidige text values
            // uitlezen en opslaan in variabelen
            string textOne = txtOne.Text;
            string textTwo = txtTwo.Text;

            // waarden in andere textboxes plaatsen
            txtOne.Text = textTwo;
            txtTwo.Text = textOne;
        }
    }
}
