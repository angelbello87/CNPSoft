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
    public partial class Frm_AnadirBalizas : Form
    {
        private List<Clases.C_Baliza> balizas;
        private Clases.C_Fichero file;   
     
        public Frm_AnadirBalizas()
        {
            InitializeComponent();
            balizas = new List<Clases.C_Baliza>();            
        }

        private void btn_anadirbaliza_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "")
            {
                MessageBox.Show("Debe introducir los datos de la baliza","Atención",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if (VerificarNumeroBaliza((int)txt_numero.Value))
                {
                    Clases.C_Baliza b = new Clases.C_Baliza(txt_nombre.Text, (int)txt_numero.Value, 0);
                    balizas.Add(b);
                    txt_nombre.Text = "";
                    txt_numero.Value++;
                    string bal = b.Numero.ToString() + "- " + b.Nombre;
                    listbox_balizas.Items.Add(bal);
                }
                else
                    MessageBox.Show("Este número de baliza ya esta asignado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool VerificarNumeroBaliza(int numero)
        {
            for (int i = 0; i < balizas.Count; i++)
            {
                if (balizas[i].Numero == numero)
                    return false;
            }
            return true;//true es que se puede añadir
        }

        private void btn_terminar_Click(object sender, EventArgs e)
        {
            string tmp;
            file = new Clases.C_Fichero("balizas.txt");
            file.AbrirW();
            for (int i = 0; i < balizas.Count; i++)
            {
                tmp = balizas[i].Numero.ToString() + "," + balizas[i].Nombre + "," + balizas[i].Puntos.ToString();
                file.Escribir(tmp);
            }
            file.CerrarW();
            this.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (listbox_balizas.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar la baliza a eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                balizas.RemoveAt(listbox_balizas.SelectedIndex);
                listbox_balizas.Items.RemoveAt(listbox_balizas.SelectedIndex);
            }
        }
    }
}
