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
    public partial class Frm_ConfeccionManga : Form
    {
        private Clases.C_Competencia CNP;
        private List<Clases.C_Baliza> balizas;
        private List<Clases.C_Baliza> bal_puntos;        
        public Frm_ConfeccionManga()
        {
            InitializeComponent();
            balizas = new List<Clases.C_Baliza>();
            bal_puntos = new List<Clases.C_Baliza>();
            CNP = new Clases.C_Competencia();
            this.Text += "  "+DateTime.Now.Date.ToShortDateString();
        }

        private void Frm_ResultadoManga_Load(object sender, EventArgs e)
        {            
            try
            {
                balizas = CNP.CargarBalizasCampeonato();
            }
            catch
            {                
                MessageBox.Show("Debe adicionar todas las balizas del campeonato primeramente"," Indicación!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            for (int i = 0; i < balizas.Count; i++)
            {             
                if (balizas[i].Numero == 0)
                    listbox_balizas.Items.Add(balizas[i].Nombre);
                else
                    listbox_balizas.Items.Add(balizas[i].Numero.ToString() + "- " + balizas[i].Nombre);                
            }            
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (listbox_balizas.SelectedIndex < 0)
            {
                MessageBox.Show("Debe Seleccionar una baliza", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Clases.C_Baliza b = balizas[listbox_balizas.SelectedIndex];
                b.Puntos = (int)txt_puntos.Value;
                bal_puntos.Add(b);
                if(b.Numero == 0)
                    listbox_balizasPuntos.Items.Add(b.Nombre + " " + b.Puntos.ToString());
                else
                    listbox_balizasPuntos.Items.Add(b.Numero.ToString() + "- " + b.Nombre + " " + b.Puntos.ToString());
                balizas.Remove(b);
                listbox_balizas.Items.RemoveAt(listbox_balizas.SelectedIndex);
            }
        }        

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (listbox_balizasPuntos.SelectedIndex < 0)
            {
                MessageBox.Show("Debe Seleccionar una baliza", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Clases.C_Baliza b = bal_puntos[listbox_balizasPuntos.SelectedIndex];
                bal_puntos.Remove(b);
                listbox_balizasPuntos.Items.RemoveAt(listbox_balizasPuntos.SelectedIndex);
                balizas.Add(b);
                if(b.Numero == 0)
                    listbox_balizas.Items.Add(b.Nombre);
                else
                    listbox_balizas.Items.Add(b.Numero.ToString() + "- " + b.Nombre);
            }
        }
        

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            int sumapuntosbaliza = 0;
            for (int i = 0; i < bal_puntos.Count; i++)
            {
                sumapuntosbaliza += bal_puntos[i].Puntos;
            }
            if (sumapuntosbaliza != 1000)
            {
                MessageBox.Show("La suma de los puntos de las balizas debe ser igual a 1000", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                DateTime aperManga = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(txt_horaAperturadeManga.Value.ToString()), int.Parse(txt_minutosAperturadeManga.Value.ToString()), 0);
                DateTime cierreVentana = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(txt_horaCierredeVentana.Value.ToString()), int.Parse(txt_minutosCierredeVentana.Value.ToString()), 0);
                DateTime cierreManga = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(txt_horaCierredeManga.Value.ToString()), int.Parse(txt_minutosCierredeManga.Value.ToString()), 0);
                List<Clases.C_Baliza> b = new List<Clases.C_Baliza>();
                List<Clases.C_Competidor> c = new List<Clases.C_Competidor>();
                Clases.C_Manga m = new Clases.C_Manga(b, c, aperManga, cierreVentana, cierreManga);
                Frm_ResultadosPiloto frm = new Frm_ResultadosPiloto(bal_puntos, m);
                frm.Show();
                this.Close();
            }
        }
    }
}
