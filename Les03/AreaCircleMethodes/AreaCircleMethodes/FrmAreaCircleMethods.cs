using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaCircleMethodes
{
    public partial class FrmAreaCircleMethods : Form
    {
        public FrmAreaCircleMethods()
        {
            InitializeComponent();
        }

        #region methods

        // schrijf de methode die hieronder gevraagd wordt
        // koppel deze daarna correct aan de knop en zorg dat 
        // de output ook in het juiste tekstvak terecht komt

        // methode die als parameter een straal van een cirkel krijgt
        // de uitvoer (return) van de methode is de oppervlakte van deze cirkel
        // formule: straal * straal * pi
        private double AreaCircle(double radius)
        {
            double result = radius * radius * Math.PI;
            return result;
        }

        #endregion

        private void btnArea_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(txtRadius.Text);
            double area = AreaCircle(radius);
            txtResult.Text = area.ToString();
        }
    }
}
