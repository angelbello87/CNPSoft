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
    public partial class Frm_AnadirPiloto : Form
    {
        private List<Clases.C_Piloto> pilotos;
        private Clases.C_Fichero file;

        public Frm_AnadirPiloto()
        {
            InitializeComponent();
            pilotos = new List<Clases.C_Piloto>();            
        }

        private void btn_anadirpiloto_Click(object sender, EventArgs e)
        {
            if (txt_nombreyapellidos.Text == "" || txt_parapente.Text == "" || txt_pais.Text == "")
            {
                lbl_error.Text = "Debe llenar todos los campos";
            }
            else
            {
                if (VerificarNumeroDorsal((int)numUpD_Dorsal.Value))
                {
                    Clases.C_Piloto p = new Clases.C_Piloto((int)numUpD_Dorsal.Value, txt_nombreyapellidos.Text, (string)cbox_club.SelectedItem, cbox_provincia.SelectedItem.ToString(), txt_pais.Text, txt_parapente.Text);
                    pilotos.Add(p);
                    numUpD_Dorsal.Value++;
                    txt_nombreyapellidos.Text = "";
                    txt_pais.Text = "Cuba";
                    txt_parapente.Text = "";
                    lbl_error.Text = "";
                    string pil = p.Dorsal.ToString() + "- " + p.Nombre_apellido + ", " + p.Provincia;
                    listbox_pilotos.Items.Add(pil);
                }
                else
                    MessageBox.Show("Este número de dorsal ya esta asignado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool VerificarNumeroDorsal(int dorsal)
        {
            for (int i = 0; i < pilotos.Count; i++)
            {
                if (pilotos[i].Dorsal == dorsal)
                    return false;
            }
            return true;//true es que se puede añadir
        }
        private void btn_terminar_Click(object sender, EventArgs e)
        {
            string tmp;
            file = new Clases.C_Fichero("pilotos.txt");
            file.AbrirW();
            for (int i = 0; i < pilotos.Count; i++)
            {
                tmp = pilotos[i].Dorsal.ToString() + "," + pilotos[i].Nombre_apellido + "," + pilotos[i].Club + "," + pilotos[i].Provincia + "," + pilotos[i].Pais + "," + pilotos[i].Parapente;
                file.Escribir(tmp);
            }
            file.CerrarW();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listbox_pilotos.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar el piloto a eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                pilotos.RemoveAt(listbox_pilotos.SelectedIndex);
                listbox_pilotos.Items.RemoveAt(listbox_pilotos.SelectedIndex);
            }
        }
    }
}
