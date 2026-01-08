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
            Person p1 = new Person();

            // eigenschappen instellen
            p1.FirstName = "Koenraad";
            p1.LastName = "Pecceu";
            p1.BirthDate = new DateTime(1985, 10, 30);
            p1.Email = "koenraad.pecceu@creo.be";
            p1.Place = "Emelgem";

            // persoon toevoegen aan listbox
            lbxContacts.Items.Add(p1);
        }
    }
}
