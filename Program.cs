using Dolgozatgyakorlo;

if (File.Exists("eszkozok.txt"))
{
    foreach ( string sor in File.ReadAllLines("eszkozok.txt"))
    {
        if (string.IsNullOrWhiteSpace(sor)) continue;

        string[] adatok = sor.Split(';');
        string azonosito = adatok[0];
        string nev = adatok[1];
        string kategoria = adatok[2];
        int db = adatok.Count();
        if (db < 4) continue;
        if (db == 4)
        {
            int.TryParse(NapiDij);
        }

    }
}
