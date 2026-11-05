using System;
using System.Collections.Generic;
using System.Text;

namespace Dolgozatgyakorlo
{
    public class Eszkoz
    {
        private int napiDij;
        private int keszlet;
        private static int osszesRegisztraltEszkoz = 0;
        public string Azonosito;
        public string Nev;
        public string Kategoria;
        public int NapiDij
        {
            get { return napiDij; }
            set
            {
                if (value < 0)
                {
                    napiDij = 0;
                }
                else
                {
                    napiDij = value;
                }
            }
        }
        public int Keszlet {
            get { return keszlet; }
            set
            {
                if (value < 1)
                {
                    keszlet = 1;
                }
                else
                {
                    keszlet = value;
                }
            }
        }
        public static int OsszesRegisztraltEszkoz
        {
            get { return osszesRegisztraltEszkoz; }
        }
        public Eszkoz(string azonosito, string nev, string kategoria, int napiDij):this(azonosito,nev,kategoria,napiDij,1)
        {

        }
        public Eszkoz(string azonosito, string nev, string kategoria, int napiDij, int keszlet)
        {
            Azonosito = azonosito;
            Nev = nev;
            Kategoria = kategoria;
            NapiDij = napiDij;
            Keszlet = keszlet;
            osszesRegisztraltEszkoz++;

        }
        public override string ToString()
        {
            return $"{Azonosito} Nev {Kategoria} - Napi díj: {NapiDij} Ft | Készlet: {Keszlet} db";
        }
        public int TeljesNapiBevetel()
        {
            return NapiDij * Keszlet;
        }
    }
}
