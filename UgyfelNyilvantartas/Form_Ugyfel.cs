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
    public partial class form_Ugyfel : Form
    {
        public form_Ugyfel()
        {
            InitializeComponent();
        }

        private void button_fooldalra_Click(object sender, EventArgs e)
        {
            DG_Ugyfel_ugyfel.Rows.Clear();
            textBox_keresomezo.Clear();
            this.Close();
            Program.form_Fooldal.Show();
        }

        private void button_hasznal_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form_UjMunka.Show();
        }

        private void button_kereses_Click(object sender, EventArgs e)
        {
            if (textBox_keresomezo.Text != "")
            {
                DG_Ugyfel_ugyfel_Betoltes();
            }
            else MessageBox.Show("Nem értelmezhető keresési feltétel!");
        }

        private void form_Ugyfel_Load(object sender, EventArgs e)
        {
            Program.Ugyfelek_betoltese();
            DG_Ugyfel_ugyfel_Beallitasok();
            DG_Ugyfel_ugyfel.Rows.Clear();
            textBox_keresomezo.Clear();
        }
        private void DG_Ugyfel_ugyfel_Beallitasok()
        {
            DG_Ugyfel_ugyfel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DG_Ugyfel_ugyfel.MultiSelect = false;
            DG_Ugyfel_ugyfel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void DG_Ugyfel_ugyfel_Betoltes()
        {
            DG_Ugyfel_ugyfel.Rows.Clear();
            for (int i = 0; i < Program.ugyfelek.Count; i++)
            {
                if (Program.ugyfelek[i].Ugyfel_nev.Contains(textBox_keresomezo.Text) || Program.ugyfelek[i].Ugyfel_tel.Contains(textBox_keresomezo.Text) || Program.ugyfelek[i].Ugyfel_email.Contains(textBox_keresomezo.Text))
                {
                    int sor_index = DG_Ugyfel_ugyfel.Rows.Add();
                    DG_Ugyfel_ugyfel.Rows[sor_index].Cells["UgyfelID"].Value = Program.ugyfelek[i].Ugyfel_ID;
                    DG_Ugyfel_ugyfel.Rows[sor_index].Cells["Nev"].Value = Program.ugyfelek[i].Ugyfel_nev;
                    DG_Ugyfel_ugyfel.Rows[sor_index].Cells["Telefonszam"].Value = Program.ugyfelek[i].Ugyfel_tel;
                    DG_Ugyfel_ugyfel.Rows[sor_index].Cells["EmailCim"].Value = Program.ugyfelek[i].Ugyfel_email;
                    DG_Ugyfel_ugyfel.Rows[sor_index].Cells["MasElerhetoseg"].Value = Program.ugyfelek[i].Ugyfel_mas;
                    DG_Ugyfel_ugyfel.Rows[sor_index].Cells["Adoszam"].Value = Program.ugyfelek[i].Ugyfel_adoszam;
                    DG_Ugyfel_ugyfel.Rows[sor_index].Cells["Cegjegyzekszam"].Value = Program.ugyfelek[i].Ugyfel_cegj;
                    DG_Ugyfel_ugyfel.Rows[sor_index].Cells["Szekhely"].Value = Program.ugyfelek[i].Ugyfel_szekhely;
                    DG_Ugyfel_ugyfel.Rows[sor_index].Cells["Bank"].Value = Program.ugyfelek[i].Ugyfel_bank;
                    DG_Ugyfel_ugyfel.Rows[sor_index].Cells["IBAN"].Value = Program.ugyfelek[i].Ugyfel_iban;
                    DG_Ugyfel_ugyfel.Rows[sor_index].Cells["Kategoria"].Value = Program.ugyfelek[i].Ugyfel_kategoria;
                    DG_Ugyfel_ugyfel.Rows[sor_index].Cells["Megjegyzes"].Value = Program.ugyfelek[i].Ugyfel_megj;
                }
            }
        }

        private void button_modositas_Click(object sender, EventArgs e)
        {
            if (DG_Ugyfel_ugyfel.ReadOnly==true)
            {
                DG_Ugyfel_ugyfel.ReadOnly = false;
            }
        }
        private void Modositasok_tiltasa()
        {
            if (DG_Ugyfel_ugyfel.ReadOnly == false)
            {
                DG_Ugyfel_ugyfel.ReadOnly = true;
            }
        }

        private void DG_Ugyfel_ugyfel_SelectionChanged(object sender, EventArgs e)
        {
            Program.kivalasztott_ugyfel = DG_Ugyfel_ugyfel.SelectedRows[0];
        }
        private void Modositasok_mentese()
        {
            for (int i = 0; i < Program.ugyfelek.Count; i++)
            {
                if (Program.kivalasztott_ugyfel.Cells["UgyfelID"].Value.Equals(Program.ugyfelek[i].Ugyfel_ID))
                {
                    Program.ugyfelek[i].Ugyfel_nev = Convert.ToString(DG_Ugyfel_ugyfel.Rows[0].Cells["Nev"].Value);
                    Program.ugyfelek[i].Ugyfel_tel = Convert.ToString(DG_Ugyfel_ugyfel.Rows[0].Cells["Telefonszam"].Value);
                    Program.ugyfelek[i].Ugyfel_email = Convert.ToString(DG_Ugyfel_ugyfel.Rows[0].Cells["EmailCim"].Value);
                    Program.ugyfelek[i].Ugyfel_mas = Convert.ToString(DG_Ugyfel_ugyfel.Rows[0].Cells["MasElerhetoseg"].Value);
                    Program.ugyfelek[i].Ugyfel_adoszam = Convert.ToString(DG_Ugyfel_ugyfel.Rows[0].Cells["Adoszam"].Value);
                    Program.ugyfelek[i].Ugyfel_cegj = Convert.ToString(DG_Ugyfel_ugyfel.Rows[0].Cells["Cegjegyzekszam"].Value);
                    Program.ugyfelek[i].Ugyfel_szekhely = Convert.ToString(DG_Ugyfel_ugyfel.Rows[0].Cells["Szekhely"].Value);
                    Program.ugyfelek[i].Ugyfel_bank = Convert.ToString(DG_Ugyfel_ugyfel.Rows[0].Cells["Bank"].Value);
                    Program.ugyfelek[i].Ugyfel_iban = Convert.ToString(DG_Ugyfel_ugyfel.Rows[0].Cells["IBAN"].Value);
                    Program.ugyfelek[i].Ugyfel_kategoria = Convert.ToString(DG_Ugyfel_ugyfel.Rows[0].Cells["Kategoria"].Value);
                    Program.ugyfelek[i].Ugyfel_megj = Convert.ToString(DG_Ugyfel_ugyfel.Rows[0].Cells["Megjegyzes"].Value);
                }
                else
                {
                    Ugyfel uj = new Ugyfel();
                    int uj_index = Program.ugyfelek.Count+1;
                    Program.ugyfelek[uj_index].Ugyfel_ID=Program.ugyfelek.Count+1;
                    Program.ugyfelek[uj_index].Ugyfel_nev = Convert.ToString(DG_Ugyfel_ugyfel.Rows[0].Cells["Nev"].Value);
                    Program.ugyfelek[uj_index].Ugyfel_tel = Convert.ToString(DG_Ugyfel_ugyfel.Rows[0].Cells["Telefonszam"].Value);
                    Program.ugyfelek[uj_index].Ugyfel_email = Convert.ToString(DG_Ugyfel_ugyfel.Rows[0].Cells["EmailCim"].Value);
                    Program.ugyfelek[uj_index].Ugyfel_mas = Convert.ToString(DG_Ugyfel_ugyfel.Rows[0].Cells["MasElerhetoseg"].Value);
                    Program.ugyfelek[uj_index].Ugyfel_adoszam = Convert.ToString(DG_Ugyfel_ugyfel.Rows[0].Cells["Adoszam"].Value);
                    Program.ugyfelek[uj_index].Ugyfel_cegj = Convert.ToString(DG_Ugyfel_ugyfel.Rows[0].Cells["Cegjegyzekszam"].Value);
                    Program.ugyfelek[uj_index].Ugyfel_szekhely = Convert.ToString(DG_Ugyfel_ugyfel.Rows[0].Cells["Szekhely"].Value);
                    Program.ugyfelek[uj_index].Ugyfel_bank = Convert.ToString(DG_Ugyfel_ugyfel.Rows[0].Cells["Bank"].Value);
                    Program.ugyfelek[uj_index].Ugyfel_iban = Convert.ToString(DG_Ugyfel_ugyfel.Rows[0].Cells["IBAN"].Value);
                    Program.ugyfelek[uj_index].Ugyfel_kategoria = Convert.ToString(DG_Ugyfel_ugyfel.Rows[0].Cells["Kategoria"].Value);
                    Program.ugyfelek[uj_index].Ugyfel_megj = Convert.ToString(DG_Ugyfel_ugyfel.Rows[0].Cells["Megjegyzes"].Value);
                    Program.ugyfelek.Add(uj);
                }
            }
        }

        private void button_mentes_Click(object sender, EventArgs e)
        {
            Modositasok_mentese();
            Modositasok_tiltasa();
        }

        private void button_ujUgyfel_Click(object sender, EventArgs e)
        {
            DG_Ugyfel_ugyfel.Rows.Clear();
            DG_Ugyfel_ugyfel.ReadOnly = false;
        }
    }
}
