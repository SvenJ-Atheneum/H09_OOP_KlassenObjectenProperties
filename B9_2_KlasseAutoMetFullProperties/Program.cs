// B9.2 - Klasse Auto met full properties  [BASIS]
//
// Maak een klasse Auto met full properties. Bouw validatie in voor de instantievariabelen.
// Vereisten:
//   - Klasse Auto in Auto.cs: voorzie private instantievariabelen string kleur, int bouwjaar en double
//     kilometerstand.
//   - Voeg een full property Kleur toe (get + set), zonder validatie.
//   - Voeg een full property Bouwjaar toe (get + set) met validatie: bouwjaar moet >= 1886 zijn (de
//     eerste auto ooit) en <= het huidige jaar.
//   - Voeg een full property Kilometerstand toe (get + private set), zodat deze enkel via de methode
//     Rijd() kan stijgen en niet rechtstreeks van buitenaf gewijzigd kan worden.
//   - Voeg een public methode void Rijd(double km) toe die km optelt bij de kilometerstand. Valideer
//     hierbij dat km > 0.
//   - Voeg een public methode void ToonInfo() toe die alle eigenschappen netjes toont.
//   - Testen: maak in Program.cs 2 auto-objecten aan, en test zowel de validatie als de Rijd-methode.

namespace B9_2_KlasseAutoMetFullProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: schrijf hier je code
        }
    }
}
