// P9.2 - Klasse Auto-park - arrays van objecten + DateTime  [PRO]
//
// Bouw een autoparkregistratiesysteem dat OOP en DateTime combineert.
// Vereisten:
//   - Klasse Auto: voorzie auto-properties Nummerplaat (string) en Merk (string), en een full property
//     Bouwjaar (int, moet altijd >= 1886 zijn).
//   - Klasse ParkeerPlaats:
//     - Voorzie auto-properties Nr (int) en IsVrij (bool).
//     - Voorzie een full property InrijTijd (DateTime, met private set).
//     - Voeg een methode void Parkeer(Auto auto) toe: sla de auto op, zet InrijTijd = DateTime.Now en
//       zet IsVrij = false.
//     - Voeg een methode Auto Vertrek() toe: geef de opgeslagen auto terug, bereken de parkeerduur via
//       TimeSpan, en toon de kostprijs (0,05 per minuut).
//   - Klasse Parkeergarage:
//     - Voorzie een array van ParkeerPlaats met 20 plaatsen.
//     - Voeg een methode void ToonStatus() toe: geef een overzicht van alle plaatsen (vrij of bezet),
//       en toon voor elke bezette plaats hoelang de auto al geparkeerd staat.
// Testen: bouw een CLI-menu met de keuzes aankomst, vertrek en status tonen.

namespace P9_2_KlasseAutoParkArraysVanObjectenDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: schrijf hier je code
        }
    }
}
