using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoekWinkel
{
  

    class Boek
    {
        private string isbn;
        private string naam;
        private string uitgever;
        private double prijs;

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public string Uitgever
        {
            get { return uitgever; }
            set { uitgever = value; }
        }

        public double Prijs
        {
            get { return prijs; }
            set
            {
                if (value >= 5 && value <= 50)
                    prijs = value;
                else
                    Console.WriteLine("Prijs is te klein of te hoog ");
            }
        }

        public Boek(string isbn, string naam, string uitgever, double prijs)
        {
            Isbn = isbn;
            Naam = naam;
            Uitgever = uitgever;
            Prijs = prijs;
        }

        public override string ToString()
        {
            return $"ISBN: {Isbn}, Naam: {Naam}, Uitgever: {Uitgever}, Prijs: {Prijs:C}";
        }

        public void Lees()
        {
            Console.WriteLine($"Je leest het boek \"{Naam}\".");
        }
    }

}
