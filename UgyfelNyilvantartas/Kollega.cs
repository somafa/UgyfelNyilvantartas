using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgyfelNyilvantartas
{
    class Kollega
    {
        int kollega_ID;
        string kollega_nev;
        string kollega_tel;
        string kollega_email;
        string kollega_mas;
        string kollega_adoszam;
        string kollega_cegj;
        string kollega_cim;
        string kollega_iban;
        string kollega_bank;
        string kollega_szem_szam;
        string kollega_megj;

        public int Kollega_ID { get => kollega_ID; set => kollega_ID = value; }
        public string Kollega_nev { get => kollega_nev; set => kollega_nev = value; }
        public string Kollega_tel { get => kollega_tel; set => kollega_tel = value; }
        public string Kollega_email { get => kollega_email; set => kollega_email = value; }
        public string Kollega_mas { get => kollega_mas; set => kollega_mas = value; }
        public string Kollega_adoszam { get => kollega_adoszam; set => kollega_adoszam = value; }
        public string Kollega_cegj { get => kollega_cegj; set => kollega_cegj = value; }
        public string Kollega_cim { get => kollega_cim; set => kollega_cim = value; }
        public string Kollega_iban { get => kollega_iban; set => kollega_iban = value; }
        public string Kollega_bank { get => kollega_bank; set => kollega_bank = value; }
        public string Kollega_szem_szam { get => kollega_szem_szam; set => kollega_szem_szam = value; }
        public string Kollega_megj { get => kollega_megj; set => kollega_megj = value; }

        public Kollega(int kollega_ID, string kollega_nev, string kollega_tel, string kollega_email, string kollega_mas, string kollega_adoszam, string kollega_cegj, string kollega_cim, string kollega_iban, string kollega_bank, string kollega_szem_szam, string kollega_megj)
        {
            Kollega_ID = kollega_ID;
            Kollega_nev = kollega_nev;
            Kollega_tel = kollega_tel;
            Kollega_email = kollega_email;
            Kollega_mas = kollega_mas;
            Kollega_adoszam = kollega_adoszam;
            Kollega_cegj = kollega_cegj;
            Kollega_cim = kollega_cim;
            Kollega_iban = kollega_iban;
            Kollega_bank = kollega_bank;
            Kollega_szem_szam = kollega_szem_szam;
            Kollega_megj = kollega_megj;
        }
        public Kollega()
        {

        }
    }
}
