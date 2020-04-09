using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgyfelNyilvantartas
{
    class Megrendeles
    {
        int megrendeles_ID;
        DateTime felvetel;
        DateTime hatarido;
        int vegleges_ar;
        int eddig_fizetve;
        DateTime eddig_fizetett_datum;
        int peldanyszam;
        string leiras;
        string statusz;
        string kiindulasi_nyelv;
        string celnyelv;
        string ugyfel_nev;
        string ugyfel_telefon;
        string ugyfel_email;
        string ugyfel_mas;
        string ugyfel_megj;
        string ugyfel_kategoria;
        string kollega_nev;
        int kollega_dija;
        int hitelesites;
        int futar;
        DateTime elkeszult_datum;

        public int Megrendeles_ID { get => megrendeles_ID; set => megrendeles_ID = value; }
        public DateTime Felvetel { get => felvetel; set => felvetel = value; }
        public DateTime Hatarido { get => hatarido; set => hatarido = value; }
        public int Vegleges_ar { get => vegleges_ar; set => vegleges_ar = value; }
        public int Eddig_fizetve { get => eddig_fizetve; set => eddig_fizetve = value; }
        public DateTime Eddig_fizetett_datum { get => eddig_fizetett_datum; set => eddig_fizetett_datum = value; }
        public int Peldanyszam { get => peldanyszam; set => peldanyszam = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        public string Statusz { get => statusz; set => statusz = value; }
        public string Kiindulasi_nyelv { get => kiindulasi_nyelv; set => kiindulasi_nyelv = value; }
        public string Celnyelv { get => celnyelv; set => celnyelv = value; }
        public string Ugyfel_nev { get => ugyfel_nev; set => ugyfel_nev = value; }
        public string Ugyfel_telefon { get => ugyfel_telefon; set => ugyfel_telefon = value; }
        public string Ugyfel_email { get => ugyfel_email; set => ugyfel_email = value; }
        public string Ugyfel_mas { get => ugyfel_mas; set => ugyfel_mas = value; }
        public string Ugyfel_megj { get => ugyfel_megj; set => ugyfel_megj = value; }
        public string Ugyfel_kategoria { get => ugyfel_kategoria; set => ugyfel_kategoria = value; }
        public string Kollega_nev { get => kollega_nev; set => kollega_nev = value; }
        public int Kollega_dija { get => kollega_dija; set => kollega_dija = value; }
        public int Hitelesites { get => hitelesites; set => hitelesites = value; }
        public int Futar { get => futar; set => futar = value; }
        public DateTime Elkeszult_datum { get => elkeszult_datum; set => elkeszult_datum = value; }

        public Megrendeles(int megrendeles_ID, DateTime felvetel, DateTime hatarido, int vegleges_ar, int eddig_fizetve, DateTime eddig_fizetett_datum, int peldanyszam, string leiras, string statusz, string kiindulasi_nyelv, string celnyelv, string ugyfel_nev, string ugyfel_telefon, string ugyfel_email, string ugyfel_mas, string ugyfel_megj, string ugyfel_kategoria, string kollega_nev, int kollega_dija, int hitelesites, int futar, DateTime elkeszult_datum)
        {
            Megrendeles_ID = megrendeles_ID;
            Felvetel = felvetel;
            Hatarido = hatarido;
            Vegleges_ar = vegleges_ar;
            Eddig_fizetve = eddig_fizetve;
            Eddig_fizetett_datum = eddig_fizetett_datum;
            Peldanyszam = peldanyszam;
            Leiras = leiras;
            Statusz = statusz;
            Kiindulasi_nyelv = kiindulasi_nyelv;
            Celnyelv = celnyelv;
            Ugyfel_nev = ugyfel_nev;
            Ugyfel_telefon = ugyfel_telefon;
            Ugyfel_email = ugyfel_email;
            Ugyfel_mas = ugyfel_mas;
            Ugyfel_megj = ugyfel_megj;
            Ugyfel_kategoria = ugyfel_kategoria;
            Kollega_nev = kollega_nev;
            Kollega_dija = kollega_dija;
            Hitelesites = hitelesites;
            Futar = futar;
            Elkeszult_datum = elkeszult_datum;
        }

        public Megrendeles()
        {
        }
    }
}
