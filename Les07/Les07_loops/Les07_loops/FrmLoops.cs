using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les07_loops
{
    public partial class FrmLoops : Form
    {
        public FrmLoops()
        {
            InitializeComponent();
        }

        // methode die een for loop gebruikt
        private string ForLoopNumbers(int max)
        {
            // variabele voor return
            string output = "";

            // alle cijfers vanaf 1 tot en met 10 overlopen
            for (int i = 1; i <= max; i++)
            {
                // huidig cijfer (i) toevoegen aan output string
                output += i.ToString();
                // 'nieuwe regel' toevoegen aan string
                output += Environment.NewLine;
                //output += "\r\n";
            }

            return output;
        }

        // methode die met een while loop werkt
        private string WhileLoopNumbers(int max)
        {
            string output = "";

            // beginnen bij 1
            int i = 1;

            // zolang i niet groter is dan max...
            while (i <= max)
            {
                output += i.ToString();
                output += Environment.NewLine;
                // niet vergeten teller te verhogen op het einde van de while
            }

            return output;
        }

        private void BtnShowNumbers_Click(object sender, EventArgs e)
        {
            string output = ForLoopNumbers(1);
            // getrimde output in textbox plaatsen
            // trim --> alle spaties/witregels voor en na de string verwijderen
            txtNumbers.Text = output.Trim();
        }

        private void BtnShowNumbers2_Click(object sender, EventArgs e)
        {
            string output = ForLoopNumbers(100);
            // getrimde output in textbox plaatsen
            // trim --> alle spaties/witregels voor en na de string verwijderen
            txtNumbers.Text = output.Trim();
        }

        private void BtnShowNumbers3_Click(object sender, EventArgs e)
        {
            string output = ForLoopNumbers(1000);
            // getrimde output in textbox plaatsen
            // trim --> alle spaties/witregels voor en na de string verwijderen
            txtNumbers.Text = output.Trim();
        }

        private void BtnWhile_Click(object sender, EventArgs e)
        {
            string output = WhileLoopNumbers(10);
            // getrimde output in textbox plaatsen
            // trim --> alle spaties/witregels voor en na de string verwijderen
            txtNumbers.Text = output.Trim();
        }
    }
}
