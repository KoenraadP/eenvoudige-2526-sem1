using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les06_herhaling_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int score = 75;
            //Console.WriteLine("Typ een score in:");
            // bij ReadLine() wacht de applicatie tot
            // er op enter gedrukt wordt (nadat je iets ingetypt hebt, liefst)
            //int score = Convert.ToInt32(Console.ReadLine());

            //if (score >= 50)
            //{
            //    Console.WriteLine("Geslaagd");
            //}
            //else
            //{
            //    Console.WriteLine("Niet geslaagd");
            //}

            // nog een laatste readline om programma te doen wachten op het einde
            //Console.WriteLine("Einde programma");

            // leeftijd opvragen
            Console.WriteLine("Typ je leeftijd in");
            string input = Console.ReadLine();
            int age = Convert.ToInt32(input);

            // leeftijd controleren
            if (ValidAge(age))
            {
                // variabele voor prijs ticket
                int price = 0;

                // met if...else if...else if...
                // prijs instellen zodat:
                // jonger dan 4 jaar: 0 euro
                // van 4 t/m 12 jaar: 5 euro
                // van 13 t/m 17 jaar: 8 euro
                // van 18 t/m 64: 12 euro
                // ouder dan 64: 6 euro

                if (age < 4)
                {
                    price = 0;
                }
                else if (age < 13)
                {
                    price = 5;
                }
                else if (age < 18)
                {
                    price = 8;
                }
                else if (age < 65)
                {
                    price = 12;
                }
                else
                {
                    price = 6;
                }

                string output = "Je moet " + price + " euro betalen.";
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Deze leeftijd is onmogelijk!");
            }
        }

        // methode om te controleren of een leeftijd
        // niet kleiner is dan 0 en niet groter dan 130
        private static bool ValidAge(int age)
        {
            if (age < 0 || age > 130)
            {
                return false;
            }

            return true;
        }
    }
}
