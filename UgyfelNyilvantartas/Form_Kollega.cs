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
    public partial class form_Kollega : Form
    {
        public form_Kollega()
        {
            InitializeComponent();
        }

        private void button_hasznal_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form_UjMunka.Show();
        }

        private void button_fooldalra_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form_Fooldal.Show();
        }

        private void form_Kollega_Load(object sender, EventArgs e)
        {
            Program.Kollegak_betoltese();
            DG_Kollega_kollega_Beallitasok();
            DG_Kollega_kollega.Rows.Clear();
            textBox_koll_keresomezo.Clear();
        }
        private void DG_Kollega_kollega_Beallitasok()
        {
            DG_Kollega_kollega.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DG_Kollega_kollega.MultiSelect = false;
            DG_Kollega_kollega.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button_kereses_Click(object sender, EventArgs e)
        {
            if (textBox_koll_keresomezo.Text != "")
            {
                DG_Kollega_kollega_Betoltes();
            }
            else MessageBox.Show("Nem értelmezhető keresési feltétel!");
        }
        private void DG_Kollega_kollega_Betoltes()
        {
            DG_Kollega_kollega.Rows.Clear();
            for (int i = 0; i < Program.kollegak.Count; i++)
            {
                if (Program.kollegak[i].Kollega_nev.Contains(textBox_koll_keresomezo.Text) || Program.kollegak[i].Kollega_tel.Contains(textBox_koll_keresomezo.Text) || Program.kollegak[i].Kollega_email.Contains(textBox_koll_keresomezo.Text))
                {
                    int sor_index = DG_Kollega_kollega.Rows.Add();
                    DG_Kollega_kollega.Rows[sor_index].Cells["KollegaID"].Value = Program.kollegak[i].Kollega_ID;
                    DG_Kollega_kollega.Rows[sor_index].Cells["Nev"].Value = Program.kollegak[i].Kollega_nev;
                    DG_Kollega_kollega.Rows[sor_index].Cells["Telefonszam"].Value = Program.kollegak[i].Kollega_tel;
                    DG_Kollega_kollega.Rows[sor_index].Cells["EmailCim"].Value = Program.kollegak[i].Kollega_email;
                    DG_Kollega_kollega.Rows[sor_index].Cells["MasElerhetoseg"].Value = Program.kollegak[i].Kollega_mas;
                    DG_Kollega_kollega.Rows[sor_index].Cells["Adoszam"].Value = Program.kollegak[i].Kollega_adoszam;
                    DG_Kollega_kollega.Rows[sor_index].Cells["Cegjegyzekszam"].Value = Program.kollegak[i].Kollega_cegj;
                    DG_Kollega_kollega.Rows[sor_index].Cells["Szekhely"].Value = Program.kollegak[i].Kollega_cim;
                    DG_Kollega_kollega.Rows[sor_index].Cells["Bank"].Value = Program.kollegak[i].Kollega_bank;
                    DG_Kollega_kollega.Rows[sor_index].Cells["IBAN"].Value = Program.kollegak[i].Kollega_iban;
                    DG_Kollega_kollega.Rows[sor_index].Cells["SzemSzam"].Value = Program.kollegak[i].Kollega_szem_szam;
                    DG_Kollega_kollega.Rows[sor_index].Cells["Megjegyzes"].Value = Program.kollegak[i].Kollega_megj;
                }
            }
        }

        private void button_modositas_Click(object sender, EventArgs e)
        {
            if (DG_Kollega_kollega.ReadOnly == true)
            {
                DG_Kollega_kollega.ReadOnly = false;
            }
        }
        private void Modositasok_tiltasa()
        {
            if (DG_Kollega_kollega.ReadOnly == false)
            {
                DG_Kollega_kollega.ReadOnly = true;
            }
        }

        private void DG_Kollega_kollega_SelectionChanged(object sender, EventArgs e)
        {
            Program.kivalasztott_kollega = DG_Kollega_kollega.SelectedRows[0];
        }
        private void Modositasok_mentese()
        {
            for (int i = 0; i < Program.kollegak.Count; i++)
            {
                if (Program.kivalasztott_kollega.Cells["KollegaID"].Value.Equals(Program.kollegak[i].Kollega_ID))
                {
                    Program.kollegak[i].Kollega_nev = Convert.ToString(DG_Kollega_kollega.Rows[0].Cells["Nev"].Value);
                    Program.kollegak[i].Kollega_tel = Convert.ToString(DG_Kollega_kollega.Rows[0].Cells["Telefonszam"].Value);
                    Program.kollegak[i].Kollega_email = Convert.ToString(DG_Kollega_kollega.Rows[0].Cells["EmailCim"].Value);
                    Program.kollegak[i].Kollega_mas = Convert.ToString(DG_Kollega_kollega.Rows[0].Cells["MasElerhetoseg"].Value);
                    Program.kollegak[i].Kollega_adoszam = Convert.ToString(DG_Kollega_kollega.Rows[0].Cells["Adoszam"].Value);
                    Program.kollegak[i].Kollega_cegj = Convert.ToString(DG_Kollega_kollega.Rows[0].Cells["Cegjegyzekszam"].Value);
                    Program.kollegak[i].Kollega_cim = Convert.ToString(DG_Kollega_kollega.Rows[0].Cells["Szekhely"].Value);
                    Program.kollegak[i].Kollega_bank = Convert.ToString(DG_Kollega_kollega.Rows[0].Cells["Bank"].Value);
                    Program.kollegak[i].Kollega_iban = Convert.ToString(DG_Kollega_kollega.Rows[0].Cells["IBAN"].Value);
                    Program.kollegak[i].Kollega_szem_szam = Convert.ToString(DG_Kollega_kollega.Rows[0].Cells["SzemSzam"].Value);
                    Program.kollegak[i].Kollega_megj = Convert.ToString(DG_Kollega_kollega.Rows[0].Cells["Megjegyzes"].Value);
                }
                else
                {
                    Kollega uj = new Kollega();
                    int uj_index = Program.kollegak.Count + 1;
                    Program.kollegak[uj_index].Kollega_ID = Program.kollegak.Count + 1;
                    Program.kollegak[uj_index].Kollega_nev = Convert.ToString(DG_Kollega_kollega.Rows[0].Cells["Nev"].Value);
                    Program.kollegak[uj_index].Kollega_tel = Convert.ToString(DG_Kollega_kollega.Rows[0].Cells["Telefonszam"].Value);
                    Program.kollegak[uj_index].Kollega_email = Convert.ToString(DG_Kollega_kollega.Rows[0].Cells["EmailCim"].Value);
                    Program.kollegak[uj_index].Kollega_mas = Convert.ToString(DG_Kollega_kollega.Rows[0].Cells["MasElerhetoseg"].Value);
                    Program.kollegak[uj_index].Kollega_adoszam = Convert.ToString(DG_Kollega_kollega.Rows[0].Cells["Adoszam"].Value);
                    Program.kollegak[uj_index].Kollega_cegj = Convert.ToString(DG_Kollega_kollega.Rows[0].Cells["Cegjegyzekszam"].Value);
                    Program.kollegak[uj_index].Kollega_cim = Convert.ToString(DG_Kollega_kollega.Rows[0].Cells["Szekhely"].Value);
                    Program.kollegak[uj_index].Kollega_bank = Convert.ToString(DG_Kollega_kollega.Rows[0].Cells["Bank"].Value);
                    Program.kollegak[uj_index].Kollega_iban = Convert.ToString(DG_Kollega_kollega.Rows[0].Cells["IBAN"].Value);
                    Program.kollegak[uj_index].Kollega_szem_szam = Convert.ToString(DG_Kollega_kollega.Rows[0].Cells["SzemSzam"].Value);
                    Program.kollegak[uj_index].Kollega_megj = Convert.ToString(DG_Kollega_kollega.Rows[0].Cells["Megjegyzes"].Value);
                    Program.kollegak.Add(uj);
                }
            }
        }

        private void button_mentes_Click(object sender, EventArgs e)
        {
            Modositasok_mentese();
            Modositasok_tiltasa();
        }

        private void button_ujKollega_Click(object sender, EventArgs e)
        {
            DG_Kollega_kollega.Rows.Clear();
            DG_Kollega_kollega.ReadOnly = false;
        }
    }
}
