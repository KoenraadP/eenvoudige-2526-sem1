using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    internal class Person
    {
        // eigenschappen (properties) van Person
        public string FirstName { get; set; }   
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Place { get; set; }

        // constructor --> deze properties MOETEN ingevuld worden
        // bij aanmaken persoon in programma
        public Person(string firstName, string lastName,
            DateTime birthDate, string email, string place)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Email = email;
            Place = place;
        }

        // override instellen voor ToString
        // dit zorgt er voor dat we zelf kiezen
        // welke info in de listbox getoond wordt
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
