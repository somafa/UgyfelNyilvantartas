using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgyfelNyilvantartas
{
    class Ugyfel
    {
        int ugyfel_ID;
        string ugyfel_nev;
        string ugyfel_tel;
        string ugyfel_email;
        string ugyfel_mas;
        string ugyfel_adoszam;
        string ugyfel_cegj;
        string ugyfel_szekhely;
        string ugyfel_iban;
        string ugyfel_bank;
        string ugyfel_kategoria;
        string ugyfel_megj;

        public int Ugyfel_ID { get => ugyfel_ID; set => ugyfel_ID = value; }
        public string Ugyfel_nev { get => ugyfel_nev; set => ugyfel_nev = value; }
        public string Ugyfel_tel { get => ugyfel_tel; set => ugyfel_tel = value; }
        public string Ugyfel_email { get => ugyfel_email; set => ugyfel_email = value; }
        public string Ugyfel_mas { get => ugyfel_mas; set => ugyfel_mas = value; }
        public string Ugyfel_adoszam { get => ugyfel_adoszam; set => ugyfel_adoszam = value; }
        public string Ugyfel_cegj { get => ugyfel_cegj; set => ugyfel_cegj = value; }
        public string Ugyfel_szekhely { get => ugyfel_szekhely; set => ugyfel_szekhely = value; }
        public string Ugyfel_iban { get => ugyfel_iban; set => ugyfel_iban = value; }
        public string Ugyfel_bank { get => ugyfel_bank; set => ugyfel_bank = value; }
        public string Ugyfel_kategoria { get => ugyfel_kategoria; set => ugyfel_kategoria = value; }
        public string Ugyfel_megj { get => ugyfel_megj; set => ugyfel_megj = value; }

        public Ugyfel(int ugyfel_ID, string ugyfel_nev, string ugyfel_tel, string ugyfel_email, string ugyfel_mas, string ugyfel_adoszam, string ugyfel_cegj, string ugyfel_szekhely, string ugyfel_iban, string ugyfel_bank, string ugyfel_kategoria, string ugyfel_megj)
        {
            Ugyfel_ID = ugyfel_ID;
            Ugyfel_nev = ugyfel_nev;
            Ugyfel_tel = ugyfel_tel;
            Ugyfel_email = ugyfel_email;
            Ugyfel_mas = ugyfel_mas;
            Ugyfel_adoszam = ugyfel_adoszam;
            Ugyfel_cegj = ugyfel_cegj;
            Ugyfel_szekhely = ugyfel_szekhely;
            Ugyfel_iban = ugyfel_iban;
            Ugyfel_bank = ugyfel_bank;
            Ugyfel_kategoria = ugyfel_kategoria;
            Ugyfel_megj = ugyfel_megj;
        }
        public Ugyfel()
        {

        }
    }
}
