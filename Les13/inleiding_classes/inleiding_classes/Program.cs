using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inleiding_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variabele/object maken op basis van eigen class
            Car car1 = new Car();
            Car car2 = new Car();

            // enkele eigenschappen instellen
            car1.Make = "Toyota";
            car1.Model = "Avalon";
            car1.BuildYear = 1994;

            car2.Make = "Ferrari";
            car2.Model = "Roma";

            // merk en model tonen in console
            Console.WriteLine(car1.Make + " " + car1.Model);
            Console.WriteLine(car1.BuildYear);
            Console.WriteLine(car1.EngineType);

            // film aanmaken
            Movie movie1 = new Movie("Gladiator", "Ridley Scott");

            // enkele eigenschappen van film invullen
            movie1.Is3D = false;
            movie1.ReleaseDate = new DateTime(2000, 6, 20);

            // list met enkele acteurs maken
            List<string> gladiatorCast = new List<string>();
            gladiatorCast.Add("Russel Crowe");
            gladiatorCast.Add("Joaquin Phoenix");
            gladiatorCast.Add("Connie Nielsen");

            // list instellen bij film
            movie1.Cast = gladiatorCast;

            // eigenschappen film opvragen in console
            Console.WriteLine(movie1.Title);

            // alle personen uit cast tonen in console
            Console.WriteLine(movie1.Cast); // deze manier werkt niet
            foreach (string name in movie1.Cast)
            {
                Console.WriteLine(name);
            }
        }
    }
}
