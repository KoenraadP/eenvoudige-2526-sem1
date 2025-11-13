using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HelloName
{
    public partial class frmHelloName : Form
    {
        public frmHelloName()
        {
            InitializeComponent();
        }

        private void btnGreet_Click(object sender, EventArgs e)
        {
            // naam uit tekstvak halen en opslaan in variabele
            string name = txtName.Text;

            // zin opbouwen in variabele
            string greeting = "Hallo " + name;            

            // greeting in ander tekstvak plaatsen
            txtResult.Text = greeting;            

        }
    }
}
