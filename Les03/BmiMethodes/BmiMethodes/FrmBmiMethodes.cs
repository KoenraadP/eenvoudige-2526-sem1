using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BmiMethodes
{
    public partial class FrmBmiMethodes : Form
    {

        // globale variabelen instellen voor gewicht in kg en lengte in CENTIMETER
    

        public FrmBmiMethodes()
        {
            InitializeComponent();
        }

        #region methods

        // maak eerst de variabelen aan bovenaan (staat ook vermeld in commentaar)
        // schrijf vervolgens de gevraagde methodes hieronder
        // en koppel ten slotte de nodige methodes aan de knop
        // uiteraard zorg je ook weer voor output in het correcte tekstvak

        // methode die waarden instelt voor de globale variabelen
        // deze methode heeft geen parameters en heeft ook geen uitvoer/return


        // methode die parameter lengte in centimeter krijgt
        // uitvoer/return van de methode is deze lengte in meter


        // methode die BMI waarde berekent ZONDER PARAMETERS
        // formule: gewicht / (lengte * lengte)
        // gebruik je eerste methode om de waarden van de textboxes op te vragen en in
        // de globale variabelen op te slaan, gebruik deze globale variabelen voor de berekening
        // lengte moet in meter zijn, gebruik hiervoor de conversie methode
        // uitvoer/return van de methode is de BMI waarde afgerond tot op 2 cijfers


        #endregion
    }
}
