// P9.1 - Klasse Product - volledig OOP-systeem  [PRO]
//
// Bouw een voorraad- en kassasysteem voor een kleine winkel met drie klassen die samenwerken. Gebruik
// alle property-types uit dit hoofdstuk.
// Vereisten:
//   - Klasse Product (in Product.cs):
//     - Voorzie auto-properties Naam (string, beginwaarde "onbekend") en Categorie (string).
//     - Voorzie een auto-property AanmaakDatum (DateTime, get + set), zodat je de datum bij het testen
//       zelf kan instellen.
//     - Voorzie een auto-property AantalVerkocht (int, met private set).
//     - Voorzie een full property Prijs (double, get + set) met validatie: de prijs moet groter zijn
//       dan 0, anders blijft de oude waarde behouden.
//     - Voorzie een write-only property Inkoopprijs (double, enkel een set) die opgeslagen wordt in
//       een private instantievariabele en nooit van buitenaf uitgelezen kan worden. Valideer dat de
//       waarde niet negatief is.
//     - Voorzie een full property Voorraad (int, get + private set), zodat de voorraad enkel via de
//       methoden Bijvullen() en Verkoop() kan wijzigen.
//     - Voorzie transformerende read-only properties: PrijsInclBtw (Prijs plus 21% btw, gebruik een
//       const voor het percentage), Marge (Prijs min Inkoopprijs), IsUitverkocht (bool), Status
//       ("Uitverkocht" bij voorraad 0, "Bijna op" bij minder dan 5, anders "Op voorraad") en
//       DagenInAssortiment (via een TimeSpan-berekening met AanmaakDatum).
//     - Voeg een methode bool Bijvullen(int aantal) toe: valideer dat aantal > 0, verhoog de voorraad
//       en geef true terug, anders false.
//     - Voeg een methode bool Verkoop(int aantal) toe: valideer dat aantal > 0 en niet groter is dan
//       de voorraad, verlaag dan de voorraad, verhoog AantalVerkocht en geef true terug, anders false.
//     - Voeg een methode void ToonInfo() toe die alle eigenschappen netjes uitgelijnd toont (inclusief
//       Marge en Status).
//   - Klasse Magazijn (in Magazijn.cs):
//     - Voorzie een private array Product[] met 10 plaatsen en een private teller die bijhoudt hoeveel
//       plaatsen gevuld zijn.
//     - Voorzie een read-only property AantalProducten (enkel een get).
//     - Voorzie een transformerende read-only property Voorraadwaarde: de som van Prijs × Voorraad van
//       alle producten.
//     - Voeg een methode bool VoegToe(Product product) toe: geef false terug als het magazijn vol is.
//     - Voeg een methode int ZoekIndex(string naam) toe die via lineair zoeken de plaats van het
//       product teruggeeft, of -1 als het niet gevonden werd.
//     - Voeg een methode Product GeefProduct(int index) toe die het product op die plaats teruggeeft.
//     - Voeg een methode void ToonOverzicht() toe: toon alle producten netjes uitgelijnd (naam,
//       categorie, prijs, voorraad en status), gevolgd door de totale voorraadwaarde.
//     - Voeg een methode void ToonBijnaOp() toe die enkel de producten toont met status "Bijna op" of
//       "Uitverkocht".
//   - Klasse Kassabon (in Kassabon.cs):
//     - Voorzie twee synchrone arrays, Product[] producten en int[] aantallen, met maximaal 10 regels,
//       en een private teller.
//     - Voorzie een auto-property Datum (DateTime, met private set en als beginwaarde DateTime.Now).
//     - Voorzie een transformerende read-only property Totaal: de som van aantal × PrijsInclBtw voor
//       alle regels.
//     - Voeg een methode bool VoegRegelToe(Product product, int aantal) toe: controleer eerst of er
//       nog plaats is op de bon, roep dan Verkoop() van het product aan en sla enkel bij een gelukte
//       verkoop het product en het aantal op. Geef true terug als de regel toegevoegd werd, anders
//       false.
//     - Voeg een methode void Toon() toe die de bon netjes toont: de datum, per regel de naam, het
//       aantal, de prijs incl. btw en het subtotaal, en onderaan het totaal.
// Testen: maak in Program.cs eerst minstens 5 producten aan met zinvolle gegevens (zet bij minstens
// één product de AanmaakDatum in het verleden) en bouw daarna een CLI-menu (do-while + switch) met de
// keuzes: 1) product toevoegen, 2) overzicht tonen, 3) product bijvullen, 4) nieuwe verkoop met
// kassabon, 5) bijna-op-overzicht, 0) stoppen. Toon dat ongeldige acties (een negatieve prijs, meer
// verkopen dan de voorraad, een vol magazijn) netjes geweigerd worden zonder dat het programma crasht.
// Bonus: toon in het overzicht ook het product met de hoogste marge.

namespace P9_1_KlasseProductVolledigOOPSysteem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: schrijf hier je code
        }
    }
}
