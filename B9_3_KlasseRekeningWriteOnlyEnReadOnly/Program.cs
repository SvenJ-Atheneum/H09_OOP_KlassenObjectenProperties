// B9.3 - Klasse Rekening - write-only en read-only  [BASIS]
//
// Maak een klasse Rekening die een bankrekening simuleert. Demonstreer write-only en read-only
// properties.
// Vereisten:
//   - Private instantievariabelen: double saldo = 0; en int pincode;.
//   - Write-only property Pincode (enkel een set): sla de ingegeven pincode op in de private
//     variabele, zonder dat deze ooit uitgelezen kan worden.
//   - Read-only property Saldo (enkel een get): geeft het saldo terug.
//   - Read-only property IsRood (enkel een get, transformerende property): geeft saldo < 0 terug.
//   - Voeg een public methode bool Stort(double bedrag) toe: verhoog het saldo met het bedrag (saldo
//     += bedrag), maar valideer eerst dat bedrag > 0. Geef true terug als de storting lukt, false als
//     ze ongeldig is.
//   - Voeg een public methode bool Hef(double bedrag, int ingevoerdePincode) toe: controleer of de
//     ingevoerde pincode klopt en of er voldoende saldo is, voer de afhaling dan pas uit. Geef true
//     terug bij een geslaagde afhaling, false als de pincode fout is of het saldo onvoldoende is.
//   - Testen: toon na elke operatie (storting of afhaling) de waarde van IsRood, zodat je kan
//     controleren of het saldo correct wordt bijgehouden.

namespace B9_3_KlasseRekeningWriteOnlyEnReadOnly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: schrijf hier je code
        }
    }
}
