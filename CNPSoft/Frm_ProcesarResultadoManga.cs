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
    public partial class Frm_ProcesarResultadoManga : Form
    {
        private Clases.C_Manga manga;
        private Clases.C_Fichero file;
        public Frm_ProcesarResultadoManga(Clases.C_Manga manga)
        {
            InitializeComponent();
            this.manga = manga;
            this.Text += " " + DateTime.Now.ToShortDateString();
        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            EscribirManga();
            this.Close();
        }        
        private List<Clases.C_Competidor> Descuento()//Se descuenta aqui a los competidores que tengan marcada la baliza Gol(0).
        {
            for (int i = 0; i < manga.Competidores.Count; i++)
            {
                List<Clases.C_Baliza> balizas = manga.Competidores[i].Balizas_marcadas;
                for (int j = 0; j < balizas.Count; j++)
                {
                    if (balizas[j].Numero == 0)
                    {
                        manga.Competidores[i].Total_de_puntos = manga.Competidores[i].Total_de_puntos - (manga.Competidores[i].Tiempo_realizado.TotalMinutes / 10);
                    }
                }
            }
            List<Clases.C_Competidor> compe = OrdenarCompetidoresPuntos(manga.Competidores);
            double puntos = compe[0].Total_de_puntos;
            double tiempo = compe[0].Tiempo_realizado.TotalMinutes;
            if (compe[0].Balizas_marcadas.Count == manga.Balizas.Count)
            {
                compe[0].Total_de_puntos = 1000;
                for (int i = 1; i < compe.Count; i++)
                {
                    if (compe[i].Total_de_puntos == puntos && compe[i].Tiempo_realizado.TotalMinutes == tiempo)
                    {
                        compe[i].Total_de_puntos = 1000;
                    }
                }
            }
            return compe;
        }
        private List<Clases.C_Competidor> OrdenarCompetidoresPuntos(List<Clases.C_Competidor> competidores)
        {
            List<Clases.C_Competidor> ordenadosCompetidores = new List<Clases.C_Competidor>();
            for (int i = 0; i < competidores.Count; i++)
            {
                ordenadosCompetidores.Add(competidores[i]);                
            }            
            Clases.C_Competidor aux;
            for (int i = 0; i < ordenadosCompetidores.Count; ++i)
            {
                for (int j = i; j < ordenadosCompetidores.Count; ++j)
                {
                    if (ordenadosCompetidores[i].Total_de_puntos < ordenadosCompetidores[j].Total_de_puntos)
                    {
                        aux = ordenadosCompetidores[i];
                        ordenadosCompetidores[i] = ordenadosCompetidores[j];
                        ordenadosCompetidores[j] = aux;
                    }
                }
            }
            return ordenadosCompetidores;
        }
        //Ver si se queda este metodo de ordenar por tiempo!!!!
        private List<Clases.C_Competidor> OrdenarCompetidoresTiempo(List<Clases.C_Competidor> competidores)
        {
            List<Clases.C_Competidor> ordenadosCompetidores = new List<Clases.C_Competidor>();
            for (int i = 0; i < competidores.Count; i++)
            {
                ordenadosCompetidores.Add(competidores[i]);
            }
            Clases.C_Competidor aux;
            for (int i = 0; i < ordenadosCompetidores.Count; ++i)
            {
                for (int j = i; j < ordenadosCompetidores.Count; ++j)
                {
                    if (ordenadosCompetidores[i].Tiempo_realizado.TotalMinutes < ordenadosCompetidores[j].Tiempo_realizado.TotalMinutes)
                    {
                        aux = ordenadosCompetidores[i];
                        ordenadosCompetidores[i] = ordenadosCompetidores[j];
                        ordenadosCompetidores[j] = aux;
                    }
                }
            }
            return ordenadosCompetidores;
        }
        private void EscribirManga()
        {
            file = new Clases.C_Fichero("mangas.txt");
            file.AbrirW();
            file.Escribir("\n");
            file.Escribir("Manga-" + DateTime.Now.ToShortDateString() + "-" + manga.Apertura_manga.TimeOfDay.ToString() + "-" + manga.Cierre_ventana.TimeOfDay.ToString() + "-" + manga.Cierre_manga.TimeOfDay.ToString());
            string bali = "B-";
            for (int i = 0; i < manga.Balizas.Count; i++)
            {
                bali += manga.Balizas[i].Numero.ToString()+"-";
            }
            bali = bali.TrimEnd(';');
            file.Escribir(bali);
            //Escribir Dorsal - Nombre - Provincia - Pais - Parapente - puntos - balizasmarcadas - hora_desp - hora_ater
            for (int i = 0; i < manga.Competidores.Count; i++)
            {
                Clases.C_Competidor compeAux = manga.Competidores[i];
                string tmp = "P-";
                tmp = compeAux.Dorsal.ToString() + "-" + compeAux.Nombre_apellido + "-" + compeAux.Provincia + "-" + compeAux.Pais + "-" + compeAux.Parapente + "-" + compeAux.Total_de_puntos.ToString() + "-";
                for (int j = 0; j < manga.Competidores[i].Balizas_marcadas.Count; j++)
			    {
			        tmp += manga.Competidores[i].Balizas_marcadas[j].Numero.ToString()+";";
			    }
                tmp = tmp.TrimEnd(';');
                tmp+="-" + compeAux.Hora_despegue.TimeOfDay.ToString()+"-"+compeAux.Hora_aterrizaje.TimeOfDay.ToString();
                //tmp += manga.Competidores[i].Total_de_puntos.ToString();
                //file.Escribir(manga.Competidores[i].Dorsal.ToString() + " " + tmp);
                file.Escribir(tmp);
                tmp = "";
            }
            file.CerrarW();
        }       
        private void Frm_ProcesarResultadoManga_Load(object sender, EventArgs e)
        {
            string temp = "";
            List<Clases.C_Competidor> compe = Descuento();
            Clases.C_Competidor aux;

            for (int i = 0; i < compe.Count; i++)
            {
                bool llegoaGol = false;
                aux = compe[i];
                lview_resultadoManga.Items.Add(aux.Dorsal.ToString());
                lview_resultadoManga.Items[i].SubItems.Add(aux.Nombre_apellido);
                for (int j = 0; j < aux.Balizas_marcadas.Count; j++)
                {
                    if (aux.Balizas_marcadas[j].Numero == 0)
                    {
                        temp += "G -";
                        llegoaGol = true;
                    }
                    else
                        temp += aux.Balizas_marcadas[j].Numero + " - ";
                }
                temp = temp.TrimEnd(' ', '-');
                lview_resultadoManga.Items[i].SubItems.Add(temp);
                lview_resultadoManga.Items[i].SubItems.Add(aux.Total_de_puntos.ToString());
                if (!llegoaGol)
                    lview_resultadoManga.Items[i].SubItems.Add("0");
                else
                    lview_resultadoManga.Items[i].SubItems.Add(aux.Tiempo_realizado.ToString());
                lview_resultadoManga.Items[i].SubItems.Add((i + 1).ToString());
                temp = "";
            }   
        }
    }
}
