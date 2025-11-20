using System.Windows.Forms;

namespace Swap
{
    public partial class FrmSwap : Form
    {
        public FrmSwap()
        {
            InitializeComponent();
        }

        // schrijf een methode met de naam SwapText()
        // deze methode moet de inhoud (text) van twee
        // opgegeven textboxes wisselen
        // koppel deze methode uiteindelijk aan de knop
        private void SwapText(TextBox box1, TextBox box2)
        {
            // waarden van de textboxes box1 en box2
            // opslaan in variabelen
            string text1 = box1.Text;
            string text2 = box2.Text;

            // teksten verplaatsen
            box1.Text = text2;
            box2.Text = text1;
        }

        private void BtnSwap_Click(object sender, System.EventArgs e)
        {
            // methode gebruiken/aanroepen
            SwapText(txtFirst, txtSecond);
        }
    }
}
