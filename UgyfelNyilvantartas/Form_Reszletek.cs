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
            DG_Reszletek_megrendeles_Frissit();
           /* DG_Reszletek_ugyfel_Frissit();
            DG_Reszletek_kollega_Frissit();
            DG_Reszletek_koltsegek_Frissit();*/
        }

        private void DG_Reszletek_megrendeles_Beallitasok()
        {
            DG_Reszletek_megrendeles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
        }
        private void DG_Reszletek_megrendeles_Frissit()
        {
            DG_Reszletek_megrendeles.Rows.Clear();
            DG_Reszletek_megrendeles.Rows[0].Cells["FelvetelDatum"].Value = Program.megrendelesek[].Felvetel;
            /*DG_Reszletek_megrendeles.Rows[0].Cells["FelvetelDatum"].Value = Program.kivalasztott.Cells["MunkaFelvetel"].Value;
            DG_Reszletek_megrendeles.Rows[0].Cells["Hatarido"].Value = Program.kivalasztott.Cells["Hatarido"].Value;
            DG_Reszletek_megrendeles.Rows[0].Cells["VeglegesAr"].Value = Program.kivalasztott.Cells["VeglegesAr"].Value;
            DG_Reszletek_megrendeles.Rows[0].Cells["EddigFizetve"].Value = Program.kivalasztott.Cells["EddigFizetve"].Value;
            DG_Reszletek_megrendeles.Rows[0].Cells["FizetveDatum"].Value = Program.kivalasztott.Cells["Hatarido"].Value;
            DG_Reszletek_megrendeles.Rows[0].Cells["Peldanyszam"].Value = Program.kivalasztott.Cells["Peldanyszam"].Value;
            DG_Reszletek_megrendeles.Rows[0].Cells["KiindulasiNyelv"].Value = Program.kivalasztott.Cells["ForrasNyelv"].Value;
            DG_Reszletek_megrendeles.Rows[0].Cells["CelNyelv"].Value = Program.kivalasztott.Cells["CelNyelv"].Value;
            DG_Reszletek_megrendeles.Rows[0].Cells["Statusz"].Value = Program.kivalasztott.Cells["Statusz"].Value;*/
        }
    }
}
