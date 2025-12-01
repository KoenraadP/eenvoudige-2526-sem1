using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhaling_06_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kies tussen 1 - 2 - 3");
            string input = Console.ReadLine();
            byte choice = Convert.ToByte(input);

            string output = "";

            switch (choice)
            {
                case 1:
                    output = "Optie 1 gekozen: nieuwe klant";
                    break;
                case 2:
                    output = "Optie 2 gekozen: bestelling bekijken";
                    break;
                case 3:
                    output = "Optie 3 gekozen: afsluiten";
                    break;
                default:
                    output = "Dit is geen geldige keuze";
                    break;
            }

            Console.WriteLine(output);
        }
    }
}
