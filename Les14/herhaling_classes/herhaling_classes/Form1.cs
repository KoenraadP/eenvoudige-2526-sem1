using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herhaling_classes
{
    public partial class Form1 : Form
    {
        // globale list voor cars
        List<Car> cars = new List<Car>();

        public Form1()
        {
            InitializeComponent();
        }

        // methode die enkele auto's aanmaakt
        private void CreateCars()
        {
            // auto's aanmaken
            Car car1 = new Car("Audi", "A1", 35000);
            Car car2 = new Car("BMW", "X3", 42000);
            Car car3 = new Car("Mercedes", "C200", 40000);

            // auto's aan list toevoegen
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
        }

        // methode om alle auto's uit de list te tonen in de combobox
        private void UpdateBox()
        {
            cbxCars.Items.Clear();

            foreach (Car car in cars)
            {
                cbxCars.Items.Add(car);
            }
        }

        // load --> uitvoeren bij opstarten app
        private void Form1_Load(object sender, EventArgs e)
        {
            // methode createcars aanroepen om auto's aan te maken
            CreateCars();
            // methode updatebox aanroepen om de auto's te tonen in de combobox
            UpdateBox();
        }

        private void CbxCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            // huidig geselecteerde auto opslaan in aparte variabele
            Car selectedCar = (Car)cbxCars.SelectedItem;
            // prijs van geselecteerde auto tonen in textbox
            txtPrice.Text = selectedCar.Price.ToString("C");
        }
    }
}
