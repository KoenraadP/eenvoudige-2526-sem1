using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class Form1 : Form
    {
        // global list voor personen
        List<Person> contacts = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateContacts();
        }

        // methode om enkele default contacts aan te maken
        private void CreateContacts()
        {
            // eerste persoon aanmaken
            DateTime birthDate1 = new DateTime(1985, 10, 30);
            Person p1 = new Person("Koenraad", "Pecceu",
                birthDate1, "koenraad.pecceu@creo.be",
                "Emelgem");

            // tweede persoon aanmaken
            DateTime birthDate2 = new DateTime(1959, 11, 4);
            Person p2 = new Person("Eric", "Pecceu",
                birthDate2, "eric.pecceu@outlook.com",
                "Torhout");

            // personen toevoegen aan contacts list
            contacts.Add(p1);
            contacts.Add(p2);
        }
    }
}
