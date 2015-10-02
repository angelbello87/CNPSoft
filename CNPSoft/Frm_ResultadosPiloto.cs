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
    public partial class Frm_ResultadosPiloto : Form
    {
        private Clases.C_Competencia CNP;
        private List<Clases.C_Baliza> balizas;
        private List<Clases.C_Piloto> pilotos;
        private List<Clases.C_Competidor> competidor;
        private Clases.C_Manga manga;        

        public Frm_ResultadosPiloto(List<Clases.C_Baliza> balizas, Clases.C_Manga manga)
        {
            InitializeComponent();
            this.balizas = balizas;
            this.manga = manga;
            competidor = new List<Clases.C_Competidor>();
            pilotos = new List<Clases.C_Piloto>();
            CNP = new Clases.C_Competencia();
            this.Text += "  " + DateTime.Now.Date.ToShortDateString();
        }

        private bool Validar(DateTime desp, DateTime ater,bool gol)
        {
            if (desp.Hour < manga.Apertura_manga.Hour || desp.Hour > manga.Cierre_ventana.Hour)
            {
                MessageBox.Show("La Hora de despegue del piloto debe estar en el intervalo con la Ventana de la Manga", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ater.TimeOfDay.TotalMinutes > manga.Cierre_manga.TimeOfDay.TotalMinutes && gol)
            {
                MessageBox.Show("La Hora de aterriaje del piloto debe estar en el intervalo antes del cierre de la Manga", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ater.TimeOfDay.TotalMinutes < manga.Apertura_manga.TimeOfDay.TotalMinutes && gol)
            {
                MessageBox.Show("La Hora de aterriaje del piloto debe estar en el intervalo antes del cierre de la Manga", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!gol && ater.Hour != 0)
            {
                if(ater.Minute != 0)
                {
                    MessageBox.Show("La Hora de aterrizaje debe ser 0 horas y 0 minutos", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (listbox_baliza.CheckedItems.Count == 0)
            {     //para cuando no ha marcado ninguna baliza          
                if (MessageBox.Show("Seguro que este piloto no marco ninguna baliza ?", "Atención!!!", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    List<Clases.C_Baliza> bal_acept = new List<Clases.C_Baliza>();                    
                    DateTime desp = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)txt_horadeDespegue.Value, (int)txt_minutodeDespegue.Value, 0);
                    DateTime ater = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(txt_horadeAterrizaje.Value.ToString()), int.Parse(txt_minutodeAterrizaje.Value.ToString()), 0);   
                                        
                    if (Validar(desp, ater,false))
                    {
                        Clases.C_Piloto p = ObtenerPiloto(int.Parse(cbox_dorsal.Text));
                        Clases.C_Competidor comp = new Clases.C_Competidor(p.Dorsal, p.Nombre_apellido, p.Club, p.Provincia, p.Pais, p.Parapente, desp, ater, bal_acept);
                        competidor.Add(comp);
                        cbox_dorsal.Items.RemoveAt(cbox_dorsal.SelectedIndex);
                        cbox_piloto.Items.RemoveAt(cbox_piloto.SelectedIndex);

                        lview_pilotoscalificados.Items.Add(comp.Dorsal.ToString());
                        lview_pilotoscalificados.Items[lview_pilotoscalificados.Items.Count - 1].SubItems.Add(comp.Nombre_apellido);
                        string tmp = "";
                        lview_pilotoscalificados.Items[lview_pilotoscalificados.Items.Count - 1].SubItems.Add(tmp);
                        listbox_baliza.ClearSelected();
                        if (cbox_dorsal.Items.Count >= 1)
                        {
                            cbox_dorsal.SelectedIndex = 0;
                            cbox_piloto.SelectedIndex = 0;
                        }  
                    }
                }                    
            }            
            else //Para cuando marco alguna baliza o todas
            {
                bool chequeoGolAterrizaje = false;
                List<Clases.C_Baliza> bal_aceptadas = new List<Clases.C_Baliza>();
                DateTime desp = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(txt_horadeDespegue.Text), int.Parse(txt_minutodeDespegue.Text), 0);
                DateTime ater = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(txt_horadeAterrizaje.Text), int.Parse(txt_minutodeAterrizaje.Text), 0);
                //ciclo para obtener cuales son las balizas que hizo el piloto
                for (int i = 0; i < listbox_baliza.CheckedItems.Count; i++)
			    { 
                    int num = 1;
                    if (listbox_baliza.CheckedItems[i].ToString() == "Gol")
                    {
                        num = 0;
                        chequeoGolAterrizaje = true;
                    }
                    else
                        num = int.Parse(listbox_baliza.CheckedItems[i].ToString().Split()[0]);
			        bal_aceptadas.Add(ObtenerBaliza(num));
			    }                
                if (Validar(desp,ater,chequeoGolAterrizaje))//Si tiene chequeado el gol tiene que tener hora de aterrizaje
                {
                    Clases.C_Piloto p = ObtenerPiloto(int.Parse(cbox_dorsal.Text));
                    Clases.C_Competidor comp = new Clases.C_Competidor(p.Dorsal, p.Nombre_apellido, p.Club, p.Provincia, p.Pais, p.Parapente, desp, ater, bal_aceptadas);
                    competidor.Add(comp);
                    cbox_dorsal.Items.RemoveAt(cbox_dorsal.SelectedIndex);
                    cbox_piloto.Items.RemoveAt(cbox_piloto.SelectedIndex);
                    listbox_baliza.ClearSelected();

                    lview_pilotoscalificados.Items.Add(comp.Dorsal.ToString());
                    lview_pilotoscalificados.Items[lview_pilotoscalificados.Items.Count - 1].SubItems.Add(comp.Nombre_apellido);
                    string tmp = "";
                    for (int i = 0; i < comp.Balizas_marcadas.Count; i++)
                    {
                        if (comp.Balizas_marcadas[i].Numero == 0)
                            tmp += "G - ";
                        else
                            tmp += comp.Balizas_marcadas[i].Numero.ToString() + " - ";
                    }
                    tmp = tmp.TrimEnd(' ', '-');
                    lview_pilotoscalificados.Items[lview_pilotoscalificados.Items.Count - 1].SubItems.Add(tmp);

                    for (int i = 0; i < listbox_baliza.Items.Count; i++)
                    {
                        listbox_baliza.SetItemCheckState(i, CheckState.Unchecked);
                    }
                    if (cbox_dorsal.Items.Count >= 1)
                    {
                        cbox_dorsal.SelectedIndex = 0;
                        cbox_piloto.SelectedIndex = 0;
                    }  
                }                
            }            
            //para seleccionar otro elemento del combobox y no dejarlo en blanco y para desabilitar el boton de aceptar 
            if (cbox_dorsal.Items.Count == 0)
            {
                btn_aceptar.Enabled = false;
            }            
                      
        }
        private Clases.C_Piloto ObtenerPiloto(int dorsal)
        {
            Clases.C_Piloto p = null;
            for (int i = 0; i < pilotos.Count; i++)
			{
                if (pilotos[i].Dorsal == dorsal)
                {
                    p = pilotos[i];
                    break;
                }
			}
            return p;
        }
        private Clases.C_Baliza ObtenerBaliza(int numero)
        {
            Clases.C_Baliza bal = null;
            for (int i = 0; i < balizas.Count; i++)
            {
                if (balizas[i].Numero == numero)
                {
                    bal = balizas[i];
                    break;
                }
            }
            return bal;
        }
        private void Frm_ResultadosPiloto_Load(object sender, EventArgs e)
        {            
            try
            {
                pilotos = CNP.CargarPilotos();
            }
            catch (Exception error)
            {                
                MessageBox.Show("Debe adicionar todos los pilotos del campeonato primeramente", error.Message+" Indicación!", MessageBoxButtons.OK);
                this.Close();
            }            
            for (int i = 0; i < pilotos.Count;)
            {            
                cbox_dorsal.Items.Add(pilotos[i].Dorsal.ToString());
                cbox_piloto.Items.Add(pilotos[i].Nombre_apellido + ", " + pilotos[i].Provincia);
                i++;                
            }
            cbox_dorsal.Text = cbox_dorsal.Items[0].ToString();
            cbox_piloto.Text = cbox_piloto.Items[0].ToString();
            for (int i = 0; i < balizas.Count; i++)
            {
                Clases.C_Baliza b = balizas[i];
                if (b.Numero == 0)
                    listbox_baliza.Items.Add("Gol");
                else
                {
                    listbox_baliza.Items.Add(b.Numero.ToString() + " - " + b.Nombre);
                }
            }
        }
        private void btn_terminar_Click(object sender, EventArgs e)
        {
            if (cbox_dorsal.Items.Count <= 0)
            {
                Clases.C_Manga m = new Clases.C_Manga(balizas, competidor, manga.Apertura_manga,manga.Cierre_ventana,manga.Cierre_manga);
                Frm_ProcesarResultadoManga frm = new Frm_ProcesarResultadoManga(m);
                frm.Show();
                this.Close();
            }
            else
                MessageBox.Show("Debe puntuar a cada piloto antes de terminar", "ATENCION!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbox_dorsal_SelectionChangeCommitted(object sender, EventArgs e)
        {            
            cbox_piloto.SelectedIndex = cbox_dorsal.SelectedIndex;
        }
        private void cbox_piloto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbox_dorsal.SelectedIndex = cbox_piloto.SelectedIndex;
        }
        private void btn_recalificar_Click(object sender, EventArgs e)
        {
            if (lview_pilotoscalificados.SelectedItems.Count < 1)
            {
                MessageBox.Show("Debe seleccionar el piloto a recalificar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string dorsal = lview_pilotoscalificados.SelectedItems[0].Text;
                string nombre = lview_pilotoscalificados.SelectedItems[0].SubItems[1].Text;
                lview_pilotoscalificados.Items.RemoveAt(lview_pilotoscalificados.SelectedIndices[0]);
                cbox_dorsal.Items.Add(dorsal);
                cbox_piloto.Items.Add(nombre);
                cbox_dorsal.SelectedIndex = cbox_dorsal.Items.Count - 1;
                cbox_piloto.SelectedIndex = cbox_dorsal.Items.Count - 1;
                int dorsalaux = int.Parse(dorsal);
                for (int i = 0; i < competidor.Count; i++)
                {
                    if (competidor[i].Dorsal == dorsalaux)
                        competidor.RemoveAt(i);
                }
                btn_aceptar.Enabled = true;
            }
        }
        private void txt_horadeDespegue_ValueChanged(object sender, EventArgs e)
        {
            txt_horadeAterrizaje.Value = txt_horadeDespegue.Value;
        }
        private void txt_minutodeDespegue_ValueChanged(object sender, EventArgs e)
        {
            if (txt_minutodeDespegue.Value == 59)
                txt_minutodeAterrizaje.Value = 0;
            else
                txt_minutodeAterrizaje.Value = txt_minutodeDespegue.Value + 1;
        }            
    }
}
