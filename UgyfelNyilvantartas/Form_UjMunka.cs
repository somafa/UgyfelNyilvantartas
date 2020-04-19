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
    public partial class form_UjMunka : Form
    {
        public form_UjMunka()
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

        private void DG_UjMunka_Beallitasok()
        {
            DG_UjMunka_megrendeles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DG_UjMunka_megrendeles.MultiSelect = false;
            DG_UjMunka_ugyfel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DG_UjMunka_ugyfel.MultiSelect = false;
            DG_UjMunka_kollega.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DG_UjMunka_kollega.MultiSelect = false;
            DG_UjMunka_koltsegek.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DG_UjMunka_koltsegek.MultiSelect = false;
        }

        private void form_UjMunka_Load(object sender, EventArgs e)
        {
            
            Nyelvek_Combo_feltoltese();
            DG_UjMunka_Beallitasok();
            DG_UjMunka_megrendeles.Rows.Add();
        }

        private void button_ugyfelKeres_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_Ugyfel.Show();
        }

        private void button_kollegaKeres_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_Kollega.Show();
        }
        public void DG_UjMunka_ugyfel_athozas()
        {
            int sor_index = DG_UjMunka_ugyfel.Rows.Add();
            DG_UjMunka_ugyfel.Rows[0].Cells["UgyfelNev"].Value = Program.kivalasztott_ugyfel.Cells["Nev"].Value;
            DG_UjMunka_ugyfel.Rows[0].Cells["Telefonszam"].Value = Program.kivalasztott_ugyfel.Cells["Telefonszam"].Value;
            DG_UjMunka_ugyfel.Rows[0].Cells["EmailCim"].Value = Program.kivalasztott_ugyfel.Cells["EmailCim"].Value;
            DG_UjMunka_ugyfel.Rows[0].Cells["MasElerhetoseg"].Value = Program.kivalasztott_ugyfel.Cells["MasElerhetoseg"].Value;
            DG_UjMunka_ugyfel.Rows[0].Cells["Megjegyzes"].Value = Program.kivalasztott_ugyfel.Cells["Megjegyzes"].Value;
            DG_UjMunka_ugyfel.Rows[0].Cells["Kategoria"].Value = Program.kivalasztott_ugyfel.Cells["Kategoria"].Value;
        }
        private void DG_UjMunka_kollega_athozas()
        {
            int sor_index = DG_UjMunka_kollega.Rows.Add();
            DG_UjMunka_kollega.Rows[0].Cells["KollegaNev"].Value = Program.kivalasztott_kollega.Cells["Nev"].Value;
        }
        private void Nyelvek_Combo_feltoltese()
        {
            Program.Nyelv_lista();
            var CellSample = new DataGridViewComboBoxCell();
            var CellSample2 = new DataGridViewComboBoxCell();
            CellSample.DataSource = Program.nyelvek.ToArray();
            CellSample2.DataSource = Program.nyelvek.ToArray();
            DG_UjMunka_megrendeles.Rows[0].Cells["ForrasNyelv"] = CellSample;
            DG_UjMunka_megrendeles.Rows[0].Cells["CelNyelvCombo"] = CellSample2;
        }
    }
}
