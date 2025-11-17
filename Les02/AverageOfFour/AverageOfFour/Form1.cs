using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageOfFour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nr1 = Convert.ToDouble(textBox1.Text);
            double nr2 = Convert.ToDouble(textBox2.Text);
            double nr3 = Convert.ToDouble(textBox3.Text);
            double nr4 = Convert.ToDouble(textBox4.Text);

            double result = nr1 + nr2 + nr3 + nr4;
            result = result / 4;

            textBox5.Text = result.ToString();

            // double result = (nr1 + nr2 + nr3 + nr4) / 4;
        }
    }
}
