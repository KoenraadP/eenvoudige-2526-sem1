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

namespace les02_01
{
    public partial class frmLes02_01 : Form
    {
        public frmLes02_01()
        {
            InitializeComponent();
        }

        private void BtnHello_Click(object sender, EventArgs e)
        {
            // alle code hieronder wordt uitgevoerd wanneer
            // ik klik op de knop btnHello
            string name = txtName.Text;
            
            // even testen of de name variabele correct werkt
            // Debug en Console kun je beide hiervoor gebruiken
            Debug.WriteLine(name);
            Console.WriteLine(name);

            // variabele voor output
            string greeting = "Hallo " + name;

            // output tekst in output textbox plaatsen
            txtOutput.Text = greeting;

            // txtOutput.Text = "Hallo " + txtName.Text;
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {
            // txtName.Text = "Hallo " + txtOutput.Text;
        }
    }
}
