using BoekWinkel;
using System;

class Program
{
    static void Main(string[] args)
    {
        Boek boek1 = new Boek("123456789", "C# Programming", "Tech Books Inc.", 25.99);
        Boek boek2 = new Boek("987654321", "Python Basics", "Coding Press", 19.99);

        Tijdschrift tijdschrift1 = new Tijdschrift("456789123", "Science News", "Science Pub", 5.99, Verschijningsperiode.Wekelijks);
        Tijdschrift tijdschrift2 = new Tijdschrift("789123456", "Fashion Trends", "Fashion Mag", 3.99, Verschijningsperiode.Maandelijks);

        Bestelling<Boek> boekBestelling = new Bestelling<Boek>(boek1, DateTime.Now, 3);
        boekBestelling.BoekBesteld += (sender, message) => Console.WriteLine(message);
        var boekBestellingResult = boekBestelling.Bestel();

        Console.WriteLine($"Bestelling ID: {boekBestelling.Id}");
        Console.WriteLine($"ISBN: {boekBestellingResult.Item1}, Aantal: {boekBestellingResult.Item2}, Totale prijs: {boekBestellingResult.Item3:C}");

        Bestelling<Tijdschrift> tijdschriftBestelling = new Bestelling<Tijdschrift>(tijdschrift1, DateTime.Now, 5, Verschijningsperiode.Wekelijks);
        var tijdschriftBestellingResult = tijdschriftBestelling.Bestel();

        Console.WriteLine($"Bestelling ID: {tijdschriftBestelling.Id}");
        Console.WriteLine($"ISBN: {tijdschriftBestellingResult.Item1}, Aantal: {tijdschriftBestellingResult.Item2}, Totale prijs: {tijdschriftBestellingResult.Item3:C}");
    }
}
