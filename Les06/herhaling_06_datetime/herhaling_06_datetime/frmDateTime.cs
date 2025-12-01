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

namespace herhaling_06_datetime
{
    public partial class frmDateTime : Form
    {
        public frmDateTime()
        {
            InitializeComponent();
        }

        private void BtnHerhaling_Click(object sender, EventArgs e)
        {
            //DateTime chosenDate = Convert.ToDateTime(dtpHerhaling.Text);
            //MessageBox.Show(chosenDate.ToString("d"));

            DateTime chosenDate = dtpHerhaling.Value;
            // twee datums van elkaar aftrekken of optellen of...
            // type TimeSpan nodig om op te slaan
            TimeSpan duration = DateTime.Now - chosenDate;
            // een timespan kun je 'ontleden' in bijvoorbeeld enkel de days/dagen
            int days = duration.Days;
            MessageBox.Show(days.ToString());
        }
    }
}
