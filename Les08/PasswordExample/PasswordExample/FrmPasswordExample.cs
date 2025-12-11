using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordExample
{
    public partial class FrmPasswordExample : Form
    {
        public FrmPasswordExample()
        {
            InitializeComponent();
        }

        private string GeneratePassword(int length)
        {
            string password = "";
            Random rng = new Random();

            for (int i = 0; i < length; i++)
            {

                
                int randomNumber = rng.Next(1, 4);

                if (randomNumber == 1)
                {
                    char newSymbol = (char)rng.Next(97, 123);
                    password += newSymbol;
                }
                if (randomNumber == 2)
                {
                    char newSymbol = (char)rng.Next(65, 91);
                    password += newSymbol;
                }
                if (randomNumber == 3)
                {
                    char newSymbol = (char)rng.Next(48, 58);
                    password += newSymbol;
                }
            }

            return password;
        }

        private void BtnPassword_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(txtAmount.Text);   
            string password = GeneratePassword(length);
            txtPassword.Text = password;
        }
    }
}
