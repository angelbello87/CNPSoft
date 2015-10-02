using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CNPSoft
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AnadirPiloto frm = new Frm_AnadirPiloto();
            frm.ShowDialog();
        }

        private void añadirBalizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AnadirBalizas frm = new Frm_AnadirBalizas();
            frm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resultadosMangaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ConfeccionManga frm = new Frm_ConfeccionManga();
            frm.ShowDialog();
        }
    }
}
