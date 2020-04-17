using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UgyfelNyilvantartas
{
    public partial class form_Reszletek : Form
    {
        public form_Reszletek()
        {
            InitializeComponent();
        }

        private void button_mentes_Click(object sender, EventArgs e)
        {
            Modositasok_mentese();
            Modositasok_tiltasa();
            
            this.Close();
            Program.form_Fooldal.Show();
        }

        private void button_kilepes_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form_Fooldal.Show();
        }

        /*private void form_Reszletek_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
            Program.form_Fooldal.Show();
        }*/

        private void form_Reszletek_Load(object sender, EventArgs e)
        {
            DG_Reszletek_megrendeles_Beallitasok();
            DG_Reszletek_ugyfel_Beallitasok();
            DG_Reszletek_kollega_Beallitasok();
            DG_Reszletek_koltsegek_Beallitasok();
            textBox_Reszletek_leiras.Clear();
            Reszletek_Betoltes();
        }

        private void DG_Reszletek_megrendeles_Beallitasok()
        {
            DG_Reszletek_megrendeles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DG_Reszletek_megrendeles.MultiSelect = false;
        }
        private void DG_Reszletek_ugyfel_Beallitasok()
        {
            DG_Reszletek_ugyfel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void DG_Reszletek_kollega_Beallitasok()
        {
            DG_Reszletek_kollega.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void DG_Reszletek_koltsegek_Beallitasok()
        {
            DG_Reszletek_koltsegek.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DG_Reszletek_koltsegek.MultiSelect = false;
        }
        private void Reszletek_Betoltes()
        {
            DG_Reszletek_megrendeles.Rows.Clear();
            for (int i = 0; i < Program.megrendelesek.Count; i++)
            {
                if (Program.megrendelesek[i].Megrendeles_ID.Equals(Program.kivalasztott.Cells["MunkaID"].Value))
                {
                    DG_Reszletek_megrendeles.Rows[0].Cells["FelvetelDatum"].Value = Program.megrendelesek[i].Felvetel;
                    DG_Reszletek_megrendeles.Rows[0].Cells["Hatarido"].Value = Program.megrendelesek[i].Hatarido.ToString("yyyy.MM.dd");
                    DG_Reszletek_megrendeles.Rows[0].Cells["VeglegesAr"].Value = Program.megrendelesek[i].Vegleges_ar;
                    DG_Reszletek_megrendeles.Rows[0].Cells["EddigFizetve"].Value = Program.megrendelesek[i].Eddig_fizetve;
                    DG_Reszletek_megrendeles.Rows[0].Cells["FizetveDatum"].Value = Program.megrendelesek[i].Eddig_fizetett_datum.ToString("yyyy.MM.dd");
                    DG_Reszletek_megrendeles.Rows[0].Cells["Peldanyszam"].Value = Program.megrendelesek[i].Peldanyszam;
                    DG_Reszletek_megrendeles.Rows[0].Cells["KiindulasiNyelv"].Value = Program.megrendelesek[i].Kiindulasi_nyelv;
                    DG_Reszletek_megrendeles.Rows[0].Cells["CelNyelv"].Value = Program.megrendelesek[i].Celnyelv;
                    DG_Reszletek_megrendeles.Rows[0].Cells["Statusz"].Value = Program.megrendelesek[i].Statusz;
                    DG_Reszletek_ugyfel.Rows[0].Cells["UgyfelNev"].Value = Program.megrendelesek[i].Ugyfel_nev;
                    DG_Reszletek_ugyfel.Rows[0].Cells["Telefonszam"].Value = Program.megrendelesek[i].Ugyfel_telefon;
                    DG_Reszletek_ugyfel.Rows[0].Cells["EmailCim"].Value = Program.megrendelesek[i].Ugyfel_email;
                    DG_Reszletek_ugyfel.Rows[0].Cells["MasElerhetoseg"].Value = Program.megrendelesek[i].Ugyfel_mas;
                    DG_Reszletek_ugyfel.Rows[0].Cells["Megjegyzes"].Value = Program.megrendelesek[i].Ugyfel_megj;
                    DG_Reszletek_ugyfel.Rows[0].Cells["Kategoria"].Value = Program.megrendelesek[i].Ugyfel_kategoria;
                    DG_Reszletek_kollega.Rows[0].Cells["KollegaNev"].Value = Program.megrendelesek[i].Kollega_nev;
                    textBox_Reszletek_leiras.Text = Program.megrendelesek[i].Leiras;
                    DG_Reszletek_koltsegek.Rows[0].Cells["KollegaDija"].Value = Program.megrendelesek[i].Kollega_dija;
                    DG_Reszletek_koltsegek.Rows[0].Cells["Hitelesites"].Value = Program.megrendelesek[i].Hitelesites;
                    DG_Reszletek_koltsegek.Rows[0].Cells["Futar"].Value = Program.megrendelesek[i].Futar;
                }
            }
        }

        private void button_modositasEnged_Click(object sender, EventArgs e)
        {
            if (DG_Reszletek_megrendeles.ReadOnly == true)
            {
                DG_Reszletek_megrendeles.ReadOnly = false;
                DG_Reszletek_koltsegek.ReadOnly = false;
                textBox_Reszletek_leiras.ReadOnly = false;
            }
        }

        private void Modositasok_tiltasa()
        {
            if (DG_Reszletek_megrendeles.ReadOnly==false)
            {
                DG_Reszletek_megrendeles.ReadOnly = true;
                DG_Reszletek_koltsegek.ReadOnly = true;
                textBox_Reszletek_leiras.ReadOnly = true;
            }
        }
        private void Modositasok_mentese()
        {
            for (int i = 0; i < Program.megrendelesek.Count; i++)
            {
                if (Program.kivalasztott.Cells["MunkaID"].Value.Equals(Program.megrendelesek[i].Megrendeles_ID))
                {
                    Program.megrendelesek[i].Hatarido = Convert.ToDateTime(DG_Reszletek_megrendeles.Rows[0].Cells["Hatarido"].Value);
                    Program.megrendelesek[i].Vegleges_ar = Convert.ToInt32(DG_Reszletek_megrendeles.Rows[0].Cells["VeglegesAr"].Value);
                    Program.megrendelesek[i].Eddig_fizetve = Convert.ToInt32(DG_Reszletek_megrendeles.Rows[0].Cells["EddigFizetve"].Value);
                    Program.megrendelesek[i].Eddig_fizetett_datum = Convert.ToDateTime(DG_Reszletek_megrendeles.Rows[0].Cells["FizetveDatum"].Value);
                    Program.megrendelesek[i].Peldanyszam = Convert.ToInt32(DG_Reszletek_megrendeles.Rows[0].Cells["Peldanyszam"].Value);
                    Program.megrendelesek[i].Kiindulasi_nyelv = Convert.ToString(DG_Reszletek_megrendeles.Rows[0].Cells["KiindulasiNyelv"].Value);
                    Program.megrendelesek[i].Celnyelv = Convert.ToString(DG_Reszletek_megrendeles.Rows[0].Cells["CelNyelv"].Value);
                    Program.megrendelesek[i].Statusz = Convert.ToString(DG_Reszletek_megrendeles.Rows[0].Cells["Statusz"].Value);
                    Program.megrendelesek[i].Kollega_nev = Convert.ToString(DG_Reszletek_kollega.Rows[0].Cells["KollegaNev"].Value);
                    Program.megrendelesek[i].Leiras = Convert.ToString(textBox_Reszletek_leiras.Text);
                    Program.megrendelesek[i].Kollega_dija = Convert.ToInt32(DG_Reszletek_koltsegek.Rows[0].Cells["KollegaDija"].Value);
                    Program.megrendelesek[i].Hitelesites = Convert.ToInt32(DG_Reszletek_koltsegek.Rows[0].Cells["Hitelesites"].Value);
                    Program.megrendelesek[i].Futar = Convert.ToInt32(DG_Reszletek_koltsegek.Rows[0].Cells["Futar"].Value);
                }
            }
            /*
            Program.sql.Parameters.Clear();
            Program.sql.CommandText = "UPDATE munka, kollega SET munka.felvetel_datuma=@felvetel, munka.hatarido=@hatarido, munka.vegleges_ar=@vegleges_ar, munka.eddig_fizetett=@eddig_fizetett, munka.eddig_fizetett_datuma=@eddig_fizetett_datuma, munka.peldanyszam=@peldanyszam, munka.leiras=@leiras, munka.statusz=@statusz, munka.kiindulasi_nyelv_ID=@kiindulasi_nyelv, munka.celnyelv_ID=@celnyelv, kollega.k_nev=@k_nev, munka.kollega_dija=@kollega_dija, munka.hitelesites=@hitelesites, munka.futar=@futar, munka.elkeszult_datum=@elkeszult_datum";
            Program.sql.Parameters.AddWithValue("@munka.felvetel", DG_Reszletek_megrendeles.Rows[0].Cells["FelvetelDatum"].Value);
            Program.sql.Parameters.AddWithValue("@munka.hatarido", DG_Reszletek_megrendeles.Rows[0].Cells["Hatarido"].Value);
            Program.sql.Parameters.AddWithValue("@munka.vegleges_ar", DG_Reszletek_megrendeles.Rows[0].Cells["VeglegesAr"].Value);
            Program.sql.Parameters.AddWithValue("@munka.eddig_fizetett", DG_Reszletek_megrendeles.Rows[0].Cells["EddigFizetve"].Value);
            Program.sql.Parameters.AddWithValue("@munka.eddig_fizetett_datuma", DG_Reszletek_megrendeles.Rows[0].Cells["FizetveDatum"].Value);
            Program.sql.Parameters.AddWithValue("@munka.peldanyszam", DG_Reszletek_megrendeles.Rows[0].Cells["Peldanyszam"].Value);
            Program.sql.Parameters.AddWithValue("@munka.leiras", textBox_leiras.Text);
            Program.sql.Parameters.AddWithValue("@munka.statusz", DG_Reszletek_megrendeles.Rows[0].Cells["Statusz"].Value);
            Program.sql.Parameters.AddWithValue("@munka.kiindulasi_nyelv_ID", DG_Reszletek_megrendeles.Rows[0].Cells["KiindulasiNyelv"].Value);
            Program.sql.Parameters.AddWithValue("@munka.celnyelv_ID", DG_Reszletek_megrendeles.Rows[0].Cells["CelNyelv"].Value);
            Program.sql.Parameters.AddWithValue("@kollega.k_nev", DG_Reszletek_megrendeles.Rows[0].Cells["KollegaNev"].Value);
            Program.sql.Parameters.AddWithValue("@munka.kollega_dija", DG_Reszletek_megrendeles.Rows[0].Cells["KollegaDija"].Value);
            Program.sql.Parameters.AddWithValue("@munka.hitelesites", DG_Reszletek_megrendeles.Rows[0].Cells["Hitelesites"].Value);
            Program.sql.Parameters.AddWithValue("@munka.futar", DG_Reszletek_megrendeles.Rows[0].Cells["Futar"].Value);
            Program.sql.Parameters.AddWithValue("@munka.elkeszult_datum", DateTime.Now);*/
        }
    }
}
