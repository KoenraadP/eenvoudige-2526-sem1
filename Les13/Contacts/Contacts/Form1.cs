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
            UpdateListbox();
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

        // methode om alle contacts uit list in listbox te tonen
        private void UpdateListbox()
        {
            // listbox eerst leeg maken voor update
            lbxContacts.Items.Clear();

            foreach (Person p in contacts)
            {
                lbxContacts.Items.Add(p);
            }
        }

        // methode om alle properties (eigenschappen)
        // van een opgegeven persoon in de textboxes te plaatsen
        private void GetProperties(Person p)
        {
            txtFirstName.Text = p.FirstName;
            txtLastName.Text = p.LastName;
            txtEmail.Text = p.Email;
            txtPlace.Text = p.Place;
            txtBirthDate.Text = p.BirthDate.ToString("d");
        }

        // methode om nieuwe persoon aan te maken
        // op basis van de ingevulde informatie
        // en deze persoon toe te voegen aan de contacts list
        private void AddContact()
        {
            // informatie uit textboxes halen
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string place = txtPlace.Text;
            DateTime birthDate = Convert.ToDateTime(txtBirthDate.Text);

            // nieuwe contact/Person aanmaken
            Person newContact = new Person(firstName, lastName, 
                birthDate, email, place);

            // toevoegen aan contacts list
            contacts.Add(newContact);
        }

        // methode om gegevens van een Person aan te passen
        private void UpdateContact(Person p)
        {
            // informatie uit textboxes halen
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string place = txtPlace.Text;
            DateTime birthDate = Convert.ToDateTime(txtBirthDate.Text);

            // eigenschappen van Person p vervangen door textbox data
            p.FirstName = firstName;
            p.LastName = lastName;
            p.Email = email;
            p.Place = place;
            p.BirthDate = birthDate;
        }

        // deze code wordt uitgevoerd telkens
        // wanneer een item uit de listbox geselecteerd werd
        private void LbxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // eerst controleren of effectief een item geselecteerd werd
            if (lbxContacts.SelectedItem != null)
            {
                // geselecteerde persoon opslaan in variabele
                // hier voeren we een 'explicit cast' uit zodat
                // het geselecteerde element kan gebruikt worden als een Person
                Person selectedPerson = (Person)lbxContacts.SelectedItem;

                // uitvoeren methode om alles te tonen
                GetProperties(selectedPerson);
            }            
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            // alle textboxes leeg maken
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtBirthDate.Text = "";
            txtEmail.Text = "";
            txtPlace.Text = "";

            // cursor in firstname plaatsen
            txtFirstName.Focus();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // methode uitvoeren om persoon aan list toe te voegen
            AddContact();
            // listbox updaten met nieuwe data
            UpdateListbox();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Person p = (Person)lbxContacts.SelectedItem;
            contacts.Remove(p);
            UpdateListbox();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Person p = (Person)lbxContacts.SelectedItem;
            UpdateContact(p);
            UpdateListbox();
        }
    }
}
