// E9.3 - Klasse Temperatuurmeter  [ESSENTIAL]
//
// Bouw een klasse die temperatuurmetingen bijhoudt en analyseert. Gebruik full en auto-properties in
// combinatie.
// Vereisten:
//   - Private instantievariabelen: voorzie double huidigeTemp, double minTemp en double maxTemp.
//   - Full property HuidigeTemp (get + set): bij de set moeten ook minTemp en maxTemp automatisch
//     bijgewerkt worden op basis van de nieuwe waarde.
//   - Read-only properties MinTemp, MaxTemp en GemiddeldeTemp: GemiddeldeTemp houdt het bijgehouden
//     gemiddelde van alle ingevoerde temperaturen bij.
//   - Read-only property Status: geeft "Koud" terug bij een temperatuur onder 10, "Aangenaam" tussen
//     10 en 25, en "Warm" boven 25.
//   - Voeg een public methode void VoegMetingToe(double temp) toe die de waarde via de property
//     HuidigeTemp instelt.
//   - Testen: lees 10 temperaturen in via de Console en toon na elke meting een live statusbalk (met
//     de huidige temperatuur, min, max, gemiddelde en status).

namespace E9_3_KlasseTemperatuurmeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: schrijf hier je code
        }
    }
}
