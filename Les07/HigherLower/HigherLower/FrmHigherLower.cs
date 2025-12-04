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

namespace HigherLower
{
    public partial class FrmHigherLower : Form
    {
        public FrmHigherLower()
        {
            InitializeComponent();
        }

        // Load wordt uitgevoerd bij starten van programma
        private void FrmHigherLower_Load(object sender, EventArgs e)
        {
            // een Random variabele maken 
            // om te kunnen een random cijfer genereren
            Random rng = new Random();
            // random cijfer kiezen vanaf 1 tot en met 5
            // let op: tweede parameter is de bovengrens maar is EXCLUSIEF dit cijfer
            int randomNumber = rng.Next(1,6);
            // random cijfer tonen in output venster
            Debug.WriteLine(randomNumber.ToString());
        }
    }
}
