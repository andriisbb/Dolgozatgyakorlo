using Dolgozatgyakorlo;
using KoltsegKalkulator;

List<Eszkoz> eszkozok = new List<Eszkoz>();

if (File.Exists("eszkozok.txt"))
{
    foreach ( string sor in File.ReadAllLines("eszkozok.txt"))
    {
        if (string.IsNullOrWhiteSpace(sor)) continue;

        string[] adatok = sor.Split(';');
        int db = adatok.Count();
        if (db < 4) continue;
        string azonosito = adatok[0];
        string nev = adatok[1];
        string kategoria = adatok[2];
        if (db == 4)
        {
            if (int.TryParse(adatok[3], out int napiDij))
            {
                Eszkoz eszkoz = new Eszkoz(azonosito, nev, kategoria, napiDij);
                eszkozok.Add(eszkoz);
            }
            else
            {
                Console.WriteLine($"[HIBA] A(z) {adatok[0]} azonosítójú eszköz adatai hibásak, átugorva!");
            }
        }
        else if (db == 5)
        {
            if (int.TryParse(adatok[3], out int napiDij) && int.TryParse(adatok[4], out int keszlet))
            {
                Eszkoz eszkoz = new Eszkoz(azonosito, nev, kategoria, napiDij, keszlet);
                eszkozok.Add(eszkoz);
            }
            else
            {
                Console.WriteLine($"[HIBA] A(z) {adatok[0]} azonosítójú eszköz adatai hibásak, átugorva!");
            }
        }

    }

}
foreach (Eszkoz eszkoz in eszkozok)
{
    Console.WriteLine(eszkoz);
}

Console.WriteLine($"\nRegisztrált eszközök száma a rendszerben: {Eszkoz.OsszesRegisztraltEszkoz} db");


double napibevetel = 0;
//foreach(Eszkoz e in eszkozok)
//{
//    napiDij* keszlet;
//}

Console.WriteLine($"Teljes eszközpark napi maximális bevétele: {napibevetel} Ft");

int berletdij = napidij * 10;
Console.WriteLine($"Legdrágább napi díjú eszköz: Dell Latitude Laptop (4500 Ft/nap)\r\n10 napos bérleti díja (15% kedvezménnyel):{berletiDij * KoltsegKalkulator.BérletiDijKedvezmennyel Ft\r\n");
Console.WriteLine($"Legnagyobb készlettel rendelkező eszköz: Logitech MX Master Egér (12 db)");