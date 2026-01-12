using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herhaling_classes
{
    internal class Car
    {
        // eigenschappen/properties van een auto
        public string Make { get; set; } // merk
        public string Model { get; set; }
        public decimal Price { get; set; }

        // constructor voor Car
        public Car(string make, string model, decimal price)
        {
            Make = make;
            Model = model;
            Price = price;
        }

        // override voor tostring
        // ik wil het merk en model van de auto zien in de combobox
        public override string ToString()
        {
            return Make + " " + Model;
        }
    }
}
