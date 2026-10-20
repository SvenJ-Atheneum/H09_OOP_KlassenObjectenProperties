// E9.1 - Klasse Student met auto-properties en berekeningen  [ESSENTIAL]
//
// Bouw een klasse Student met auto-properties en transformerende read-only properties. Verwerk een
// array van studenten.
// Vereisten:
//   - Klasse Student: voorzie auto-properties Voornaam (string), Achternaam (string) en Geboortejaar
//     (int).
//   - Voeg transformerende read-only properties toe:
//     - VolledigeNaam: combinatie van Voornaam en Achternaam.
//     - Leeftijd: berekend als huidig jaar min Geboortejaar.
//     - Email: samengesteld als voornaam@school.be.
//   - Voeg een full property Gemiddelde toe met een publieke get en een private set. Valideer dat de
//     waarde steeds tussen 0 en 100 ligt (0 <= waarde <= 100).
//   - Voeg een public methode void VoegPuntToe(double punt) toe die het gemiddelde herberekent. Houd
//     hiervoor intern een teller en een som bij.
//   - Testen: maak in Program.cs een array van 5 Student-objecten aan, voeg voor elke student enkele
//     punten toe, en toon daarna een klassement gesorteerd op gemiddelde.

namespace E9_1_KlasseStudentMetAutoPropertiesEnBerekeningen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: schrijf hier je code
        }
    }
}
