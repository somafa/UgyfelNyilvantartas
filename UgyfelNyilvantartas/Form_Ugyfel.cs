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
            this.Close();
            Program.form_Fooldal.Show();
        }

        private void button_hasznal_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form_UjMunka.Show();
        }
    }
}
