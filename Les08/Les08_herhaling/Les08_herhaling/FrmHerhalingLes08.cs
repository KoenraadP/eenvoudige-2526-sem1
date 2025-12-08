using System;
using System.Windows.Forms;

namespace Les08_herhaling
{
    public partial class FrmHerhalingLes08 : Form
    {
        public FrmHerhalingLes08()
        {
            InitializeComponent();
        }

        private string RepeatText(string input, int amount)
        {
            string output = "";

            for (int i = 0; i < amount; i++)
            {
                output += input + Environment.NewLine;
                //output += input + "\r\n";
            }

            return output;
        }

        private void BtnRepeatText_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            int amount = Convert.ToInt32(txtAmount.Text);
            string output = RepeatText(input, amount);
            txtOutput.Text += output.Trim();
            txtOutput.Text += Environment.NewLine;
        }
    }
}
