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

namespace DaysAlive
{
    public partial class frmDaysAlive : Form
    {
        public frmDaysAlive()
        {
            InitializeComponent();
        }

        private void BtnDays_Click(object sender, EventArgs e)
        {
            // alle data uit de textboxes halen
            // en opslaan in juiste data types
            // int omdat we geen cijfers na de komma verwachten
            int day = Convert.ToInt32(txtDay.Text);
            int month = Convert.ToInt32(txtMonth.Text);
            int year = Convert.ToInt32(txtYear.Text);

            // met de opgegeven data een Date object maken
            // dit is dan een 'echte' datum om mee te werken
            DateTime birthdate = new DateTime(year, month, day);

            // datum 'testen'
            Debug.WriteLine(birthdate.ToString());

            // 'vandaag' opslaan in variabele
            DateTime now = DateTime.Now;

            // berekening doen door twee datums 
            // van elkaar af te trekken
            // en resultaat opslaan in variabele
            TimeSpan timeBetween = now - birthdate;

            // enkel dagen overhouden
            int daysAlive = timeBetween.Days;

            // resultaat tonen onderaan
            txtResult.Text = daysAlive.ToString();
        }

        private void BtnDaysAlive2_Click(object sender, EventArgs e)
        {
            // datum uit datetimepicker opslaan in variabele
            DateTime birthdate = dateTimePicker1.Value;

            // datum 'testen'
            Debug.WriteLine(birthdate.ToString());

            // 'vandaag' opslaan in variabele
            DateTime now = DateTime.Now;

            // berekening doen door twee datums 
            // van elkaar af te trekken
            // en resultaat opslaan in variabele
            TimeSpan timeBetween = now - birthdate;

            // enkel dagen overhouden
            int daysAlive = timeBetween.Days;

            // resultaat tonen onderaan
            txtResult.Text = daysAlive.ToString();
        }
    }
}
