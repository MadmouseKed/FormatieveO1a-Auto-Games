using System;
using System.Runtime;

namespace Autoverhuur_Gameswinkel
{
    public class Autohuur
    {
        private int aantalDagen;
        string naam;
        double kortingsPercentage;
        string type;
        double prijsPerDag;
        Autohuur()
        {
            void setAantalDagen(int Ad)
            {
                aantalDagen = Ad;
            }

            void setGehuurdeAuto(Auto gA)
            {

            }

            Auto getGehuurdeAuto()
            {

            }

            void setHuurder(k Klant)
            {

            }
            Klant getHuurder()
            {
                return a
            }
            double totaalPrijs()
            {
                return a
            }
            string toString(string inText)
            {
                string uitText;
                uitText = inText;
                return uitText;
            }

        }
    }

    public class Klant
    {
        string naam;
        double kortingsPercentage;
    }

    public class Auto
    {
        string type;
        double prijsPerDag;
    }


    public class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello world!";
            Console.WriteLine(text);
        }
    }
}
