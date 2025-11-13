using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eerste_project
{
    public partial class frmEersteProject : Form
    {
        public frmEersteProject()
        {
            InitializeComponent();
        }

        // deze methode wordt uitgevoerd wanneer ik op de knop klik
        private void BtnFirstProject_Click(object sender, EventArgs e)
        {

            // tekst plaatsen in de textbox
            txtFirstProject.Text = "Hello World!";
        }
    }
}
