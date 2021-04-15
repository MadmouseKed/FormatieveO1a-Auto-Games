using System;
using System.Runtime;

namespace Autoverhuur_Gameswinkel
{
    /*public class AutoHuur
    {
        private int aantalDagen;
        public AutoHuur()
        {

        }
        void setAantalDagen(int Ad)
        {
            aantalDagen = Ad;
        }

        void setGehuurdeAuto(Auto gA)
        {
            Auto(gA);
        }

        Auto getGehuurdeAuto()
        {
            return type;
        }

        void setHuurder(Klant k)
        {
            Klant Klant(k);
        }

        Klant getHuurder()
        {
            return naam;
        }

        double totaalPrijs()
        {
            double prijs;
            prijs = prijsPerDag * (1 - kortingsPercentage) * aantalDagen;
            return prijs;
        }

        string toString()
        {
            string s = "String";
            return s;
        }
    }*/
    public class Klant
    {
        private string naam;
        private double kortingsPercentage;

        public Klant(string nm)
        {
            naam = nm;
        }

        public void setKorting(double kp)
        {
            kortingsPercentage = kp;
        }

        public double getKorting()
        {
            return kortingsPercentage;
        }

        public string toString()
        {
            string s;
            s = "Klant: " + naam + " Met korting " + kortingsPercentage;
            return s;
        }
    }

    public class Auto
    {
        private string type;
        private double prijsPerDag;

        public Auto(string tp)
        {
            type = tp;
        }

        public void setPrijsPerDag(double prPd)
        {
            prijsPerDag = prPd;
        }

        public double getPrijsPerDag()
        {
            return prijsPerDag;
        }

        public string toString()
        {
            string s;
            s = "De gehuurde auto " + type + " voor " + prijsPerDag + " per dag.";
            return s;
        }
    }

/*    public class Game
    {
        private string v1;
        private int v2;
        private double v3;

        public Game(string v1, int v2, double v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
    }*/

    public class GamesWinkel
    {
        public class Persoon
        {
            private double budget;
            private string naam;

            public Persoon(string nm, double bd)
            {
                setBudget(bd);
                setNaam(nm);
            }

            public void setBudget(double bd)
            {
                budget = bd;
            }

            public double getBudget()
            {
                double d = budget;
                return d;
            }

            public void setNaam(string nm)
            {
                naam = nm;
            }

            public string getNaam()
            {
                string s = naam;
                return s;
            }

            public void koop(Game spel)
            {
                if ((spel.getOwner() != naam) & ((budget - spel.getPrijs()) > 0))
                    spel.setOwner(naam);
                    budget = budget - spel.getPrijs();
            }
            public void verKoop(Game spel, Persoon p)
            {
                if ((p.getBudget() - spel.getPrijs()) > 0)
                    budget = budget + spel.getPrijs();
                    p.koop(spel);
                    
            }
            public string toString()
            {
                string s = budget + " " + " " + naam;
                return s;
            }
        }

        public class Game
        {
            string naam;
            int releaseJaar;
            double prijs;
            string Eigenaar;

            public Game(string gnm, int jaar, double pr)
            {
                naam = gnm;
                releaseJaar = jaar;
                double multiplier = Math.Pow(0.70, jaar);
                prijs = pr * multiplier;
            }

            public double getPrijs()
            {
                return prijs;
            }
            public string getNaam()
            {
                return naam;
            }
            public int getRelease()
            {
                return releaseJaar;
            }
            public void setOwner(string naam)
            {
                Eigenaar = naam;
            }

            public string getOwner()
            {
                return Eigenaar;
            }
            public string toString()
            {
                string s;
                s = "Naam: " + naam + " ReleaseJaar: " + releaseJaar + " Prijs: " + prijs + " Eigenaar: " + Eigenaar;
                return s;
            }
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            string informatie;
            GamesWinkel.Game g1 = new GamesWinkel.Game("Just Cause3", 1, 49.98);
            GamesWinkel.Game g2 = new GamesWinkel.Game("Need for speed:Rivals", 2, 45.99);
            GamesWinkel.Game g3 = new GamesWinkel.Game("Need for speed: Rivals", 2, 45.99);

            GamesWinkel.Persoon p1 = new GamesWinkel.Persoon("eric", 200);
            GamesWinkel.Persoon p2 = new GamesWinkel.Persoon("Hans", 55);
            GamesWinkel.Persoon p3 = new GamesWinkel.Persoon("Arno", 185);

            informatie = g1.toString();
            Console.WriteLine(informatie);

            p1.koop(g1);
            p1.koop(g2);
            p2.koop(g2);
            p2.koop(g1);
            p3.koop(g3);

            string persoon1 = p1.toString();
            string persoon2 = p2.toString();
            string persoon3 = p3.toString();
            Console.WriteLine(persoon1);
            Console.WriteLine(persoon2);
            Console.WriteLine(persoon3);

            p1.verKoop(g1, p3);
            p2.verKoop(g2, p3);
            p2.verKoop(g1, p1);

            persoon1 = p1.toString();
            persoon2 = p2.toString();
            persoon3 = p3.toString();
            Console.WriteLine(persoon1);
            Console.WriteLine(persoon2);
            Console.WriteLine(persoon3);
            /* string text = "Hello world!";
             Console.WriteLine(text);

             Auto A1 = new Auto("Peugeot 207");
             Auto A2 = new Auto("Ferrari");
             Klant k1 = new Klant("Mijnheer de Vries");
             AutoHuur ah1 = new AutoHuur();


             AutoHuur ah1();
             // Print "Eerste autohuur: " + ah1.toString()

             Klant k("Mijnheer de Vries");
             k.setKorting(10.0);
             ah1.setHuurder(k);
             // Print: "Eerste autohuur: " + ah1.toString()

             Auto a1("Peugeot 207", 50);
             ah1.setGehuurdeAuto(a1);
             ah1.setAantalDagen(4);
             // Print "Eerste autohuur:" + ah1.toString()

             AutoHuur ah2();
             Auto a2("Ferrari", 3500);
             ah2.setGehuurdeAuto(a2);
             ah2.setHuurder(k);
             ah2.setAantalDagen(1);
             // Print "Tweede autohuur: " + ah2.toString()

             // Print "Gehuurd: " + ah1.getGehuurdeAuto()
             // Print "Gehuurd: " + ah2.getGehuurdeAuto()*/


        }
    }
}
