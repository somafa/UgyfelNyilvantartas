using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UgyfelNyilvantartas
{
    static class Program
    {
        static public MySqlConnection conn = null;
        static public MySqlCommand sql = null;
        static public Form form_Fooldal = null;
        static public Form form_UjMunka = null;
        static public Form form_Reszletek = null;
        static public Form form_Ugyfel = null;
        static public Form form_Kollega = null;
        public static DataGridViewRow kivalasztott = null;
        public static DataGridViewRow kivalasztott_ugyfel = null;
        public static DataGridViewRow kivalasztott_kollega = null;
        public static List<Megrendeles> megrendelesek = new List<Megrendeles>();
        public static List<Ugyfel> ugyfelek = new List<Ugyfel>();
        public static List<Kollega> kollegak = new List<Kollega>();
        public static List<Nyelvek> nyelvek = new List<Nyelvek>();
        public static List<string> nyelv_megnev = new List<string>();
      
        static void Main()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "munkanyilvantarto";
            sb.CharacterSet = "utf8";
            conn = new MySqlConnection(sb.ToString());
            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form_Fooldal = new form_Fooldal();
            form_UjMunka = new form_UjMunka();
            form_Reszletek = new form_Reszletek();
            form_Ugyfel = new form_Ugyfel();
            form_Kollega = new form_Kollega();
            Application.Run(form_Fooldal);
        }
        public static void Megrendeles_betoltese()
        {
            sql.CommandText = "SELECT munkaID, felvetel_datuma, hatarido, vegleges_ar, eddig_fizetett, eddig_fizetett_datuma, peldanyszam, leiras, statusz, kiindulasi_nyelv, celnyelv, u_nev, u_telefonszam, u_email, u_mas, u_megjegyzes, u_kategoria, k_nev, kollega_dija, hitelesites, futar, elkeszult_datum FROM megrendeles ORDER BY felvetel_datuma";
            try
            {
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Megrendeles uj = new Megrendeles();
                        DateTime ures = DateTime.MinValue;
                        uj.Megrendeles_ID = dr.IsDBNull(0) ? 0 : dr.GetInt32("munkaID");
                        uj.Felvetel = dr.IsDBNull(1) ? ures : dr.GetDateTime("felvetel_datuma");
                        uj.Hatarido = dr.IsDBNull(2) ? ures : dr.GetDateTime("hatarido");
                        uj.Vegleges_ar = dr.IsDBNull(3) ? 0 : dr.GetInt32("vegleges_ar");
                        uj.Eddig_fizetve = dr.IsDBNull(4) ? 0 : dr.GetInt32("eddig_fizetett");
                        uj.Eddig_fizetett_datum = dr.IsDBNull(5) ? ures : dr.GetDateTime("eddig_fizetett_datuma");
                        uj.Peldanyszam = dr.IsDBNull(6) ? 0 : dr.GetInt32("peldanyszam");
                        uj.Leiras = dr.IsDBNull(7) ? "" : dr.GetString("leiras");
                        uj.Statusz = dr.IsDBNull(8) ? "" : dr.GetString("statusz");
                        uj.Kiindulasi_nyelv = dr.IsDBNull(9) ? "" : dr.GetString("kiindulasi_nyelv");
                        uj.Celnyelv = dr.IsDBNull(10) ? "" : dr.GetString("celnyelv");
                        uj.Ugyfel_nev = dr.IsDBNull(11) ? "" : dr.GetString("u_nev");
                        uj.Ugyfel_telefon = dr.IsDBNull(12) ? "" : dr.GetString("u_telefonszam");
                        uj.Ugyfel_email = dr.IsDBNull(13) ? "" : dr.GetString("u_email");
                        uj.Ugyfel_mas = dr.IsDBNull(14) ? "" : dr.GetString("u_mas");
                        uj.Ugyfel_megj = dr.IsDBNull(15) ? "" : dr.GetString("u_megjegyzes");
                        uj.Ugyfel_kategoria = dr.IsDBNull(16) ? "" : dr.GetString("u_kategoria");
                        uj.Kollega_nev = dr.IsDBNull(17) ? "" : dr.GetString("k_nev");
                        uj.Kollega_dija = dr.IsDBNull(18) ? 0 : dr.GetInt32("kollega_dija");
                        uj.Hitelesites = dr.IsDBNull(19) ? 0 : dr.GetInt32("hitelesites");
                        uj.Futar = dr.IsDBNull(20) ? 0 : dr.GetInt32("futar");
                        uj.Elkeszult_datum = dr.IsDBNull(21) ? ures : dr.GetDateTime("elkeszult_datum");
                        megrendelesek.Add(uj);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }
        public static void Ugyfelek_betoltese()
        {
            sql.Parameters.Clear();
            sql.CommandText = "SELECT u_ID, u_nev, u_telefonszam, u_email, u_mas, u_adoszam, u_cegjegyzekszam, u_szekhely, u_IBAN, u_bank, u_kategoria, u_megjegyzes FROM ugyfel ORDER BY u_ID";
            try
            {
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Ugyfel uj = new Ugyfel();
                        uj.Ugyfel_ID = dr.IsDBNull(0) ? 0 : dr.GetInt32("u_ID");
                        uj.Ugyfel_nev = dr.IsDBNull(1) ? "" : dr.GetString("u_nev");
                        uj.Ugyfel_tel = dr.IsDBNull(2) ? "" : dr.GetString("u_telefonszam");
                        uj.Ugyfel_email = dr.IsDBNull(3) ? "" : dr.GetString("u_email");
                        uj.Ugyfel_mas = dr.IsDBNull(4) ? "" : dr.GetString("u_mas");
                        uj.Ugyfel_adoszam = dr.IsDBNull(5) ? "" : dr.GetString("u_adoszam");
                        uj.Ugyfel_cegj = dr.IsDBNull(6) ? "" : dr.GetString("u_cegjegyzekszam");
                        uj.Ugyfel_szekhely = dr.IsDBNull(7) ? "" : dr.GetString("u_szekhely");
                        uj.Ugyfel_iban = dr.IsDBNull(8) ? "" : dr.GetString("u_IBAN");
                        uj.Ugyfel_bank = dr.IsDBNull(9) ? "" : dr.GetString("u_bank");
                        uj.Ugyfel_kategoria = dr.IsDBNull(10) ? "" : dr.GetString("u_kategoria");
                        uj.Ugyfel_megj = dr.IsDBNull(11) ? "" : dr.GetString("u_megjegyzes");
                        ugyfelek.Add(uj);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }
        public static void Kollegak_betoltese()
        {
            sql.Parameters.Clear();
            sql.CommandText = "SELECT k_ID, k_nev, k_telefonszam, k_email, k_mas, k_adoszam, k_cegjegyzekszam, k_cim, k_IBAN, k_bank, k_szemelyi_szam, k_megjegyzes FROM kollega ORDER BY k_ID";
            try
            {
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Kollega uj = new Kollega();
                        uj.Kollega_ID = dr.IsDBNull(0) ? 0 : dr.GetInt32("k_ID");
                        uj.Kollega_nev = dr.IsDBNull(1) ? "" : dr.GetString("k_nev");
                        uj.Kollega_tel = dr.IsDBNull(2) ? "" : dr.GetString("k_telefonszam");
                        uj.Kollega_email = dr.IsDBNull(3) ? "" : dr.GetString("k_email");
                        uj.Kollega_mas = dr.IsDBNull(4) ? "" : dr.GetString("k_mas");
                        uj.Kollega_adoszam = dr.IsDBNull(5) ? "" : dr.GetString("k_adoszam");
                        uj.Kollega_cegj = dr.IsDBNull(6) ? "" : dr.GetString("k_cegjegyzekszam");
                        uj.Kollega_cim = dr.IsDBNull(7) ? "" : dr.GetString("k_cim");
                        uj.Kollega_iban = dr.IsDBNull(8) ? "" : dr.GetString("k_IBAN");
                        uj.Kollega_bank = dr.IsDBNull(9) ? "" : dr.GetString("k_bank");
                        uj.Kollega_szem_szam = dr.IsDBNull(10) ? "" : dr.GetString("k_szemelyi_szam");
                        uj.Kollega_megj = dr.IsDBNull(11) ? "" : dr.GetString("k_megjegyzes");
                        kollegak.Add(uj);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }
        public static void Nyelvek_betoltese()
        {
            sql.Parameters.Clear();
            sql.CommandText = "SELECT nyelv_ID, megnevezes FROM nyelvek ORDER BY nyelv_ID";
            try
            {
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Nyelvek uj = new Nyelvek();
                        uj.Nyelv_ID = dr.IsDBNull(0) ? 0 : dr.GetInt32("nyelv_ID");
                        uj.Megnevezes = dr.IsDBNull(1) ? "" : dr.GetString("megnevezes");
                        nyelvek.Add(uj);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }
        public static void Nyelv_lista()
        {
            sql.Parameters.Clear();
            sql.CommandText = "SELECT megnevezes FROM nyelvek";
            try
            {
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        nyelv_megnev.Add(dr.GetString("megnevezes"));
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }
    }
}
