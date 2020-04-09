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
    }
}
