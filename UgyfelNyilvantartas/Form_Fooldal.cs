using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UgyfelNyilvantartas
{
    public partial class form_Fooldal : Form
    {
        public form_Fooldal()
        {
            InitializeComponent();
        }

        private void button_ugyfel_Click(object sender, EventArgs e)
        {
            ugyfelToolStripMenuItem_Click(sender, e);
        }

        private void ugyfelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_Ugyfel.ShowDialog();
        }

        private void button_kollega_Click(object sender, EventArgs e)
        {
            kollegaToolStripMenuItem_Click(sender, e);
        }

        private void kollegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_Kollega.ShowDialog();
        }
        private void button_reszletek_Click(object sender, EventArgs e)
        {
            reszletekToolStripMenuItem_Click(sender, e);
        }

        private void reszletekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_Reszletek.ShowDialog();
        }

        private void button_ujMunka_Click(object sender, EventArgs e)
        {
            ujmunkaToolStripMenuItem_Click(sender, e);
        }

        private void ujmunkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_UjMunka.ShowDialog();
        }

        private void button_frissit_Click(object sender, EventArgs e)
        {

        }

        private void frissitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button_kilep_Click(object sender, EventArgs e)
        {

        }

        private void kilepToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DG_Fooldal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void form_Fooldal_Load(object sender, EventArgs e)
        {
            Program.Megrendeles_betoltese();
            DG_Fooldal_Beallitasok();
            DG_Fooldal_Frissit();
        }

        private void DG_Fooldal_Beallitasok()
        {
            DG_Fooldal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DG_Fooldal.MultiSelect = false;
            DG_Fooldal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void DG_Fooldal_Frissit()
        {
            DG_Fooldal.Rows.Clear();
            
            foreach (Megrendeles item in Program.megrendelesek)
            {
                if (checkBox_Aktiv.Checked && item.Statusz!="letudva")
                {
                    int sor_index = DG_Fooldal.Rows.Add();
                    DG_Fooldal.Rows[sor_index].Cells["MunkaFelvetel"].Value = item.Felvetel.ToString("yyyy.MM.dd");
                    DG_Fooldal.Rows[sor_index].Cells["UgyfelNev"].Value = item.Ugyfel_nev;
                    DG_Fooldal.Rows[sor_index].Cells["Leiras"].Value = item.Leiras;
                    DG_Fooldal.Rows[sor_index].Cells["ForrasNyelv"].Value = item.Kiindulasi_nyelv;
                    DG_Fooldal.Rows[sor_index].Cells["CelNyelv"].Value = item.Celnyelv;
                    DG_Fooldal.Rows[sor_index].Cells["KollegaNev"].Value = item.Kollega_nev;
                    DG_Fooldal.Rows[sor_index].Cells["VeglegesAr"].Value = item.Vegleges_ar;
                    DG_Fooldal.Rows[sor_index].Cells["Hatarido"].Value = item.Hatarido.ToString("yyyy.MM.dd");
                    DG_Fooldal.Rows[sor_index].Cells["EddigFizetve"].Value = item.Eddig_fizetve;
                    DG_Fooldal.Rows[sor_index].Cells["ElkeszultDatum"].Value = item.Elkeszult_datum.ToString("yyyy.MM.dd");
                    DG_Fooldal.Rows[sor_index].Cells["Statusz"].Value = item.Statusz;
                }
                else if(!checkBox_Aktiv.Checked)
                {
                    int sor_index = DG_Fooldal.Rows.Add();
                    DG_Fooldal.Rows[sor_index].Cells["MunkaFelvetel"].Value = item.Felvetel.ToString("yyyy.MM.dd");
                    DG_Fooldal.Rows[sor_index].Cells["UgyfelNev"].Value = item.Ugyfel_nev;
                    DG_Fooldal.Rows[sor_index].Cells["Leiras"].Value = item.Leiras;
                    DG_Fooldal.Rows[sor_index].Cells["ForrasNyelv"].Value = item.Kiindulasi_nyelv;
                    DG_Fooldal.Rows[sor_index].Cells["CelNyelv"].Value = item.Celnyelv;
                    DG_Fooldal.Rows[sor_index].Cells["KollegaNev"].Value = item.Kollega_nev;
                    DG_Fooldal.Rows[sor_index].Cells["VeglegesAr"].Value = item.Vegleges_ar;
                    DG_Fooldal.Rows[sor_index].Cells["Hatarido"].Value = item.Hatarido.ToString("yyyy.MM.dd");
                    DG_Fooldal.Rows[sor_index].Cells["EddigFizetve"].Value = item.Eddig_fizetve;
                    DG_Fooldal.Rows[sor_index].Cells["ElkeszultDatum"].Value = item.Elkeszult_datum.ToString("yyyy.MM.dd");
                    DG_Fooldal.Rows[sor_index].Cells["Statusz"].Value = item.Statusz;
                }
            }
            
           /* Program.sql.CommandText = "SELECT `felvetel_datuma`,`u_nev`,`leiras`,`kiindulasi_nyelv`,`celnyelv`,`k_nev`,`vegleges_ar`,`hatarido`,`eddig_fizetett`,`elkeszult_datum`,`statusz` FROM `dg_fooldal` WHERE `statusz`<>'letudva';";
            try
            {
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    DG_Fooldal.Rows.Clear();
                    while (dr.Read())
                    {
                        int sor_index = DG_Fooldal.Rows.Add();
                        DG_Fooldal.Rows[sor_index].Cells["MunkaFelvetel"].Value = dr.GetMySqlDateTime("felvetel_datuma");
                        DG_Fooldal.Rows[sor_index].Cells["UgyfelNev"].Value = dr.GetString("u_nev");
                        DG_Fooldal.Rows[sor_index].Cells["Leiras"].Value = dr.GetString("leiras");
                        DG_Fooldal.Rows[sor_index].Cells["ForrasNyelv"].Value = dr.GetString("kiindulasi_nyelv");
                        DG_Fooldal.Rows[sor_index].Cells["CelNyelv"].Value = dr.GetString("celnyelv");
                        DG_Fooldal.Rows[sor_index].Cells["KollegaNev"].Value = dr.GetString("k_nev");
                        /*DG_Fooldal.Rows[sor_index].Cells["VeglegesAr"].Value = dr.GetInt32("vegleges_ar");
                        DG_Fooldal.Rows[sor_index].Cells["Hatarido"].Value = dr.GetMySqlDateTime("hatarido");
                        DG_Fooldal.Rows[sor_index].Cells["EddigFizetve"].Value = dr.GetInt32("eddig_fizetett");
                        DG_Fooldal.Rows[sor_index].Cells["ElkeszultDatum"].Value = dr.GetMySqlDateTime("elkeszult_datum");
                        DG_Fooldal.Rows[sor_index].Cells["Statusz"].Value = dr.GetString("statusz");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void DG_Fooldal_SelectionChanged(object sender, EventArgs e)
        {
            Program.kivalasztott = DG_Fooldal.SelectedRows[0];
        }

        private void checkBox_Aktiv_CheckedChanged(object sender, EventArgs e)
        {
            DG_Fooldal_Frissit();
        }
    }
}
