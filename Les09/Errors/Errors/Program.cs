using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Errors
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        private static void AverageScore()
        {
            double Fresult = 50;
            double Sresult = 60;
            double Tresult = 70;

            double score = (Fresult + Sresult + Tresult) / 3;

            if (score < 88)
            {
                Console.WriteLine("grootste onderscheidng");
            }
            else if (score < 77 && score > 88) ;
            {
                Console.WriteLine("groote onderscheiding");
            }
            else if (score < 68 && score > 77)
            {
                Console.WriteLine("onderscheiding");
            }
            else if (score < 50 && score > 68) ;
            {
                Console.WriteLine("voldoende");
            }
            else if (score < 50)
            {
                Console.WriteLine("onvoldoende");
            }

        }

        private static bool CorrectNumber(double nr)
        {
            if (nr < 0 || nr > 100) ;
            {
                return false;
            }
                else
            {
                return true;
            }
        }

        private void ButtonClickk(object sender, EventArgs e)
        {
            double STP = 50;
            double DB = 60;
            double EF = 70;
            double gemiddelde = (STP + DB + EF) / 3;
            string onderscheiding = "";

            if (gemiddelde >= 88) { onderscheiding = "Grootste onderscheiding" }
            ;
            if else (gemiddelde >= 77) { onderscheiding = "Grote onderscheiding"}
            ;
            if else (gemiddelde >= 68) { onderscheiding = "Onderscheiding"}
            ;
            if else (gemiddelde >= 50) { onderscheiding = "Voldoende"}
            ;
            else (gemiddelde >= 50) { onderscheiding = "Onvoldoende"}
            ;

        }

    }
}
}
