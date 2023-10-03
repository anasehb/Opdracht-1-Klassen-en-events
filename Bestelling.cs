using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BoekWinkel
{
    class Bestelling<T>
    {
        private static int volgnummerCounter = 1;

        public int Id { get; private set; }
        public T Item { get; set; }
        public DateTime Datum { get; set; }
        public int Aantal { get; set; }
        public Verschijningsperiode? AbonnementPeriode { get; set; }

        public event EventHandler<string> BoekBesteld;

        public Bestelling(T item, DateTime datum, int aantal, Verschijningsperiode? periode = null)
        {
            Id = volgnummerCounter++;
            Item = item;
            Datum = datum;
            Aantal = aantal;
            AbonnementPeriode = periode;
        }

        public (string, int, double) Bestel()
        {
            if (Item is Boek boek)
            {
                double totalePrijs = boek.Prijs * Aantal;
                BoekBesteld?.Invoke(this, $"Bestelling van boek \"{boek.Naam}\" ({Aantal} exemplaren) geplaatst. Totale prijs: {totalePrijs:C}");
                return (boek.Isbn, Aantal, totalePrijs);
            }
            else
            {
                throw new InvalidOperationException("Kan alleen boeken bestellen met deze methode.");
            }
        }
    }
}
